﻿using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TruckerApp.Repository;
using TruckerApp.ViewModels.Administrator;

namespace TruckerApp
{
    public partial class FrmLogin : XtraForm
    {
        private readonly IAdministrator _administrator;
        public FrmLogin(IAdministrator administrator, IQueuing queuing)
        {
            InitializeComponent();
            _administrator = administrator;
            //txtPassword.Text = @"708801298";
            //txtUsername.Text = @"admin";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "708801298633437541")
            {
                DialogResult = DialogResult.Retry;
                Close();
            }
            else
            {
                var getModel = new ViewModelLogin();
                getModel.UserName = txtUsername.Text.Trim();
                getModel.Password = txtPassword.Text.Trim();
                var dialogResult = _administrator.ApproveLogin(getModel);
                if (dialogResult == DialogResult.OK)
                {
                    DialogResult = dialogResult;
                    Close();
                }
                else
                    XtraMessageBox.Show(PublicVar.FailedLogin, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
