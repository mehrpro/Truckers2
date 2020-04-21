﻿using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TruckerApp.UserForm
{
    public partial class FrmCash : XtraForm
    {
        private TruckersEntities db;
        public int QueueID { get; set; }
        public string CashTemp { get; set; }
        public byte _userid { get; set; }
        public FrmCash(TruckersEntities entities)
        {
            InitializeComponent();
            db = entities;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                var c = new Cash();
                c.QueueID_FK = QueueID;
                c.Pos = Convert.ToInt32(txtPOS.EditValue);
                c.CashDesk = Convert.ToInt32(txtCash.EditValue);
                c.userID = _userid;
                c.seriesID_FK = _serialID;
                db.Cashes.Add(c);
                db.SaveChanges();
                Close();
            }
            catch
            {
                var str = $"ثبت انجام نشد";
                XtraMessageBox.Show(str, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public int _serialID { get; set; }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCash_Load(object sender, EventArgs e)
        {
            txtPOS.Text = CashTemp;
        }
    }
}
