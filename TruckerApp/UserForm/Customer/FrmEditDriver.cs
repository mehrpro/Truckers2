using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TruckerApp.Repository;

namespace TruckerApp.UserForm.Customer
{
    public partial class FrmEditDriver : XtraForm
    {
        private Driver _selectDriver;
        private Driver _driver;
        private readonly ICustomers _customers;
        public FrmEditDriver(ICustomers customers)
        {
            _customers = customers;
            InitializeComponent();
            PublicVar.play = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate()) NotComplateFormMessage();
            _selectDriver.PhoneNumber = txtPhoneNumber.Text;
            _selectDriver.driver_code = Convert.ToInt32(txtDriverCode.Text.Trim());
            _selectDriver.FirstName = txtFirstName.Text;
            _selectDriver.LastName = txtLastNAme.Text;
            _selectDriver.editor_FK = PublicVar.UserID;
            _selectDriver.GroupID = Convert.ToByte(radComosiun.EditValue);
            var result = await _customers.EditDriver(_selectDriver);
            if (result)
            {
                SuccessFulSaveMessage();
                txtSmartCart.EditValue = 0;
            }
            else
                ErrorMessageForNotSave();
        }

        private void NotComplateFormMessage()
        {
            XtraMessageBox.Show(PublicVar.NotComplateForm, this.Text, MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void ErrorMessageForNotSave()
        {
            XtraMessageBox.Show(PublicVar.ErrorMessageForNotSave, this.Text, MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void SuccessFulSaveMessage()
        {
            XtraMessageBox.Show(PublicVar.SuccessfulSave, Text, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void txtSmartCart_EditValueChanged(object sender, EventArgs e)
        {
            _selectDriver = (Driver)txtSmartCart.GetSelectedDataRow();
            if (_selectDriver == null)
            {

                txtPhoneNumber.EditValue =
                    txtDriverCode.EditValue =
                        txtFirstName.EditValue =
                            txtLastNAme.EditValue =
                                txtTag.EditValue =
                                    txtTagNumber.EditValue = null;
                return;
            }
            txtPhoneNumber.Text = _selectDriver.PhoneNumber;
            txtDriverCode.Text = _selectDriver.driver_code == null ? "0" : _selectDriver.driver_code.Value.ToString();
            txtFirstName.Text = _selectDriver.FirstName;
            txtLastNAme.Text = _selectDriver.LastName;
            txtTag.Text = _selectDriver.Tag;
            txtTagNumber.Text = _selectDriver.TagNumber;
            radComosiun.EditValue = _selectDriver.GroupID;
        }


        private async void FrmNewDriver3_Load(object sender, EventArgs e)
        {
            driversBindingSource.DataSource = await _customers.GetAllDriver();

        }
    }
}
