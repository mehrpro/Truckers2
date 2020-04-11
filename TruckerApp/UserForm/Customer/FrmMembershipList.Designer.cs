namespace TruckerApp.UserForm
{
    partial class FrmMembershipList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMembershipList));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTagNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSmartCart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.FirstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PhoneNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SmartCartTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TagNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TagTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSmartCart = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPhoneNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFirstName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLastName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTag = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTagNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmartCartTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TagNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TagTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSmartCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTagNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("B Yekan", 16F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImage = global::TruckerApp.Properties.Resources.icons8_list_48;
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(838, 636);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "اعضاء اتحادیه";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 55);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(540, 579);
            this.panelControl2.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.driversBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(536, 575);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataSource = typeof(TruckerApp.Driver);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridView1.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.DetailTip.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.DetailTip.Options.UseFont = true;
            this.gridView1.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridView1.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Empty.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.Empty.Options.UseFont = true;
            this.gridView1.Appearance.Empty.Options.UseTextOptions = true;
            this.gridView1.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.EvenRow.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.EvenRow.Options.UseFont = true;
            this.gridView1.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterCloseButton.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FixedLine.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.FixedLine.Options.UseFont = true;
            this.gridView1.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupButton.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.GroupButton.Options.UseFont = true;
            this.gridView1.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HorzLine.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.HorzLine.Options.UseFont = true;
            this.gridView1.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.OddRow.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.OddRow.Options.UseFont = true;
            this.gridView1.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView1.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.RowSeparator.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView1.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridView1.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.VertLine.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.VertLine.Options.UseFont = true;
            this.gridView1.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFirstName,
            this.colLastName,
            this.colTagNumber,
            this.colSmartCart});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colFirstName
            // 
            this.colFirstName.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colFirstName.Caption = "نام";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            this.colFirstName.Width = 146;
            // 
            // colLastName
            // 
            this.colLastName.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colLastName.Caption = "نام خانوادگی";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            this.colLastName.Width = 176;
            // 
            // colTagNumber
            // 
            this.colTagNumber.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colTagNumber.Caption = "پلاک";
            this.colTagNumber.FieldName = "TagNumber";
            this.colTagNumber.Name = "colTagNumber";
            this.colTagNumber.Visible = true;
            this.colTagNumber.VisibleIndex = 3;
            this.colTagNumber.Width = 101;
            // 
            // colSmartCart
            // 
            this.colSmartCart.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colSmartCart.Caption = "کارت هوشمند";
            this.colSmartCart.FieldName = "SmartCart";
            this.colSmartCart.Name = "colSmartCart";
            this.colSmartCart.OptionsColumn.ReadOnly = true;
            this.colSmartCart.Visible = true;
            this.colSmartCart.VisibleIndex = 0;
            this.colSmartCart.Width = 95;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dataLayoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(542, 55);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(294, 579);
            this.panelControl1.TabIndex = 0;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Appearance.Control.Font = new System.Drawing.Font("B Yekan", 12F);
            this.dataLayoutControl1.Appearance.Control.Options.UseFont = true;
            this.dataLayoutControl1.Appearance.ControlDisabled.Font = new System.Drawing.Font("B Yekan", 12F);
            this.dataLayoutControl1.Appearance.ControlDisabled.Options.UseFont = true;
            this.dataLayoutControl1.Appearance.ControlDropDown.Font = new System.Drawing.Font("B Yekan", 12F);
            this.dataLayoutControl1.Appearance.ControlDropDown.Options.UseFont = true;
            this.dataLayoutControl1.Appearance.ControlDropDownHeader.Font = new System.Drawing.Font("B Yekan", 12F);
            this.dataLayoutControl1.Appearance.ControlDropDownHeader.Options.UseFont = true;
            this.dataLayoutControl1.Appearance.ControlFocused.Font = new System.Drawing.Font("B Yekan", 12F);
            this.dataLayoutControl1.Appearance.ControlFocused.Options.UseFont = true;
            this.dataLayoutControl1.Appearance.ControlReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.dataLayoutControl1.Appearance.ControlReadOnly.Options.UseFont = true;
            this.dataLayoutControl1.Appearance.DisabledLayoutGroupCaption.Font = new System.Drawing.Font("B Yekan", 12F);
            this.dataLayoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseFont = true;
            this.dataLayoutControl1.Appearance.DisabledLayoutItem.Font = new System.Drawing.Font("B Yekan", 12F);
            this.dataLayoutControl1.Appearance.DisabledLayoutItem.Options.UseFont = true;
            this.dataLayoutControl1.Controls.Add(this.btnsave);
            this.dataLayoutControl1.Controls.Add(this.FirstNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.LastNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PhoneNumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SmartCartTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TagNumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TagTextEdit);
            this.dataLayoutControl1.DataSource = this.driversBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Font = new System.Drawing.Font("B Yekan", 12F);
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 2);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsFocus.MoveFocusRightToLeft = true;
            this.dataLayoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dataLayoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.dataLayoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.dataLayoutControl1.OptionsPrint.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dataLayoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseFont = true;
            this.dataLayoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(290, 575);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // btnsave
            // 
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.Location = new System.Drawing.Point(12, 216);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(266, 31);
            this.btnsave.StyleController = this.dataLayoutControl1;
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "ذخیره";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // FirstNameTextEdit
            // 
            this.FirstNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.driversBindingSource, "FirstName", true));
            this.FirstNameTextEdit.Location = new System.Drawing.Point(12, 46);
            this.FirstNameTextEdit.Name = "FirstNameTextEdit";
            this.FirstNameTextEdit.Parmida_ActivePlusMultiKeys = false;
            this.FirstNameTextEdit.Properties.MaxLength = 50;
            this.FirstNameTextEdit.Size = new System.Drawing.Size(180, 30);
            this.FirstNameTextEdit.StyleController = this.dataLayoutControl1;
            this.FirstNameTextEdit.TabIndex = 0;
            // 
            // LastNameTextEdit
            // 
            this.LastNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.driversBindingSource, "LastName", true));
            this.LastNameTextEdit.Location = new System.Drawing.Point(12, 80);
            this.LastNameTextEdit.Name = "LastNameTextEdit";
            this.LastNameTextEdit.Parmida_ActivePlusMultiKeys = false;
            this.LastNameTextEdit.Properties.MaxLength = 50;
            this.LastNameTextEdit.Size = new System.Drawing.Size(180, 30);
            this.LastNameTextEdit.StyleController = this.dataLayoutControl1;
            this.LastNameTextEdit.TabIndex = 1;
            // 
            // PhoneNumberTextEdit
            // 
            this.PhoneNumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.driversBindingSource, "PhoneNumber", true));
            this.PhoneNumberTextEdit.Location = new System.Drawing.Point(12, 114);
            this.PhoneNumberTextEdit.Name = "PhoneNumberTextEdit";
            this.PhoneNumberTextEdit.Parmida_ActivePlusMultiKeys = false;
            this.PhoneNumberTextEdit.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.PhoneNumberTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PhoneNumberTextEdit.Properties.Mask.EditMask = "d";
            this.PhoneNumberTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.PhoneNumberTextEdit.Properties.MaxLength = 10;
            this.PhoneNumberTextEdit.Size = new System.Drawing.Size(180, 30);
            this.PhoneNumberTextEdit.StyleController = this.dataLayoutControl1;
            this.PhoneNumberTextEdit.TabIndex = 2;
            // 
            // SmartCartTextEdit
            // 
            this.SmartCartTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.driversBindingSource, "SmartCart", true));
            this.SmartCartTextEdit.Location = new System.Drawing.Point(12, 12);
            this.SmartCartTextEdit.Name = "SmartCartTextEdit";
            this.SmartCartTextEdit.Parmida_ActivePlusMultiKeys = false;
            this.SmartCartTextEdit.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.SmartCartTextEdit.Properties.Mask.EditMask = "N0";
            this.SmartCartTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.SmartCartTextEdit.Properties.ReadOnly = true;
            this.SmartCartTextEdit.Size = new System.Drawing.Size(180, 30);
            this.SmartCartTextEdit.StyleController = this.dataLayoutControl1;
            this.SmartCartTextEdit.TabIndex = 8;
            // 
            // TagNumberTextEdit
            // 
            this.TagNumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.driversBindingSource, "TagNumber", true));
            this.TagNumberTextEdit.Location = new System.Drawing.Point(70, 182);
            this.TagNumberTextEdit.Name = "TagNumberTextEdit";
            this.TagNumberTextEdit.Parmida_ActivePlusMultiKeys = false;
            this.TagNumberTextEdit.Properties.Mask.EditMask = "\\d{0,5}";
            this.TagNumberTextEdit.Properties.MaxLength = 6;
            this.TagNumberTextEdit.Size = new System.Drawing.Size(122, 30);
            this.TagNumberTextEdit.StyleController = this.dataLayoutControl1;
            this.TagNumberTextEdit.TabIndex = 4;
            // 
            // TagTextEdit
            // 
            this.TagTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.driversBindingSource, "Tag", true));
            this.TagTextEdit.Location = new System.Drawing.Point(142, 148);
            this.TagTextEdit.Name = "TagTextEdit";
            this.TagTextEdit.Parmida_ActivePlusMultiKeys = false;
            this.TagTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.TagTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.TagTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TagTextEdit.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.TagTextEdit.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.TagTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TagTextEdit.Properties.Mask.EditMask = "d";
            this.TagTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TagTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TagTextEdit.Properties.MaxLength = 2;
            this.TagTextEdit.Size = new System.Drawing.Size(50, 30);
            this.TagTextEdit.StyleController = this.dataLayoutControl1;
            this.TagTextEdit.TabIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.Font = new System.Drawing.Font("B Yekan", 12F);
            this.layoutControlGroup1.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("B Yekan", 12F);
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(290, 575);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.ItemForSmartCart,
            this.ItemForPhoneNumber,
            this.ItemForFirstName,
            this.ItemForLastName,
            this.ItemForTag,
            this.ItemForTagNumber,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(270, 555);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnsave;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 204);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(270, 35);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ItemForSmartCart
            // 
            this.ItemForSmartCart.Control = this.SmartCartTextEdit;
            this.ItemForSmartCart.Location = new System.Drawing.Point(0, 0);
            this.ItemForSmartCart.Name = "ItemForSmartCart";
            this.ItemForSmartCart.Size = new System.Drawing.Size(270, 34);
            this.ItemForSmartCart.Text = "کارت هوشمند";
            this.ItemForSmartCart.TextSize = new System.Drawing.Size(83, 24);
            // 
            // ItemForPhoneNumber
            // 
            this.ItemForPhoneNumber.Control = this.PhoneNumberTextEdit;
            this.ItemForPhoneNumber.Location = new System.Drawing.Point(0, 102);
            this.ItemForPhoneNumber.Name = "ItemForPhoneNumber";
            this.ItemForPhoneNumber.Size = new System.Drawing.Size(270, 34);
            this.ItemForPhoneNumber.Text = "تلفن همراه";
            this.ItemForPhoneNumber.TextSize = new System.Drawing.Size(83, 24);
            // 
            // ItemForFirstName
            // 
            this.ItemForFirstName.Control = this.FirstNameTextEdit;
            this.ItemForFirstName.Location = new System.Drawing.Point(0, 34);
            this.ItemForFirstName.Name = "ItemForFirstName";
            this.ItemForFirstName.Size = new System.Drawing.Size(270, 34);
            this.ItemForFirstName.Text = "نام";
            this.ItemForFirstName.TextSize = new System.Drawing.Size(83, 24);
            // 
            // ItemForLastName
            // 
            this.ItemForLastName.Control = this.LastNameTextEdit;
            this.ItemForLastName.Location = new System.Drawing.Point(0, 68);
            this.ItemForLastName.Name = "ItemForLastName";
            this.ItemForLastName.Size = new System.Drawing.Size(270, 34);
            this.ItemForLastName.Text = "نام خانوادگی";
            this.ItemForLastName.TextSize = new System.Drawing.Size(83, 24);
            // 
            // ItemForTag
            // 
            this.ItemForTag.Control = this.TagTextEdit;
            this.ItemForTag.Location = new System.Drawing.Point(130, 136);
            this.ItemForTag.Name = "ItemForTag";
            this.ItemForTag.Size = new System.Drawing.Size(140, 34);
            this.ItemForTag.Text = "ایران";
            this.ItemForTag.TextSize = new System.Drawing.Size(83, 24);
            // 
            // ItemForTagNumber
            // 
            this.ItemForTagNumber.Control = this.TagNumberTextEdit;
            this.ItemForTagNumber.Location = new System.Drawing.Point(58, 170);
            this.ItemForTagNumber.Name = "ItemForTagNumber";
            this.ItemForTagNumber.Size = new System.Drawing.Size(212, 34);
            this.ItemForTagNumber.Text = "پلاک";
            this.ItemForTagNumber.TextSize = new System.Drawing.Size(83, 24);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 239);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(270, 316);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 136);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(130, 34);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 170);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(58, 34);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FrmMembershipList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 636);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMembershipList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "لیست اعضاء اتحادیه";
            this.Load += new System.EventHandler(this.FrmMembershipList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmartCartTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TagNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TagTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSmartCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTagNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colTagNumber;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit FirstNameTextEdit;
        private DevExpress.XtraEditors.TextEdit LastNameTextEdit;
        private DevExpress.XtraEditors.TextEdit PhoneNumberTextEdit;
        private DevExpress.XtraEditors.TextEdit SmartCartTextEdit;
        private DevExpress.XtraEditors.TextEdit TagNumberTextEdit;
        private DevExpress.XtraEditors.TextEdit TagTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLastName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhoneNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSmartCart;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTagNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTag;
        private DevExpress.XtraEditors.SimpleButton btnsave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFirstName;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colSmartCart;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}