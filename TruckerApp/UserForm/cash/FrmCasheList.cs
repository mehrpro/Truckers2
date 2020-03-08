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
        private void setup()
        {
            db = new TruckersEntities();
            db.Cashes.LoadAsync().ContinueWith(loadTask =>
            {
                cashesBindingSource.DataSource =
                    db.Cashes.Where((x => x.seriesID_FK == PublicVar.SeriesID)).ToListAsync();
            }, TaskScheduler.FromCurrentSynchronizationContext());

            db = new TruckersEntities();
            var pacet = db.Cashes.Where(x => x.seriesID_FK == PublicVar.SeriesID && x.Queue.Type_FK == 2)
                .Sum(x => x.Queue.Commission.CommissionPrice);
            txtFalaeh.Text = $"{db.Cashes.Where(x => x.seriesID_FK == PublicVar.SeriesID && x.Queue.Type_FK == 1).Sum(x => x.Queue.Commission.CommissionPrice)}";
            txtPacket.Text = $"{db.Cashes.Where(x => x.seriesID_FK == PublicVar.SeriesID && x.Queue.Type_FK == 2).Sum(x => x.Queue.Commission.CommissionPrice)}";
            txtGandom.Text = $"{db.Cashes.Where(x => x.seriesID_FK == PublicVar.SeriesID && x.Queue.Type_FK == 3).Sum(x => x.Queue.Commission.CommissionPrice)}";
            txtMember.Text = $"{db.Cashes.Where(x => x.seriesID_FK == PublicVar.SeriesID && x.Queue.GroupCommission == 1).Sum(x => x.Queue.Commission.CommissionPrice)}";
        }
    }
}
