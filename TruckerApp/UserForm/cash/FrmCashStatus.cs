using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace TruckerApp.UserForm
{
    public partial class FrmCashStatus : Form
    {
        public FrmCashStatus()
        {
            InitializeComponent();
            
        }

        private double other_NoNative, other_Member, other_Native;
        TruckersEntities db = new TruckersEntities();

        private void FrmCashStatus_Load(object sender, EventArgs e)
        {
            QueryGhalat();
        }

        Series chartOther = new Series("Other", ViewType.Bubble);
        private void QueryGhalat()
        {
            //other_Member = db.Queues.Count(x => x.GroupCommission == 1 && x.SeriesID_FK == PublicVar.SeriesID);
            //other_NoNative = db.Queues.Count(x => x.GroupCommission == 3 && x.SeriesID_FK == PublicVar.SeriesID);
            //other_Native = db.Queues.Count(x => x.GroupCommission == 2 && x.SeriesID_FK == PublicVar.SeriesID);
            ////series2.Points.Add(new SeriesPoint("A", 15));
            
            //chartOther.Points.Add(new SeriesPoint("اعضاء", new object[] { other_Member, (35000D)}));
            //chartOther.Points.Add(new SeriesPoint("بومی", new object[] { (300D), (55000D) }));
            //chartOther.Points.Add(new SeriesPoint("سایر", new object[] { (600D), (135000D) }));

            //chartPacket.Series.Add(chartOther);
            //chartPacket.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;


        }
    }
}
