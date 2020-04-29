﻿namespace TruckerApp.UserForm
{
    partial class FrmCasheList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCasheList));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cashesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFamily = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSmartCart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCasher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQueue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalCash = new DevExpress.XtraEditors.TextEdit();
            this.txtClinker = new DevExpress.XtraEditors.TextEdit();
            this.txtGandom = new DevExpress.XtraEditors.TextEdit();
            this.txtPOS = new DevExpress.XtraEditors.TextEdit();
            this.txtSerial = new DevExpress.XtraEditors.TextEdit();
            this.txtDate = new DevExpress.XtraEditors.TextEdit();
            this.txtFalaeh = new DevExpress.XtraEditors.TextEdit();
            this.txtCash = new DevExpress.XtraEditors.TextEdit();
            this.txtPacket = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalCash.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClinker.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGandom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPOS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFalaeh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCash.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPacket.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("B Yekan", 16F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImage = global::TruckerApp.Properties.Resources.icons8_cash_receipt_48;
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1107, 643);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "صندوق";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cashesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 238);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1103, 403);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cashesBindingSource
            // 
            this.cashesBindingSource.DataSource = typeof(TruckerApp.Cash);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.colName,
            this.colFamily,
            this.colSmartCart,
            this.colType,
            this.colCasher,
            this.colQueue,
            this.colUser,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colName
            // 
            this.colName.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colName.Caption = "نام";
            this.colName.FieldName = "Queue.Driver.LastName";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colFamily
            // 
            this.colFamily.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colFamily.Caption = "فامیلی";
            this.colFamily.FieldName = "Queue.Driver.FirstName";
            this.colFamily.Name = "colFamily";
            this.colFamily.Visible = true;
            this.colFamily.VisibleIndex = 1;
            // 
            // colSmartCart
            // 
            this.colSmartCart.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colSmartCart.Caption = "کارت هوشمند";
            this.colSmartCart.FieldName = "Queue.Driver.SmartCart";
            this.colSmartCart.Name = "colSmartCart";
            this.colSmartCart.Visible = true;
            this.colSmartCart.VisibleIndex = 2;
            // 
            // colType
            // 
            this.colType.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colType.Caption = "محموله";
            this.colType.FieldName = "Queue.LoadType.Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 3;
            // 
            // colCasher
            // 
            this.colCasher.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colCasher.Caption = "صندوقدار";
            this.colCasher.FieldName = "User.username";
            this.colCasher.Name = "colCasher";
            this.colCasher.Visible = true;
            this.colCasher.VisibleIndex = 4;
            // 
            // colQueue
            // 
            this.colQueue.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colQueue.Caption = "نوبت";
            this.colQueue.FieldName = "Queue.Number";
            this.colQueue.Name = "colQueue";
            this.colQueue.Visible = true;
            this.colQueue.VisibleIndex = 5;
            // 
            // colUser
            // 
            this.colUser.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colUser.Caption = "کمیسیون";
            this.colUser.FieldName = "Queue.Commission.Commission1";
            this.colUser.Name = "colUser";
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 6;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.gridColumn1.Caption = "وجه نقد";
            this.gridColumn1.FieldName = "CashDesk";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.gridColumn2.Caption = "کارت اعتباری";
            this.gridColumn2.FieldName = "Pos";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 8;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.simpleButton9);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl12);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.txtTotalCash);
            this.panelControl1.Controls.Add(this.txtClinker);
            this.panelControl1.Controls.Add(this.txtGandom);
            this.panelControl1.Controls.Add(this.txtPOS);
            this.panelControl1.Controls.Add(this.txtSerial);
            this.panelControl1.Controls.Add(this.txtDate);
            this.panelControl1.Controls.Add(this.txtFalaeh);
            this.panelControl1.Controls.Add(this.txtCash);
            this.panelControl1.Controls.Add(this.txtPacket);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 55);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1103, 183);
            this.panelControl1.TabIndex = 2;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // simpleButton9
            // 
            this.simpleButton9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton9.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.simpleButton9.Appearance.Options.UseFont = true;
            this.simpleButton9.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton9.Image")));
            this.simpleButton9.Location = new System.Drawing.Point(108, 109);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(133, 53);
            this.simpleButton9.TabIndex = 24;
            this.simpleButton9.Text = "چاپ";
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl9.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl9.Location = new System.Drawing.Point(464, 63);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(35, 24);
            this.labelControl9.TabIndex = 23;
            this.labelControl9.Text = "POS";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl3.Location = new System.Drawing.Point(719, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 24);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "فله";
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl8.Location = new System.Drawing.Point(464, 99);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(38, 24);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "مجموع";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl1.Location = new System.Drawing.Point(719, 135);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 24);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "کلینکر";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl5.Location = new System.Drawing.Point(719, 99);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 24);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "غلات";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl7.Location = new System.Drawing.Point(464, 27);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(43, 24);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "صندوق";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl4.Location = new System.Drawing.Point(718, 27);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 24);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "پاکت";
            // 
            // labelControl12
            // 
            this.labelControl12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl12.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl12.Location = new System.Drawing.Point(970, 27);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(30, 24);
            this.labelControl12.TabIndex = 16;
            this.labelControl12.Text = "تاریخ";
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl11.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl11.Location = new System.Drawing.Point(970, 63);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(81, 24);
            this.labelControl11.TabIndex = 14;
            this.labelControl11.Text = "سریال فروش";
            // 
            // txtTotalCash
            // 
            this.txtTotalCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalCash.EditValue = "";
            this.txtTotalCash.Location = new System.Drawing.Point(289, 96);
            this.txtTotalCash.Name = "txtTotalCash";
            this.txtTotalCash.Parmida_ActivePlusMultiKeys = false;
            this.txtTotalCash.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtTotalCash.Properties.Appearance.Options.UseFont = true;
            this.txtTotalCash.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalCash.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtTotalCash.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalCash.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtTotalCash.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtTotalCash.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtTotalCash.Properties.ReadOnly = true;
            this.txtTotalCash.Size = new System.Drawing.Size(169, 30);
            this.txtTotalCash.TabIndex = 11;
            // 
            // txtClinker
            // 
            this.txtClinker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClinker.EditValue = "";
            this.txtClinker.Location = new System.Drawing.Point(613, 132);
            this.txtClinker.Name = "txtClinker";
            this.txtClinker.Parmida_ActivePlusMultiKeys = false;
            this.txtClinker.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtClinker.Properties.Appearance.Options.UseFont = true;
            this.txtClinker.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtClinker.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtClinker.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtClinker.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtClinker.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtClinker.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtClinker.Properties.ReadOnly = true;
            this.txtClinker.Size = new System.Drawing.Size(100, 30);
            this.txtClinker.TabIndex = 9;
            // 
            // txtGandom
            // 
            this.txtGandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGandom.EditValue = "";
            this.txtGandom.Location = new System.Drawing.Point(613, 96);
            this.txtGandom.Name = "txtGandom";
            this.txtGandom.Parmida_ActivePlusMultiKeys = false;
            this.txtGandom.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtGandom.Properties.Appearance.Options.UseFont = true;
            this.txtGandom.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtGandom.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtGandom.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtGandom.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtGandom.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtGandom.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtGandom.Properties.ReadOnly = true;
            this.txtGandom.Size = new System.Drawing.Size(100, 30);
            this.txtGandom.TabIndex = 9;
            // 
            // txtPOS
            // 
            this.txtPOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPOS.EditValue = "";
            this.txtPOS.Location = new System.Drawing.Point(289, 60);
            this.txtPOS.Name = "txtPOS";
            this.txtPOS.Parmida_ActivePlusMultiKeys = false;
            this.txtPOS.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtPOS.Properties.Appearance.Options.UseFont = true;
            this.txtPOS.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPOS.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtPOS.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtPOS.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtPOS.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtPOS.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtPOS.Properties.ReadOnly = true;
            this.txtPOS.Size = new System.Drawing.Size(169, 30);
            this.txtPOS.TabIndex = 8;
            // 
            // txtSerial
            // 
            this.txtSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerial.EditValue = "";
            this.txtSerial.Location = new System.Drawing.Point(819, 60);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Parmida_ActivePlusMultiKeys = false;
            this.txtSerial.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtSerial.Properties.Appearance.Options.UseFont = true;
            this.txtSerial.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSerial.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtSerial.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtSerial.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtSerial.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtSerial.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtSerial.Properties.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(145, 30);
            this.txtSerial.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.EditValue = "";
            this.txtDate.Location = new System.Drawing.Point(819, 24);
            this.txtDate.Name = "txtDate";
            this.txtDate.Parmida_ActivePlusMultiKeys = false;
            this.txtDate.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtDate.Properties.Appearance.Options.UseFont = true;
            this.txtDate.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDate.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtDate.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtDate.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtDate.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtDate.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtDate.Properties.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(145, 30);
            this.txtDate.TabIndex = 5;
            // 
            // txtFalaeh
            // 
            this.txtFalaeh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFalaeh.EditValue = "";
            this.txtFalaeh.Location = new System.Drawing.Point(613, 60);
            this.txtFalaeh.Name = "txtFalaeh";
            this.txtFalaeh.Parmida_ActivePlusMultiKeys = false;
            this.txtFalaeh.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtFalaeh.Properties.Appearance.Options.UseFont = true;
            this.txtFalaeh.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFalaeh.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtFalaeh.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtFalaeh.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtFalaeh.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtFalaeh.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtFalaeh.Properties.ReadOnly = true;
            this.txtFalaeh.Size = new System.Drawing.Size(100, 30);
            this.txtFalaeh.TabIndex = 4;
            // 
            // txtCash
            // 
            this.txtCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCash.EditValue = "";
            this.txtCash.Location = new System.Drawing.Point(289, 24);
            this.txtCash.Name = "txtCash";
            this.txtCash.Parmida_ActivePlusMultiKeys = false;
            this.txtCash.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtCash.Properties.Appearance.Options.UseFont = true;
            this.txtCash.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCash.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtCash.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtCash.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtCash.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtCash.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtCash.Properties.ReadOnly = true;
            this.txtCash.Size = new System.Drawing.Size(169, 30);
            this.txtCash.TabIndex = 12;
            // 
            // txtPacket
            // 
            this.txtPacket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPacket.EditValue = "";
            this.txtPacket.Location = new System.Drawing.Point(613, 24);
            this.txtPacket.Name = "txtPacket";
            this.txtPacket.Parmida_ActivePlusMultiKeys = false;
            this.txtPacket.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtPacket.Properties.Appearance.Options.UseFont = true;
            this.txtPacket.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPacket.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtPacket.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtPacket.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtPacket.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtPacket.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtPacket.Properties.ReadOnly = true;
            this.txtPacket.Size = new System.Drawing.Size(100, 30);
            this.txtPacket.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(-31, 109);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(133, 53);
            this.simpleButton1.TabIndex = 24;
            this.simpleButton1.Text = "خروج";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmCasheList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 643);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmCasheList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "گزارش صندوق";
            this.Load += new System.EventHandler(this.FrmCasheList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalCash.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClinker.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGandom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPOS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFalaeh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCash.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPacket.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource cashesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colFamily;
        private DevExpress.XtraGrid.Columns.GridColumn colSmartCart;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colCasher;
        private DevExpress.XtraGrid.Columns.GridColumn colQueue;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtGandom;
        private DevExpress.XtraEditors.TextEdit txtPOS;
        private DevExpress.XtraEditors.TextEdit txtSerial;
        private DevExpress.XtraEditors.TextEdit txtDate;
        private DevExpress.XtraEditors.TextEdit txtFalaeh;
        private DevExpress.XtraEditors.TextEdit txtCash;
        private DevExpress.XtraEditors.TextEdit txtPacket;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtClinker;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtTotalCash;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}