using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace TruckerApp.UserForm
{
    public partial class FrmSerial : Form
    {
        public FrmSerial()
        {
            InitializeComponent();

            Grid();
        }

        private void Grid()
        {
            var dbContext = new TruckersEntities();
            dbContext.Series.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                seriesBindingSource.DataSource = dbContext.Series.Local.ToBindingList();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private TruckersEntities db = new TruckersEntities();
        private int serialNumber, lastID;
        private void SetupPage()
        {
            txtDate.Text = DateTime.Today.ToLongDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
            var userCreator = db.Users.SingleOrDefault(x => x.userID == PublicVar.UserID);
            txtUsers.Text = $"{userCreator.FirstName} {userCreator.LastName}";
            var qry = db.Series.ToList();
            if (qry.Count == 0)
            {
                txtLastSerial.Text = "0";
                serialNumber = 0;
            }
            else
            {
                var qryLast = db.Series.ToList();
                var lastid = qryLast.Count;
                serialNumber = qryLast[lastid - 1].Series1.Value;
                lastID = qryLast[lastid - 1].SereisID;
                txtLastSerial.Text = serialNumber.ToString();

            }
        }

        private void FrmSerial_Load(object sender, EventArgs e)
        {
            SetupPage();
        }

        private void btnNewSerial_Click(object sender, EventArgs e)
        {

            db = new TruckersEntities();
            var qryType = db.Queues.Where(x => x.SeriesID_FK == lastID).ToList();
            try
            {
                var last = db.Series.Single(x => x.SereisID == lastID);
                last.SeriesDateEnd = DateTime.Now;
                last.Faleh = qryType.Where(x => x.Type_FK == 1).ToList().Count;
                last.Packet = qryType.Where(x => x.Type_FK == 2).ToList().Count;
                last.Gandom = qryType.Where(x => x.Type_FK == 3).ToList().Count;
                last.Member =Convert.ToInt16(qryType.Where(x => x.GroupCommission == 1).ToList().Count);
                last.Native = Convert.ToInt16(qryType.Where(x => x.GroupCommission == 2).ToList().Count);
                last.Other = Convert.ToInt16(qryType.Where(x => x.GroupCommission == 3).ToList().Count);
                last.SeriesCount = qryType.Count;
                last.enabeled = false;
                db.SaveChanges();
                var series = new Series();
                series.Series1 = serialNumber + 1;
                series.SeriesDateStart = DateTime.Now;
                series.userCreator = PublicVar.UserID;
                series.enabeled = true;

                db.Series.Add(series);
                db.SaveChanges();
                var Msg = $"سریال فروش {series.Series1} در تاریخ {series.SeriesDateStart} ایجاد شد ";
                XtraMessageBox.Show(Msg, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetupPage();
                Grid();
            }
            catch 
            {
            }

        }
    }
}
