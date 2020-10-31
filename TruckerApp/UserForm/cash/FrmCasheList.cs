using System;
using System.Linq;
using System.Data.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using TruckerApp.ExtentionMethod;

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
            int id = PublicVar.SeriesID;
            db = new TruckersEntities();
            db.Cashes.Load();
            cashesBindingSource.DataSource =  db.Cashes.Where(x => x.seriesID_FK == id).ToList();
            txtFalaeh.Text = counter.faleh(id).ToString();
            txtPacket.Text = counter.packet(id).ToString();
            txtGandom.Text = counter.gandom(id).ToString();
            txtClinker.Text = counter.clinker(id).ToString();
            txtCash.Text = counter.TotalCash(id).ToString();
            txtPOS.Text = counter.TotalPOS(id).ToString();
            txtAhakFaleh.Text = counter.AhakFaleh(id).ToString();
            txtAhakPackat.Text = counter.AhakPackat(id).ToString();
            txtOtherType.Text = counter.OtherType(id).ToString();
            txtTotalCash.Text = $"{counter.TotalCash(id)+ counter.TotalPOS(id)}";
            txtSerial.Text = PublicVar.SeriesName.ToString();
            txtDate.Text = $"{PublicVar.DateSerial:yyyy/MM/dd}";
        }
        private void FrmCasheList_Load(object sender, EventArgs e)
        {
            setup();
        }

 
        private void PrintFish()
        {
            var report = XtraReport.FromFile("Cash_Report.repx", true);
            var tool = new ReportPrintTool(report);
            report.Parameters["datetime"].Value = $"{DateTime.Now.PersianConvertorFull()}";
            report.Parameters["operator"].Value = $"{PublicVar.OpreatorName}";
            report.Parameters["faleh"].Value = $"{ txtFalaeh.Text}";
            report.Parameters["packat"].Value = $"{txtPacket.Text}";
            report.Parameters["clinker"].Value = $"{ txtClinker.Text}";
            report.Parameters["gandom"].Value = $"{txtGandom.Text}";
            report.Parameters["cash"].Value = $"{txtCash.Text}";
            report.Parameters["pos"].Value = $"{txtPOS.Text}";
            report.Parameters["total"].Value = $"{ txtTotalCash.Text}";
            report.Parameters["ahakfaleh"].Value = $"{ txtAhakFaleh.Text}";
            report.Parameters["ahakpackat"].Value = $"{ txtAhakPackat.Text}";
            report.Parameters["other"].Value = $"{ txtOtherType.Text}";
            report.Parameters["serial"].Value = $"{PublicVar.SeriesName}";

            tool.PrintDialog();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            PrintFish();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
