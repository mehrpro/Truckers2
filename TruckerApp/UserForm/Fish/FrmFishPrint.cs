using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
namespace TruckerApp.UserForm
{
    public partial class FrmFishPrint : Form
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
            driverList();
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

        private void driverList()
        {
            db = new TruckersEntities();
            db.Drivers.LoadAsync()
                .ContinueWith(loadTask => { driversBindingSource.DataSource = db.Drivers.Local.ToBindingList(); },
                    System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void setupPage()
        {
            //using (var db = new TruckersEntities())
            //{
            //    _series = db.SeriesPrices.Single(x => x.enabeled == true && x.closing == null).SereisID;
            //    PublicVar.SeriesID = _series;
                txtserial.Text = PublicVar.SeriesName.ToString();
                _series = PublicVar.SeriesID;
                //}
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrintFish()
        {
            //db = new TruckersEntities();
            //var qryUser = db.Users.Single(row => row.UserID == PublicVariable.LoginUserId);
            var report = XtraReport.FromFile("ReportFish.repx", true);
            var tool = new ReportPrintTool(report);
            report.Parameters["date"].Value = DateTime.Now.ToLongDateString();
            report.Parameters["name"].Value = _name;
            report.Parameters["number"].Value = _number;
            report.Parameters["smartcart"].Value = _smartcart;
            report.Parameters["TagNumbers"].Value = _tagnumber;
            report.Parameters["Type"].Value = _type;
            tool.Print();

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

            if (_group == 1) //عضو
            {
                if (_typeID == 4)
                {
                    var qry2x = db.Commissions.SingleOrDefault(x => x.enabled == true && x.Groups_FK == 13);
                    _commissionID = qry2x.CommissionID;
                    _commission = qry2x.CommissionPrice;
                }

                else
                {
                    var qry2x = db.Commissions.SingleOrDefault(x => x.enabled == true && x.Groups_FK == 14);
                    _commissionID = qry2x.CommissionID;
                    _commission = qry2x.CommissionPrice;
                }

            }
            else if (_group == 2)
            {
                if (_typeID == 4)
                {
                    var qry2x = db.Commissions.SingleOrDefault(x => x.enabled == true && x.Groups_FK == 17);
                    _commissionID = qry2x.CommissionID;
                    _commission = qry2x.CommissionPrice;
                }

                else
                {
                    var qry2x = db.Commissions.SingleOrDefault(x => x.enabled == true && x.Groups_FK == 15);
                    _commissionID = qry2x.CommissionID;
                    _commission = qry2x.CommissionPrice;
                }
            }
            else if (_group == 3)
            {
                if (_typeID == 4)
                {
                    var qry2x = db.Commissions.SingleOrDefault(x => x.enabled == true && x.Groups_FK == 18);
                    _commissionID = qry2x.CommissionID;
                    _commission = qry2x.CommissionPrice;
                }

                else
                {
                    var qry2x = db.Commissions.SingleOrDefault(x => x.enabled == true && x.Groups_FK == 16);
                    _commissionID = qry2x.CommissionID;
                    _commission = qry2x.CommissionPrice;
                }
            }

            //var qryCommission1 = db.Commissions.SingleOrDefault(x => x.enabled == true && x.GroupID == _commissionID && x.Groups_FK ==_selectRadioButten);
            //_commission = qryCommission1.CommissionID;
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
            var driverCheck = db.Queues.Where(x => x.Status_FK == 4 && x.DriverID_FK == _driver).ToList();
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
            var dbPrinter = new TruckersEntities();
            var qryNumber = dbPrinter.Queues.Where(x => x.SeriesID_FK == _series).OrderByDescending(z => z.ID)
                .FirstOrDefault();
            if (qryNumber == null)
            {
                //
                txtNumber.Text = @"001";
            }
            else
            {
                txtNumber.Text = ((qryNumber.Number) + 1).ToString("000");
            }
        }
    }
}
