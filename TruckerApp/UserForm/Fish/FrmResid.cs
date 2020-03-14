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
using DevExpress.XtraReports.Design;

namespace TruckerApp.UserForm.Fish
{
    public partial class FrmResid : Form
    {
        public FrmResid()
        {
            InitializeComponent();
            cbxSerialList();

        }

        private TruckersEntities db;
        private BindingList<NumberList> ds;
        private BindingList<NumberList> dsList;
        private void cbxSerialList()
        {
            db = new TruckersEntities();
            var qry = db.SeriesPrices.Where(x => x.closing == null ).ToList();
            cbxSerial.Properties.DataSource = qry;
            cbxSerial.Properties.DisplayMember = "SeriesName";
            cbxSerial.Properties.ValueMember = "SereisID";
        }

        private void cbxSerial_EditValueChanged(object sender, EventArgs e)
        {
            ds = new BindingList<NumberList>();
            dsList= new BindingList<NumberList>();
            var qry = db.Queues.Where(x => x.Status_FK == 20).ToList();
            foreach (Queue itemQueue in qry)
            {
                var id = itemQueue.ID;
                var fullname =
                    $"{itemQueue.Number} {itemQueue.Driver.FirstName} {itemQueue.Driver.LastName} {itemQueue.Driver.TagNumber}";
                var name = $"{itemQueue.Driver.FirstName} {itemQueue.Driver.LastName}";
                var tag = $"{itemQueue.Driver.TagNumber}";
                var date = itemQueue.DateTimeRegister;
                ds.Add(new NumberList(id,fullname));
                dsList.Add(new NumberList(itemQueue.SeriesPrice.SeriesName,itemQueue.Number,name,tag,date));
                
            }

            gridControl1.DataSource = dsList.ToList();
            cbxListNumber.Properties.DataSource = ds.ToList();
            cbxListNumber.Properties.DisplayMember = "Name";
            cbxListNumber.Properties.ValueMember = "Id";
        }
    }

    public class NumberList
    {
        public int Serial { get; }
        public short Number { get; }
        public string Tag { get; }
        public DateTime Date { get; }
        public int Id { get; }
        public string Name { get; }


        public NumberList(int id,string name )
        {
            Id = id;
            Name = name;
        }

        /// <inheritdoc />
        public NumberList(int serial,short number,string name,string tag,DateTime date)
        {
            Serial = serial;
            Number = number;
            Tag = tag;
            Date = date;
            Name = name;
        }
    }
}
