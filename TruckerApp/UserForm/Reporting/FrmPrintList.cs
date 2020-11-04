using System;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using TruckerApp.Repository;

namespace TruckerApp
{
    public partial class FrmPrintList : XtraForm
    {
        private readonly ICustomReport _customReport;
        public byte TypeId { get; set; }
        public FrmPrintList(ICustomReport customReport)
        {
            InitializeComponent();
            _customReport = customReport;

        }

        private async void Grid()
        {

            //txtLast.EditValue = await _customReport.CountOfStatus20_Old(TypeId);

            if (chkLastFish.IsOn)
            {
                gridControl1.DataSource = await _customReport.GetAllReportListByType(TypeId);
                txtTotal.EditValue = await _customReport.CountOfStatus20_All(TypeId);
                txtNew.EditValue = await _customReport.CountOfStatus20_LastSeries(TypeId);
                txtLast.EditValue = await _customReport.CountOfStatus20_Old(TypeId);
            }
            else
            {
                gridControl1.DataSource = await _customReport.GetLastSeriesReportListByType(TypeId);
                txtTotal.EditValue = await _customReport.CountOfStatus20_All(TypeId);
                txtNew.EditValue = await _customReport.CountOfStatus20_LastSeries(TypeId);
                txtLast.EditValue = await _customReport.CountOfStatus20_Old(TypeId);
            }


            gridView1.RefreshData();

        }

        private void btnAllPrint_Click(object sender, EventArgs e)
        {
            var ps = new PrintingSystem();
            var link = new PrintableComponentLink(ps);
            link.Component = gridControl1;
            link.Margins.Right = 10;
            link.Margins.Left = 10;
            link.Margins.Top = 10;
            link.Margins.Bottom = 10;
            link.PaperKind = PaperKind.A4;
            link.Landscape = false;
            link.CreateDocument();
            link.ShowRibbonPreviewDialog(UserLookAndFeel.Default);
        }
        private void chkLastFish_Toggled(object sender, EventArgs e)
        {
            Grid();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            var ps = new PrintingSystem();
            var link = new PrintableComponentLink(ps);
            link.Component = gridControl1;
            link.Margins.Right = 10;
            link.Margins.Left = 10;
            link.Margins.Top = 10;
            link.Margins.Bottom = 10;
            link.PaperKind = PaperKind.A4;
            link.Landscape = false;
            link.CreateDocument();
            link.PrintDlg();
        }

        private void FrmPrintList_Load(object sender, EventArgs e)
        {
            Grid();

        }
    }
}
