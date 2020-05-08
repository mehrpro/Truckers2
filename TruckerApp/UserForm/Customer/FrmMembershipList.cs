using System;
using DevExpress.XtraEditors;
using System.Linq;
using System.Windows.Forms;

namespace TruckerApp.UserForm
{
    public partial class FrmMembershipList : XtraForm
    {
        TruckersEntities db = new TruckersEntities();
        public FrmMembershipList(int groupid)
        {
            InitializeComponent();
            driversBindingSource.DataSource =groupid==0 ? db.Drivers.ToList(): db.Drivers.Where(x=> x.GroupID==groupid).ToList();
        }
    }
}
