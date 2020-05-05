using System;
using System.Windows.Forms;
using TruckerApp.UserForm;
using TruckerApp.UserForm.Fish;


namespace TruckerApp
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
            new Counter().serialBuy();
        }

        private void btnAddDriver_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var newForm = new FrmNewDriver { StartPosition = FormStartPosition.CenterScreen };
            newForm.ShowDialog();
        }

        private void btnMemberShipList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var c in this.MdiChildren)
            {
                c.Close();
            }

            var newForm = new FrmMembershipList(true,false)
            {
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                Dock = DockStyle.Fill
            };
            newForm.Show();
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

            var newForm = new FrmFishPrint
            {
                TypeId = 1,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen
            };
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
        {}

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
            foreach (var c in MdiChildren) c.Close();
            var newForm = new FrmCasheList()
            {
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                Dock = DockStyle.Fill
            };
            newForm.Show();
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
            var newForm = new FrmFishPrint()
            {
                TypeId = 2,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
            };
            newForm.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = new FrmFishPrint()
            {
                TypeId = 4,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
            };
            newForm.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = new FrmFishPrint()
            {
                TypeId = 3,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
            };
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
            var newForm = new FrmPrintList()
            {
                TypeId = 1,
                FormBorderStyle = FormBorderStyle.FixedDialog,
               WindowState = FormWindowState.Maximized,
                StartPosition = FormStartPosition.CenterParent,
            };
            newForm.ShowDialog();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = new FrmPrintList()
            {
                TypeId = 2,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                WindowState = FormWindowState.Maximized,
                StartPosition = FormStartPosition.CenterParent,
            };
            newForm.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = new FrmPrintList()
            {
                TypeId = 3,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                WindowState = FormWindowState.Maximized,
                StartPosition = FormStartPosition.CenterParent,
            };
            newForm.ShowDialog();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newForm = new FrmPrintList()
            {
                TypeId = 4,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                WindowState = FormWindowState.Maximized,
                StartPosition = FormStartPosition.CenterParent,
            };
            newForm.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var c in this.MdiChildren)
            {
                c.Close();
            }
            var newForm = new FrmResid()
            {
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                Dock = DockStyle.Fill
            };
            newForm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var c in this.MdiChildren)
            {
                c.Close();
            }

            var newForm = new FrmMembershipList(false,false)
            {
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                Dock = DockStyle.Fill
            };
            newForm.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var c in this.MdiChildren)
            {
                c.Close();
            }

            var newForm = new FrmMembershipList(false, true)
            {
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                Dock = DockStyle.Fill
            };
            newForm.Show();
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
    }
}
