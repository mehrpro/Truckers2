namespace TruckerApp.UserForm
{
    partial class FrmRevFish3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRevFish3));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnRevSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtserial = new DevExpress.XtraEditors.TextEdit();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtDateRegister = new DevExpress.XtraEditors.TextEdit();
            this.txtType = new DevExpress.XtraEditors.TextEdit();
            this.txtDateReg = new DevExpress.XtraEditors.TextEdit();
            this.txtTag = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.cbxSmart = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDriverID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMembership = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSmartCart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTagNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtComossin = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtserial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateRegister.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateReg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSmart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComossin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("B Yekan", 16F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImage = global::TruckerApp.Properties.Resources.icons8_mail_statistics_48;
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnRevSave);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtserial);
            this.groupControl1.Controls.Add(this.txtNumber);
            this.groupControl1.Controls.Add(this.txtDateRegister);
            this.groupControl1.Controls.Add(this.txtType);
            this.groupControl1.Controls.Add(this.txtDateReg);
            this.groupControl1.Controls.Add(this.txtTag);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.cbxSmart);
            this.groupControl1.Controls.Add(this.txtComossin);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(473, 506);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "رسید حواله";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(45, 437);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 48);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "بستن";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRevSave
            // 
            this.btnRevSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRevSave.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.btnRevSave.Appearance.Options.UseFont = true;
            this.btnRevSave.Image = ((System.Drawing.Image)(resources.GetObject("btnRevSave.Image")));
            this.btnRevSave.Location = new System.Drawing.Point(227, 435);
            this.btnRevSave.Name = "btnRevSave";
            this.btnRevSave.Size = new System.Drawing.Size(135, 50);
            this.btnRevSave.TabIndex = 16;
            this.btnRevSave.Text = "ثبت ";
            this.btnRevSave.Click += new System.EventHandler(this.btnRevSave_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl7.Location = new System.Drawing.Point(368, 392);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 24);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "محموله";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl4.Location = new System.Drawing.Point(368, 348);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 24);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "تاریخ";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl3.Location = new System.Drawing.Point(368, 304);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 24);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "هزینه دریافتی";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl2.Location = new System.Drawing.Point(372, 260);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 24);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "پلاک";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl6.Location = new System.Drawing.Point(372, 172);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(81, 24);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "سریال فروش";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl5.Location = new System.Drawing.Point(368, 128);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(83, 24);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "کارت هوشمند";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl1.Location = new System.Drawing.Point(368, 216);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 24);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "نام راننده";
            // 
            // txtserial
            // 
            this.txtserial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtserial.Location = new System.Drawing.Point(299, 169);
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
            this.txtserial.TabIndex = 10;
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumber.Location = new System.Drawing.Point(45, 169);
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
            this.txtNumber.Size = new System.Drawing.Size(247, 30);
            this.txtNumber.TabIndex = 9;
            // 
            // txtDateRegister
            // 
            this.txtDateRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateRegister.Location = new System.Drawing.Point(45, 81);
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
            this.txtDateRegister.Size = new System.Drawing.Size(317, 30);
            this.txtDateRegister.TabIndex = 8;
            // 
            // txtType
            // 
            this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtType.Location = new System.Drawing.Point(45, 389);
            this.txtType.Name = "txtType";
            this.txtType.Parmida_ActivePlusMultiKeys = false;
            this.txtType.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtType.Properties.Appearance.Options.UseFont = true;
            this.txtType.Properties.Appearance.Options.UseForeColor = true;
            this.txtType.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtType.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtType.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtType.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtType.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtType.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtType.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtType.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtType.Properties.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(317, 30);
            this.txtType.TabIndex = 7;
            // 
            // txtDateReg
            // 
            this.txtDateReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateReg.Location = new System.Drawing.Point(45, 345);
            this.txtDateReg.Name = "txtDateReg";
            this.txtDateReg.Parmida_ActivePlusMultiKeys = false;
            this.txtDateReg.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtDateReg.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtDateReg.Properties.Appearance.Options.UseFont = true;
            this.txtDateReg.Properties.Appearance.Options.UseForeColor = true;
            this.txtDateReg.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtDateReg.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtDateReg.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtDateReg.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtDateReg.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtDateReg.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtDateReg.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtDateReg.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtDateReg.Properties.ReadOnly = true;
            this.txtDateReg.Size = new System.Drawing.Size(317, 30);
            this.txtDateReg.TabIndex = 7;
            // 
            // txtTag
            // 
            this.txtTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTag.Location = new System.Drawing.Point(45, 257);
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
            this.txtTag.Size = new System.Drawing.Size(317, 30);
            this.txtTag.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(45, 213);
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
            this.txtName.Size = new System.Drawing.Size(317, 30);
            this.txtName.TabIndex = 5;
            // 
            // cbxSmart
            // 
            this.cbxSmart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSmart.Location = new System.Drawing.Point(45, 125);
            this.cbxSmart.Name = "cbxSmart";
            this.cbxSmart.Parmida_ActivePlusMultiKeys = false;
            this.cbxSmart.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.cbxSmart.Properties.Appearance.Options.UseFont = true;
            this.cbxSmart.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxSmart.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cbxSmart.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxSmart.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxSmart.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxSmart.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbxSmart.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxSmart.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cbxSmart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSmart.Properties.DataSource = this.driversBindingSource;
            this.cbxSmart.Properties.DisplayMember = "SmartCart";
            this.cbxSmart.Properties.ValueMember = "DriverID";
            this.cbxSmart.Properties.View = this.searchLookUpEdit1View;
            this.cbxSmart.Size = new System.Drawing.Size(317, 30);
            this.cbxSmart.TabIndex = 3;
            this.cbxSmart.EditValueChanged += new System.EventHandler(this.cbxSmart_EditValueChanged);
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataSource = typeof(TruckerApp.Driver);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.DetailTip.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.DetailTip.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.DetailTip.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.Empty.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.Empty.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.Empty.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.EvenRow.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.EvenRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.FilterCloseButton.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FilterPanel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.FilterPanel.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FixedLine.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.FixedLine.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.FixedLine.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.FocusedCell.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.FocusedRow.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.FooterPanel.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.GroupButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.GroupButton.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.GroupButton.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.GroupFooter.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.GroupPanel.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.GroupRow.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.GroupRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.HideSelectionRow.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.HorzLine.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.HorzLine.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.HorzLine.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.OddRow.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.OddRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.Preview.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.Preview.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.Row.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.RowSeparator.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.RowSeparator.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.SelectedRow.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.TopNewRow.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.VertLine.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.VertLine.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.VertLine.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLookUpEdit1View.Appearance.ViewCaption.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDriverID,
            this.colFirstName,
            this.colLastName,
            this.colMembership,
            this.colSmartCart,
            this.colTag,
            this.colTagNumber});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 1200;
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.searchLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSmartCart, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colDriverID
            // 
            this.colDriverID.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colDriverID.Caption = "کد";
            this.colDriverID.FieldName = "DriverID";
            this.colDriverID.Name = "colDriverID";
            this.colDriverID.Visible = true;
            this.colDriverID.VisibleIndex = 0;
            this.colDriverID.Width = 86;
            // 
            // colFirstName
            // 
            this.colFirstName.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colFirstName.Caption = "نام";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            this.colFirstName.Width = 158;
            // 
            // colLastName
            // 
            this.colLastName.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colLastName.Caption = "فامیلی";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            this.colLastName.Width = 153;
            // 
            // colMembership
            // 
            this.colMembership.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colMembership.Caption = "عضو";
            this.colMembership.FieldName = "Membership";
            this.colMembership.Name = "colMembership";
            this.colMembership.Visible = true;
            this.colMembership.VisibleIndex = 3;
            this.colMembership.Width = 146;
            // 
            // colSmartCart
            // 
            this.colSmartCart.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colSmartCart.Caption = "شماره هوشمند";
            this.colSmartCart.FieldName = "SmartCart";
            this.colSmartCart.Name = "colSmartCart";
            this.colSmartCart.Visible = true;
            this.colSmartCart.VisibleIndex = 4;
            this.colSmartCart.Width = 170;
            // 
            // colTag
            // 
            this.colTag.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colTag.Caption = "ایران پلاک";
            this.colTag.FieldName = "Tag";
            this.colTag.Name = "colTag";
            this.colTag.Visible = true;
            this.colTag.VisibleIndex = 5;
            this.colTag.Width = 91;
            // 
            // colTagNumber
            // 
            this.colTagNumber.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colTagNumber.Caption = "شماره پلاک";
            this.colTagNumber.FieldName = "TagNumber";
            this.colTagNumber.Name = "colTagNumber";
            this.colTagNumber.Visible = true;
            this.colTagNumber.VisibleIndex = 6;
            this.colTagNumber.Width = 188;
            // 
            // txtComossin
            // 
            this.txtComossin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComossin.EditValue = "0";
            this.txtComossin.Location = new System.Drawing.Point(45, 301);
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
            this.txtComossin.Size = new System.Drawing.Size(317, 30);
            this.txtComossin.TabIndex = 11;
            // 
            // FrmRevFish3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 506);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRevFish3";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "رسید حواله";
            this.Load += new System.EventHandler(this.FrmRevFish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtserial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateRegister.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateReg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSmart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComossin.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnRevSave;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtserial;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private DevExpress.XtraEditors.TextEdit txtDateRegister;
        private DevExpress.XtraEditors.TextEdit txtDateReg;
        private DevExpress.XtraEditors.TextEdit txtTag;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxSmart;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colDriverID;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colMembership;
        private DevExpress.XtraGrid.Columns.GridColumn colSmartCart;
        private DevExpress.XtraGrid.Columns.GridColumn colTag;
        private DevExpress.XtraGrid.Columns.GridColumn colTagNumber;
        private DevExpress.XtraEditors.TextEdit txtComossin;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtType;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}