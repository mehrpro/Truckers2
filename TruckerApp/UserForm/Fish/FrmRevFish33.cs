using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TruckerApp.ExtentionMethod;
using TruckerApp.Repository;
using System.Data.Entity;

namespace TruckerApp.UserForm
{
    public partial class FrmRevFish33 : XtraForm
    {
        private readonly ICustomers _customers;
        private readonly IQueuing _queuing;
        public FrmRevFish33(ICustomers customers, IQueuing queuing)
        {
            _customers = customers;
            _queuing = queuing;
            InitializeComponent();

        }
        private int _selectid;
        private Queue row;


        private void cbxSmart_EditValueChanged(object sender, EventArgs e)
        {
            _selectid = 0;
            row = (Queue)cbxSmart.GetSelectedDataRow();
            if (row == null)
            {
                return;
            }
            _selectid = row.ID;
            txtName.Text = $@"{row.Driver.FirstName}  {row.Driver.LastName}";
            txtTag.Text = $@"{row.Driver.TagNumber}";
            txtserial.EditValue = row.SeriesPrice.SeriesName;
            txtNumber.EditValue = row.Number;
            txtType.EditValue = row.LoadType.Type;
            txtDateReg.EditValue = row.DateTimeRegister.PersianConvertor();

        }

        private async void btnRevSave_Click(object sender, EventArgs e)
        {
            if (_selectid > 0)
            {
                var result = await _queuing.Tamdid(_selectid);
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
           // txtDateRegister.Text = DateTime.Today.PersianConvertor();
            cbxSmart.Properties.DataSource =  await _queuing.GetTamdid();

        }


    }
}
