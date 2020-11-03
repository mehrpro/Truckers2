using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckerApp.Repository;
using TruckerApp.ViewModels.Administrator;

namespace TruckerApp.UserForm.Administrator
{
    public partial class FrmUsres : DevExpress.XtraEditors.XtraForm
    {
        private readonly IAdministrator _administrator;
        public FrmUsres(IAdministrator administrator)
        {
            _administrator = administrator;
            InitializeComponent();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newUser = new ViewModelUsers
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastname.Text.Trim(),
                Phone = txtPhoneNumber.Text.Trim(),
                Roul = cbxRole.Text.Trim(),
                username = txtUsername.Text.Trim(),
                password = txtPassword.Text.Trim(),
                userID = 0
            };
        }

        private async void FrmUsres_Load(object sender, EventArgs e)
        {
            dgvUserList.DataSource = await _administrator.GetAllUser();
        }
    }
}
