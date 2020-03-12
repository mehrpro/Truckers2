using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using System.Drawing.Text;

namespace TruckerApp.UserForm
{
    public partial class FrmMembershipList :XtraForm
    {
        public FrmMembershipList()
        {
            InitializeComponent();
            
        }
        TruckersEntities dbContext = new TruckersEntities();

        private void List()
        {
      
            dbContext.Drivers.LoadAsync().ContinueWith(loadTask =>
            {
                driversBindingSource.DataSource = dbContext.Drivers.Where(x=> x.GroupID == 1).ToList();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void FrmMembershipList_Load(object sender, EventArgs e)
        {
            List();
        }
    }
}
