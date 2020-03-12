namespace TruckerApp.UserForm
{
    partial class FrmSerial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSerial));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtDate = new DevExpress.XtraEditors.TextEdit();
            this.txtTime = new DevExpress.XtraEditors.TextEdit();
            this.btnNewSerial = new DevExpress.XtraEditors.SimpleButton();
            this.txtLastSerial = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsers = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.seriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSereisID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeries1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriesCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriesDateStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriesDateEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluserCreator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemToggleSwitch1 = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastSerial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("B Yekan", 16F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImage = global::TruckerApp.Properties.Resources.icons8_bookmark_48;
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(874, 482);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "سریال فروش";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtDate);
            this.panelControl1.Controls.Add(this.txtTime);
            this.panelControl1.Controls.Add(this.btnNewSerial);
            this.panelControl1.Controls.Add(this.txtLastSerial);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtUsers);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 55);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(870, 148);
            this.panelControl1.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.Location = new System.Drawing.Point(580, 33);
            this.txtDate.Name = "txtDate";
            this.txtDate.Parmida_ActivePlusMultiKeys = false;
            this.txtDate.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtDate.Properties.Appearance.Options.UseFont = true;
            this.txtDate.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtDate.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtDate.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtDate.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtDate.Properties.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(200, 30);
            this.txtDate.TabIndex = 0;
            // 
            // txtTime
            // 
            this.txtTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTime.Location = new System.Drawing.Point(580, 85);
            this.txtTime.Name = "txtTime";
            this.txtTime.Parmida_ActivePlusMultiKeys = false;
            this.txtTime.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtTime.Properties.Appearance.Options.UseFont = true;
            this.txtTime.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtTime.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtTime.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtTime.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtTime.Properties.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(200, 30);
            this.txtTime.TabIndex = 0;
            // 
            // btnNewSerial
            // 
            this.btnNewSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewSerial.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.btnNewSerial.Appearance.Options.UseFont = true;
            this.btnNewSerial.Image = ((System.Drawing.Image)(resources.GetObject("btnNewSerial.Image")));
            this.btnNewSerial.Location = new System.Drawing.Point(105, 64);
            this.btnNewSerial.Name = "btnNewSerial";
            this.btnNewSerial.Size = new System.Drawing.Size(134, 51);
            this.btnNewSerial.TabIndex = 2;
            this.btnNewSerial.Text = "سریال جدید";
            this.btnNewSerial.Click += new System.EventHandler(this.btnNewSerial_Click);
            // 
            // txtLastSerial
            // 
            this.txtLastSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastSerial.Location = new System.Drawing.Point(265, 33);
            this.txtLastSerial.Name = "txtLastSerial";
            this.txtLastSerial.Parmida_ActivePlusMultiKeys = false;
            this.txtLastSerial.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtLastSerial.Properties.Appearance.Options.UseFont = true;
            this.txtLastSerial.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtLastSerial.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtLastSerial.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtLastSerial.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtLastSerial.Properties.ReadOnly = true;
            this.txtLastSerial.Size = new System.Drawing.Size(207, 30);
            this.txtLastSerial.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl4.Location = new System.Drawing.Point(478, 88);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 24);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "صادر کننده";
            // 
            // txtUsers
            // 
            this.txtUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsers.Location = new System.Drawing.Point(265, 85);
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Parmida_ActivePlusMultiKeys = false;
            this.txtUsers.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtUsers.Properties.Appearance.Options.UseFont = true;
            this.txtUsers.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtUsers.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtUsers.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.txtUsers.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtUsers.Properties.ReadOnly = true;
            this.txtUsers.Size = new System.Drawing.Size(207, 30);
            this.txtUsers.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl3.Location = new System.Drawing.Point(478, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 24);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "سریال قبلی";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl1.Location = new System.Drawing.Point(786, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "تاریخ";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl2.Location = new System.Drawing.Point(786, 88);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 24);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "ساعت";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.seriesBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 209);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemToggleSwitch1});
            this.gridControl1.Size = new System.Drawing.Size(850, 261);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // seriesBindingSource
            // 
            this.seriesBindingSource.DataSource = typeof(TruckerApp.SeriesPrice);
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
            this.colSereisID,
            this.colSeries1,
            this.colSeriesCount,
            this.colSeriesDateStart,
            this.colSeriesDateEnd,
            this.coluserCreator});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSeries1, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colSereisID
            // 
            this.colSereisID.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colSereisID.Caption = "کد سیستم";
            this.colSereisID.FieldName = "SereisID";
            this.colSereisID.Name = "colSereisID";
            this.colSereisID.Visible = true;
            this.colSereisID.VisibleIndex = 0;
            this.colSereisID.Width = 74;
            // 
            // colSeries1
            // 
            this.colSeries1.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colSeries1.Caption = "سریال فروش";
            this.colSeries1.FieldName = "SeriesName";
            this.colSeries1.Name = "colSeries1";
            this.colSeries1.Visible = true;
            this.colSeries1.VisibleIndex = 1;
            this.colSeries1.Width = 121;
            // 
            // colSeriesCount
            // 
            this.colSeriesCount.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colSeriesCount.Caption = "تعداد فروش";
            this.colSeriesCount.FieldName = "SeriesCount";
            this.colSeriesCount.Name = "colSeriesCount";
            this.colSeriesCount.Visible = true;
            this.colSeriesCount.VisibleIndex = 2;
            this.colSeriesCount.Width = 138;
            // 
            // colSeriesDateStart
            // 
            this.colSeriesDateStart.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colSeriesDateStart.Caption = "زمان آغاز";
            this.colSeriesDateStart.DisplayFormat.FormatString = "d";
            this.colSeriesDateStart.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSeriesDateStart.FieldName = "SeriesDateStart";
            this.colSeriesDateStart.Name = "colSeriesDateStart";
            this.colSeriesDateStart.Visible = true;
            this.colSeriesDateStart.VisibleIndex = 3;
            this.colSeriesDateStart.Width = 173;
            // 
            // colSeriesDateEnd
            // 
            this.colSeriesDateEnd.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colSeriesDateEnd.Caption = "زمان پایان";
            this.colSeriesDateEnd.FieldName = "SeriesDateEnd";
            this.colSeriesDateEnd.Name = "colSeriesDateEnd";
            this.colSeriesDateEnd.Visible = true;
            this.colSeriesDateEnd.VisibleIndex = 4;
            this.colSeriesDateEnd.Width = 148;
            // 
            // coluserCreator
            // 
            this.coluserCreator.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.coluserCreator.Caption = "ایجاد کننده";
            this.coluserCreator.FieldName = "User.username";
            this.coluserCreator.Name = "coluserCreator";
            this.coluserCreator.Visible = true;
            this.coluserCreator.VisibleIndex = 5;
            this.coluserCreator.Width = 71;
            // 
            // repositoryItemToggleSwitch1
            // 
            this.repositoryItemToggleSwitch1.AutoHeight = false;
            this.repositoryItemToggleSwitch1.Name = "repositoryItemToggleSwitch1";
            this.repositoryItemToggleSwitch1.OffText = "بسته";
            this.repositoryItemToggleSwitch1.OnText = "باز";
            // 
            // FrmSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 482);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmSerial";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "سریال فروش";
            this.Load += new System.EventHandler(this.FrmSerial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastSerial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnNewSerial;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUsers;
        private DevExpress.XtraEditors.TextEdit txtLastSerial;
        private DevExpress.XtraEditors.TextEdit txtTime;
        private DevExpress.XtraEditors.TextEdit txtDate;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource seriesBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSereisID;
        private DevExpress.XtraGrid.Columns.GridColumn colSeries1;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriesCount;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriesDateStart;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriesDateEnd;
        private DevExpress.XtraGrid.Columns.GridColumn coluserCreator;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemToggleSwitch1;
    }
}