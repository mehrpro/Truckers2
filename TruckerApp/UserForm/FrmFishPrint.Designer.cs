namespace TruckerApp.UserForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.radioGroupType = new DevExpress.XtraEditors.RadioGroup();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtserial = new DevExpress.XtraEditors.TextEdit();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtDateRegister = new DevExpress.XtraEditors.TextEdit();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtTag = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.cbxSmart = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDriverID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMembership = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSmartCart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTagNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtComossin = new DevExpress.XtraEditors.TextEdit();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtserial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateRegister.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSmart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComossin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("B Yekan", 16F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.radioGroupType);
            this.groupControl1.Controls.Add(this.btnPrint);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtserial);
            this.groupControl1.Controls.Add(this.txtNumber);
            this.groupControl1.Controls.Add(this.txtDateRegister);
            this.groupControl1.Controls.Add(this.txtPhoneNumber);
            this.groupControl1.Controls.Add(this.txtTag);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.cbxSmart);
            this.groupControl1.Controls.Add(this.txtComossin);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(682, 631);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = " صدور حواله ";
            // 
            // radioGroupType
            // 
            this.radioGroupType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioGroupType.EditValue = ((byte)(1));
            this.radioGroupType.Location = new System.Drawing.Point(296, 334);
            this.radioGroupType.Name = "radioGroupType";
            this.radioGroupType.Parmida_ActivePlusMultiKeys = false;
            this.radioGroupType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupType.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioGroupType.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupType.Properties.Appearance.Options.UseFont = true;
            this.radioGroupType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(1)), "فله"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(2)), "پاکت"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(3)), "غلات")});
            this.radioGroupType.Size = new System.Drawing.Size(239, 38);
            this.radioGroupType.TabIndex = 1;
            this.radioGroupType.SelectedIndexChanged += new System.EventHandler(this.radioGroupType_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(420, 378);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(115, 48);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "ثبت نوبت";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl4.Location = new System.Drawing.Point(540, 301);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 24);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "شماره تلفن";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl3.Location = new System.Drawing.Point(540, 265);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 24);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "کمسیون";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl2.Location = new System.Drawing.Point(541, 229);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "پلاک";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl6.Location = new System.Drawing.Point(542, 121);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(81, 24);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "سریال فروش";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl5.Location = new System.Drawing.Point(541, 157);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(83, 24);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "کارت هوشمند";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl1.Location = new System.Drawing.Point(541, 193);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 24);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "نام راننده";
            // 
            // txtserial
            // 
            this.txtserial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtserial.Location = new System.Drawing.Point(471, 118);
            this.txtserial.Name = "txtserial";
            this.txtserial.Parmida_ActivePlusMultiKeys = false;
            this.txtserial.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtserial.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtserial.Properties.Appearance.Options.UseFont = true;
            this.txtserial.Properties.Appearance.Options.UseForeColor = true;
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
            this.txtNumber.Location = new System.Drawing.Point(294, 118);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Parmida_ActivePlusMultiKeys = false;
            this.txtNumber.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtNumber.Properties.Appearance.Options.UseFont = true;
            this.txtNumber.Properties.Appearance.Options.UseForeColor = true;
            this.txtNumber.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtNumber.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtNumber.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtNumber.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtNumber.Properties.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(169, 30);
            this.txtNumber.TabIndex = 1;
            // 
            // txtDateRegister
            // 
            this.txtDateRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateRegister.Location = new System.Drawing.Point(295, 82);
            this.txtDateRegister.Name = "txtDateRegister";
            this.txtDateRegister.Parmida_ActivePlusMultiKeys = false;
            this.txtDateRegister.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtDateRegister.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtDateRegister.Properties.Appearance.Options.UseFont = true;
            this.txtDateRegister.Properties.Appearance.Options.UseForeColor = true;
            this.txtDateRegister.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtDateRegister.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtDateRegister.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtDateRegister.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtDateRegister.Properties.ReadOnly = true;
            this.txtDateRegister.Size = new System.Drawing.Size(240, 30);
            this.txtDateRegister.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(295, 298);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Parmida_ActivePlusMultiKeys = false;
            this.txtPhoneNumber.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtPhoneNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtPhoneNumber.Properties.Appearance.Options.UseFont = true;
            this.txtPhoneNumber.Properties.Appearance.Options.UseForeColor = true;
            this.txtPhoneNumber.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtPhoneNumber.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtPhoneNumber.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtPhoneNumber.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtPhoneNumber.Properties.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(239, 30);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // txtTag
            // 
            this.txtTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTag.Location = new System.Drawing.Point(294, 226);
            this.txtTag.Name = "txtTag";
            this.txtTag.Parmida_ActivePlusMultiKeys = false;
            this.txtTag.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtTag.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTag.Properties.Appearance.Options.UseFont = true;
            this.txtTag.Properties.Appearance.Options.UseForeColor = true;
            this.txtTag.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtTag.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTag.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtTag.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtTag.Properties.ReadOnly = true;
            this.txtTag.Size = new System.Drawing.Size(241, 30);
            this.txtTag.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(294, 190);
            this.txtName.Name = "txtName";
            this.txtName.Parmida_ActivePlusMultiKeys = false;
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Properties.Appearance.Options.UseForeColor = true;
            this.txtName.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtName.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtName.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtName.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtName.Properties.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(241, 30);
            this.txtName.TabIndex = 1;
            // 
            // cbxSmart
            // 
            this.cbxSmart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSmart.Location = new System.Drawing.Point(295, 154);
            this.cbxSmart.Name = "cbxSmart";
            this.cbxSmart.Parmida_ActivePlusMultiKeys = false;
            this.cbxSmart.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.cbxSmart.Properties.Appearance.Options.UseFont = true;
            this.cbxSmart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSmart.Properties.DataSource = this.driversBindingSource;
            this.cbxSmart.Properties.DisplayMember = "SmartCart";
            this.cbxSmart.Properties.ValueMember = "DriverID";
            this.cbxSmart.Properties.View = this.searchLookUpEdit1View;
            this.cbxSmart.Size = new System.Drawing.Size(239, 30);
            this.cbxSmart.TabIndex = 0;
            this.cbxSmart.EditValueChanged += new System.EventHandler(this.cbxSmart_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
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
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colDriverID
            // 
            this.colDriverID.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colDriverID.FieldName = "DriverID";
            this.colDriverID.Name = "colDriverID";
            this.colDriverID.Visible = true;
            this.colDriverID.VisibleIndex = 0;
            // 
            // colFirstName
            // 
            this.colFirstName.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            // 
            // colMembership
            // 
            this.colMembership.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colMembership.FieldName = "Membership";
            this.colMembership.Name = "colMembership";
            this.colMembership.Visible = true;
            this.colMembership.VisibleIndex = 3;
            // 
            // colSmartCart
            // 
            this.colSmartCart.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colSmartCart.FieldName = "SmartCart";
            this.colSmartCart.Name = "colSmartCart";
            this.colSmartCart.Visible = true;
            this.colSmartCart.VisibleIndex = 4;
            // 
            // colTag
            // 
            this.colTag.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colTag.FieldName = "Tag";
            this.colTag.Name = "colTag";
            this.colTag.Visible = true;
            this.colTag.VisibleIndex = 5;
            // 
            // colTagNumber
            // 
            this.colTagNumber.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colTagNumber.FieldName = "TagNumber";
            this.colTagNumber.Name = "colTagNumber";
            this.colTagNumber.Visible = true;
            this.colTagNumber.VisibleIndex = 6;
            // 
            // txtComossin
            // 
            this.txtComossin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComossin.EditValue = "0";
            this.txtComossin.Location = new System.Drawing.Point(295, 262);
            this.txtComossin.Name = "txtComossin";
            this.txtComossin.Parmida_ActivePlusMultiKeys = false;
            this.txtComossin.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtComossin.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtComossin.Properties.Appearance.Options.UseFont = true;
            this.txtComossin.Properties.Appearance.Options.UseForeColor = true;
            this.txtComossin.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.txtComossin.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.txtComossin.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.txtComossin.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtComossin.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtComossin.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtComossin.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtComossin.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.txtComossin.Properties.ReadOnly = true;
            this.txtComossin.Size = new System.Drawing.Size(239, 30);
            this.txtComossin.TabIndex = 1;
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataSource = typeof(TruckerApp.Driver);
            // 
            // FrmFishPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 631);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmFishPrint";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "صدور حواله";
            this.Load += new System.EventHandler(this.FrmFishPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtserial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateRegister.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSmart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComossin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colMembership;
        private DevExpress.XtraGrid.Columns.GridColumn colSmartCart;
        private DevExpress.XtraGrid.Columns.GridColumn colTag;
        private DevExpress.XtraGrid.Columns.GridColumn colTagNumber;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.TextEdit txtTag;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtComossin;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.RadioGroup radioGroupType;
        private DevExpress.XtraEditors.TextEdit txtDateRegister;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtserial;
        private DevExpress.XtraEditors.TextEdit txtNumber;
    }
}