﻿using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace TruckerApp.UserForm
{
    public partial class FrmQueueList : XtraForm
    {
        public FrmQueueList()
        {
            InitializeComponent();
            SerialList();

        }

        private TruckersEntities db = new TruckersEntities();

        private void calcuterList()
        {
            List<Queue> qryOLD;
            queuesBindingSource.DataSource = qryOLD = db.Queues.Where(x => x.SeriesID_FK == PublicVar.SeriesID).ToList();
            txtDate.Text = $"{PublicVar.DateSerial:yyyy/MM/dd}";
            txtSerial.Text = PublicVar.SeriesName.ToString();
            var qry = qryOLD.Where(x => x.SeriesID_FK == PublicVar.SeriesID).ToList();

            txtFalaeh.Text = qry.Count(x => x.Type_FK == 1).ToString();
            txtPacket.Text = qry.Count(x => x.Type_FK == 2).ToString();
            txtGandom.Text = qry.Count(x => x.Type_FK == 3).ToString();
            txtClinker.Text = qry.Count(x => x.Type_FK == 4).ToString();

            txtMember.Text = qry.Count(x => x.GroupCommission == 1).ToString();
            txtNoMember.Text = qry.Count(x => x.GroupCommission == 2).ToString();
            txtOther.Text = qry.Count(x => x.GroupCommission == 3).ToString();
        }

        private void SerialList()
        {
            seriesPricesBindingSource.DataSource = db.SeriesPrices.ToList().OrderByDescending(x=> x.SereisID);
        }
        private void txtSerial_EditValueChanged(object sender, EventArgs e)
        {
            var select = (SeriesPrice) txtSerial.GetSelectedDataRow();
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
                queuesBindingSource.DataSource = db.Queues.Where(x => x.SeriesID_FK == select.SereisID).ToList();
                gridView1.RefreshData();

            }
        }
    }
}
