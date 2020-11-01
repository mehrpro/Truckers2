using System;
using System.Linq;
using System.Data.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using TruckerApp.ExtentionMethod;
using TruckerApp.Repository;

namespace TruckerApp.UserForm.cash
{
    public partial class FrmCasheList : XtraForm
    {
        private readonly ICustomReport _report;
        private readonly ICounter _counter;
        public FrmCasheList(ICustomReport report, ICounter counter)
        {
            _report = report;
            _counter = counter;
            InitializeComponent();
        }

    
     

        private async void setup()
        {
            cashesBindingSource.DataSource = await _report.GetCashListBySeriesId(PublicVar.SeriesID);
            txtFalaeh.EditValue = await _counter.faleh(PublicVar.SeriesID);
            txtPacket.EditValue = await _counter.packet(PublicVar.SeriesID);
            txtGandom.EditValue = await _counter.gandom(PublicVar.SeriesID);
            txtClinker.EditValue = await _counter.clinker(PublicVar.SeriesID);
            txtCash.EditValue = await _counter.TotalCash(PublicVar.SeriesID);
            txtPOS.EditValue = await _counter.TotalPOS(PublicVar.SeriesID);
            txtAhakFaleh.EditValue = await _counter.AhakFaleh(PublicVar.SeriesID);
            txtAhakPackat.EditValue = await _counter.AhakPackat(PublicVar.SeriesID);
            txtOtherType.EditValue = await _counter.OtherType(PublicVar.SeriesID);
            txtTotalCash.EditValue =  $@"{await _counter.TotalCash(PublicVar.SeriesID) + await _counter.TotalPOS(PublicVar.SeriesID)}";
            txtSerial.Text = PublicVar.SeriesName.ToString();
            txtDate.Text = $@"{PublicVar.DateSerial:yyyy/MM/dd}";
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
