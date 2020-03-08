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

namespace TruckerApp.UserForm
{
    public partial class FrmQueueList : Form
    {
        public FrmQueueList()
        {
            InitializeComponent();
            GridList();
            CalcuterList();
        }

        private TruckersEntities Db { get; set; }

        private async void GridList()
        {
            Db = new TruckersEntities();
            queuesBindingSource.DataSource = await Db.Queues.Where(x=> x.Status_FK == 4).ToListAsync();
            
        }

        private async void Loading()
        {

        }
        private  void CalcuterList()
        {
            Db=new TruckersEntities();
            var qryOLD = Db.Queues.Where(x => x.Status_FK == 4).ToList();
            var serial = Db.SeriesPrices.SingleOrDefault(x => x.closing == null && x.enabeled == true && x.SeriesDateEnd == null);
            if (serial != null)
            {
                txtTotal.Text = qryOLD.Count.ToString();
                txtDate.Text = string.Format("{0:yyyy/MM/dd}", serial.SeriesDateStart);
                txtSerial.Text = serial.SeriesName.ToString();
                var qry = Db.Queues.Where(x => x.SeriesID_FK == serial.SeriesName).ToList();
                txtNew.Text = qry.Count.ToString();
                txtFalaeh.Text = qry.Where(x => x.Type_FK == 1).Count().ToString();
                txtPacket.Text = qry.Where(x => x.Type_FK == 2).Count().ToString();
                txtGandom.Text = qry.Where(x => x.Type_FK == 3).Count().ToString();
                txtMember.Text = qry.Where(x => x.GroupCommission == 1).Count().ToString();
                txtNoMember.Text = qry.Where(x => x.GroupCommission == 2).Count().ToString();
                txtOther.Text = qry.Where(x => x.GroupCommission == 3).Count().ToString();
                txtOld.Text = (Convert.ToInt32(txtTotal.Text) - Convert.ToInt32(txtNew.Text)).ToString();
            }

        }
    }
}
