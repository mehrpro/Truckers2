using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DataProcessing;
using DevExpress.LookAndFeel;
using DevExpress.XtraPrinting;
using TruckerApp.Repository;
using TruckerApp.ViewModels;

namespace TruckerApp.UserForm.cash
{
    public partial class FrmCashPiriodList : Form
    {
        private readonly ICustomReport _report;
        public FrmCashPiriodList(ICustomReport report)
        {
            _report = report;
            InitializeComponent();
            dateStart.DateTime = dateFenish.DateTime = DateTime.Today;
        }

        //private void TotalCash(int[] id)
        //{
        //    long totaCash = 0, totalPos = 0;
        //    var cashLists = new List<ViewModelTotalCashList>();
        //    var list = new List<Queue>();
        //    foreach (var item in id)
        //    {
        //        var qry23 = db.Queues.Where(x => x.SeriesID_FK == item && x.Status_FK == 23).AsNoTracking().ToList();
        //        var qry20 = db.Queues.Where(x => x.SeriesID_FK == item && x.Status_FK == 20).AsNoTracking().ToList();
        //        list.AddRange(qry23);
        //        list.AddRange(qry20);
        //    }
        //    txtFaleh.EditValue = list.Count(x => x.Type_FK == 1);
        //    txtPackat.EditValue = list.Count(x => x.Type_FK == 2);
        //    txtGandom.EditValue = list.Count(x => x.Type_FK == 3);
        //    txtClinker.EditValue = list.Count(x => x.Type_FK == 4);
        //    txtAhakFaleh.EditValue = list.Count(x => x.Type_FK == 5);
        //    txtAhakPackat.EditValue = list.Count(x => x.Type_FK == 6);
        //    txtOtherType.EditValue = list.Count(x => x.Type_FK == 7);


        //    foreach (var item in id)
        //    {
        //        var tCash = Convert.ToInt64(db.Cashes.Where(x => x.seriesID_FK == item).AsNoTracking().Sum(x => x.CashDesk));
        //        var tPos = Convert.ToInt64(db.Cashes.Where(x => x.seriesID_FK == item).AsNoTracking().Sum(x => x.Pos));
        //        var seriesPrice = db.SeriesPrices.Find(item);
        //        cashLists.Add(new ViewModelTotalCashList()
        //        {
        //            SeriesName = seriesPrice.SeriesName,
        //            TotalCash = tCash,
        //            TotalPos = tPos,
        //            DateTime = seriesPrice.SeriesDateStart.ToString("yyyy/MM/dd"),
        //            faleh = list.Count(x=> x.SeriesID_FK == item  && x.Type_FK ==1),
        //            packat = list.Count(x => x.SeriesID_FK == item && x.Type_FK == 2),
        //            gandom = list.Count(x => x.SeriesID_FK == item && x.Type_FK == 3),
        //            clinker = list.Count(x => x.SeriesID_FK == item && x.Type_FK == 4),
        //            AhakFaleh = list.Count(x => x.SeriesID_FK == item && x.Type_FK == 5),
        //            AhakPackat = list.Count(x => x.SeriesID_FK == item && x.Type_FK == 6),
        //            Othertype = list.Count(x => x.SeriesID_FK == item && x.Type_FK == 7),

        //        });
        //        totaCash += tCash;
        //        totalPos += tPos;
        //    }
        //    gridControl1.DataSource = cashLists.ToList();
        //    txtTotalCash.EditValue = totaCash;
        //    txtTotalPos.EditValue = totalPos;
        //}
        
        private async void btnReporter_Click(object sender, EventArgs e)
        {
            var start = dateStart.DateTime.Date;
            var end = dateFenish.DateTime.Date;
            var sumList = new List<ViewModelTotalCashList>();
            gridControl1.DataSource= sumList = await _report.GetTotalReportByBetweenDate(start, end);
            if (sumList.Count > 0)
            {
                txtFaleh.EditValue = sumList.Sum(x => x.faleh);
                txtPackat.EditValue = sumList.Sum(x => x.packat);
                txtGandom.EditValue = sumList.Sum(x => x.gandom);
                txtClinker.EditValue = sumList.Sum(x => x.clinker);
                txtAhakFaleh.EditValue = sumList.Sum(x => x.AhakFaleh);
                txtAhakPackat.EditValue = sumList.Sum(x => x.AhakPackat);
                txtOtherType.EditValue = sumList.Sum(x => x.Othertype);
                txtTotalCash.EditValue = sumList.Sum(x => x.TotalCash); 
                txtTotalPos.EditValue = sumList.Sum(x => x.TotalPos); 
            }

        }


        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            var ee = e.Button.Properties.Tag;
            if (ee != null && (string) ee == @"printList")
            {
                var ps = new PrintingSystem();
                var link = new PrintableComponentLink(ps);
                link.Component = gridControl1;
                link.Margins.Right = 10;
                link.Margins.Left = 10;
                link.Margins.Top = 10;
                link.Margins.Bottom = 10;
                link.PaperKind = PaperKind.A4;
                link.Landscape = true;
                link.CreateDocument();
                link.ShowRibbonPreviewDialog(UserLookAndFeel.Default);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
