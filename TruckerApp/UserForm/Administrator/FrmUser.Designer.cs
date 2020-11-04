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
            this.btnCounterCreator = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnConvertTag
            // 
            this.btnConvertTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertTag.Location = new System.Drawing.Point(24, 35);
            this.btnConvertTag.Name = "btnConvertTag";
            this.btnConvertTag.Size = new System.Drawing.Size(276, 46);
            this.btnConvertTag.TabIndex = 0;
            this.btnConvertTag.Text = "تبدیل پلاک های وارد شده به پلاک استاندارد";
            this.btnConvertTag.Click += new System.EventHandler(this.btnConvertTag_Click);
            // 
            // btnEncryptUsers
            // 
            this.btnEncryptUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncryptUsers.Location = new System.Drawing.Point(24, 87);
            this.btnEncryptUsers.Name = "btnEncryptUsers";
            this.btnEncryptUsers.Size = new System.Drawing.Size(276, 46);
            this.btnEncryptUsers.TabIndex = 0;
            this.btnEncryptUsers.Text = "رمزنگار جدول کاربران\r\n";
            this.btnEncryptUsers.Click += new System.EventHandler(this.btnEncryptUsers_Click);
            // 
            // btnCounterCreator
            // 
            this.btnCounterCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCounterCreator.Location = new System.Drawing.Point(24, 139);
            this.btnCounterCreator.Name = "btnCounterCreator";
            this.btnCounterCreator.Size = new System.Drawing.Size(276, 46);
            this.btnCounterCreator.TabIndex = 0;
            this.btnCounterCreator.Text = "افزودن جدول شمارنده";
            this.btnCounterCreator.Click += new System.EventHandler(this.btnCounterCreator_Click);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 275);
            this.Controls.Add(this.btnCounterCreator);
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
        private DevExpress.XtraEditors.SimpleButton btnCounterCreator;
    }
}