using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraEditors;
using TruckerApp.ExtentionMethod;
using TruckerApp.Repository;

namespace TruckerApp.UserForm.Fish
{
    public partial class FrmRevFish : XtraForm
    {
        private readonly ICustomers _customers;
        private readonly IQueuing _queuing;
        public  FrmRevFish(ICustomers customers, IQueuing queuing)
        {
            _customers = customers;
            _queuing = queuing;
            InitializeComponent();
            
        }

        private int _selectid;



        private async void cbxSmart_EditValueChanged(object sender, EventArgs e)
        {
            var row = (Driver) cbxSmart.GetSelectedDataRow();
            var result = await _queuing.FindByQueue(row.DriverID);
            if (result != null)
            {
                _selectid = result.ID;
                result.DateTimeRegister.PersianConvertor();
                txtName.Text = $@"{row.FirstName}  {row.LastName}";
                txtTag.Text = $@"{row.Tag}";
                txtComossin.Text = result.Commission.CommissionPrice.ToString();
                txtserial.Text = result.SeriesID_FK.ToString();
                txtNumber.Text = result.Number.ToString();
                txtType.Text = result.LoadType.Type;
                txtDateReg.Text = result.DateTimeRegister.PersianConvertor();
            }
            else
            {
                //txtType.Text = txtNumber.Text = txtDateReg.Text = txtTag.Text = txtName.Text = txtComossin.Text = "";
                var str = $@"هیچ حواله ای برای کارت هوشمند {row.SmartCart} صادر نشده است";
                XtraMessageBox.Show(str, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private async void btnRevSave_Click(object sender, EventArgs e)
        {
            
            var result = await _queuing.RetrunCashByQueueID(_selectid, byte.Parse(radioGroupType.EditValue.ToString()));
            if (result)
            {
                XtraMessageBox.Show(PublicVar.SuccessfulSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            else
                XtraMessageBox.Show(PublicVar.ErrorMessageForNotSave, Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void FrmRevFish_Load(object sender, EventArgs e)
        {
            txtDateRegister.Text = DateTime.Today.PersianConvertor();
            cbxSmart.Properties.DataSource = await _customers.GetAllDriver();
        }
    }
}
