using System;
using System.Linq;
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
        }

        private void btnAddDriver_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var frmSpring = new FrmNewDriver()
            {
                FormBorderStyle = FormBorderStyle.None,
              //  MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen,
               // Dock = DockStyle.Fill
            };
            frmSpring.ShowDialog();
        }

        private void btnMemberShipList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            var frmSpring = new TruckerApp.UserForm.FrmMembershipList();
            frmSpring.FormBorderStyle = FormBorderStyle.None;
            frmSpring.MdiParent = this;
            frmSpring.StartPosition = FormStartPosition.CenterParent;
            frmSpring.Dock = DockStyle.Fill;
            frmSpring.Show();
        }

        private void btnCommission_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            var frmSpring = new UserForm.Commission.FrmCommissionNative()
            {
                Group1 = 14,
                Group2 = 13,
//FormBorderStyle = FormBorderStyle.None,
               MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen,
               // Dock = DockStyle.Fill
            };
            frmSpring.Show();
        }

        private void btnNewQue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var frmSpring = new FrmFishPrint()
            {
                _typeID = 1,
                FormBorderStyle = FormBorderStyle.None,
              //  MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen,
                //Dock = DockStyle.Fill
            };
            frmSpring.ShowDialog();
        }

        private void btnSeries_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            var frmSpring = new FrmSerial();
            frmSpring.FormBorderStyle = FormBorderStyle.None;
            frmSpring.MdiParent = this;
            frmSpring.StartPosition = FormStartPosition.CenterParent;
            frmSpring.Dock = DockStyle.Fill;
            frmSpring.Show();
        }

        private void btnReportDis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            




        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //foreach (Form c in this.MdiChildren)
            //{
            //    c.Close();
            //}
            var frmSpring = new FrmRevFish()
            {
                FormBorderStyle = FormBorderStyle.None,
                //MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen,
                //Dock = DockStyle.Fill
            };
            frmSpring.ShowDialog();
        }

        private void btnHavaleh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            var frmSpring = new FrmQueueList()
            {
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                Dock = DockStyle.Fill
            };
            frmSpring.Show();
        }

        private void btnCasheStatus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            var frmSpring = new FrmCasheList()
            {
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                Dock = DockStyle.Fill
            };
            frmSpring.Show();
        }

        private void btnCommissionNative_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            var frmSpring = new UserForm.Commission.FrmCommissionNative()
            {
                Group1 = 15,
                Group2 = 17,
                //FormBorderStyle = FormBorderStyle.None,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen,
                // Dock = DockStyle.Fill
            };
            frmSpring.Show();
        }

        private void btnCommissionOther_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            var frmSpring = new UserForm.Commission.FrmCommissionNative()
            {
                Group1 = 16,
                Group2 = 18,
                //FormBorderStyle = FormBorderStyle.None,
                 MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen,
                // Dock = DockStyle.Fill
            };
            frmSpring.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            var frmSpring = new FrmFishPanel()
            {
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                Dock = DockStyle.Fill
            };
            frmSpring.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmSpring = new FrmFishPrint()
            {
                _typeID = 2,
                FormBorderStyle = FormBorderStyle.None,
                //  MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen,
                //Dock = DockStyle.Fill
            };
            frmSpring.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmSpring = new FrmFishPrint()
            {
                _typeID = 4,
                FormBorderStyle = FormBorderStyle.None,
                //  MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen,
                //Dock = DockStyle.Fill
            };
            frmSpring.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmSpring = new FrmFishPrint()
            {
                _typeID = 3,
                FormBorderStyle = FormBorderStyle.None,
                //  MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen,
                //Dock = DockStyle.Fill
            };
            frmSpring.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            var frmSpring = new FrmFishPanel()
            {
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                Dock = DockStyle.Fill
            };
            frmSpring.Show();
        }
    }
}
