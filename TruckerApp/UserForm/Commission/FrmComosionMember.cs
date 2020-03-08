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
using DevExpress.XtraEditors;

namespace TruckerApp.UserForm
{
    public partial class FrmComosionMember : Form
    {
        TruckerApp.TruckersEntities dbContext = new TruckerApp.TruckersEntities();

        public FrmComosionMember()
        {
            InitializeComponent();

        }

        private void GridList1(byte groupid)
        {
            dbContext = new TruckersEntities();
            var qry = dbContext.Commissions.Where(x => x.Groups_FK == groupid).ToList();
            if (groupid == 14)
            {
                gridControl1.DataSource = qry;
            }
            else if (groupid == 13)
            {
                gridControl2.DataSource = qry;
            }


        }



        private void Add(byte group,int commission)
        {
            using (var db = new TruckersEntities())
            {
                try
                {
                    var qry = db.Commissions.Where(x => x.Groups_FK == group).ToList();
                    foreach (var item in qry)
                    {
                        item.enabled = false;
                    }
                    TruckerApp.Commission newCommission = new TruckerApp.Commission()
                    {
                        DataRegister = DateTime.Now,
                        Groups_FK = group,
                        enabled = true,
                        CommissionPrice = commission
                    };
                    db.Commissions.Add(newCommission);
                    db.SaveChanges();
                    txtComosin1.Text = txtComosin2.Text ="";
                    GridList1(group);
                }
                catch 
                {
            
                }

            }

        }
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                Add(14, Convert.ToInt32(txtComosin1.EditValue));
            }
            else
            {
                XtraMessageBox.Show("مقادیر را درست وارد کنید", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmComosionPrice_Load(object sender, EventArgs e)
        {
            GridList1(14);
            GridList1(13);
           
        }



        private void btnAdd2_Click_1(object sender, EventArgs e)
        {
            if (dxValidationProvider2.Validate())
            {
                Add(13, Convert.ToInt32(txtComosin2.EditValue));
            }
            else
            {
                XtraMessageBox.Show("مقادیر را درست وارد کنید", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
