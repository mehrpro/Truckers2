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
            this.btnCameraMode = new DevExpress.XtraEditors.SimpleButton();
            this.txtCameraMode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCameraMode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConvertTag
            // 
            this.btnConvertTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertTag.Location = new System.Drawing.Point(18, 35);
            this.btnConvertTag.Name = "btnConvertTag";
            this.btnConvertTag.Size = new System.Drawing.Size(764, 46);
            this.btnConvertTag.TabIndex = 0;
            this.btnConvertTag.Text = "تبدیل پلاک های وارد شده به پلاک استاندارد";
            this.btnConvertTag.Click += new System.EventHandler(this.btnConvertTag_Click);
            // 
            // btnEncryptUsers
            // 
            this.btnEncryptUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncryptUsers.Location = new System.Drawing.Point(18, 87);
            this.btnEncryptUsers.Name = "btnEncryptUsers";
            this.btnEncryptUsers.Size = new System.Drawing.Size(764, 46);
            this.btnEncryptUsers.TabIndex = 0;
            this.btnEncryptUsers.Text = "رمزنگار جدول کاربران\r\n";
            this.btnEncryptUsers.Click += new System.EventHandler(this.btnEncryptUsers_Click);
            // 
            // btnCounterCreator
            // 
            this.btnCounterCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCounterCreator.Location = new System.Drawing.Point(18, 139);
            this.btnCounterCreator.Name = "btnCounterCreator";
            this.btnCounterCreator.Size = new System.Drawing.Size(764, 46);
            this.btnCounterCreator.TabIndex = 0;
            this.btnCounterCreator.Text = "افزودن جدول شمارنده";
            this.btnCounterCreator.Click += new System.EventHandler(this.btnCounterCreator_Click);
            // 
            // btnCameraMode
            // 
            this.btnCameraMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCameraMode.Location = new System.Drawing.Point(621, 191);
            this.btnCameraMode.Name = "btnCameraMode";
            this.btnCameraMode.Size = new System.Drawing.Size(161, 46);
            this.btnCameraMode.TabIndex = 0;
            this.btnCameraMode.Text = "تغییر وضعیت";
            this.btnCameraMode.Click += new System.EventHandler(this.btnCameraMode_Click);
            // 
            // txtCameraMode
            // 
            this.txtCameraMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCameraMode.Location = new System.Drawing.Point(18, 203);
            this.txtCameraMode.Name = "txtCameraMode";
            this.txtCameraMode.Parmida_ActivePlusMultiKeys = false;
            this.txtCameraMode.Size = new System.Drawing.Size(597, 24);
            this.txtCameraMode.TabIndex = 1;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.txtCameraMode);
            this.Controls.Add(this.btnCameraMode);
            this.Controls.Add(this.btnCounterCreator);
            this.Controls.Add(this.btnEncryptUsers);
            this.Controls.Add(this.btnConvertTag);
            this.Name = "FrmUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "کاربران اتوماسیون";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCameraMode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnConvertTag;
        private DevExpress.XtraEditors.SimpleButton btnEncryptUsers;
        private DevExpress.XtraEditors.SimpleButton btnCounterCreator;
        private DevExpress.XtraEditors.SimpleButton btnCameraMode;
        private DevExpress.XtraEditors.TextEdit txtCameraMode;
    }
}