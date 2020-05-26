using System;
using System.Linq;
using System.Data.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace TruckerApp.UserForm
{
    public partial class FrmCasheList3 : XtraForm
    {
        public FrmCasheList3()
        {
            InitializeComponent();
        }
        private TruckersEntities db = new TruckersEntities();


        private void setup()
        {
            int id = PublicVar.SeriesID;
            var qryList = db.Queues.Where(x => x.SeriesID_FK == id && x.userid == PublicVar.UserID).AsNoTracking();
            var qryCash = db.Cashes.Where(x => x.seriesID_FK == id && x.userID == PublicVar.UserID).AsNoTracking();
            txtFalaeh.Text = qryList.Count(x => x.Type_FK == 1).ToString();
            txtPacket.Text = qryList.Count(x => x.Type_FK == 2).ToString();
            txtGandom.Text = qryList.Count(x => x.Type_FK == 3).ToString();
            txtClinker.Text = qryList.Count(x => x.Type_FK == 4).ToString();
            txtAhakFaleh.Text = qryList.Count(x => x.Type_FK == 5).ToString();
            txtAhakPackat.Text = qryList.Count(x => x.Type_FK == 6).ToString();
            txtOtherType.Text = qryList.Count(x => x.Type_FK == 7).ToString();
            txtCash.Text = qryCash.Sum(x => x.CashDesk).ToString();
            txtPOS.Text = qryCash.Sum(x => x.Pos).ToString();
           // txtTotalCash.Text = (Convert.ToInt32(txtCash.Text) + Convert.ToInt32(txtPOS.Text)).ToString();
            txtDate.Text = $"{PublicVar.DateSerial:yyyy/MM/dd}";
        }
        private void FrmCasheList_Load(object sender, EventArgs e) => setup();

        private void panelControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }


        private void simpleButton1_Click(object sender, EventArgs e) => Close();
    }
}
