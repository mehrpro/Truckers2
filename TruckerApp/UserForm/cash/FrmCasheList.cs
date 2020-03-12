using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Core.Common;

namespace TruckerApp.UserForm
{
    public partial class FrmCasheList : Form
    {
        public FrmCasheList()
        {
            InitializeComponent();

        }

        private TruckersEntities db = new TruckerApp.TruckersEntities();
        private List<Cash> qryDB;

        private void setup()
        {
            db = new TruckersEntities();
            db.Cashes.Load();
            cashesBindingSource.DataSource = qryDB = db.Cashes.Where((x => x.seriesID_FK == PublicVar.SeriesID)).ToList();
            txtFalaeh.Text = $"{qryDB.Count(x => x.Queue.Type_FK == 1)}";
            txtPacket.Text = $"{qryDB.Count(x => x.Queue.Type_FK == 2)}";
            txtGandom.Text = $"{qryDB.Count(x => x.Queue.Type_FK == 3)}";
            txtClinker.Text = $"{qryDB.Count(x => x.Queue.Type_FK == 4)}";

            txtMember.Text = $"{qryDB.Count(x => x.Queue.GroupCommission == 1)}";
            txtNoMember.Text = $"{qryDB.Count(x => x.Queue.GroupCommission == 2)}";
            txtOther.Text = $"{qryDB.Count(x => x.Queue.GroupCommission == 3)}";

            txtSerial.Text = PublicVar.SeriesName.ToString();
            txtDate.Text = $"{PublicVar.DateSerial:yyyy/MM/dd}";


        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmCasheList_Load(object sender, EventArgs e)
        {
            setup();
        }
    }
}
