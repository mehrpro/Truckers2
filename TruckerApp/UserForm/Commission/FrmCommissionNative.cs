using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TruckerApp.Repository;

namespace TruckerApp.UserForm.Commission
{
    public partial class FrmCommissionNative : XtraForm
    {
        private readonly ICustomers _customers;
        public byte Group1 { get; set; }
        public byte GroupType4 { get; set; }

        public FrmCommissionNative(ICustomers customers)
        {
            _customers = customers;
            InitializeComponent();
        }


        private async void GridList1()
        {
            
            //var qry = dbContext.Commissions.Where(x => x.Groups_FK == groupid).ToList().OrderByDescending(x=> x.CommissionID);
       
                var list = await _customers.GetCommissinByGroupId(Group1);
                gridControl1.DataSource = list.OrderByDescending(x => x.CommissionID);
                var list2 = await _customers.GetCommissinByGroupId(GroupType4);
                gridControl2.DataSource = list2.OrderByDescending(x => x.CommissionID);
            


        }


        private async void btnAdd1_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                var result = await _customers.AddNewCommision(Group1, Convert.ToInt32(txtComosin1.EditValue));
                if (result)
                {
                    txtComosin1.Text = txtComosin2.Text = "";
                    GridList1();
                }
            }
            else
                XtraMessageBox.Show("مقادیر را درست وارد کنید", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void btnAdd2_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider2.Validate())
            {
                var result = await _customers.AddNewCommision(GroupType4, Convert.ToInt32(txtComosin1.EditValue));
                if (result)
                {
                    txtComosin1.Text = txtComosin2.Text = "";
                    GridList1();
                }
            }
            else
                XtraMessageBox.Show("مقادیر را درست وارد کنید", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            GridList1();
           // GridList1(GroupType4);
        }
    }
}
