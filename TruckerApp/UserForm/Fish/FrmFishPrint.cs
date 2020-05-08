using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using TruckerApp.UserForm.cash;

namespace TruckerApp.UserForm.Fish
{
    public partial class FrmFishPrint : XtraForm
    {
        private readonly TruckersEntities _db = new TruckersEntities();
        private int _driver, _series;
        private int _commission;
        private short _commissionId;//حق کمیسیون
        private string _name, _number, _smartcart, _tagnumber, _type;
        public byte TypeId { get; set; }
        private byte _group;
        //private string _price;
        private string _memeber;
        private string _code;


        public FrmFishPrint()
        {
            InitializeComponent();
            driversBindingSource.DataSource = new BindingList().DriversList();
            //  db = new TruckersEntities();

        }

        private void selectType()
        {
            switch (TypeId)
            {
                case 1:
                    _type = "فله";
                    groupControl1.Text = "صدور حواله فله";
                    break;
                case 2:
                    _type = "پاکت";
                    groupControl1.Text = "صدور حواله پاکت";

                    break;
                case 3:
                    _type = "گندم";
                    groupControl1.Text = "صدور حواله غلات";

                    break;
                case 4:
                    _type = "کلینکر";
                    groupControl1.Text = "صدور حواله کلینکر";

                    break;
            }
        }



        private void setupPage()
        {
            txtserial.Text = PublicVar.SeriesName.ToString();
            _series = PublicVar.SeriesID;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printFish()
        {
            var report = XtraReport.FromFile("ReportFish.repx", true);
            var tool = new ReportPrintTool(report);
            report.Parameters["date"].Value = DateTime.Now.ToLongDateString();
            report.Parameters["name"].Value = _name;
            report.Parameters["number"].Value = _number;
            report.Parameters["smartcart"].Value = _smartcart;
            report.Parameters["TagNumbers"].Value = _tagnumber;
            report.Parameters["member"].Value = _memeber;
            report.Parameters["price"].Value = _commission;
            report.Parameters["Type"].Value = _type;
            report.Parameters["code"].Value = _code;
            tool.PrintDialog();
        }


        private void cbxSmart_EditValueChanged(object sender, EventArgs e)
        {
            var driver = (Driver)cbxSmart.GetSelectedDataRow();
            if (driver==null)return;
            _code = Convert.ToInt32(driver.driver_code) > 0 ? driver.driver_code.ToString() : " ";
            txtName.Text = _name = $"{driver.FirstName}  {driver.LastName}";
            txtTag.Text = _tagnumber = $"ایران {driver.Tag}  {driver.TagNumber}";
            txtPhoneNumber.Text = driver.PhoneNumber;
            _driver = driver.DriverID;
            _smartcart = driver.SmartCart.ToString();
            _group = driver.GroupID;
            _memeber = driver.LoadType.Type;
            if (_group == 30)
            {
                if (TypeId == 4)
                {
                    var qry = _db.Commissions.SingleOrDefault(x => x.enabled && x.Groups_FK == 13);
                    _commissionId = qry.CommissionID;
                    _commission = qry.CommissionPrice;
                    
                }
                else
                {
                    var qry = _db.Commissions.SingleOrDefault(x => x.enabled  && x.Groups_FK == 14);
                    _commissionId = qry.CommissionID;
                    _commission = qry.CommissionPrice;
                }
            }
            else if (_group == 31)
            {
                if (TypeId == 4)
                {
                    var qry = _db.Commissions.SingleOrDefault(x => x.enabled  && x.Groups_FK == 17);
                    _commissionId = qry.CommissionID;
                    _commission = qry.CommissionPrice;
                }
                else
                {
                    var qry = _db.Commissions.SingleOrDefault(x => x.enabled  && x.Groups_FK == 15);
                    _commissionId = qry.CommissionID;
                    _commission = qry.CommissionPrice;
                }
            }
            else if (_group == 32)
            {
                if (TypeId == 4)
                {
                    var qry = _db.Commissions.SingleOrDefault(x => x.enabled  && x.Groups_FK == 18);
                    _commissionId = qry.CommissionID;
                    _commission = qry.CommissionPrice;
                }

                else
                {
                    var qry = _db.Commissions.SingleOrDefault(x => x.enabled  && x.Groups_FK == 16);
                    _commissionId = qry.CommissionID;
                    _commission = qry.CommissionPrice;
                }
            }
            txtComossin.Text = _commission.ToString();
        }

        private void FrmFishPrint_Load(object sender, EventArgs e)
        {
            setupPage();
            txtDateRegister.Text = DateTime.Today.ToLongDateString();
            lastNumber();
            selectType();
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
                        Status_FK = 20
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
            var qryNumber = new Counter().lastNumber(PublicVar.SeriesID , (byte)TypeId);
            txtNumber.Text = (qryNumber + 1).ToString("000");

        }
    }
}
