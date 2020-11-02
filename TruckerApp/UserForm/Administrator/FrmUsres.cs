using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckerApp.ViewModels.Administrator;

namespace TruckerApp.UserForm.Administrator
{
    public partial class FrmUsres : DevExpress.XtraEditors.XtraForm
    {
        public FrmUsres()
        {
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
    }
}
