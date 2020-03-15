using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraEditors;

namespace TruckerApp.UserForm
{
    public partial class FrmRevFish : XtraForm
    {
        public FrmRevFish()
        {
            InitializeComponent();
            driverList();
            setupPage();
        }
        private TruckersEntities db = new TruckersEntities();
        private int selectid;
        private void driverList()
        {
            db = new TruckersEntities();
            db.Drivers.LoadAsync()
                .ContinueWith(loadTask => { driversBindingSource.DataSource = db.Drivers.Local.ToBindingList(); },
                    TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void setupPage()
        {
            txtDateRegister.Text = DateTime.Today.ToLongDateString();
        }

        private void cbxSmart_EditValueChanged(object sender, EventArgs e)
        {
            var qry = (Driver) cbxSmart.GetSelectedDataRow();

            var qryQuese = db.Queues.Where(x => x.DriverID_FK == qry.DriverID && x.Status_FK == 20).ToList();
            if (qryQuese.Count > 0)
            {
                selectid = qryQuese[0].ID;
                 qryQuese[0].DateTimeRegister.ToLongDateString();
                txtName.Text = $"{qry.FirstName}  {qry.LastName}";
                txtTag.Text = $"ایران {qry.Tag}-{qry.TagNumber}";
                txtComossin.Text = qryQuese[0].Commission.CommissionPrice.ToString();
                txtserial.Text = qryQuese[0].SeriesID_FK.ToString();
                txtNumber.Text = qryQuese[0].Number.ToString();
                txtType.Text = qryQuese[0].LoadType.Type;
                txtDateReg.Text = qryQuese[0].DateTimeRegister.ToLongDateString();
            }
            else
            {
                txtType.Text = txtNumber.Text = txtDateReg.Text = txtTag.Text = txtName.Text = txtComossin.Text = "";
                var str = $"هیچ حواله ای برای کارت هوشمند {qry.SmartCart} صادر نشده است";
                XtraMessageBox.Show(str, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void btnRevSave_Click(object sender, EventArgs e)
        {
            db = new TruckersEntities();
            var qry = db.Cashes.Single(x => x.QueueID_FK == selectid);
            qry.Queue.Status_FK = byte.Parse(radioGroupType.EditValue.ToString());
            qry.Pos = qry.CashDesk =  0;
            db.SaveChanges();
            var str = $"باطل شد";
            XtraMessageBox.Show(str, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Close();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmRevFish_Load(object sender, EventArgs e)
        {

        }
    }
}
