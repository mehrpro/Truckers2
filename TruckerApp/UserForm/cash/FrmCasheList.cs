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
            txtFalaeh.Text = counter.faleh().ToString();
            txtPacket.Text = counter.packet().ToString();
            txtGandom.Text = counter.gandom().ToString();
            txtClinker.Text = counter.clinker().ToString();
            txtMember.Text = counter.member().ToString();
            txtNoMember.Text = counter.noMember().ToString();
            txtOther.Text = counter.other().ToString();

            txtSerial.Text = PublicVar.SeriesName.ToString();
            txtDate.Text = $"{PublicVar.DateSerial:yyyy/MM/dd}";


        }


        private void FrmCasheList_Load(object sender, EventArgs e)
        {
            setup();
        }
    }
}
