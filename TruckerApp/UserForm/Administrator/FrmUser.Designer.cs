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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.txtCameraMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConvertTag
            // 
            this.btnConvertTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertTag.Location = new System.Drawing.Point(334, 227);
            this.btnConvertTag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConvertTag.Name = "btnConvertTag";
            this.btnConvertTag.Size = new System.Drawing.Size(389, 60);
            this.btnConvertTag.TabIndex = 0;
            this.btnConvertTag.Text = "تبدیل پلاک های وارد شده به پلاک استاندارد";
            this.btnConvertTag.Click += new System.EventHandler(this.btnConvertTag_Click);
            // 
            // btnEncryptUsers
            // 
            this.btnEncryptUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncryptUsers.Location = new System.Drawing.Point(334, 295);
            this.btnEncryptUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncryptUsers.Name = "btnEncryptUsers";
            this.btnEncryptUsers.Size = new System.Drawing.Size(389, 60);
            this.btnEncryptUsers.TabIndex = 0;
            this.btnEncryptUsers.Text = "رمزنگار جدول کاربران\r\n";
            this.btnEncryptUsers.Click += new System.EventHandler(this.btnEncryptUsers_Click);
            // 
            // btnCounterCreator
            // 
            this.btnCounterCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCounterCreator.Location = new System.Drawing.Point(334, 363);
            this.btnCounterCreator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCounterCreator.Name = "btnCounterCreator";
            this.btnCounterCreator.Size = new System.Drawing.Size(389, 60);
            this.btnCounterCreator.TabIndex = 0;
            this.btnCounterCreator.Text = "افزودن جدول شمارنده";
            this.btnCounterCreator.Click += new System.EventHandler(this.btnCounterCreator_Click);
            // 
            // btnCameraMode
            // 
            this.btnCameraMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCameraMode.Location = new System.Drawing.Point(536, 431);
            this.btnCameraMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCameraMode.Name = "btnCameraMode";
            this.btnCameraMode.Size = new System.Drawing.Size(188, 60);
            this.btnCameraMode.TabIndex = 0;
            this.btnCameraMode.Text = "تغییر وضعیت";
            this.btnCameraMode.Click += new System.EventHandler(this.btnCameraMode_Click);
            // 
            // txtCameraMode
            // 
            this.txtCameraMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCameraMode.Location = new System.Drawing.Point(334, 447);
            this.txtCameraMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCameraMode.Name = "txtCameraMode";
            this.txtCameraMode.Parmida_ActivePlusMultiKeys = false;
            this.txtCameraMode.Size = new System.Drawing.Size(194, 24);
            this.txtCameraMode.TabIndex = 1;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(766, 162);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "ایجاد کامل بانک اطلاعاتی";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = global::TruckerApp.Properties.Resources.icons8_add_database_32;
            this.barButtonItem1.ImageOptions.LargeImage = global::TruckerApp.Properties.Resources.addnewdatasource_32x32;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "پشتیبان گیری اطلاعات";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = global::TruckerApp.Properties.Resources.icons8_data_backup_32;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "بازیابی اطلاعات";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.Image = global::TruckerApp.Properties.Resources.icons8_database_restore_32;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Options.UseTextOptions = true;
            this.ribbonPage1.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "مدیریت بانک اطلاعاتی";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "بانک اطلاعاتی";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 513);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(766, 37);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 550);
            this.Controls.Add(this.txtCameraMode);
            this.Controls.Add(this.btnCameraMode);
            this.Controls.Add(this.btnCounterCreator);
            this.Controls.Add(this.btnEncryptUsers);
            this.Controls.Add(this.btnConvertTag);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmUser";
            this.Ribbon = this.ribbonControl1;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "کاربران اتوماسیون";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCameraMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnConvertTag;
        private DevExpress.XtraEditors.SimpleButton btnEncryptUsers;
        private DevExpress.XtraEditors.SimpleButton btnCounterCreator;
        private DevExpress.XtraEditors.SimpleButton btnCameraMode;
        private DevExpress.XtraEditors.TextEdit txtCameraMode;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}