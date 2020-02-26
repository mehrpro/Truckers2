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
    public partial class FrmComosionPrice : Form
    {
        TruckerApp.TruckersEntities dbContext = new TruckerApp.TruckersEntities();

        public FrmComosionPrice()
        {
            InitializeComponent();

        }

        private void GridList1(byte groupid)
        {
            dbContext = new TruckersEntities();
            var qry = dbContext.Commissions.Where(x => x.Groups == groupid).ToList();
            if (groupid == 1)
            {
                gridControl1.DataSource = qry;
            }
            else if (groupid == 2)
            {
                gridControl2.DataSource = qry;
            }
            else if (groupid == 3)
            {
                gridControl3.DataSource = qry;
            }

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void Add(byte group,int commission)
        {
            using (var db = new TruckersEntities())
            {
                try
                {
                    var qry = db.Commissions.Where(x => x.Groups == group).ToList();
                    foreach (var item in qry)
                    {
                        item.enabled = false;
                    }
                    Commission newCommission = new Commission()
                    {
                        DataRegister = DateTime.Now,
                        Groups = group,
                        enabled = true,
                        Commission1 = commission
                    };
                    db.Commissions.Add(newCommission);
                    db.SaveChanges();
                    txtComosin1.Text = txtComosin2.Text = txtComosin3.Text = "";
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
                Add(1, Convert.ToInt32(txtComosin1.EditValue));
            }
            else
            {
                XtraMessageBox.Show("مقادیر را درست وارد کنید", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmComosionPrice_Load(object sender, EventArgs e)
        {
            GridList1(1);
            GridList1(2);
            GridList1(3);
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider2.Validate())
            {
                Add(2, Convert.ToInt32(txtComosin2.EditValue));
            }
            else
            {
                XtraMessageBox.Show("مقادیر را درست وارد کنید", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider3.Validate())
            {
                Add(3, Convert.ToInt32(txtComosin3.EditValue));
            }
            else
            {
                XtraMessageBox.Show("مقادیر را درست وارد کنید", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
