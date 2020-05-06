using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using System.Data.Entity;
using System.Windows.Forms;

namespace TruckerApp.UserForm
{
    public partial class FrmQueueList : Form
    {
        public FrmQueueList()
        {
            InitializeComponent();
        }

        private TruckersEntities db;

        //private void calcuterList()
        //{
        //    List<Queue> qryOLD;
        //    queuesBindingSource.DataSource = qryOLD = db.Queues.Where(x => x.SeriesID_FK == PublicVar.SeriesID).ToList();
        //    txtDate.Text = $"{PublicVar.DateSerial:yyyy/MM/dd}";
        //    cbxSerial.Text = PublicVar.SeriesName.ToString();
        //    var qry = qryOLD.Where(x => x.SeriesID_FK == PublicVar.SeriesID).ToList();

        //    txtFalaeh.Text = qry.Count(x => x.Type_FK == 1).ToString();
        //    txtPacket.Text = qry.Count(x => x.Type_FK == 2).ToString();
        //    txtGandom.Text = qry.Count(x => x.Type_FK == 3).ToString();
        //    txtClinker.Text = qry.Count(x => x.Type_FK == 4).ToString();

        //    txtMember.Text = qry.Count(x => x.GroupCommission == 1).ToString();
        //    txtNoMember.Text = qry.Count(x => x.GroupCommission == 2).ToString();
        //    txtOther.Text = qry.Count(x => x.GroupCommission == 3).ToString();
        //}

        private void SerialList()
        {
            List<SeriesPrice> list = new List<SeriesPrice>();
            foreach (var price in db.SeriesPrices.OrderByDescending(x => x.SereisID)) list.Add(price);
            searchLookUpEdit1.Properties.DataSource= cbxSerial.Properties.DataSource = list;
            searchLookUpEdit1.Properties.DisplayMember= cbxSerial.Properties.DisplayMember = "SeriesName";
            searchLookUpEdit1.Properties.ValueMember= cbxSerial.Properties.ValueMember = "SereisID";
        }
        private void txtSerial_EditValueChanged(object sender, EventArgs e)
        {
      
            var select = (SeriesPrice) cbxSerial.GetSelectedDataRow();
            if (select!= null)
            {
                txtDate.Text = select.SeriesDateStart.ToLongDateString();
                txtFalaeh.Text = db.Queues.Count(x => x.SeriesID_FK == select.SereisID && x.Type_FK== 1).ToString();
                txtPacket.Text = db.Queues.Count(x => x.SeriesID_FK == select.SereisID && x.Type_FK == 2).ToString();
                txtGandom.Text = db.Queues.Count(x => x.SeriesID_FK == select.SereisID && x.Type_FK == 3).ToString();
                txtClinker.Text = db.Queues.Count(x => x.SeriesID_FK == select.SereisID && x.Type_FK == 4).ToString();

                txtMember.Text = db.Queues.Count(x => x.SeriesID_FK == select.SereisID && x.GroupCommission == 31).ToString();
                txtNoMember.Text = db.Queues.Count(x => x.SeriesID_FK == select.SereisID && x.GroupCommission == 32).ToString();
                txtOther.Text = db.Queues.Count(x => x.SeriesID_FK == select.SereisID && x.GroupCommission == 33).ToString();
                gridControl1.DataSource = db.Queues.Where(x => x.SeriesID_FK == select.SereisID).ToList();
                //gridView1.RefreshData();

            }
        }

        private void FrmQueueList_Load(object sender, EventArgs e)
        {
            db = new TruckersEntities();
            SerialList();
        }
    }
}
