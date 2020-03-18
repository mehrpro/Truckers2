using System;
using DevExpress.XtraEditors;

namespace TruckerApp.UserForm
{
    public partial class FrmMembershipList : XtraForm
    {
        public bool Member { get; set; }

        public FrmMembershipList(bool member)
        {
            Member = member;
            InitializeComponent();
        }
        private void FrmMembershipList_Load(object sender, EventArgs e)
        {
            driversBindingSource.DataSource = Member ? new BindingList().DriversMembers() : new BindingList().DriversList();
        }
    }
}
