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
            //var PacketCount = qryDB.Where(x => x.seriesID_FK == PublicVar.SeriesID && x.Queue.Type_FK == 2).Sum(x => x.Queue.Commission.CommissionPrice);
            txtFalaeh.Text = $"{qryDB.Where(x =>  x.Queue.Type_FK == 1).Sum(x =>  x.Queue.Commission.CommissionPrice)}";
            txtPacket.Text = $"{qryDB.Where(x =>  x.Queue.Type_FK == 2).Sum(x => x.Queue.Commission.CommissionPrice)}";
            txtGandom.Text = $"{qryDB.Where(x =>  x.Queue.Type_FK == 3).Sum(x => x.Queue.Commission.CommissionPrice)}";
            txtMember.Text = $"{qryDB.Where(x =>  x.Queue.GroupCommission == 1).Sum(x => x.Queue.Commission.CommissionPrice)}";
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
