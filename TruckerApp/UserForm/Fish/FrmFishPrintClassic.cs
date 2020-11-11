using System;
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
        private string _seriesNumber;

        public FrmFishPrintClassic(IQueuing queuing, ICustomers customers)
        {
            _queuing = queuing;
            _customers = customers;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void PrintFish()
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
            var selectType = (ViewModelCargoType)cbxCargoType.GetSelectedDataRow();
            if (selectType == null)
            {
                txtComossin.EditValue = 0;
                txtNumber.EditValue = null;
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
            _smartcart = driver.SmartCart.ToString();
            _group = driver.GroupID;
            _memeber = driver.LoadType.Type;
        }

        private void cbxSmart_EditValueChanged(object sender, EventArgs e)
        {
            var driver = (Driver)cbxSmart.GetSelectedDataRow();
            if (driver == null)
            {
                cbxCargoType.EditValue = null;
                txtDateRegister.EditValue = DateTime.Now.PersianConvertor();
                txtName.EditValue = null;
                txtPhoneNumber.EditValue = null;
                txtTag.EditValue = 
                    txtTagNumber.EditValue = null;
                chkMandeh.EditValue = false;
                return;
            }
            GetPropertyByDriver(driver);

        }

        private async void FrmFishPrint_Load(object sender, EventArgs e)
        {
            cbxCargoType.Properties.DataSource = await _queuing.GetAllCargoType();
            driversBindingSource.DataSource = await _customers.GetAllDriver();
            txtserial.EditValue = PublicVar.SeriesName;
            _series = PublicVar.SeriesID;
            txtDateRegister.EditValue = DateTime.Now.PersianConvertor();

        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
            {
                XtraMessageBox.Show(PublicVar.NotComplateForm, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var driverCheck = await _queuing.FindByQueue(_driver); //عدم ثبت مجدد نوبت
                if (driverCheck == null)
                {
                    // مجاز به ثبت نوبت است
                    var newQueue = new ViewModelQueue()
                    {
                        DriverIdFk = _driver,
                        ComosiunIdFk = _commissionId,
                        TypeFk = Convert.ToByte(cbxCargoType.EditValue),
                        DateTimeRegister = DateTime.Now,
                        SeriesIdFk = PublicVar.SeriesID,
                        Number = Convert.ToInt16(txtNumber.EditValue),
                        GroupCommission = _group,
                        StatusFk = 20,
                        Mandeh = chkMandeh.Checked,

                    };
                    PublicVar.TempCash = Convert.ToInt32(txtComossin.Text);
                    var frm = new FrmCash();
                    var dialogResult = frm.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        var result = _queuing.RegisterNewQueue(newQueue, frm.ModelCash);
                        if (result)
                        {
                            _seriesNumber = $"س {PublicVar.SeriesName}  شماره {Convert.ToInt16(txtNumber.EditValue)}";
                            _number = await _queuing.GetScheduleByTypeId(newQueue.TypeFk);
                            PrintFish();
                            await _queuing.GetLastNumberByTypeId(Convert.ToByte(cbxCargoType.EditValue));
                            cbxSmart.EditValue = cbxCargoType.EditValue = null;

                        }
                        else
                        {
                            XtraMessageBox.Show(PublicVar.ErrorMessageForNotSave, Text, MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            cbxSmart.EditValue = cbxCargoType.EditValue = null;
                        }
                    }
                }
                else
                {
                    var str =
                        $"برای شماره هوشمند {driverCheck.Driver.SmartCart} نوبت محموله {driverCheck.LoadType.Type} در تاریخ {driverCheck.DateTimeRegister.PersianConvertor()} ثبت شده است";
                    XtraMessageBox.Show(str, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }
    }
}

