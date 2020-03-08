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
using System.Threading;

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
            dbContext.SeriesPrices.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                seriesBindingSource.DataSource = dbContext.SeriesPrices.Local.ToBindingList();
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
            var qry = db.SeriesPrices.ToList();
            if (qry.Count == 0)
            {
                txtLastSerial.Text = "0";
                serialNumber = 0;
            }
            else
            {
                var qryLast = db.SeriesPrices.ToList();
                var lastid = qryLast.Count;
                serialNumber = qryLast[lastid - 1].SeriesName.Value;
                lastID = qryLast[lastid - 1].SereisID;
                txtLastSerial.Text = serialNumber.ToString();

            }
        }

        private void FrmSerial_Load(object sender, EventArgs e)
        {
            SetupPage();
        }

        private  void simpleButton1_Click(object sender, EventArgs e)
        {
            Random gebratoRandom = new Random();
            Random commsionRandom = new Random();
            int num = 7;
            
            for (int i = 0; i < 3200; i++)
            {

                var dbc = new TruckersEntities();
                var qu = new Queue
                {
                    DriverID_FK = 1,
                    ComosiunID_FK = Convert.ToInt16(commsionRandom.Next(1, 18)),
                    Type_FK = Convert.ToByte(gebratoRandom.Next(1, 4)),
                    DateTimeRegister = DateTime.Now.AddDays(Convert.ToInt16(commsionRandom.Next(1, 30))),
                    SeriesID_FK = commsionRandom.Next(1, 15),
                    Number = Convert.ToInt16(num++),
                    
                    GroupCommission = Convert.ToByte(gebratoRandom.Next(1, 4)),
                    Status_FK = Convert.ToByte(gebratoRandom.Next(1, 12))
                };
                if (num > 500) num = 2;
                dbc.Queues.Add(qu);
                dbc.SaveChangesAsync();

                //Thread.Sleep(25);

            }
           // await dbc.SaveChangesAsync();
            MessageBox.Show("ok");
        }




    

    private void btnNewSerial_Click(object sender, EventArgs e)
    {

        db = new TruckersEntities();
        var qryType = db.Queues.Where(x => x.SeriesID_FK == serialNumber).ToList();
        try
        {
            var last = db.SeriesPrices.Single(x => x.SereisID == lastID);
            last.SeriesDateEnd = DateTime.Now;
            last.Faleh = qryType.Where(x => x.Type_FK == 1).ToList().Count;
            last.Packet = qryType.Where(x => x.Type_FK == 2).ToList().Count;
            last.Gandom = qryType.Where(x => x.Type_FK == 3).ToList().Count;
            last.Member = Convert.ToInt16(qryType.Where(x => x.GroupCommission == 1).ToList().Count);
            last.Native = Convert.ToInt16(qryType.Where(x => x.GroupCommission == 2).ToList().Count);
            last.Other = Convert.ToInt16(qryType.Where(x => x.GroupCommission == 3).ToList().Count);
            last.SeriesCount = qryType.Count;
            last.enabeled = last.closing = false;
            db.SaveChanges();
            var series = new SeriesPrice();
            series.SeriesName = serialNumber + 1;
            series.SeriesDateStart = DateTime.Now;
            series.userCreator = PublicVar.UserID;
            series.enabeled = true;


            db.SeriesPrices.Add(series);
            db.SaveChanges();
            var Msg = $"سریال فروش {series.SeriesName} در تاریخ {series.SeriesDateStart} ایجاد شد ";
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
