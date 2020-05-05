using System;
using System.Linq;
using System.Data.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace TruckerApp.UserForm
{
    public partial class FrmCasheList : XtraForm
    {
        public FrmCasheList()
        {
            InitializeComponent();

        }

        private TruckersEntities db = new TruckersEntities();
        Counter counter =  new Counter();

        private void setup()
        {
            db = new TruckersEntities();
            db.Cashes.Load();
            cashesBindingSource.DataSource =  db.Cashes.Where((x => x.seriesID_FK == PublicVar.SeriesID)).ToList();
            txtFalaeh.Text = counter.faleh(PublicVar.SeriesID).ToString();
            txtPacket.Text = counter.packet(PublicVar.SeriesID).ToString();
            txtGandom.Text = counter.gandom(PublicVar.SeriesID).ToString();
            txtClinker.Text = counter.clinker(PublicVar.SeriesID).ToString();
            txtCash.Text = counter.TotalCash(PublicVar.SeriesID).ToString();
            txtPOS.Text = counter.TotalPOS(PublicVar.SeriesID).ToString();
            txtTotalCash.Text = $"{counter.TotalCash(PublicVar.SeriesID)+ counter.TotalPOS(PublicVar.SeriesID)}";
            txtSerial.Text = PublicVar.SeriesName.ToString();
            txtDate.Text = $"{PublicVar.DateSerial:yyyy/MM/dd}";
        }
        private void FrmCasheList_Load(object sender, EventArgs e)
        {
            setup();
        }

        private void panelControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
        private void printFish()
        {
            var report = XtraReport.FromFile("Cash.repx", true);
            var tool = new ReportPrintTool(report);
            report.Parameters["datetime"].Value = $"{DateTime.Now:yyyy/MM/dd}  {DateTime.Now.ToShortTimeString()}";
            report.Parameters["faleh"].Value = $"{ txtFalaeh.Text}";
            report.Parameters["packat"].Value = $"{txtPacket.Text}";
            report.Parameters["clinker"].Value = $"{ txtClinker.Text}";
            report.Parameters["gandom"].Value = $"{txtGandom.Text}";
            report.Parameters["cash"].Value = $"{txtCash.Text}";
            report.Parameters["pos"].Value = $"{txtPOS.Text}";
            report.Parameters["total"].Value = $"{ txtTotalCash.Text}";
            report.Parameters["serial"].Value = $"س {PublicVar.SeriesName} - {PublicVar.DateSerial:yyyy/MM/dd}";
            tool.PrintDialog();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            printFish();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
