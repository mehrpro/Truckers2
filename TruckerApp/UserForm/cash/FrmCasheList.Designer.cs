﻿namespace TruckerApp.UserForm.cash
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
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalCash = new DevExpress.XtraEditors.TextEdit();
            this.txtOtherType = new DevExpress.XtraEditors.TextEdit();
            this.txtAhakPackat = new DevExpress.XtraEditors.TextEdit();
            this.txtAhakFaleh = new DevExpress.XtraEditors.TextEdit();
            this.txtClinker = new DevExpress.XtraEditors.TextEdit();
            this.txtGandom = new DevExpress.XtraEditors.TextEdit();
            this.txtPOS = new DevExpress.XtraEditors.TextEdit();
            this.txtSerial = new DevExpress.XtraEditors.TextEdit();
            this.txtDate = new DevExpress.XtraEditors.TextEdit();
            this.txtFalaeh = new DevExpress.XtraEditors.TextEdit();
            this.txtCash = new DevExpress.XtraEditors.TextEdit();
            this.txtPacket = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalCash.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtherType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAhakPackat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAhakFaleh.Properties)).BeginInit();
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
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = global::TruckerApp.Properties.Resources.icons8_cash_receipt_48;
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(950, 535);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "صندوق";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cashesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(2, 59);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(639, 474);
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
            this.gridView1.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridView1.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Empty.Options.UseTextOptions = true;
            this.gridView1.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView1.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridView1.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colFamily,
            this.colSmartCart,
            this.colType,
            this.colCasher,
            this.colQueue,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.DetailHeight = 458;
            this.gridView1.FixedLineWidth = 3;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colType, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colQueue, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colName
            // 
            this.colName.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colName.Caption = "نام";
            this.colName.FieldName = "Queue.Driver.LastName";
            this.colName.MinWidth = 23;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 87;
            // 
            // colFamily
            // 
            this.colFamily.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colFamily.Caption = "فامیلی";
            this.colFamily.FieldName = "Queue.Driver.FirstName";
            this.colFamily.MinWidth = 23;
            this.colFamily.Name = "colFamily";
            this.colFamily.Visible = true;
            this.colFamily.VisibleIndex = 1;
            this.colFamily.Width = 87;
            // 
            // colSmartCart
            // 
            this.colSmartCart.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colSmartCart.Caption = "کارت هوشمند";
            this.colSmartCart.FieldName = "Queue.Driver.SmartCart";
            this.colSmartCart.MinWidth = 23;
            this.colSmartCart.Name = "colSmartCart";
            this.colSmartCart.Visible = true;
            this.colSmartCart.VisibleIndex = 2;
            this.colSmartCart.Width = 87;
            // 
            // colType
            // 
            this.colType.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colType.Caption = "محموله";
            this.colType.FieldName = "Queue.LoadType.Type";
            this.colType.MinWidth = 23;
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 3;
            this.colType.Width = 87;
            // 
            // colCasher
            // 
            this.colCasher.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colCasher.Caption = "صندوقدار";
            this.colCasher.FieldName = "User.LastName";
            this.colCasher.MinWidth = 23;
            this.colCasher.Name = "colCasher";
            this.colCasher.Visible = true;
            this.colCasher.VisibleIndex = 4;
            this.colCasher.Width = 87;
            // 
            // colQueue
            // 
            this.colQueue.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colQueue.Caption = "نوبت";
            this.colQueue.FieldName = "Queue.Number";
            this.colQueue.MinWidth = 23;
            this.colQueue.Name = "colQueue";
            this.colQueue.Visible = true;
            this.colQueue.VisibleIndex = 5;
            this.colQueue.Width = 87;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.gridColumn1.Caption = "وجه نقد";
            this.gridColumn1.FieldName = "CashDesk";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 87;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.gridColumn2.Caption = "کارت اعتباری";
            this.gridColumn2.FieldName = "Pos";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            this.gridColumn2.Width = 87;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.simpleButton9);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.labelControl10);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl12);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.txtTotalCash);
            this.panelControl1.Controls.Add(this.txtOtherType);
            this.panelControl1.Controls.Add(this.txtAhakPackat);
            this.panelControl1.Controls.Add(this.txtAhakFaleh);
            this.panelControl1.Controls.Add(this.txtClinker);
            this.panelControl1.Controls.Add(this.txtGandom);
            this.panelControl1.Controls.Add(this.txtPOS);
            this.panelControl1.Controls.Add(this.txtSerial);
            this.panelControl1.Controls.Add(this.txtDate);
            this.panelControl1.Controls.Add(this.txtFalaeh);
            this.panelControl1.Controls.Add(this.txtCash);
            this.panelControl1.Controls.Add(this.txtPacket);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(641, 59);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(307, 474);
            this.panelControl1.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(27, 413);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 50);
            this.simpleButton1.TabIndex = 24;
            this.simpleButton1.Text = "خروج";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton9
            // 
            this.simpleButton9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton9.ImageOptions.Image")));
            this.simpleButton9.Location = new System.Drawing.Point(133, 413);
            this.simpleButton9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(100, 50);
            this.simpleButton9.TabIndex = 24;
            this.simpleButton9.Text = "چاپ";
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl9.Location = new System.Drawing.Point(192, 340);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(24, 17);
            this.labelControl9.TabIndex = 23;
            this.labelControl9.Text = "POS";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(192, 84);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(18, 17);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "فله";
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Location = new System.Drawing.Point(192, 371);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(39, 17);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "مجموع";
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl10.Location = new System.Drawing.Point(192, 276);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(23, 17);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "سایر";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Location = new System.Drawing.Point(192, 244);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 17);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "آهک پاکت";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(192, 212);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 17);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "آهک فله";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(192, 180);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 17);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "کلینکر";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(192, 148);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 17);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "غلات";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Location = new System.Drawing.Point(192, 308);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 17);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "صندوق";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(191, 116);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 17);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "پاکت";
            // 
            // labelControl12
            // 
            this.labelControl12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl12.Location = new System.Drawing.Point(192, 20);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(25, 17);
            this.labelControl12.TabIndex = 16;
            this.labelControl12.Text = "تاریخ";
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl11.Location = new System.Drawing.Point(191, 51);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(69, 17);
            this.labelControl11.TabIndex = 14;
            this.labelControl11.Text = "سریال فروش";
            // 
            // txtTotalCash
            // 
            this.txtTotalCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalCash.EditValue = "";
            this.txtTotalCash.Location = new System.Drawing.Point(27, 368);
            this.txtTotalCash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalCash.Name = "txtTotalCash";
            this.txtTotalCash.Parmida_ActivePlusMultiKeys = false;
            this.txtTotalCash.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalCash.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalCash.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtTotalCash.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtTotalCash.Properties.ReadOnly = true;
            this.txtTotalCash.Size = new System.Drawing.Size(159, 24);
            this.txtTotalCash.TabIndex = 11;
            // 
            // txtOtherType
            // 
            this.txtOtherType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherType.EditValue = "";
            this.txtOtherType.Location = new System.Drawing.Point(27, 272);
            this.txtOtherType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOtherType.Name = "txtOtherType";
            this.txtOtherType.Parmida_ActivePlusMultiKeys = false;
            this.txtOtherType.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtOtherType.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtOtherType.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtOtherType.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtOtherType.Properties.ReadOnly = true;
            this.txtOtherType.Size = new System.Drawing.Size(159, 24);
            this.txtOtherType.TabIndex = 9;
            // 
            // txtAhakPackat
            // 
            this.txtAhakPackat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAhakPackat.EditValue = "";
            this.txtAhakPackat.Location = new System.Drawing.Point(27, 240);
            this.txtAhakPackat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAhakPackat.Name = "txtAhakPackat";
            this.txtAhakPackat.Parmida_ActivePlusMultiKeys = false;
            this.txtAhakPackat.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAhakPackat.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtAhakPackat.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtAhakPackat.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtAhakPackat.Properties.ReadOnly = true;
            this.txtAhakPackat.Size = new System.Drawing.Size(159, 24);
            this.txtAhakPackat.TabIndex = 9;
            // 
            // txtAhakFaleh
            // 
            this.txtAhakFaleh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAhakFaleh.EditValue = "";
            this.txtAhakFaleh.Location = new System.Drawing.Point(27, 208);
            this.txtAhakFaleh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAhakFaleh.Name = "txtAhakFaleh";
            this.txtAhakFaleh.Parmida_ActivePlusMultiKeys = false;
            this.txtAhakFaleh.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAhakFaleh.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtAhakFaleh.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtAhakFaleh.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtAhakFaleh.Properties.ReadOnly = true;
            this.txtAhakFaleh.Size = new System.Drawing.Size(159, 24);
            this.txtAhakFaleh.TabIndex = 9;
            // 
            // txtClinker
            // 
            this.txtClinker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClinker.EditValue = "";
            this.txtClinker.Location = new System.Drawing.Point(27, 176);
            this.txtClinker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClinker.Name = "txtClinker";
            this.txtClinker.Parmida_ActivePlusMultiKeys = false;
            this.txtClinker.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtClinker.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtClinker.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtClinker.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtClinker.Properties.ReadOnly = true;
            this.txtClinker.Size = new System.Drawing.Size(159, 24);
            this.txtClinker.TabIndex = 9;
            // 
            // txtGandom
            // 
            this.txtGandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGandom.EditValue = "";
            this.txtGandom.Location = new System.Drawing.Point(27, 144);
            this.txtGandom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGandom.Name = "txtGandom";
            this.txtGandom.Parmida_ActivePlusMultiKeys = false;
            this.txtGandom.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtGandom.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtGandom.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtGandom.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtGandom.Properties.ReadOnly = true;
            this.txtGandom.Size = new System.Drawing.Size(159, 24);
            this.txtGandom.TabIndex = 9;
            // 
            // txtPOS
            // 
            this.txtPOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPOS.EditValue = "";
            this.txtPOS.Location = new System.Drawing.Point(27, 336);
            this.txtPOS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPOS.Name = "txtPOS";
            this.txtPOS.Parmida_ActivePlusMultiKeys = false;
            this.txtPOS.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPOS.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtPOS.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtPOS.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtPOS.Properties.ReadOnly = true;
            this.txtPOS.Size = new System.Drawing.Size(159, 24);
            this.txtPOS.TabIndex = 8;
            // 
            // txtSerial
            // 
            this.txtSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerial.EditValue = "";
            this.txtSerial.Location = new System.Drawing.Point(27, 48);
            this.txtSerial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Parmida_ActivePlusMultiKeys = false;
            this.txtSerial.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSerial.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtSerial.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtSerial.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtSerial.Properties.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(159, 24);
            this.txtSerial.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.EditValue = "";
            this.txtDate.Location = new System.Drawing.Point(27, 16);
            this.txtDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Parmida_ActivePlusMultiKeys = false;
            this.txtDate.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDate.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtDate.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtDate.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtDate.Properties.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(159, 24);
            this.txtDate.TabIndex = 5;
            // 
            // txtFalaeh
            // 
            this.txtFalaeh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFalaeh.EditValue = "";
            this.txtFalaeh.Location = new System.Drawing.Point(27, 80);
            this.txtFalaeh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFalaeh.Name = "txtFalaeh";
            this.txtFalaeh.Parmida_ActivePlusMultiKeys = false;
            this.txtFalaeh.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFalaeh.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtFalaeh.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtFalaeh.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtFalaeh.Properties.ReadOnly = true;
            this.txtFalaeh.Size = new System.Drawing.Size(159, 24);
            this.txtFalaeh.TabIndex = 4;
            // 
            // txtCash
            // 
            this.txtCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCash.EditValue = "";
            this.txtCash.Location = new System.Drawing.Point(27, 304);
            this.txtCash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCash.Name = "txtCash";
            this.txtCash.Parmida_ActivePlusMultiKeys = false;
            this.txtCash.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCash.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtCash.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtCash.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtCash.Properties.ReadOnly = true;
            this.txtCash.Size = new System.Drawing.Size(159, 24);
            this.txtCash.TabIndex = 12;
            // 
            // txtPacket
            // 
            this.txtPacket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPacket.EditValue = "";
            this.txtPacket.Location = new System.Drawing.Point(27, 112);
            this.txtPacket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPacket.Name = "txtPacket";
            this.txtPacket.Parmida_ActivePlusMultiKeys = false;
            this.txtPacket.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPacket.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtPacket.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtPacket.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtPacket.Properties.ReadOnly = true;
            this.txtPacket.Size = new System.Drawing.Size(159, 24);
            this.txtPacket.TabIndex = 2;
            // 
            // FrmCasheList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 535);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCasheList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "گزارش صندوق";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            ((System.ComponentModel.ISupportInitialize)(this.txtOtherType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAhakPackat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAhakFaleh.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtOtherType;
        private DevExpress.XtraEditors.TextEdit txtAhakPackat;
        private DevExpress.XtraEditors.TextEdit txtAhakFaleh;
    }
}