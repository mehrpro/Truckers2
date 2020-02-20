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
            string _User, _Pass;
            _User = txtUsername.Text.Trim();
            _Pass = txtPassword.Text.Trim();
            using (var db = new TruckersEntities())
            {
                var qry = db.Users.SingleOrDefault(x => x.username == _User);
                if (qry != null)
                {
                    if (qry.password == _Pass)
                    {
                        _Accsept = true;
                        _UserID = qry.userID;
                        _OpName = $"{qry.FirstName} {qry.FirstName}";
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
    }
}
