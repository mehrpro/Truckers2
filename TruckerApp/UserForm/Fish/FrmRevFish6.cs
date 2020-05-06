using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraEditors;

namespace TruckerApp.UserForm
{
    public partial class FrmRevFish6 : XtraForm
    {
        public FrmRevFish6()
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
            var qry = (Driver)cbxSmart.GetSelectedDataRow();

            var qryQuese = db.Queues.SingleOrDefault(x => x.DriverID_FK == qry.DriverID && x.Status_FK == 20);
            if (qryQuese != null)
            {
                selectid = qryQuese.ID;
                qryQuese.DateTimeRegister.ToLongDateString();
                txtName.Text = $"{qry.FirstName}  {qry.LastName}";
                txtTag.Text = $"ایران {qry.Tag}-{qry.TagNumber}";
                txtComossin.Text = qryQuese.Commission.CommissionPrice.ToString();
                txtserial.Text = qryQuese.SeriesID_FK.ToString();
                txtNumber.Text = qryQuese.Number.ToString();
                txtType.Text = qryQuese.LoadType.Type;
                txtDateReg.Text = qryQuese.DateTimeRegister.ToLongDateString();
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
            var qryQueue = db.Queues.Single(x => x.ID == selectid);
            qryQueue.Status_FK = 11;
            qry.Pos = qry.CashDesk = 0;

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
