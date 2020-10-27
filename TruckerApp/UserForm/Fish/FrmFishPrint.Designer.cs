namespace TruckerApp.UserForm.Fish
{
     partial class FrmFishPrint
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFishPrint));
            this.timer_process = new System.Windows.Forms.Timer(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.edtProcessInterval = new System.Windows.Forms.TextBox();
            this.lblWH = new System.Windows.Forms.Label();
            this.cmbDrawMethod = new System.Windows.Forms.ComboBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.picPlateLast = new System.Windows.Forms.PictureBox();
            this.Res4 = new System.Windows.Forms.Label();
            this.Res2 = new System.Windows.Forms.Label();
            this.Res3 = new System.Windows.Forms.Label();
            this.Res1 = new System.Windows.Forms.Label();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            this.btnPlay = new DevExpress.XtraEditors.SimpleButton();
            this.picture = new System.Windows.Forms.PictureBox();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtserial = new DevExpress.XtraEditors.TextEdit();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtDateRegister = new DevExpress.XtraEditors.TextEdit();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtTagNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtHosmand = new DevExpress.XtraEditors.TextEdit();
            this.txtTag = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.cbxSmart = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDriverID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSmartCart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTagNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTagNumber1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtComossin = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlateLast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtserial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateRegister.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTagNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHosmand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSmart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComossin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_process
            // 
            this.timer_process.Tick += new System.EventHandler(this.timer_process_Tick);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("B Yekan", 16F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionImageOptions.Image = global::TruckerApp.Properties.Resources.icons8_label_printer_48;
            this.groupControl1.Controls.Add(this.edtProcessInterval);
            this.groupControl1.Controls.Add(this.lblWH);
            this.groupControl1.Controls.Add(this.cmbDrawMethod);
            this.groupControl1.Controls.Add(this.lbl_result);
            this.groupControl1.Controls.Add(this.picPlateLast);
            this.groupControl1.Controls.Add(this.Res4);
            this.groupControl1.Controls.Add(this.Res2);
            this.groupControl1.Controls.Add(this.Res3);
            this.groupControl1.Controls.Add(this.Res1);
            this.groupControl1.Controls.Add(this.btnStop);
            this.groupControl1.Controls.Add(this.btnPlay);
            this.groupControl1.Controls.Add(this.picture);
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnPrint);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtserial);
            this.groupControl1.Controls.Add(this.txtNumber);
            this.groupControl1.Controls.Add(this.txtDateRegister);
            this.groupControl1.Controls.Add(this.txtPhoneNumber);
            this.groupControl1.Controls.Add(this.txtTagNumber);
            this.groupControl1.Controls.Add(this.txtHosmand);
            this.groupControl1.Controls.Add(this.txtTag);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.cbxSmart);
            this.groupControl1.Controls.Add(this.txtComossin);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(919, 404);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = " صدور حواله ";
            // 
            // edtProcessInterval
            // 
            this.edtProcessInterval.BackColor = System.Drawing.Color.Honeydew;
            this.edtProcessInterval.Location = new System.Drawing.Point(655, 14);
            this.edtProcessInterval.Name = "edtProcessInterval";
            this.edtProcessInterval.Size = new System.Drawing.Size(45, 21);
            this.edtProcessInterval.TabIndex = 81;
            this.edtProcessInterval.Text = "500";
            this.edtProcessInterval.Visible = false;
            // 
            // lblWH
            // 
            this.lblWH.AutoSize = true;
            this.lblWH.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWH.Location = new System.Drawing.Point(25, 85);
            this.lblWH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWH.Name = "lblWH";
            this.lblWH.Size = new System.Drawing.Size(0, 13);
            this.lblWH.TabIndex = 64;
            // 
            // cmbDrawMethod
            // 
            this.cmbDrawMethod.BackColor = System.Drawing.Color.Honeydew;
            this.cmbDrawMethod.FormattingEnabled = true;
            this.cmbDrawMethod.Items.AddRange(new object[] {
            "Draw by WIN API",
            "Draw by OpenGL",
            "Draw by SDL",
            "Draw in Host (C#)"});
            this.cmbDrawMethod.Location = new System.Drawing.Point(516, 14);
            this.cmbDrawMethod.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDrawMethod.Name = "cmbDrawMethod";
            this.cmbDrawMethod.Size = new System.Drawing.Size(134, 21);
            this.cmbDrawMethod.TabIndex = 63;
            this.cmbDrawMethod.Text = "Draw by WIN API";
            this.cmbDrawMethod.Visible = false;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_result.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbl_result.Location = new System.Drawing.Point(577, 45);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_result.Size = new System.Drawing.Size(93, 16);
            this.lbl_result.TabIndex = 48;
            this.lbl_result.Text = "EN RESULT";
            this.lbl_result.Visible = false;
            // 
            // picPlateLast
            // 
            this.picPlateLast.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picPlateLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlateLast.Location = new System.Drawing.Point(112, 330);
            this.picPlateLast.Name = "picPlateLast";
            this.picPlateLast.Size = new System.Drawing.Size(179, 41);
            this.picPlateLast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlateLast.TabIndex = 47;
            this.picPlateLast.TabStop = false;
            // 
            // Res4
            // 
            this.Res4.AutoSize = true;
            this.Res4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Res4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Res4.Location = new System.Drawing.Point(442, 341);
            this.Res4.Name = "Res4";
            this.Res4.Size = new System.Drawing.Size(34, 24);
            this.Res4.TabIndex = 46;
            this.Res4.Text = "P4";
            // 
            // Res2
            // 
            this.Res2.AutoSize = true;
            this.Res2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Res2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Res2.Location = new System.Drawing.Point(346, 341);
            this.Res2.Name = "Res2";
            this.Res2.Size = new System.Drawing.Size(34, 24);
            this.Res2.TabIndex = 45;
            this.Res2.Text = "P2";
            // 
            // Res3
            // 
            this.Res3.AutoSize = true;
            this.Res3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Res3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Res3.Location = new System.Drawing.Point(392, 341);
            this.Res3.Name = "Res3";
            this.Res3.Size = new System.Drawing.Size(34, 24);
            this.Res3.TabIndex = 44;
            this.Res3.Text = "P3";
            // 
            // Res1
            // 
            this.Res1.AutoSize = true;
            this.Res1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Res1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Res1.Location = new System.Drawing.Point(297, 341);
            this.Res1.Name = "Res1";
            this.Res1.Size = new System.Drawing.Size(34, 24);
            this.Res1.TabIndex = 43;
            this.Res1.Text = "P1";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.ImageOptions.Image = global::TruckerApp.Properties.Resources.stop_32x321;
            this.btnStop.Location = new System.Drawing.Point(64, 330);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(42, 41);
            this.btnStop.TabIndex = 4;
            this.btnStop.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.ImageOptions.Image = global::TruckerApp.Properties.Resources.play_32x321;
            this.btnPlay.Location = new System.Drawing.Point(16, 330);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(42, 41);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Click += new System.EventHandler(this.btnRefreshPlayer_Click);
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.BackColor = System.Drawing.SystemColors.Control;
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Location = new System.Drawing.Point(16, 78);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(470, 246);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 3;
            this.picture.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(503, 341);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 48);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "بستن";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(653, 341);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(135, 48);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "ثبت و چاپ";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(800, 261);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 24);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "شماره تلفن";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(799, 297);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 24);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "کمسیون";
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(800, 225);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(26, 24);
            this.labelControl8.TabIndex = 2;
            this.labelControl8.Text = "پلاک";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(799, 80);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(32, 24);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "امروز";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(799, 114);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(81, 24);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "سریال فروش";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(801, 153);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(83, 24);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "کارت هوشمند";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(799, 189);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 24);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "نام راننده";
            // 
            // txtserial
            // 
            this.txtserial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtserial.Location = new System.Drawing.Point(725, 114);
            this.txtserial.Name = "txtserial";
            this.txtserial.Parmida_ActivePlusMultiKeys = false;
            this.txtserial.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtserial.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtserial.Properties.Appearance.Options.UseFont = true;
            this.txtserial.Properties.Appearance.Options.UseForeColor = true;
            this.txtserial.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtserial.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtserial.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtserial.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtserial.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtserial.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtserial.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtserial.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtserial.Properties.ReadOnly = true;
            this.txtserial.Size = new System.Drawing.Size(63, 30);
            this.txtserial.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumber.Location = new System.Drawing.Point(503, 114);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Parmida_ActivePlusMultiKeys = false;
            this.txtNumber.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtNumber.Properties.Appearance.Options.UseFont = true;
            this.txtNumber.Properties.Appearance.Options.UseForeColor = true;
            this.txtNumber.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtNumber.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtNumber.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtNumber.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtNumber.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtNumber.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtNumber.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtNumber.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtNumber.Properties.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(214, 30);
            this.txtNumber.TabIndex = 1;
            // 
            // txtDateRegister
            // 
            this.txtDateRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateRegister.Location = new System.Drawing.Point(503, 78);
            this.txtDateRegister.Name = "txtDateRegister";
            this.txtDateRegister.Parmida_ActivePlusMultiKeys = false;
            this.txtDateRegister.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtDateRegister.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtDateRegister.Properties.Appearance.Options.UseFont = true;
            this.txtDateRegister.Properties.Appearance.Options.UseForeColor = true;
            this.txtDateRegister.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtDateRegister.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtDateRegister.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtDateRegister.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtDateRegister.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtDateRegister.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtDateRegister.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtDateRegister.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtDateRegister.Properties.ReadOnly = true;
            this.txtDateRegister.Size = new System.Drawing.Size(285, 30);
            this.txtDateRegister.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(503, 258);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Parmida_ActivePlusMultiKeys = false;
            this.txtPhoneNumber.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtPhoneNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtPhoneNumber.Properties.Appearance.Options.UseFont = true;
            this.txtPhoneNumber.Properties.Appearance.Options.UseForeColor = true;
            this.txtPhoneNumber.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtPhoneNumber.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtPhoneNumber.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtPhoneNumber.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtPhoneNumber.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtPhoneNumber.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtPhoneNumber.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtPhoneNumber.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtPhoneNumber.Properties.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(285, 30);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // txtTagNumber
            // 
            this.txtTagNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTagNumber.Location = new System.Drawing.Point(657, 222);
            this.txtTagNumber.Name = "txtTagNumber";
            this.txtTagNumber.Parmida_ActivePlusMultiKeys = false;
            this.txtTagNumber.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtTagNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTagNumber.Properties.Appearance.Options.UseFont = true;
            this.txtTagNumber.Properties.Appearance.Options.UseForeColor = true;
            this.txtTagNumber.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtTagNumber.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtTagNumber.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtTagNumber.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtTagNumber.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtTagNumber.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTagNumber.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtTagNumber.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtTagNumber.Properties.Mask.EditMask = "\\d\\d-[آ-م]-\\d\\d\\d-\\d\\d";
            this.txtTagNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtTagNumber.Properties.ReadOnly = true;
            this.txtTagNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTagNumber.Size = new System.Drawing.Size(131, 30);
            this.txtTagNumber.TabIndex = 1;
            // 
            // txtHosmand
            // 
            this.txtHosmand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHosmand.Location = new System.Drawing.Point(503, 150);
            this.txtHosmand.Name = "txtHosmand";
            this.txtHosmand.Parmida_ActivePlusMultiKeys = false;
            this.txtHosmand.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtHosmand.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtHosmand.Properties.Appearance.Options.UseFont = true;
            this.txtHosmand.Properties.Appearance.Options.UseForeColor = true;
            this.txtHosmand.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtHosmand.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtHosmand.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtHosmand.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtHosmand.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtHosmand.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtHosmand.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtHosmand.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtHosmand.Properties.ReadOnly = true;
            this.txtHosmand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHosmand.Size = new System.Drawing.Size(285, 30);
            this.txtHosmand.TabIndex = 1;
            // 
            // txtTag
            // 
            this.txtTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTag.Location = new System.Drawing.Point(503, 222);
            this.txtTag.Name = "txtTag";
            this.txtTag.Parmida_ActivePlusMultiKeys = false;
            this.txtTag.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtTag.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTag.Properties.Appearance.Options.UseFont = true;
            this.txtTag.Properties.Appearance.Options.UseForeColor = true;
            this.txtTag.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtTag.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtTag.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtTag.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtTag.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtTag.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTag.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtTag.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtTag.Properties.ReadOnly = true;
            this.txtTag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTag.Size = new System.Drawing.Size(148, 30);
            this.txtTag.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(503, 186);
            this.txtName.Name = "txtName";
            this.txtName.Parmida_ActivePlusMultiKeys = false;
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Properties.Appearance.Options.UseForeColor = true;
            this.txtName.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtName.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtName.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtName.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtName.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtName.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtName.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtName.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtName.Properties.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(286, 30);
            this.txtName.TabIndex = 1;
            // 
            // cbxSmart
            // 
            this.cbxSmart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSmart.Location = new System.Drawing.Point(25, 42);
            this.cbxSmart.Name = "cbxSmart";
            this.cbxSmart.Parmida_ActivePlusMultiKeys = false;
            this.cbxSmart.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.cbxSmart.Properties.Appearance.Options.UseFont = true;
            this.cbxSmart.Properties.AppearanceDisabled.Font = new System.Drawing.Font("B Yekan", 12F);
            this.cbxSmart.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cbxSmart.Properties.AppearanceDropDown.Font = new System.Drawing.Font("B Yekan", 12F);
            this.cbxSmart.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxSmart.Properties.AppearanceFocused.Font = new System.Drawing.Font("B Yekan", 12F);
            this.cbxSmart.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbxSmart.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.cbxSmart.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cbxSmart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSmart.Properties.DataSource = this.driversBindingSource;
            this.cbxSmart.Properties.DisplayMember = "SmartCart";
            this.cbxSmart.Properties.PopupView = this.searchLookUpEdit1View;
            this.cbxSmart.Properties.ValueMember = "DriverID";
            this.cbxSmart.Size = new System.Drawing.Size(124, 30);
            this.cbxSmart.TabIndex = 0;
            this.cbxSmart.Visible = false;
            this.cbxSmart.EditValueChanged += new System.EventHandler(this.cbxSmart_EditValueChanged);
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataSource = typeof(TruckerApp.Driver);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.DetailTip.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.DetailTip.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.DetailTip.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.Empty.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.Empty.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.Empty.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.EvenRow.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.EvenRow.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.EvenRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FilterCloseButton.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.FilterCloseButton.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FilterPanel.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.FilterPanel.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FixedLine.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.FixedLine.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.FixedLine.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FocusedCell.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.FocusedCell.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FocusedRow.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.FocusedRow.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FooterPanel.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.FooterPanel.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.GroupButton.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.GroupButton.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.GroupButton.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.GroupFooter.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.GroupFooter.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.GroupPanel.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.GroupPanel.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.GroupRow.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.GroupRow.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.GroupRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.HideSelectionRow.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.HideSelectionRow.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.HorzLine.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.HorzLine.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.HorzLine.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.OddRow.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.OddRow.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.OddRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.Preview.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.Preview.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.Preview.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.Row.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.RowSeparator.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.RowSeparator.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.SelectedRow.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.SelectedRow.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.TopNewRow.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.TopNewRow.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.VertLine.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.VertLine.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.VertLine.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.ViewCaption.Font = new System.Drawing.Font("B Yekan", 9F);
            this.searchLookUpEdit1View.Appearance.ViewCaption.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDriverID,
            this.colFirstName,
            this.colLastName,
            this.colSmartCart,
            this.colTagNumber,
            this.colTagNumber1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colDriverID
            // 
            this.colDriverID.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colDriverID.Caption = "کد";
            this.colDriverID.FieldName = "DriverID";
            this.colDriverID.Name = "colDriverID";
            this.colDriverID.Visible = true;
            this.colDriverID.VisibleIndex = 0;
            // 
            // colFirstName
            // 
            this.colFirstName.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colFirstName.Caption = "نام";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colLastName.Caption = "فامیلی";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            // 
            // colSmartCart
            // 
            this.colSmartCart.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colSmartCart.Caption = "شماره هوشمند";
            this.colSmartCart.FieldName = "SmartCart";
            this.colSmartCart.Name = "colSmartCart";
            this.colSmartCart.Visible = true;
            this.colSmartCart.VisibleIndex = 3;
            // 
            // colTagNumber
            // 
            this.colTagNumber.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colTagNumber.Caption = "پلاک";
            this.colTagNumber.FieldName = "TagNumber";
            this.colTagNumber.Name = "colTagNumber";
            this.colTagNumber.Visible = true;
            this.colTagNumber.VisibleIndex = 4;
            // 
            // colTagNumber1
            // 
            this.colTagNumber1.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colTagNumber1.Caption = "پلاک خوان";
            this.colTagNumber1.FieldName = "Tag";
            this.colTagNumber1.Name = "colTagNumber1";
            this.colTagNumber1.Visible = true;
            this.colTagNumber1.VisibleIndex = 5;
            // 
            // txtComossin
            // 
            this.txtComossin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComossin.EditValue = "0";
            this.txtComossin.Location = new System.Drawing.Point(503, 294);
            this.txtComossin.Name = "txtComossin";
            this.txtComossin.Parmida_ActivePlusMultiKeys = false;
            this.txtComossin.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtComossin.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtComossin.Properties.Appearance.Options.UseFont = true;
            this.txtComossin.Properties.Appearance.Options.UseForeColor = true;
            this.txtComossin.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.txtComossin.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtComossin.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtComossin.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.txtComossin.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtComossin.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtComossin.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.txtComossin.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtComossin.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtComossin.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtComossin.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtComossin.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.txtComossin.Properties.ReadOnly = true;
            this.txtComossin.Size = new System.Drawing.Size(284, 30);
            this.txtComossin.TabIndex = 1;
            // 
            // FrmFishPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 404);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmFishPrint";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "صدور حواله";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFishPrint_FormClosing);
            this.Load += new System.EventHandler(this.FrmFishPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlateLast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtserial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateRegister.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTagNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHosmand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSmart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComossin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cbxSmart;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDriverID;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colSmartCart;
        private DevExpress.XtraGrid.Columns.GridColumn colTagNumber;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.TextEdit txtTag;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtComossin;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.TextEdit txtDateRegister;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtserial;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnPlay;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox picPlateLast;
        private System.Windows.Forms.Label Res4;
        private System.Windows.Forms.Label Res2;
        private System.Windows.Forms.Label Res3;
        private System.Windows.Forms.Label Res1;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.ComboBox cmbDrawMethod;
        private System.Windows.Forms.Label lblWH;
        private System.Windows.Forms.Timer timer_process;
        private System.Windows.Forms.TextBox edtProcessInterval;
        private DevExpress.XtraEditors.SimpleButton btnStop;
        private DevExpress.XtraEditors.TextEdit txtTagNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colTagNumber1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtHosmand;
    }
}
