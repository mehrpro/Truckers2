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
using TruckerApp.Repository;
using TruckerApp.ViewModels.Administrator;

namespace TruckerApp.UserForm.Administrator
{
    public partial class FrmUsres : XtraForm
    {
        private readonly IAdministrator _administrator;
        private readonly IHasherClass _hasherClass;
        private ViewModelUsers _viewModelUsers;
        private User _getUser;

        public FrmUsres(IAdministrator administrator, IHasherClass hasherClass)
        {
            _administrator = administrator;
            _hasherClass = hasherClass;
            InitializeComponent();
            Clear();

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var convertEncrypt = await _hasherClass.EncryptViewModelUser(GetViewModelUsers());//EncryptUsers
            var result = await _administrator.ManageUsers(convertEncrypt);//Save to DataBase
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

        private async void Clear()
        {
            SetViewModelUsers(new ViewModelUsers());
            dgvUserList.DataSource = await _administrator.GetAllUser();
        }

        private User GetViewModelUsers()
        {
            _getUser = new User
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastname.Text.Trim(),
                Phone = txtPhoneNumber.Text.Trim(),
                Roul = cbxRole.Text.Trim(),
                username = txtUsername.Text.Trim(),
                password = txtPassword.Text.Trim(),
                userID = Convert.ToByte(txtID.EditValue),
            };
            return _getUser;
        }
        private void SetViewModelUsers(ViewModelUsers viewModelUsers)
        {
            txtID.EditValue = viewModelUsers.userID;
            txtFirstName.EditValue = viewModelUsers.FirstName;
            txtLastname.EditValue = viewModelUsers.LastName;
            txtPhoneNumber.EditValue = viewModelUsers.Phone;
            txtUsername.EditValue = viewModelUsers.username;
            txtPassword.EditValue = viewModelUsers.password;
            cbxRole.EditValue = viewModelUsers.Roul;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (gridViewUserList.GetFocusedRowCellValue("userID") != null)
            {
                var FocusedRow = gridViewUserList.GetFocusedRow();
                _viewModelUsers = new ViewModelUsers();
                _viewModelUsers = (ViewModelUsers)FocusedRow;
                SetViewModelUsers(_viewModelUsers);
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {

            SetViewModelUsers(new ViewModelUsers());
        }
    }
}
