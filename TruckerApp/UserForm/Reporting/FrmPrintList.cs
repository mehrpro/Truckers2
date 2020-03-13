using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;

namespace TruckerApp
{
    public partial class FrmPrintList : Form
    {
        public FrmPrintList()
        {
            InitializeComponent();
        }
        TruckersEntities db = new TruckersEntities();
        private BindingList<ReportList> ds;
        private int _seriesid;
        public int TypeID { get; set; }
        private void FrmPrintList_Load(object sender, EventArgs e)
        {
            cbxList();
        }

        private void cbxList()
        {
            List<SeriesPrice> series;
            series = db.SeriesPrices.Where(x => x.closing == false && x.enabeled == false).ToList();
            cbxSerial.Properties.DataSource = series;
            cbxSerial.Properties.DisplayMember = "SeriesName";
            cbxSerial.Properties.ValueMember = "SereisID";
        }

        private void cbxSerial_EditValueChanged(object sender, EventArgs e)
        {
            _seriesid =Convert.ToInt32(cbxSerial.EditValue);
            grid(_seriesid);
        }
        private void grid(int seriesId)
        {
            ds = new BindingList<ReportList>();
            var QueryAll = db.Queues.Where(x => x.Status_FK == 4 && x.Type_FK == TypeID).ToList().OrderBy(x => x.ID);
            var QuerySeriesOnly = QueryAll.Where(x => x.SeriesID_FK == seriesId).ToList().OrderBy(x => x.ID);

            txtTotal.Text = QueryAll.Count().ToString();
            txtNew.Text = QuerySeriesOnly.Count().ToString();
            txtLast.Text = QueryAll.Count(x => x.SeriesID_FK != seriesId).ToString();
            int counter = 0;
            if (chkLastFish.IsOn)
            {
                foreach (var item in QueryAll)
                {
                    counter++;
                    var itemId = item.ID;
                    var itemNumber = $"({item.SeriesPrice.SeriesName})-{item.Number}";
                    var itemSmart = item.Driver.SmartCart;
                    var itemName = $"{item.Driver.FirstName} {item.Driver.LastName}";
                    var itemTag = $"ایران{item.Driver.Tag}-{item.Driver.TagNumber}";
                    var itemType = $"{item.LoadType.Type}";
                    var itemDate = item.DateTimeRegister;
                    ds.Add(new ReportList(counter, itemSmart, itemId, itemNumber, itemName, itemTag, itemType, itemDate));
                }
            }
            else
            {
                foreach (var item in QuerySeriesOnly)
                {
                    counter++;
                    var itemId = item.ID;
                    var itemNumber = $"({item.SeriesPrice.SeriesName})-{item.Number}";
                    var itemSmart = item.Driver.SmartCart;
                    var itemName = $"{item.Driver.FirstName} {item.Driver.LastName}";
                    var itemTag = $"ایران{item.Driver.Tag}-{item.Driver.TagNumber}";
                    var itemType = $"{item.LoadType.Type}";
                    var itemDate = item.DateTimeRegister;
                    ds.Add(new ReportList(counter, itemSmart, itemId, itemNumber, itemName, itemTag, itemType, itemDate));
                }
            }
            gridControl1.DataSource = ds.OrderBy(x => x.Typeid);
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
            // Show the report.  
            //link.PrintingSystem.PreviewRibbonFormEx.Ribbon.ApplicationIcon = BackLinkCheck.Properties.Resources.RibbonIco;  
            link.ShowRibbonPreviewDialog(UserLookAndFeel.Default);


        }
        //private void ShowGridPreview(GridControl grid)
        //{
        //    // Check whether the GridControl can be previewed. 
        //    if (!grid.IsPrintingAvailable)
        //    {
        //        MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
        //        return;
        //    }

        //    // Open the Preview window. 

        //    grid.ShowPrintPreview();
        //}

        //private void PrintGrid(GridControl grid)
        //{
        //    // Check whether the GridControl can be printed. 
        //    if (!grid.IsPrintingAvailable)
        //    {
        //        MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
        //        return;
        //    }

        //    // Print. 
        //    grid.Print();
        //}

        private void chkLastFish_Toggled(object sender, EventArgs e)
        {
            
            grid(_seriesid);
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
            // Show the report.  
            //link.PrintingSystem.PreviewRibbonFormEx.Ribbon.ApplicationIcon = BackLinkCheck.Properties.Resources.RibbonIco;  
           // link.ShowRibbonPreviewDialog(UserLookAndFeel.Default);
            link.PrintDlg();
        }
    }

    public class ReportList
    {
        public int Counter { get; }
        public int Smart { get; }
        public int Id { get; }
        public string Number { get; }
        public string Name { get; }
        public string Tag { get; }
        public string Typeid { get; }
        public DateTime DateTime { get; }

        public ReportList(int counter, int smart, int id, string number, string name, string tag, string typeid, DateTime dateTime)
        {
            Counter = counter;
            Smart = smart;
            Id = id;
            Number = number;
            Name = name;
            Tag = tag;
            Typeid = typeid;
            DateTime = dateTime;
        }
    }
}
