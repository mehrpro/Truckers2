using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using DevExpress.Office.Utils;

namespace TruckerApp.UserForm
{
    public partial class FrmSerial : Form
    {
        public FrmSerial()
        {
            InitializeComponent();
            grid();


        }



        private void grid()
        {
            seriesBindingSource.DataSource = _serList = db.SeriesPrices.ToList();

        }

        private TruckersEntities db = new TruckersEntities();
        private int serialNumber, lastID;
        private List<SeriesPrice> _serList;
        private void SetupPage()
        {
            txtDate.Text = DateTime.Today.ToLongDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
            var userCreator = db.Users.SingleOrDefault(x => x.userID == PublicVar.UserID);
            txtUsers.Text = $"{userCreator.FirstName} {userCreator.LastName}";
            lastID = _serList.Last().SereisID;
            //int qryMax = _serList.Max(x => x.SeriesName);
            //lastID = _serList[lastid - 1].SereisID;
            txtLastSerial.Text = _serList.Last().SeriesName.ToString();


        }

        private void FrmSerial_Load(object sender, EventArgs e)
        {
            SetupPage();
        }


        private void btnNewSerial_Click(object sender, EventArgs e)
        {

            //db = new TruckersEntities();
            var qryType = db.Queues.Where(x => x.SeriesID_FK == serialNumber).ToList();
            try
            {
                var last = _serList.Single(x => x.SereisID == lastID);
                last.SeriesDateEnd = DateTime.Now;
                last.Faleh = qryType.Count(x => x.Type_FK == 1);
                last.Packet = qryType.Count(x => x.Type_FK == 2);
                last.Gandom = qryType.Count(x => x.Type_FK == 3);
                last.Member = Convert.ToInt16(qryType.Count(x => x.GroupCommission == 1));
                last.Native = Convert.ToInt16(qryType.Count(x => x.GroupCommission == 2));
                last.Other = Convert.ToInt16(qryType.Count(x => x.GroupCommission == 3));
                last.SeriesCount = qryType.Count;
                last.enabeled = last.closing = false;
                db.SaveChanges();
                var series = new SeriesPrice();
                series.SeriesName = _serList.Max(x => x.SeriesName) + 1;
                series.SeriesDateStart = DateTime.Now;
                series.userCreator = PublicVar.UserID;
                series.enabeled = true;
                db.SeriesPrices.Add(series);
                db.SaveChanges();
                var Msg = $"سریال فروش {series.SeriesName} در تاریخ {series.SeriesDateStart} ایجاد شد ";
                XtraMessageBox.Show(Msg, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                grid();
                SetupPage();
            }
            catch
            {
                XtraMessageBox.Show(PublicVar.ErrorMessageForNotSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
