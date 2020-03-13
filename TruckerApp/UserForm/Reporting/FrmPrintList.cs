using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace TruckerApp
{
    public partial class FrmPrintList : Form
    {
        public FrmPrintList()
        {
            InitializeComponent();
        }
        TruckersEntities db = new TruckersEntities();
        private void FrmPrintList_Load(object sender, EventArgs e)
        {
            cbxList();
        }

        private void cbxList()
        {
            List<SeriesPrice> series;
            series = db.SeriesPrices.Where(x => x.closing == false && x.enabeled == false).ToList();
            cbxSerial.Properties.DataSource = series;
            cbxSerial.Properties.DisplayMember = "SeriesName";
            cbxSerial.Properties.ValueMember = "SereisID";
        }

        private void cbxSerial_EditValueChanged(object sender, EventArgs e)
        {
            var selection = (SeriesPrice) cbxSerial.GetSelectedDataRow();
            txtTotal.Text = selection.SeriesCount.ToString();
            txtClinker.Text = selection.Clinker.ToString();
            txtDate.Text = $@"{selection.SeriesDateStart:yyyy/MM/dd}";
            txtFaleh.Text = selection.Faleh.ToString();
            txtGandom.Text = selection.Gandom.ToString();
            txtPacket.Text = selection.Packet.ToString();
            grid(selection.SereisID);
        }

        private async void grid(int  ser)
        {
            gridControl1.DataSource = await db.Queues.Where(x => x.Status_FK == 4).ToListAsync();
        }
    }
}
