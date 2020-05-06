using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TruckerApp.UserForm
{
    public partial class FrmSerial : XtraForm
    {
        public FrmSerial()
        {
            InitializeComponent();
            grid();


        }
        Counter counter = new Counter();


        private void grid()
        {
            seriesBindingSource.DataSource = _serList = db.SeriesPrices.ToList();
        }

        private TruckersEntities db = new TruckersEntities();
        private int serialNumber;
        private List<SeriesPrice> _serList;
        private void SetupPage()
        {
            txtDate.Text = DateTime.Today.ToLongDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
            var userCreator = db.Users.SingleOrDefault(x => x.userID == PublicVar.UserID);
            txtUsers.Text = $"{userCreator.FirstName} {userCreator.LastName}";
            txtLastSerial.Text = PublicVar.SeriesName.ToString();
        }

        private void FrmSerial_Load(object sender, EventArgs e)
        {
            SetupPage();
        }


        private void btnNewSerial_Click(object sender, EventArgs e)
        {
            //using (var ts = db.Database.BeginTransaction())
            //{
               // var lastSeries = counter.lastNumber(PublicVar.SeriesID);
                try
                {
                    var last = db.SeriesPrices.Single(x => x.enabeled == true && x.closing == false);
                    last.SeriesDateEnd = DateTime.Now;
                    last.Faleh = counter.faleh(last.SereisID);
                    last.Packet = counter.packet(last.SereisID);
                    last.Gandom = counter.gandom(last.SereisID);
                    last.Clinker = counter.clinker(last.SereisID);
                    last.Member = counter.member(last.SereisID);
                    last.Native = counter.noMember(last.SereisID);
                    last.Other = counter.other(last.SereisID);
                    last.SeriesCount = counter.SeriesCount(last.SereisID);
                    last.enabeled = false;
                    last.closing = true;
                    var series = new SeriesPrice();
                    series.SeriesName = counter.LastSeriesNum() + 1;
                    series.SeriesDateStart = DateTime.Now;
                    series.userCreator = PublicVar.UserID;
                    series.enabeled = true;
                    series.closing = false;
                    db.SeriesPrices.Add(series);
                    db.SaveChanges();
                    var Msg = $"سریال فروش {series.SeriesName} در تاریخ {series.SeriesDateStart} ایجاد شد ";
                    XtraMessageBox.Show(Msg, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    counter.serialBuy();
                    grid();
                    SetupPage();
                }
                catch
                {
                    XtraMessageBox.Show(PublicVar.ErrorMessageForNotSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

          //  }


        }
    }
}
