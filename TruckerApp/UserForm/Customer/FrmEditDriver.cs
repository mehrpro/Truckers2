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
        //private Driver _driver;
        private readonly ICustomers _customers;
        private bool _changeablePlate;
        private Driver _oldDriver;

        public FrmEditDriver(ICustomers customers)
        {
            _customers = customers;
            InitializeComponent();
           // PublicVar.play = false;
            _changeablePlate = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPlateEnglish.Text.Length < 12)
            {
                XtraMessageBox.Show(PublicVar.NotComplateForm, this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!dxValidationProvider1.Validate()) NotComplateFormMessage();
            _selectDriver.PhoneNumber = txtPhoneNumber.Text;
            _selectDriver.driver_code = Convert.ToInt32(txtDriverCode.Text.Trim());
            _selectDriver.FirstName = txtFirstName.Text;
            _selectDriver.LastName = txtLastNAme.Text;
            _selectDriver.editor_FK = PublicVar.UserID;
            _selectDriver.GroupID = Convert.ToByte(radComosiun.EditValue);
            _selectDriver.Tag = txtPlateEnglish.Text.Trim();
            _selectDriver.TagNumber = txtPlateFarsi.Text.Trim();
            if (_changeablePlate)
            {
                var result = await _customers.EditDriverWithNewPlate(_selectDriver, _oldDriver.DriverID);
                if (result)
                {
                    SuccessFulSaveMessage();
                    txtSmartCart.EditValue = 0;
                }
                else
                    ErrorMessageForNotSave();

            }
            else
            {
                var result = await _customers.EditDriver(_selectDriver);
                if (result)
                {
                    SuccessFulSaveMessage();
                    txtSmartCart.EditValue = 0;
                }
                else
                    ErrorMessageForNotSave();
            }


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
                txt1.EditValue = txt2.EditValue = txt3.EditValue =
                txtPhoneNumber.EditValue =
                    txtDriverCode.EditValue =
                        txtFirstName.EditValue =
                            txtLastNAme.EditValue =
                                txtPlateEnglish.EditValue =
                                    txtPlateFarsi.EditValue = null;
                _changeablePlate = chkChangePlate.Checked = false;
                return;
            }
            _changeablePlate = chkChangePlate.Checked = false;
            txt1.Enabled = txt2.Enabled = txt3.Enabled = false;
            txt1.EditValue = txt2.EditValue = txt3.EditValue = null;
            txtPhoneNumber.Text = _selectDriver.PhoneNumber;
            txtDriverCode.Text = _selectDriver.driver_code == null ? "0" : _selectDriver.driver_code.Value.ToString();
            txtFirstName.Text = _selectDriver.FirstName;
            txtLastNAme.Text = _selectDriver.LastName;
            txtPlateEnglish.Text = _selectDriver.Tag;
            txtPlateFarsi.Text = _selectDriver.TagNumber;
            radComosiun.EditValue = _selectDriver.GroupID;
        }

        private async void UpdateTextEdit()
        {
            txtPlateEnglish.Text = txt1.Text.Trim() + "-Ain-" + txt2.Text.Trim() + txt3.Text.Trim();
            txtPlateFarsi.Text = "ایران" + txt3.Text.Trim() + " " + txt2.Text.Trim() + "ع" + txt1.Text.Trim();
            if (txtPlateEnglish.Text.Length == 12)
            {
                var result = await _customers.FindPlate(txtPlateEnglish.Text);
                if (result)
                {
                    _oldDriver = await _customers.FindDriverByTag(txtPlateEnglish.Text);

                    var dialogResult = XtraMessageBox.Show($"این پلاک متعلق است به {_oldDriver.FirstName + " " + _oldDriver.LastName} آیا قصد تغیر راننده را دارید", this.Text, MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                        _changeablePlate = true;
                    else
                        _changeablePlate = false;

                }
            }
        }

        private async void FrmNewDriver3_Load(object sender, EventArgs e)
        {
            driversBindingSource.DataSource = await _customers.GetAllDriver();

        }

        private void txt3_Click(object sender, EventArgs e)
        {
            txt3.SelectAll();
        }

        private void txt3_Enter(object sender, EventArgs e)
        {
            txt3.SelectAll();
        }

        private void txt3_EditValueChanged(object sender, EventArgs e)
        {
            UpdateTextEdit();
        }

        private void txt2_EditValueChanged(object sender, EventArgs e)
        {
            UpdateTextEdit();

        }

        private void txt1_EditValueChanged(object sender, EventArgs e)
        {
            UpdateTextEdit();

        }

        private void txt2_Enter(object sender, EventArgs e)
        {
            txt2.SelectAll();
        }

        private void txt2_Click(object sender, EventArgs e)
        {
            txt2.SelectAll();
        }

        private void txt1_Enter(object sender, EventArgs e)
        {
            txt1.SelectAll();
        }

        private void txt1_Click(object sender, EventArgs e)
        {
            txt1.SelectAll();
        }

        private void chkChangePlate_CheckedChanged(object sender, EventArgs e)
        {
            var result = chkChangePlate.Checked;
            if (result)
            {
                txtPlateEnglish.EditValue = txtPlateFarsi.EditValue = txt1.EditValue = txt2.EditValue = txt3.EditValue = null;
                txt1.Enabled = txt2.Enabled = txt3.Enabled = true;
                labelControl3.Text = $"پلاک جدید";
            }
            else
            {
                txtPlateEnglish.EditValue = txtPlateFarsi.EditValue = txt1.EditValue = txt2.EditValue = txt3.EditValue = null;
                txt1.Enabled = txt2.Enabled = txt3.Enabled = false;
                if (_selectDriver !=null)
                {
                    txtPlateEnglish.EditValue = _selectDriver.Tag;
                    txtPlateFarsi.EditValue = _selectDriver.TagNumber;
                }

                labelControl3.Text = $"پلاک فعلی راننده";
            }
        }
    }
}
