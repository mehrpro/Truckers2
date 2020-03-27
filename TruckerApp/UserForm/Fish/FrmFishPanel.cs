using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TruckerApp.UserForm;

namespace TruckerApp
{
    public partial class FrmFishPanel : XtraForm
    {
        public FrmFishPanel()
        {
            InitializeComponent();
        }
        Counter counter = new Counter();
        private void FrmFishPanel_Load(object sender, EventArgs e)
        {
            layoutControl1.Location = new Point(this.Width / 2 - (layoutControl1.Width / 2), layoutControl1.Location.Y);
            timerCounter.Start();
        }
        

        private void btnSimanFaleh_Click(object sender, EventArgs e)
        {
            var newForm = new FrmFishPrint()
            {
                _typeID = 1,
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,
            };
            newForm.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var newForm = new FrmFishPrint()
            {
                _typeID = 2,
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,
            };
            newForm.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var newForm = new FrmFishPrint()
            {
                _typeID = 4,
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,
            };
            newForm.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var newForm = new FrmFishPrint()
            {
                _typeID = 3,
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,
            };
            newForm.ShowDialog();
        }

        private void timerCounter_Tick(object sender, EventArgs e)
        {
            cntPacket.Text = counter.packet(PublicVar.SeriesID).ToString("0000");
            cntClinker.Text = counter.clinker(PublicVar.SeriesID).ToString("0000");
            cntFalah.Text = counter.faleh(PublicVar.SeriesID).ToString("0000");
            cntGandom.Text = counter.gandom(PublicVar.SeriesID).ToString("0000");
        }

        private void FrmFishPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerCounter.Stop();
        }
    }
}
