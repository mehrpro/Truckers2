using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StructureMap;
using TruckerApp.ExtentionMethod;
using TruckerApp.Repository;
using TruckerApp.UserForm;
using TruckerApp.UserForm.Administrator;
using TruckerApp.UserForm.cash;
using TruckerApp.UserForm.Commission;
using TruckerApp.UserForm.Customer;
using TruckerApp.UserForm.Fish;


namespace TruckerApp
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly Container _mainContainer;
        private readonly ICounter _counter;
        private readonly IAdministrator _administrator;

        public FrmMain(ICounter counter, IAdministrator administrator)
        {
            _counter = counter;
            _administrator = administrator;
            InitializeComponent();
            _mainContainer = new Container(new TypeRegistery());
            _counter.serialBuy();
        }

        private void btnAddDriver_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //var newForm = _mainContainer.GetInstance<FrmNewDriverWithCamera>();
            //newForm.ShowDialog();
            foreach (var c in this.MdiChildren)
            {
                c.Close();
            }
            var frm = _mainContainer.GetInstance<FrmNewDriverWithCamera>();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnMemberShipList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
   
            var newForm = _mainContainer.GetInstance<FrmMembershipList>();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.FormBorderStyle = FormBorderStyle.Sizable;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.GroupId = 30;
            newForm.ShowDialog();
        }

        private void btnCommission_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _mainContainer.GetInstance<FrmCommissionNative>();
            frm.Group1 = 14;
            frm.GroupType4 = 13;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

            
        }

        private void btnNewQue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //var newForm = _mainContainer.GetInstance<FrmFishPrint>();
            //newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            //newForm.StartPosition = FormStartPosition.CenterScreen;
            //newForm.ShowDialog();

            foreach (var c in this.MdiChildren)
            {
                c.Close();
            }
            var frm = _mainContainer.GetInstance<FrmFishPrint>();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }

        private void btnSeries_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = _mainContainer.GetInstance<FrmSerial>();
            newForm.FormBorderStyle = FormBorderStyle.Sizable;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MaximizeBox = newForm.MinimizeBox = true;
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void btnReportDis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmReport();
            frm.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = _mainContainer.GetInstance<FrmRevFish>();
            //newForm.FormBorderStyle = FormBorderStyle.Sizable;
            //newForm.WindowState = FormWindowState.Maximized;
           // newForm.MaximizeBox = newForm.MinimizeBox = true;
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void btnHavaleh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var newForm = _mainContainer.GetInstance<FrmQueueList>();
            newForm.FormBorderStyle = FormBorderStyle.Sizable;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MaximizeBox = newForm.MinimizeBox = true;
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void btnCasheStatus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = _mainContainer.GetInstance<FrmCasheList>();
            newForm.FormBorderStyle = FormBorderStyle.Sizable;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MaximizeBox = newForm.MinimizeBox = true;
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void btnCommissionNative_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _mainContainer.GetInstance<FrmCommissionNative>();
            frm.Group1 = 15;
            frm.GroupType4 = 17;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void btnCommissionOther_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _mainContainer.GetInstance<FrmCommissionNative>();
            frm.Group1 = 16;
            frm.GroupType4 = 18;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (PublicVar.userMode == "user")
            {
                ribSetting.Visible = false;
            }
            //foreach (var c in this.MdiChildren)
            //{
            //    c.Close();
            //}
            //var newForm = new FrmFishPanel()
            //{
            //    FormBorderStyle = FormBorderStyle.None,
            //    MdiParent = this,
            //    StartPosition = FormStartPosition.CenterParent,
            //    Dock = DockStyle.Fill
            //};
            //newForm.Show();

            var frm = _mainContainer.GetInstance<FrmFishPrint>();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var newForm = _mainContainer.GetInstance<FrmFishPrint>();
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var newForm = _mainContainer.GetInstance<FrmFishPrint>();
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var newForm = _mainContainer.GetInstance<FrmFishPrint>();
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = _mainContainer.GetInstance<FrmFishPanel>();
            newForm.FormBorderStyle = FormBorderStyle.Sizable;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MaximizeBox = newForm.MinimizeBox = true;
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = _mainContainer.GetInstance<FrmPrintList>();
            newForm.TypeId = 1;
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = _mainContainer.GetInstance<FrmPrintList>();
            newForm.TypeId = 2;
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = _mainContainer.GetInstance<FrmPrintList>();
            newForm.TypeId = 3;
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = _mainContainer.GetInstance<FrmPrintList>();
            newForm.TypeId = 4;
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = _mainContainer.GetInstance<FrmResid>();
            newForm.FormBorderStyle = FormBorderStyle.Sizable;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MaximizeBox = newForm.MinimizeBox = true;
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }



        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = _mainContainer.GetInstance<FrmMembershipList>();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.FormBorderStyle = FormBorderStyle.Sizable;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.GroupId = 31;
            newForm.ShowDialog();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var newForm = _mainContainer.GetInstance<FrmMembershipList>();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.FormBorderStyle = FormBorderStyle.Sizable;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.GroupId = 32;
            newForm.ShowDialog();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = _mainContainer.GetInstance<FrmRevFish3>();
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = _mainContainer.GetInstance<FrmUsres>();
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void btnMailSetting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var frm = new FrmEmailSetting().ShowDialog();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var c in this.MdiChildren)
            {
                c.Close();
            }
            var frm = _mainContainer.GetInstance<FrmEditDriverWithCamera>();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = _mainContainer.GetInstance<FrmPrintList>();
            newForm.TypeId = 5;
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = _mainContainer.GetInstance<FrmPrintList>();
            newForm.TypeId = 6;
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = _mainContainer.GetInstance<FrmPrintList>();
            newForm.TypeId = 7;
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var newForm = _mainContainer.GetInstance<FrmFishPrint>();
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var newForm = _mainContainer.GetInstance<FrmFishPrint>();
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var newForm = _mainContainer.GetInstance<FrmFishPrint>();
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var frm = new FrmCashPiriodList().ShowDialog();
            var newForm = _mainContainer.GetInstance<FrmCashPiriodList>();
            newForm.FormBorderStyle = FormBorderStyle.Sizable;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MaximizeBox = newForm.MinimizeBox = true;
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var frm = new FrmCasheList3().ShowDialog();
        }

        private void btnConvertPlate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _mainContainer.GetInstance<FrmUser>();
        }

        private async void btnEncryptUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await _administrator.EncryptUserTable();
        }

        private void btnAddressBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = _mainContainer.GetInstance<UserForm.Customer.FrmAddressBook>();
            newForm.FormBorderStyle = FormBorderStyle.Sizable;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MaximizeBox = newForm.MinimizeBox = true;
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
    }
}
