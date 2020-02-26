using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TruckerApp.UserForm;

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
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            var frmSpring = new FrmNewDriver()
            {
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                Dock = DockStyle.Fill
            };
            frmSpring.Show();
        }

        private void btnMemberShipList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            var frmSpring = new FrmMembershipList()
            {
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                Dock = DockStyle.Fill
            };
            frmSpring.Show();
        }

        private void btnCommission_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            var frmSpring = new FrmComosionPrice()
            {
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                Dock = DockStyle.Fill
            };
            frmSpring.Show();
        }

        private void btnNewQue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            var frmSpring = new FrmFishPrint()
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
