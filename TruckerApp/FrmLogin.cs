﻿using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TruckerApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private byte _UserID { get; set; }
        private bool _Accsept { get; set; }
        private string _OpName { get; set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PublicVar.Accsept = false;
            string _User, _Pass;
            _User = txtUsername.Text.Trim();
            _Pass = txtPassword.Text.Trim();
            using (var db = new TruckersEntities())
            {
                var qry = db.Users.SingleOrDefault(x => x.username.Trim() == _User);
                if (qry != null)
                {
                    if (qry.password.Trim() == _Pass)
                    {
                        PublicVar.Accsept = true;
                        PublicVar.UserID = qry.userID;
                        PublicVar.OpName = $"{qry.FirstName} {qry.FirstName}";
                        Close();

                    }
                    else
                    {
                        XtraMessageBox.Show("'رمز عبور اشتباه است مجدد تلاش کنید", "اتوماسیون پایانه");

                    }

                }
                else
                {
                    XtraMessageBox.Show("'نام کاربری اشتباه است مجدد تلاش کنید", "اتوماسیون پایانه");

                }
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
