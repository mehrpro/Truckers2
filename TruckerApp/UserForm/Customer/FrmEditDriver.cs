using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace TruckerApp.UserForm
{
    public partial class FrmNewDriver3 : XtraForm
    {
        private Driver selectDriver;
        TruckerApp.TruckersEntities db = new TruckerApp.TruckersEntities();
        public FrmNewDriver3()
        {
            InitializeComponent();

          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                var qry = db.Drivers.Find(selectDriver.DriverID);
                if (qry != null)
                {
                    qry.PhoneNumber = txtPhoneNumber.Text;
                    qry.driver_code =Convert.ToInt32(txtDriverCode.Text)>0 ? Convert.ToInt32(txtDriverCode.Text) : 0;
                    qry.FirstName = txtFirstName.Text;
                    qry.LastName = txtLastNAme.Text;
                    qry.Tag = Convert.ToByte(txtTag.Text);
                    qry.TagNumber = txtTagNumber.Text;
                    qry.GroupID = (byte) radComosiun.EditValue;
                    qry.editor_FK = PublicVar.UserID;
                }
                db.SaveChanges();
                XtraMessageBox.Show(PublicVar.SuccessfulSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtLastNAme.Text = txtPhoneNumber.Text = txtTag.Text = txtTagNumber.Text = "";

        }

        private void txtSmartCart_EditValueChanged(object sender, EventArgs e)
        {
            selectDriver = (Driver) txtSmartCart.GetSelectedDataRow();
            if (selectDriver==null)return;
            txtPhoneNumber.Text = selectDriver.PhoneNumber;
            txtDriverCode.Text = selectDriver.driver_code.ToString();
            txtFirstName.Text = selectDriver.FirstName;
            txtLastNAme.Text = selectDriver.LastName;
            txtTag.Text = selectDriver.Tag.ToString();
            txtTagNumber.Text = selectDriver.TagNumber;
            radComosiun.EditValue = selectDriver.GroupID;
        }

        private void FrmNewDriver3_Load(object sender, EventArgs e)
        {
            driversBindingSource.DataSource = db.Drivers.ToList();
        }
    }
}
