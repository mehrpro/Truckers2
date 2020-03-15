using System;
using DevExpress.XtraEditors;

namespace TruckerApp.UserForm
{
    public partial class FrmMembershipList : XtraForm
    {
        public FrmMembershipList()
        {
            InitializeComponent();
        }
        private void FrmMembershipList_Load(object sender, EventArgs e)
        {
            driversBindingSource.DataSource = new BindingList().DriversMembers();
        }
    }
}
