using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TruckerApp.UserForm.Commission
{
    public partial class FrmCommissionNative : XtraForm
    {
        public FrmCommissionNative()
        {
            InitializeComponent();
        }
        TruckerApp.TruckersEntities dbContext = new TruckerApp.TruckersEntities();
        public byte Group1 { get; set; }
        public byte Group2 { get; set; }

        private void GridList1(byte groupid)
        {
            dbContext = new TruckersEntities();
            var qry = dbContext.Commissions.Where(x => x.Groups_FK == groupid).ToList().OrderByDescending(x=> x.CommissionID);
            if (groupid == Group1)
            {
                gridControl1.DataSource = qry;
            }
            else if (groupid == Group2)
            {
                gridControl2.DataSource = qry;
            }


        }
        private void Add(byte group, int commission)
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
                        CommissionPrice = commission,
                        GroupID = 2,
                        
                    };
                    db.Commissions.Add(newCommission);
                    db.SaveChanges();
                    txtComosin1.Text = txtComosin2.Text = "";
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
                Add(Group1, Convert.ToInt32(txtComosin1.EditValue));
            }
            else
            {
                XtraMessageBox.Show("مقادیر را درست وارد کنید", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider2.Validate())
            {
                Add(Group2, Convert.ToInt32(txtComosin2.EditValue));
            }
            else
            {
                XtraMessageBox.Show("مقادیر را درست وارد کنید", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCommissionNative_Load(object sender, EventArgs e)
        {
            switch (Group1)
            {
                case 14:
                    groupControl1.Text = "مصوبات حق کمیسیون اعضاء صنف";
                    break;
                case 15:
                    groupControl1.Text = "مصوبات حق کمیسیون رانندگان بومی";
                    break;
                case 16:
                    groupControl1.Text = "مصوبات حق کمیسیون رانندگان غیربومی";
                    break;



            }
            GridList1(Group1);
            GridList1(Group2);
        }
    }
}
