using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TruckerApp.ExtentionMethod;
using TruckerApp.Repository;
using System.Data.Entity;

namespace TruckerApp.UserForm
{
    public partial class FrmRevFish333 : XtraForm
    {
        private readonly ICustomers _customers;
        private readonly IQueuing _queuing;
        public FrmRevFish333(ICustomers customers, IQueuing queuing)
        {
            _customers = customers;
            _queuing = queuing;
            InitializeComponent();

        }
        private int _selectid;
       // private Driver row;


        private async void cbxSmart_EditValueChanged(object sender, EventArgs e)
        {
            _selectid = 0;
           var row = (Driver)cbxSmart.GetSelectedDataRow();
            if (row == null)
            {
                txtName.EditValue =
                    txtNumber.EditValue =
                        txtTag.EditValue =
                            txtDateReg.EditValue =
                                txtType.EditValue =
                                    txtserial.EditValue = null;
                return;
            }
            txtName.Text = $@"{row.FirstName}  {row.LastName}";
            txtTag.Text = $@"{row.TagNumber}";
            var lastQueue = await _queuing.LastQueue23(row.DriverID);
            if (lastQueue == null)
            {

                txtNumber.EditValue =
                        txtDateReg.EditValue =
                            txtType.EditValue =
                                txtserial.EditValue = null;
                return;
            }
            _selectid = lastQueue.ID;
            txtserial.EditValue = lastQueue.SeriesPrice.SeriesName;
            txtNumber.EditValue = lastQueue.Number;
            txtType.EditValue = lastQueue.LoadType.Type;
            txtDateReg.EditValue = lastQueue.DateTimeRegister.PersianConvertor();
        }

        private async void btnRevSave_Click(object sender, EventArgs e)
        {
            if (_selectid > 0)
            {
                var result = await _queuing.Change23To20(_selectid);
                if (result)
                {
                    XtraMessageBox.Show(PublicVar.SuccessfulSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
                else
                    XtraMessageBox.Show(PublicVar.ErrorMessageForNotSave, Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void FrmRevFish_Load(object sender, EventArgs e)
        {
            cbxSmart.Properties.DataSource = await _customers.GetAllDriver();
            cbxSmart.Properties.DisplayMember = "SmartCart";
            cbxSmart.Properties.ValueMember = "ID";

        }


    }
}
