using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TruckerApp.UserForm.Fish
{
    public partial class FrmFishPanel : XtraForm
    {
        public FrmFishPanel()
        {
            InitializeComponent();
        }

        private readonly Counter _counter = new Counter();
        private void FrmFishPanel_Load(object sender, EventArgs e)
        {
            //layoutControl1.Location = new Point(this.Width / 2 - (layoutControl1.Width / 2), layoutControl1.Location.Y);
            timerCounter.Start();
        }


        private void btnSimanFaleh_Click(object sender, EventArgs e)
        {
            var newForm = new FrmFishPrint()
            {
                TypeId = 1,
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,
            };
            newForm.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var newForm = new FrmFishPrint()
            {
                TypeId = 2,
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,
            };
            newForm.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var newForm = new FrmFishPrint()
            {
                TypeId = 4,
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,
            };
            newForm.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var newForm = new FrmFishPrint()
            {
                TypeId = 3,
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,
            };
            newForm.ShowDialog();
        }

        private void timerCounter_Tick(object sender, EventArgs e)
        {
            cntPacket.Text = _counter.packet_cnt(PublicVar.SeriesID).ToString("000");
            cntClinker.Text = _counter.clinker_cnt(PublicVar.SeriesID).ToString("000");
            cntFalah.Text = _counter.faleh_cnt(PublicVar.SeriesID).ToString("000");
            cntGandom.Text = _counter.gandom_cnt(PublicVar.SeriesID).ToString("000");
            cntahakfalae.Text = _counter.ahakfaleh(PublicVar.SeriesID).ToString("000");
            cntahakPakat.Text = _counter.ahakpackat(PublicVar.SeriesID).ToString("000");
            cntothertype.Text = _counter.othertype(PublicVar.SeriesID).ToString("000");

            cntTotal.Text = _counter.total_cnt(PublicVar.SeriesID).ToString("0000");
        }

        private void FrmFishPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerCounter.Stop();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            var newForm = new FrmRevFish3()
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
            };
            newForm.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            var newForm = new FrmRevFish()
            {
                FormBorderStyle = FormBorderStyle.FixedSingle,
                StartPosition = FormStartPosition.CenterScreen,
            };
            newForm.ShowDialog();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {

            var newForm = new FrmResid()
            {
                FormBorderStyle = FormBorderStyle.None,
                // MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                Dock = DockStyle.Fill
            };
            newForm.Show();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {

            var newForm = new FrmQueueList()
            {
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                Dock = DockStyle.Fill
            };
            newForm.Show();
        }

        private void simpleButton6_Click_1(object sender, EventArgs e)
        {

            var newForm = new FrmNewDriver { StartPosition = FormStartPosition.CenterScreen };
            newForm.ShowDialog();
        }

        private void simpleButton7_Click_1(object sender, EventArgs e)
        {
            var newForm = new FrmMembershipList(0)
            {
                FormBorderStyle = FormBorderStyle.FixedSingle,
                WindowState = FormWindowState.Maximized,
                StartPosition = FormStartPosition.CenterScreen,
               // Dock = DockStyle.Fill
            };
            newForm.ShowDialog();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            var newForm = new FrmCasheList()
            {
                FormBorderStyle = FormBorderStyle.FixedSingle,
                WindowState = FormWindowState.Maximized,
                StartPosition = FormStartPosition.CenterScreen,
                //Dock = DockStyle.Fill
            };
            newForm.Show();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            var newForm = new FrmFishPrint()
            {
                TypeId = 5,
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,
            };
            newForm.ShowDialog();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            var newForm = new FrmFishPrint()
            {
                TypeId =6,
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,
            };
            newForm.ShowDialog();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            var newForm = new FrmFishPrint()
            {
                TypeId = 7,
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,
            };
            newForm.ShowDialog();
        }

        private void btnDaftarRozaneh_Click(object sender, EventArgs e)
        {
            var frm = new FrmRevFish().ShowDialog();
        }
    }
}
