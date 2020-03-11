using System;
using System.Drawing;
using System.Windows.Forms;

namespace TruckerApp.UserForm.Fish
{
    public partial class FrmFishPanel : Form
    {
        public FrmFishPanel()
        {
            InitializeComponent();
        }

        private void FrmFishPanel_Load(object sender, EventArgs e)
        {
            layoutControl1.Location = new Point(this.Width / 2 - (layoutControl1.Width / 2), layoutControl1.Location.Y);
        }

        private void btnSimanFaleh_Click(object sender, EventArgs e)
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

        private void simpleButton1_Click(object sender, EventArgs e)
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

        private void simpleButton2_Click(object sender, EventArgs e)
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

        private void simpleButton3_Click(object sender, EventArgs e)
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
    }
}
