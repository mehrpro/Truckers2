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
        private int _driver,_series;
        private Int16 _commission;
        private byte _groupCommission;
        private string _name, _number, _smartcart, _tagnumber, _type="فله";
        private int _queue;
        public FrmFishPrint()
        {
            InitializeComponent();
            driverList();
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
            using (var db = new TruckersEntities())
            {
                _series = db.Series.Single(x => x.enabeled == true && x.closing == null).Series1.Value;
                PublicVar.SeriesID = _series;
                txtserial.Text = _series.ToString();
            }
        }

        private void radioGroupType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (radioGroupType.SelectedIndex)
            {
                case 0:
                    _type = "فله";
                    break;
                case 1:
                    _type = "پاکت";
                    break;
                case 2:
                    _type = "'گندم";
                    break;
            }
        }



        private void PrintFish()
        {
            db = new TruckersEntities();
            //var qryUser = db.Users.Single(row => row.UserID == PublicVariable.LoginUserId);
            var report = XtraReport.FromFile("ReportFish.repx", true);
            var tool = new ReportPrintTool(report);
            report.Parameters["date"].Value = DateTime.Now.ToLongDateString();
            report.Parameters["name"].Value = _name;
            report.Parameters["number"].Value = _number;
            report.Parameters["smartcart"].Value = _smartcart;
            report.Parameters["TagNumbers"].Value = _tagnumber;
            report.Parameters["Type"].Value = _type ;
            tool.Print();
            var frm = new FrmCash();
            frm._userid = PublicVar.UserID;
            frm.QueueID = _queue;
            frm.CashTemp = txtComossin.Text;
            frm.ShowDialog();
        }

        private void cbxSmart_EditValueChanged(object sender, EventArgs e)
        {
            var db = new TruckersEntities();
            var driver = (Driver) cbxSmart.GetSelectedDataRow();
            _driver = driver.DriverID;
            txtName.Text =_name = $"{driver.FirstName}  {driver.LastName}";
            txtTag.Text = _tagnumber = $"ایران {driver.Tag}  {driver.TagNumber}";
            txtPhoneNumber.Text = driver.PhoneNumber;
            _smartcart = driver.SmartCart.ToString();
            _groupCommission = driver.Commission_Group;
            var qryCommission1 = db.Commissions.SingleOrDefault(x => x.enabled == true && x.Groups == _groupCommission);
            _commission = qryCommission1.CommissionID;
            txtComossin.Text = qryCommission1.Commission1.ToString();
        }

        private void FrmFishPrint_Load(object sender, EventArgs e)
        {
            setupPage();
            txtDateRegister.Text = DateTime.Today.ToLongDateString();
            LastNumber();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var driverCheck = db.Queues.Where(x => x.Status_FK == 4 && x.DriverID_FK == _driver).ToList();
            if (driverCheck.Count == 0)
            {
                Queue qu = new Queue
                {
                    DriverID_FK = _driver,
                    ComosiunID_FK = _commission,
                    Type_FK = Convert.ToByte(radioGroupType.EditValue),
                    DateTimeRegister = DateTime.Now,
                    SeriesID_FK = _series,
                    Number = Convert.ToInt16(txtNumber.EditValue),
                    GroupCommission = _groupCommission,
                    Status_FK = 4,//ثبت حواله
                };
                db.Queues.Add(qu);
                db.SaveChanges();
                _queue = qu.ID;
                _number = $"س{qu.SeriesID_FK}  شماره {qu.Number}";
                XtraMessageBox.Show(PublicVar.SuccessfulSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                PrintFish();
                LastNumber();

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
                txtNumber.Text = ((qryNumber.Number)+1).ToString("000");
            }
        }
    }
}
