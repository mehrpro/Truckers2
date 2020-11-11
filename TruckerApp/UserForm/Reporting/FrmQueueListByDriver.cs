using System;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using TruckerApp.Repository;
using TruckerApp.ViewModels.Customers;

namespace TruckerApp
{
    public partial class FrmQueueListByDriver : XtraForm
    {
        private readonly ICustomReport _customReport;
        private ICustomers _customers;
        public byte TypeId { get; set; }
        public FrmQueueListByDriver(ICustomReport customReport, ICustomers customers)
        {
            InitializeComponent();
            _customReport = customReport;
            _customers = customers;
        }

        private async void Grid()
        {
            cbxSmart.Properties.DataSource = await _customers.GetAllDriverForComboBox();
            cbxSmart.Properties.DisplayMember = "FullName";
            cbxSmart.Properties.ValueMember = "ID";
        }

        private void btnAllPrint_Click(object sender, EventArgs e)
        {
            var ps = new PrintingSystem();
            var link = new PrintableComponentLink(ps);
            link.Component = dgvList;
            link.Margins.Right = 10;
            link.Margins.Left = 10;
            link.Margins.Top = 10;
            link.Margins.Bottom = 10;
            link.PaperKind = PaperKind.A4;
            link.Landscape = false;
            link.CreateDocument();
            link.ShowRibbonPreviewDialog(UserLookAndFeel.Default);
        }


        private void simpleButton9_Click(object sender, EventArgs e)
        {
            var ps = new PrintingSystem();
            var link = new PrintableComponentLink(ps);
            link.Component = dgvList;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void cbxSmart_EditValueChanged(object sender, EventArgs e)
        {
            var select = (ViewModelCustomerForComboBox) cbxSmart.GetSelectedDataRow();
            if (select == null)
            {
                txtTotal.EditValue = null;
                dgvList.DataSource = null;
                return;
            }
            var list = await _customReport.GetQueueReportByDriverId(select.DriverID);
            dgvList.DataSource = list;
            txtTotal.EditValue = list.Count;
        }
    }
}
