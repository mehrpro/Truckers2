using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TruckerApp.Repository;

namespace TruckerApp.UserForm
{
    public partial class FrmNewDriver : XtraForm
    {
        private ICustomers _customers;
        public FrmNewDriver(ICustomers customers)
        {
            _customers = customers;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private async void btnSave_Click(object sender, EventArgs e)
        {
            //12-Ain-12525
            if (txtPlateEnglish.Text.Length < 12)
            {
                XtraMessageBox.Show(PublicVar.NotComplateForm, this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (await _customers.FindPlate(txtPlateEnglish.Text.Trim()))
            {
                XtraMessageBox.Show("این پلاک قبلا ثبت شده است", this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (dxValidationProvider1.Validate())
            {
                int smartcart =  Convert.ToInt32(txtSmartCart.Text);

                using (var db = new TruckersEntities())
                {
                    try
                    {
                        var newDriver = new Driver();
                        newDriver.FirstName = txtFirstName.Text.Trim();
                        newDriver.LastName = txtLastNAme.Text.Trim();
                        newDriver.PhoneNumber = txtPhoneNumber.Text.Trim();
                        newDriver.userID_FK = PublicVar.UserID;
                        newDriver.Tag = txtPlateEnglish.Text;
                        newDriver.TagNumber = txtPlateFarsi.Text;
                        newDriver.SmartCart = smartcart;
                        newDriver.driver_code = Convert.ToInt32(txtCode.Text);
                        newDriver.GroupID = Convert.ToByte(radComosiun.EditValue);
                        
                        db.Drivers.Add(newDriver);
                        db.SaveChanges();
                        XtraMessageBox.Show(PublicVar.SuccessfulSave,
                            Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Clear();

                    }
                    catch
                    {
                        var qry = db.Drivers.SingleOrDefault(x => x.SmartCart == smartcart);
                        if (qry != null)
                        {
                            var tel = (Driver) qry;
                            string varString = $"شماره هوشمند {qry.SmartCart} به نام {qry.FirstName} {qry.LastName} قبلا ثبت شده است";
                            XtraMessageBox.Show(varString,
                                "خطایی کاربری", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        XtraMessageBox.Show(PublicVar.ErrorMessageForNotSave, 
                            Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            else
            {
                XtraMessageBox.Show(PublicVar.NotComplateForm, this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Clear()
        {
            txtSmartCart.Text = txtFirstName.Text =
                txtLastNAme.Text = txtPhoneNumber.Text = "";

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
                    XtraMessageBox.Show("این پلاک قبلا ثبت شده است", this.Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        private void txtTagNumber_EditValueChanged(object sender, EventArgs e)
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

        private void txt3_Enter(object sender, EventArgs e)
        {
            txt3.SelectAll();
        }

        private void txt3_Click(object sender, EventArgs e)
        {
            txt3.SelectAll();
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
    }
}
