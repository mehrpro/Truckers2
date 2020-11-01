using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StructureMap;
using TruckerApp.ExtentionMethod;
using TruckerApp.Repository;
using TruckerApp.UserForm.cash;
using TruckerApp.UserForm.Customer;

namespace TruckerApp.UserForm.Fish
{
    public partial class FrmFishPanel : XtraForm
    {
        private Container mainContainer;
        private readonly ICounter _counter;
        public FrmFishPanel(ICounter counter)
        {
            _counter = counter;
            InitializeComponent();
            mainContainer = new StructureMap.Container(new TypeRegistery());
        }

        
        private void FrmFishPanel_Load(object sender, EventArgs e)
        {
            //layoutControl1.Location = new Point(this.Width / 2 - (layoutControl1.Width / 2), layoutControl1.Location.Y);
            timerCounter.Start();
        }


        private void btnSimanFaleh_Click(object sender, EventArgs e)
        {

            var newForm = mainContainer.GetInstance<FrmFishPrint>();
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var newForm = mainContainer.GetInstance<FrmFishPrint>();
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var newForm = mainContainer.GetInstance<FrmFishPrint>();
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var newForm = mainContainer.GetInstance<FrmFishPrint>();
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private async void timerCounter_Tick(object sender, EventArgs e)
        {
            cntPacket.Text = (await _counter.packet_cnt(PublicVar.SeriesID)).ToString("000");
            cntClinker.Text = (await _counter.clinker_cnt(PublicVar.SeriesID)).ToString("000");
            cntFalah.Text = (await _counter.faleh_cnt(PublicVar.SeriesID)).ToString("000");
            cntGandom.Text = (await _counter.gandom_cnt(PublicVar.SeriesID)).ToString("000");
            cntahakfalae.Text = (await _counter.ahakfaleh(PublicVar.SeriesID)).ToString("000");
            cntahakPakat.Text = (await _counter.ahakpackat(PublicVar.SeriesID)).ToString("000");
            cntothertype.Text = (await _counter.othertype(PublicVar.SeriesID)).ToString("000");

            cntTotal.Text = (await _counter.total_cnt(PublicVar.SeriesID)).ToString("0000");
        }

        private void FrmFishPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerCounter.Stop();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            var newForm = mainContainer.GetInstance<FrmRevFish3>();
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            var newForm = mainContainer.GetInstance<FrmRevFish>();
            newForm.FormBorderStyle = FormBorderStyle.Sizable;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MaximizeBox = newForm.MinimizeBox = true;
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {

            var newForm = mainContainer.GetInstance<FrmResid>();
            newForm.FormBorderStyle = FormBorderStyle.Sizable;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MaximizeBox = newForm.MinimizeBox = true;
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {

            var newForm = mainContainer.GetInstance<FrmQueueList>();
            newForm.FormBorderStyle = FormBorderStyle.Sizable;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MaximizeBox = newForm.MinimizeBox = true;
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void simpleButton6_Click_1(object sender, EventArgs e)
        {

            var newForm = mainContainer.GetInstance<FrmNewDriverWithCamera>();
            newForm.ShowDialog();
        }

        private void simpleButton7_Click_1(object sender, EventArgs e)
        {

            var newForm = mainContainer.GetInstance<FrmMembershipList>();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.FormBorderStyle = FormBorderStyle.Sizable;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.GroupId = 0;
            newForm.ShowDialog();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            var newForm = mainContainer.GetInstance<FrmCasheList>();
            newForm.FormBorderStyle = FormBorderStyle.Sizable;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MaximizeBox = newForm.MinimizeBox = true;
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            var newForm = mainContainer.GetInstance<FrmFishPrint>();
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            var newForm = mainContainer.GetInstance<FrmFishPrint>();
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            var newForm = mainContainer.GetInstance<FrmFishPrint>();
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private void btnDaftarRozaneh_Click(object sender, EventArgs e)
        {
            
        }
    }
}
