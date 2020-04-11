using System;
using DevExpress.XtraEditors;
using System.Linq;
using System.Windows.Forms;

namespace TruckerApp.UserForm
{
    public partial class FrmMembershipList : XtraForm
    {
        public bool Member { get; set; }
        public bool EditMember { get; }
        TruckersEntities db = new TruckersEntities();

        public FrmMembershipList(bool member, bool editMember)
        {
            Member = member;
            EditMember = editMember;
            InitializeComponent();
        }

        private void FrmMembershipList_Load(object sender, EventArgs e)
        {
            btnsave.Enabled = EditMember;
            list();
            // driversBindingSource.DataSource = Member ? new BindingList().DriversMembers() : new BindingList().DriversList();
        }

        private void list()
        {
            driversBindingSource.DataSource = Member ? db.Drivers.Where(x => x.GroupID == 30).ToList() : db.Drivers.ToList();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                db.SaveChanges();
                XtraMessageBox.Show("ذخیره شد", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                XtraMessageBox.Show("تغییرات اعمال نشد مجدد سعی کنید", Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }


    }
}
