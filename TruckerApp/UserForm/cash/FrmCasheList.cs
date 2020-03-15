using System;
using System.Linq;
using System.Data.Entity;
using DevExpress.XtraEditors;

namespace TruckerApp.UserForm
{
    public partial class FrmCasheList : XtraForm
    {
        public FrmCasheList()
        {
            InitializeComponent();

        }

        private TruckersEntities db = new TruckersEntities();
        Counter counter =  new Counter();

        private void setup()
        {
            db = new TruckersEntities();
            db.Cashes.Load();
            cashesBindingSource.DataSource =  db.Cashes.Where((x => x.seriesID_FK == PublicVar.SeriesID)).ToList();
            txtFalaeh.Text = counter.Faleh().ToString();
            txtPacket.Text = counter.Packet().ToString();
            txtGandom.Text = counter.Gandom().ToString();
            txtClinker.Text = counter.Clinker().ToString();
            txtMember.Text = counter.Member().ToString();
            txtNoMember.Text = counter.noMember().ToString();
            txtOther.Text = counter.Other().ToString();

            txtSerial.Text = PublicVar.SeriesName.ToString();
            txtDate.Text = $"{PublicVar.DateSerial:yyyy/MM/dd}";


        }


        private void FrmCasheList_Load(object sender, EventArgs e)
        {
            setup();
        }
    }
}
