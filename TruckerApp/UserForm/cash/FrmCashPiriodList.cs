using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraPrinting;

namespace TruckerApp.UserForm.cash
{
    public partial class FrmCashPiriodList : Form
    {
        public FrmCashPiriodList()
        {
            InitializeComponent();
            dateStart.DateTime = dateFenish.DateTime = DateTime.Today;
        }
        private TruckersEntities db = new TruckersEntities();
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TotalCash(int[] id)
        {
            long totaCash = 0, totalPos = 0;
            var cashLists = new List<TotalCashList>();
            var list = new List<Queue>();
            foreach (var item in id)
            {
                var qry23 = db.Queues.Where(x => x.SeriesID_FK == item && x.Status_FK == 23).AsNoTracking().ToList();
                var qry20 = db.Queues.Where(x => x.SeriesID_FK == item && x.Status_FK == 20).AsNoTracking().ToList();
                list.AddRange(qry23);
                list.AddRange(qry20);
            }
            txtFaleh.EditValue = list.Count(x => x.Type_FK == 1);
            txtPackat.EditValue = list.Count(x => x.Type_FK == 2);
            txtGandom.EditValue = list.Count(x => x.Type_FK == 3);
            txtClinker.EditValue = list.Count(x => x.Type_FK == 4);
            txtAhakFaleh.EditValue = list.Count(x => x.Type_FK == 5);
            txtAhakPackat.EditValue = list.Count(x => x.Type_FK == 6);
            txtOtherType.EditValue = list.Count(x => x.Type_FK == 7);


            foreach (var item in id)
            {
                var tCash = Convert.ToInt64(db.Cashes.Where(x => x.seriesID_FK == item).AsNoTracking().Sum(x => x.CashDesk));
                var tPos = Convert.ToInt64(db.Cashes.Where(x => x.seriesID_FK == item).AsNoTracking().Sum(x => x.Pos));
                var seriesPrice = db.SeriesPrices.Find(item);
                cashLists.Add(new TotalCashList()
                {
                    SeriesName = seriesPrice.SeriesName,
                    TotalCash = tCash,
                    TotalPos = tPos,
                    DateTime = seriesPrice.SeriesDateStart.ToString("yyyy/MM/dd"),
                    faleh = list.Count(x=> x.SeriesID_FK == item  && x.Type_FK ==1),
                    packat = list.Count(x => x.SeriesID_FK == item && x.Type_FK == 2),
                    gandom = list.Count(x => x.SeriesID_FK == item && x.Type_FK == 3),
                    clinker = list.Count(x => x.SeriesID_FK == item && x.Type_FK == 4),
                    AhakFaleh = list.Count(x => x.SeriesID_FK == item && x.Type_FK == 5),
                    AhakPackat = list.Count(x => x.SeriesID_FK == item && x.Type_FK == 6),
                    Othertype = list.Count(x => x.SeriesID_FK == item && x.Type_FK == 7),

                });
                totaCash += tCash;
                totalPos += tPos;
            }
            gridControl1.DataSource = cashLists.ToList();
            txtTotalCash.EditValue = totaCash;
            txtTotalPos.EditValue = totalPos;
        }
        
        private void btnReporter_Click(object sender, EventArgs e)
        {
            var start = dateStart.DateTime.Date;
            var end = dateFenish.DateTime.Date.AddDays(1);
            var qry = db.SeriesPrices.Where(x => x.SeriesDateStart >= start).ToList();
            var qry2 = qry.Where(x => x.SeriesDateStart <= end).ToList();
            txtTotalSerial.EditValue = qry2.Count.ToString();
            var idInts = new int[qry2.Count];
            for (var i = 0; i < qry2.Count; i++) idInts[i] = qry2[i].SereisID;
            TotalCash(id: idInts);
          
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {
      
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
