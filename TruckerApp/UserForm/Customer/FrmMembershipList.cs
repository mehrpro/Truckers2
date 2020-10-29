using DevExpress.XtraEditors;
using TruckerApp.Repository;

namespace TruckerApp.UserForm.Customer
{
    public partial class FrmMembershipList : XtraForm
    {
        private readonly ICustomers _customers;
        public byte GroupId { get; set; }
        public FrmMembershipList(ICustomers customers)
        {
            _customers = customers;
            InitializeComponent();
        }

        private async void FrmMembershipList_Load(object sender, System.EventArgs e)
        {
            if (GroupId == 0)
            {
                driversBindingSource.DataSource = await _customers.GetAllDriver();
            }
            else
                driversBindingSource.DataSource = await _customers.GetAllDriverByGroupID(GroupId);
        }
    }
}
