using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
namespace TruckerApp.UserForm
{
    public partial class FrmFishPrint : XtraForm
    {
        private TruckersEntities db = new TruckersEntities();

        private int _driver, _series;
        private int _commission;
        private short _commissionID;//حق کمیسیون
        private string _name, _number, _smartcart, _tagnumber, _type;
        public byte _typeID { get; set; }
        private int _queue;
        private byte _group;


        public FrmFishPrint()
        {
            InitializeComponent();
            driversBindingSource.DataSource = new BindingList().DriversList();
        }

        private void SelectType()
        {
            switch (_typeID)
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

        private void PrintFish()
        {
            var report = XtraReport.FromFile("ReportFish.repx", true);
            var tool = new ReportPrintTool(report);
            report.Parameters["date"].Value = DateTime.Now.ToLongDateString();
            report.Parameters["name"].Value = _name;
            report.Parameters["number"].Value = _number;
            report.Parameters["smartcart"].Value = _smartcart;
            report.Parameters["TagNumbers"].Value = _tagnumber;
            report.Parameters["Type"].Value = _type;
            tool.PrintDialog();

        }

        private void Pardakht()
        {
            var frm = new FrmCash();
            frm._userid = PublicVar.UserID;
            frm.QueueID = _queue;
            frm._serialID = _series;
            frm.CashTemp = txtComossin.Text;
            frm.ShowDialog();
        }

        private void cbxSmart_EditValueChanged(object sender, EventArgs e)
        {
            Driver driver = (Driver)cbxSmart.GetSelectedDataRow();
            txtName.Text = _name = $"{driver.FirstName}  {driver.LastName}";
            txtTag.Text = _tagnumber = $"ایران {driver.Tag}  {driver.TagNumber}";
            txtPhoneNumber.Text = driver.PhoneNumber;
            _driver = driver.DriverID;
            _smartcart = driver.SmartCart.ToString();
            _group = driver.GroupID;

            if (_group == 30)
            {
                if (_typeID == 4)
                {
                    var qry = db.Commissions.SingleOrDefault(x => x.enabled == true && x.Groups_FK == 13);
                    _commissionID = qry.CommissionID;
                    _commission = qry.CommissionPrice;
                }

                else
                {
                    var qry = db.Commissions.SingleOrDefault(x => x.enabled == true && x.Groups_FK == 14);
                    _commissionID = qry.CommissionID;
                    _commission = qry.CommissionPrice;
                }

            }
            else if (_group == 31)
            {
                if (_typeID == 4)
                {
                    var qry = db.Commissions.SingleOrDefault(x => x.enabled == true && x.Groups_FK == 17);
                    _commissionID = qry.CommissionID;
                    _commission = qry.CommissionPrice;
                }

                else
                {
                    var qry = db.Commissions.SingleOrDefault(x => x.enabled == true && x.Groups_FK == 15);
                    _commissionID = qry.CommissionID;
                    _commission = qry.CommissionPrice;
                }
            }
            else if (_group == 32)
            {
                if (_typeID == 4)
                {
                    var qry = db.Commissions.SingleOrDefault(x => x.enabled == true && x.Groups_FK == 18);
                    _commissionID = qry.CommissionID;
                    _commission = qry.CommissionPrice;
                }

                else
                {
                    var qry = db.Commissions.SingleOrDefault(x => x.enabled == true && x.Groups_FK == 16);
                    _commissionID = qry.CommissionID;
                    _commission = qry.CommissionPrice;
                }
            }
            txtComossin.Text = _commission.ToString();
        }

        private void FrmFishPrint_Load(object sender, EventArgs e)
        {
            setupPage();
            txtDateRegister.Text = DateTime.Today.ToLongDateString();
            LastNumber();
            SelectType();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            db = new TruckersEntities();
            var driverCheck = db.Queues.Where(x => x.Status_FK == 20 && x.DriverID_FK == _driver).ToList();
            if (driverCheck.Count == 0)
            {
                    try
                    {
                        var qu = new Queue();
                        qu.DriverID_FK = _driver;
                        qu.ComosiunID_FK = _commissionID;
                        qu.Type_FK = _typeID;
                        qu.DateTimeRegister = DateTime.Now;
                        qu.SeriesID_FK = _series;
                        qu.Number = Convert.ToInt16(txtNumber.EditValue);
                        qu.GroupCommission = _group;
                        qu.Status_FK = 20;
                        db.Queues.Add(qu);
                        db.SaveChanges();
                        _queue = qu.ID;
                        _number = $"س{qu.SeriesID_FK}  شماره {qu.Number}";
                        XtraMessageBox.Show(PublicVar.SuccessfulSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PrintFish();
                        Pardakht();
                        LastNumber();
                    }
                    catch 
                    {
                        XtraMessageBox.Show(PublicVar.ErrorMessageForNotSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else
            {
                var str =
                    $"برای شماره هوشمند {driverCheck[0].Driver.SmartCart} نوبت محموله {driverCheck[0].LoadType.Type} در تاریخ {driverCheck[0].DateTimeRegister} ثبت شده است";
                XtraMessageBox.Show(str, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LastNumber()
        {
            int qryNumber = new Counter().lastNumber(PublicVar.SeriesID);
                txtNumber.Text = (qryNumber + 1).ToString("000");
            
        }
    }
}
