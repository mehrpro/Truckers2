using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StructureMap;
using TruckerApp.ExtentionMethod;
using TruckerApp.UserForm;
using TruckerApp.UserForm.cash;
using TruckerApp.UserForm.Customer;
using TruckerApp.UserForm.Fish;


namespace TruckerApp
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly Container _mainContainer;

        public FrmMain()
        {
            InitializeComponent();
            _mainContainer = new Container(new TypeRegistery());
            new Counter().serialBuy();
        }

        private void btnAddDriver_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var newForm = _mainContainer.GetInstance<FrmNewDriverWithCamera>();
            newForm.ShowDialog();
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
            var newForm = new UserForm.Commission.FrmCommissionNative
            {
                Group1 = 14,
                Group2 = 13,
                StartPosition = FormStartPosition.CenterScreen
            };
            newForm.ShowDialog();
        }

        private void btnNewQue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var newForm = _mainContainer.GetInstance<FrmFishPrint>();
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private void btnSeries_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form c in this.MdiChildren) c.Close();
            var newForm = new FrmSerial
            {
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                Dock = DockStyle.Fill
            };
            newForm.Show();
        }

        private void btnReportDis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmReport();
            frm.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var newForm = new FrmRevFish()
            {
                FormBorderStyle = FormBorderStyle.FixedSingle,
                StartPosition = FormStartPosition.CenterScreen,
            };
            newForm.ShowDialog();
        }

        private void btnHavaleh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var c in MdiChildren) c.Close();
            var newForm = new FrmQueueList()
            {
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                Dock = DockStyle.Fill
            };
            newForm.Show();
        }

        private void btnCasheStatus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //foreach (var c in MdiChildren) c.Close();
            var newForm = new FrmCasheList().ShowDialog();
            //{
            //    FormBorderStyle = FormBorderStyle.None,
            //    MdiParent = this,
            //    StartPosition = FormStartPosition.CenterParent,
            //    Dock = DockStyle.Fill
            //};
            //newForm.Show();
        }

        private void btnCommissionNative_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = new UserForm.Commission.FrmCommissionNative()
            {
                Group1 = 15,
                Group2 = 17,
                StartPosition = FormStartPosition.CenterScreen,
            };
            newForm.ShowDialog();
        }

        private void btnCommissionOther_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = new UserForm.Commission.FrmCommissionNative()
            {
                Group1 = 16,
                Group2 = 18,
                StartPosition = FormStartPosition.CenterScreen,
            };
            newForm.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (PublicVar.userMode == "user")
            {
                ribSetting.Visible = false;
            }
            foreach (var c in this.MdiChildren)
            {
                c.Close();
            }
            var newForm = new FrmFishPanel()
            {
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                Dock = DockStyle.Fill
            };
            newForm.Show();
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
            foreach (var c in this.MdiChildren)
            {
                c.Close();
            }
            var newForm = new FrmFishPanel()
            {
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                Dock = DockStyle.Fill
            };
            newForm.Show();
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
            //foreach (var c in this.MdiChildren)
            //{
            //    c.Close();
            //}
            var newForm = new FrmResid().ShowDialog();
            //{
            //    FormBorderStyle = FormBorderStyle.None,
            //    MdiParent = this,
            //    StartPosition = FormStartPosition.CenterParent,
            //    Dock = DockStyle.Fill
            //};
            //newForm.Show();
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
            var newForm = new FrmRevFish3()
            {
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,
            };
            newForm.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmUser().ShowDialog();
        }

        private void btnMailSetting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var frm = new FrmEmailSetting().ShowDialog();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _mainContainer.GetInstance<FrmEditDriverWithCamera>();
            frm.ShowDialog();
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
            var frm = new FrmCashPiriodList().ShowDialog();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmCasheList3().ShowDialog();
        }

        private void btnConvertPlate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = PlateEditor.SaveChanage(new TruckersEntities());
            if (result)
            {
                XtraMessageBox.Show("انتقال انجام شد");
            }
            else
            {
                XtraMessageBox.Show("انتقال انجام نشد");
            }
        }
    }
}
