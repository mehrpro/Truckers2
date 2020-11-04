using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TruckerApp.ExtentionMethod;
using TruckerApp.Repository;

namespace TruckerApp.UserForm.Customer
{
    public partial class FrmAddressBook : XtraForm
    {
        private readonly ICustomers _customers;
        private AddressBook _addressBook;
        public FrmAddressBook(ICustomers customers)
        {
            _customers = customers;
            InitializeComponent();
            Clear();

        }

        private AddressBook GetModel()
        {
            _addressBook = new AddressBook
            {
                ID = Convert.ToInt32(txtID.EditValue),
                Fname = txtFname.Text.Trim(),
                LName = txtLName.Text.Trim(),
                Mobile = txtMobile.Text.Trim(),
                Mobile2 = txtMobile2.Text.Trim(),
                Phone = txtHomeTel.Text.Trim(),
                Addres = txtAddress.Text.Trim(),
                postalCode = txtPostalCode.Text.Trim(),
                Jobs = cbxJobs.Text.Trim(),
                Description = txtDescription.Text.Trim(),
            };
            return _addressBook;
        }

        private void SetModel(AddressBook addressBook)
        {
            txtID.EditValue = addressBook.ID;
            txtFname.EditValue = addressBook.Fname;
            txtLName.EditValue = addressBook.LName;
            txtMobile.EditValue = addressBook.Mobile;
            txtMobile2.EditValue = addressBook.Mobile2;
            txtHomeTel.EditValue = addressBook.Phone;
            txtAddress.EditValue = addressBook.Addres;
            txtPostalCode.EditValue = addressBook.postalCode;
            cbxJobs.EditValue = addressBook.Jobs;
            txtDescription.EditValue = addressBook.Description;
        }
        private async void Clear()
        {
            lblStatusProcess.Text = DateTime.Now.PersianConvertor();
            ProgressBarTransformer.Visible = false;
            timerTransporter.Enabled = false;
        
            gridControl1.DataSource =  await _customers.GetAllAddressBook();
            
            
        }
        private void timerTransporter_Tick(object sender, EventArgs e)
        {
            lblStatusProcess.Text = PublicVar.ConterString;
            ProgressBarTransformer.Visible = true;
            ProgressBarTransformer.Maximum = PublicVar.MasterConter;
            ProgressBarTransformer.Value = PublicVar.Conter;

        }

        private async void btnTransformer_Click(object sender, EventArgs e)
        {
            timerTransporter.Enabled = true;
            var result = await _customers.TransfomatorPhone();
            //timerTransporter.Enabled = true;
            if (result)
            {
                Clear();
                XtraMessageBox.Show(PublicVar.SuccessfulSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                Clear();
                XtraMessageBox.Show(PublicVar.ErrorMessageForNotSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ID") != null)
            {
                var FocusedRow = gridView1.GetFocusedRow();
                _addressBook = new AddressBook();
                _addressBook = (AddressBook)FocusedRow;
                SetModel(_addressBook);
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            SetModel(new AddressBook());
        }

        private  void btnSave_Click(object sender, EventArgs e)
        {
            var result =  _customers.ManageAddressBook(GetModel());
            if (result)
            {
                XtraMessageBox.Show(PublicVar.SuccessfulSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else
            {
                XtraMessageBox.Show(PublicVar.ErrorMessageForNotSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
