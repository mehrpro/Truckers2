using System;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraEditors;

namespace TruckerApp.UserForm.Fish
{
    public partial class FrmResid : XtraForm
    {
        public FrmResid()
        {
            InitializeComponent();
      
        }

        private TruckersEntities db = new TruckersEntities();
        private BindingList<NumberList> dsAccept;
        private BindingList<NumberList> dsList;

        private void ListResied(int typr)
        {
            dsAccept = new BindingList<NumberList>();
            dsList = new BindingList<NumberList>();
            var qry = db.Queues.Where(x => x.Status_FK == 20 && x.Type_FK==typr).ToList();
            if (qry.Count > 0)
            {
                foreach (var itemQueue in qry)
                {
                    var id = itemQueue.ID;
                    var name = $"{itemQueue.Driver.FirstName} {itemQueue.Driver.LastName}";
                    var tag = $"{itemQueue.Driver.TagNumber}";
                    var date = itemQueue.DateTimeRegister;
                    dsList.Add(new NumberList(id,itemQueue.SeriesPrice.SeriesName, itemQueue.Number, name, tag, date));
                }
   
            }
            gridControlTop.DataSource = dsList.ToList();
            gridControlBotten.DataSource = dsAccept.ToList();
        }

        private void btnDeleteRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("Serial") != null)
            {
                var sel = gridView1.GetFocusedRow();
                var id = (NumberList) sel;
                dsList.Remove(id);
                dsAccept.Add(id);
                gridControlTop.DataSource = dsList.ToList();
                gridControlBotten.DataSource = dsAccept.ToList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ListResied(3);
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridView2.GetFocusedRowCellValue("Serial") == null)
            {

            }
            else
            {
                var sel = gridView2.GetFocusedRow();
                var id = (NumberList)sel;
                dsAccept.Remove(id);
                dsList.Add(id);
                gridControlTop.DataSource = dsList.ToList();
                gridControlBotten.DataSource = dsAccept.ToList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (var item in dsAccept)
            {
                db.Queues.Find(item.ID).Status_FK = 23;
            }

            db.SaveChanges();
          //  ListResied();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ListResied(2);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ListResied(4);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ListResied(1);
        }
    }

    public class NumberList
    {
        public int Serial { get; }
        public short Number { get; }
        public string Tag { get; }
        public DateTime Date { get; }
        public int ID { get; }
        public string Name { get; }
        
        public NumberList(int id, int serial,short number,string name,string tag,DateTime date)
        {
            ID = id;
            Serial = serial;
            Number = number;
            Tag = tag;
            Date = date;
            Name = name;
        }
    }
}
