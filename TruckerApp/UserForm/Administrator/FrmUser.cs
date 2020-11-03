using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraEditors;
using TruckerApp.ExtentionMethod;
using TruckerApp.Repository;

namespace TruckerApp
{
    public partial class FrmUser : Form
    {
        private readonly IAdministrator _administrator;
        public FrmUser(IAdministrator administrator)
        {
            _administrator = administrator;
            InitializeComponent();
        }


        private TruckersEntities dbContext;
        private void FrmUser_Load(object sender, EventArgs e)
        {



        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private async void btnConvertTag_Click(object sender, EventArgs e)
        {
            var result = await _administrator.ConvertPlate();
            if (result)
            {
                XtraMessageBox.Show("انتقال انجام شد");
            }
            else
            {
                XtraMessageBox.Show("انتقال انجام نشد");
            }
        }

        private async void btnEncryptUsers_Click(object sender, EventArgs e)
        {
            await _administrator.EncryptUserTable();

        }

        private void btnCreateAddressBook_Click(object sender, EventArgs e)
        {

        }
    }
}
