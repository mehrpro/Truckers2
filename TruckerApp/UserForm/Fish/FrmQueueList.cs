using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace TruckerApp.UserForm
{
    public partial class FrmQueueList : Form
    {
        public FrmQueueList()
        {
            InitializeComponent();
 
            calcuterList();
        }

        private TruckersEntities Db = new TruckersEntities();

        private void calcuterList()
        {
            List<Queue> qryOLD;
            queuesBindingSource.DataSource = qryOLD = Db.Queues.Where(x => x.Status_FK == 20).ToList();
            txtTotal.Text = qryOLD.Count.ToString();
            txtDate.Text = $"{PublicVar.DateSerial:yyyy/MM/dd}";
            txtSerial.Text = PublicVar.SeriesID.ToString();
            var qry = qryOLD.Where(x => x.SeriesID_FK == PublicVar.SeriesID).ToList();
            txtNew.Text = qry.Count.ToString();
            txtFalaeh.Text = qry.Count(x => x.Type_FK == 1).ToString();
            txtPacket.Text = qry.Count(x => x.Type_FK == 2).ToString();
            txtGandom.Text = qry.Count(x => x.Type_FK == 3).ToString();
            txtClinker.Text = qry.Count(x => x.Type_FK == 4).ToString();

            txtMember.Text = qry.Count(x => x.GroupCommission == 1).ToString();
            txtNoMember.Text = qry.Count(x => x.GroupCommission == 2).ToString();
            txtOther.Text = qry.Count(x => x.GroupCommission == 3).ToString();

            txtOld.Text = (Convert.ToInt32(txtTotal.Text) - Convert.ToInt32(txtNew.Text)).ToString();


        }
    }
}
