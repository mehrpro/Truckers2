using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TruckerApp.Repository;
using TruckerApp.ViewModels.Administrator;

namespace TruckerApp
{
    public partial class FrmLogin : XtraForm
    {
        private readonly IAdministrator _administrator;
        public FrmLogin(IAdministrator administrator)
        {
            InitializeComponent();
            _administrator = administrator;
            txtPassword.Text = @"708801298";
            txtUsername.Text = @"admin";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var dialogResult = await _administrator.ApproveLogin(new ViewModelLogin()
            {
                UserName = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim(),
            });

            if (dialogResult == DialogResult.OK)
            {
                DialogResult = dialogResult;
                Close();
            }
            else
                XtraMessageBox.Show(PublicVar.FailedLogin, Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
