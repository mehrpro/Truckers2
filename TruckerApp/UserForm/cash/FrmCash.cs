using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TruckerApp.UserForm.cash
{
    public partial class FrmCash : XtraForm
    {
        public Cash Cash { get; set; } = new Cash();
        public FrmCash(string cashTemp)
        {
            InitializeComponent();
            txtPOS.Text = cashTemp;

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Cash.Pos = Convert.ToInt32(txtPOS.EditValue);
            Cash.CashDesk = Convert.ToInt32(txtCash.EditValue);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
