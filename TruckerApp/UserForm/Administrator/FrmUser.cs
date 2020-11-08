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
        private bool CameraMode;

        public FrmUser(IAdministrator administrator)
        {
            _administrator = administrator;
            InitializeComponent();
        }

        private void CameraModeChange()
        {
            CameraMode = Properties.Settings.Default.em;
            txtCameraMode.EditValue = CameraMode ? @"وضعیت صدور حواله با کارت هوشمند فعال است" : @"وضعیت صدور حواله با پلاک خوان هوشمند فعال است";

        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            CameraModeChange();
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
            //await _administrator.EncryptUserTable();

            var result = await _administrator.EncryptUserTable();
            if (result)
            {
                XtraMessageBox.Show(" انجام شد");
            }
            else
            {
                XtraMessageBox.Show(" انجام نشد");
            }

        }

        private async void btnCounterCreator_Click(object sender, EventArgs e)
        {
            var result = await _administrator.CreateScheduleList();
            if (result)
            {
                XtraMessageBox.Show(" انجام شد");
            }
            else
            {
                XtraMessageBox.Show(" انجام نشد");
            }
        }

        private void btnCameraMode_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.em = !CameraMode;
            Properties.Settings.Default.Save();
            CameraModeChange();
        }
    }
}
