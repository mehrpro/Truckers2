namespace TruckerApp
{
    partial class FrmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConvertTag = new DevExpress.XtraEditors.SimpleButton();
            this.btnEncryptUsers = new DevExpress.XtraEditors.SimpleButton();
            this.btnTransportDriverTel = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnConvertTag
            // 
            this.btnConvertTag.Location = new System.Drawing.Point(585, 37);
            this.btnConvertTag.Name = "btnConvertTag";
            this.btnConvertTag.Size = new System.Drawing.Size(276, 46);
            this.btnConvertTag.TabIndex = 0;
            this.btnConvertTag.Text = "تبدیل پلاک های وارد شده به پلاک استاندارد";
            this.btnConvertTag.Click += new System.EventHandler(this.btnConvertTag_Click);
            // 
            // btnEncryptUsers
            // 
            this.btnEncryptUsers.Location = new System.Drawing.Point(585, 89);
            this.btnEncryptUsers.Name = "btnEncryptUsers";
            this.btnEncryptUsers.Size = new System.Drawing.Size(276, 46);
            this.btnEncryptUsers.TabIndex = 0;
            this.btnEncryptUsers.Text = "رمزنگار جدول کاربران\r\n";
            this.btnEncryptUsers.Click += new System.EventHandler(this.btnEncryptUsers_Click);
            // 
            // btnTransportDriverTel
            // 
            this.btnTransportDriverTel.Location = new System.Drawing.Point(585, 141);
            this.btnTransportDriverTel.Name = "btnTransportDriverTel";
            this.btnTransportDriverTel.Size = new System.Drawing.Size(276, 46);
            this.btnTransportDriverTel.TabIndex = 0;
            this.btnTransportDriverTel.Text = "انتقال لیست تلفن ها به جدول تلفن\r\n";
            this.btnTransportDriverTel.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 275);
            this.Controls.Add(this.btnTransportDriverTel);
            this.Controls.Add(this.btnEncryptUsers);
            this.Controls.Add(this.btnConvertTag);
            this.Name = "FrmUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "کاربران اتوماسیون";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnConvertTag;
        private DevExpress.XtraEditors.SimpleButton btnEncryptUsers;
        private DevExpress.XtraEditors.SimpleButton btnTransportDriverTel;
    }
}