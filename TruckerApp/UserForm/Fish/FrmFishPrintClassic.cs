using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using TruckerApp.ExtentionMethod;
using TruckerApp.Repository;
using TruckerApp.UserForm.cash;
using TruckerApp.ViewModels;

namespace TruckerApp.UserForm.Fish
{
    public partial class FrmFishPrintClassic : XtraForm
    {
       
        private int _driver, _series;
        private int _commission;
        private short _commissionId;//حق کمیسیون
        private string _name, _number, _smartcart, _tagnumber, _type;
        public byte TypeId { get; set; }
        private byte _group;
        //private string _price;
        private string _memeber;
        private string _code;

        private IQueuing _queuing;
        private ICustomers _customers;
        public FrmFishPrintClassic(IQueuing queuing, ICustomers customers)
        {
            _queuing = queuing;
            _customers = customers;
            InitializeComponent();
        }

        private async Task setupPage()
        {
            driversBindingSource.DataSource = await _customers.GetAllDriver();
            txtserial.EditValue = PublicVar.SeriesName;
            _series = PublicVar.SeriesID;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void printFish()
        {
            var report = XtraReport.FromFile("Report_Fish.repx", true);
            var tool = new ReportPrintTool(report);
            report.Parameters["date"].Value = DateTime.Now.PersianConvertorFull();
            report.Parameters["name"].Value = _name;
            report.Parameters["seriesNumber"].Value = _seriesNumber;
            report.Parameters["smartcart"].Value = _smartcart;
            report.Parameters["TagNumbers"].Value = _tagnumber;
            report.Parameters["member"].Value = _memeber;
            report.Parameters["price"].Value = _commission;
            report.Parameters["Type"].Value = _type;
            report.Parameters["code"].Value = _code;
            report.Parameters["number"].Value = _number;
            tool.PrintDialog();
        }

        private void ChangeTypeId(byte TypeId)
        {
            switch (TypeId)
            {
                case 1:
                    _type = "فله";
                    break;
                case 2:
                    _type = "پاکت";
                    break;
                case 3:
                    _type = "گندم";
                    break;
                case 4:
                    _type = "کلینکر";
                    break;
                case 5:
                    _type = "آهک فله";
                    break;
                case 6:
                    _type = "آهک پاکت";
                    break;
                case 7:
                    _type = "سایر";
                    break;
            }
        }

        private async void cbxCargo_EditValueChanged(object sender, EventArgs e)
        {
            var selectType = (ViewModelCargoType)cbxCargo.GetSelectedDataRow();
            if (selectType == null || txtTag.Text.Trim() == "")
            {
                txtComossin.EditValue = 0;
                txtDateRegister.EditValue = DateTime.Now.PersianConvertor();
                txtName.EditValue = null;
                txtNumber.EditValue = null;
                txtPhoneNumber.EditValue = null;
                txtTag.EditValue = txtTagNumber.EditValue = null;
                chkMandeh.EditValue = false;
                return;
            }

            ChangeTypeId(selectType.TypeID);
            txtNumber.EditValue = await _queuing.GetLastNumberByTypeId(selectType.TypeID);
            var com = await _queuing.GetCommisinoByTypeIdAndByGroupId(selectType.TypeID, _group);
            txtComossin.EditValue = _commission = com.CommissionPrice;
            _commissionId = com.CommissionID;
        }

        private void GetPropertyByDriver(Driver driver)
        {
            _code = Convert.ToInt32(driver.driver_code) > 0 ? driver.driver_code.ToString() : " ";
            txtName.Text = _name = $"{driver.FirstName}  {driver.LastName}";
            txtTag.Text = driver.Tag;
            txtTagNumber.Text = _tagnumber = driver.TagNumber;
            txtPhoneNumber.Text = driver.PhoneNumber;

            _driver = driver.DriverID;
            _smartcart =  driver.SmartCart.ToString();
            _group = driver.GroupID;
            _memeber = driver.LoadType.Type;
        }

        private void cbxSmart_EditValueChanged(object sender, EventArgs e)
        {
            var driver = (Driver)cbxSmart.GetSelectedDataRow();
            if (driver == null) return;
            GetPropertyByDriver(driver);

        }

        private async void FrmFishPrint_Load(object sender, EventArgs e)
        {
            await setupPage();
            txtDateRegister.Text = DateTime.Today.ToLongDateString();
            lastNumber();
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var driverCheck = _db.Queues.Where(x => x.Status_FK == 20 && x.DriverID_FK == _driver).ToList();
            if (driverCheck.Count == 0)
            {
                try
                {
                    var queue = new Queue
                    {
                        DriverID_FK = _driver,
                        ComosiunID_FK = _commissionId,
                        Type_FK = TypeId,
                        DateTimeRegister = DateTime.Now,
                        SeriesID_FK = _series,
                        Number = Convert.ToInt16(txtNumber.EditValue),
                        GroupCommission = _group,
                        Status_FK = 20,
                        userid = PublicVar.UserID,
                    };
                    var frm = new FrmCash(txtComossin.Text);
                    var result = frm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        var adding = new Adding();
                        var rec = adding.addingFish(queue, frm.Cash);
                        if (rec)
                        {
                            _number = $"س {PublicVar.SeriesName}  شماره {adding.StrNumber}";
                            printFish();
                            lastNumber();
                        }
                    }
                }
                catch
                {
                    XtraMessageBox.Show(PublicVar.ErrorMessageForNotSave, Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                var str =
                    $"برای شماره هوشمند {driverCheck[0].Driver.SmartCart} نوبت محموله {driverCheck[0].LoadType.Type} در تاریخ {driverCheck[0].DateTimeRegister} ثبت شده است";
                XtraMessageBox.Show(str, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void lastNumber()
        {
            var qryNumber = new Counter().lastNumber(PublicVar.SeriesID, (byte)TypeId);
            txtNumber.Text = (qryNumber + 1).ToString("000");

        }
    }
}

