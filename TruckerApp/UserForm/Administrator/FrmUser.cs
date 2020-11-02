using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraEditors;
using TruckerApp.ExtentionMethod;

namespace TruckerApp
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            usersBindingSource.AddNew();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                dbContext.SaveChanges();
                XtraMessageBox.Show("اطلاعات با موفقیت ذخیره شد",Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch 
            {
                XtraMessageBox.Show("خطا در ثبت اطلاعات مجدد تلاش کنید",Text,MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private TruckersEntities dbContext;
        private void FrmUser_Load(object sender, EventArgs e)
        {

            dbContext = new TruckersEntities();
            dbContext.Users.Load();
            usersBindingSource.DataSource = dbContext.Users.Local;

            var qry = dbContext.Users.ToList();
            foreach (var user in qry)
            {
                var ser = user.password.EncryptTextUsingUtf8();
            }

        }
    }
}
