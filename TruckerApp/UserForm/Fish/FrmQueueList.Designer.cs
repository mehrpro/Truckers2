﻿namespace TruckerApp.UserForm
{
    partial class FrmQueueList
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtOther = new DevExpress.XtraEditors.TextEdit();
            this.txtClinker = new DevExpress.XtraEditors.TextEdit();
            this.txtOtherType = new DevExpress.XtraEditors.TextEdit();
            this.txtGandom = new DevExpress.XtraEditors.TextEdit();
            this.txtNoMember = new DevExpress.XtraEditors.TextEdit();
            this.txtDate = new DevExpress.XtraEditors.TextEdit();
            this.txtAhakfaleh = new DevExpress.XtraEditors.TextEdit();
            this.txtFalaeh = new DevExpress.XtraEditors.TextEdit();
            this.txtAhakPackat = new DevExpress.XtraEditors.TextEdit();
            this.txtMember = new DevExpress.XtraEditors.TextEdit();
            this.txtPacket = new DevExpress.XtraEditors.TextEdit();
            this.cbxSerial = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSeriesName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriesDateStart = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOther.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClinker.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtherType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGandom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoMember.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAhakfaleh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFalaeh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAhakPackat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMember.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPacket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSerial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = global::TruckerApp.Properties.Resources.icons8_list_48;
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1127, 534);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "دفتر روزانه";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 59);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(891, 473);
            this.panelControl2.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(887, 469);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.labelControl10);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl12);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.txtOther);
            this.panelControl1.Controls.Add(this.txtClinker);
            this.panelControl1.Controls.Add(this.txtOtherType);
            this.panelControl1.Controls.Add(this.txtGandom);
            this.panelControl1.Controls.Add(this.txtNoMember);
            this.panelControl1.Controls.Add(this.txtDate);
            this.panelControl1.Controls.Add(this.txtAhakfaleh);
            this.panelControl1.Controls.Add(this.txtFalaeh);
            this.panelControl1.Controls.Add(this.txtAhakPackat);
            this.panelControl1.Controls.Add(this.txtMember);
            this.panelControl1.Controls.Add(this.txtPacket);
            this.panelControl1.Controls.Add(this.cbxSerial);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(893, 59);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(232, 473);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl9.Location = new System.Drawing.Point(134, 121);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(49, 17);
            this.labelControl9.TabIndex = 1;
            this.labelControl9.Text = "غیر عضو";
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl10.Location = new System.Drawing.Point(134, 301);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(46, 17);
            this.labelControl10.TabIndex = 1;
            this.labelControl10.Text = "آهک فله";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(134, 181);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(18, 17);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "فله";
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Location = new System.Drawing.Point(134, 151);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(47, 17);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "غیربومی";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(134, 271);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "کلینکر";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Location = new System.Drawing.Point(134, 361);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 17);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "متفرقه";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(134, 241);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 17);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "غلات";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Location = new System.Drawing.Point(134, 91);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(32, 17);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "اعضاء";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(134, 331);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "آهک پاکت";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(134, 211);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 17);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "پاکت";
            // 
            // labelControl12
            // 
            this.labelControl12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl12.Location = new System.Drawing.Point(134, 61);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(25, 17);
            this.labelControl12.TabIndex = 1;
            this.labelControl12.Text = "تاریخ";
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl11.Location = new System.Drawing.Point(134, 31);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(69, 17);
            this.labelControl11.TabIndex = 1;
            this.labelControl11.Text = "سریال فروش";
            // 
            // txtOther
            // 
            this.txtOther.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOther.EditValue = "0";
            this.txtOther.Location = new System.Drawing.Point(28, 148);
            this.txtOther.Name = "txtOther";
            this.txtOther.Parmida_ActivePlusMultiKeys = false;
            this.txtOther.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtOther.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtOther.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtOther.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtOther.Properties.ReadOnly = true;
            this.txtOther.Size = new System.Drawing.Size(100, 24);
            this.txtOther.TabIndex = 0;
            // 
            // txtClinker
            // 
            this.txtClinker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClinker.EditValue = "0";
            this.txtClinker.Location = new System.Drawing.Point(28, 268);
            this.txtClinker.Name = "txtClinker";
            this.txtClinker.Parmida_ActivePlusMultiKeys = false;
            this.txtClinker.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtClinker.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtClinker.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtClinker.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtClinker.Properties.ReadOnly = true;
            this.txtClinker.Size = new System.Drawing.Size(100, 24);
            this.txtClinker.TabIndex = 0;
            // 
            // txtOtherType
            // 
            this.txtOtherType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherType.EditValue = "0";
            this.txtOtherType.Location = new System.Drawing.Point(28, 358);
            this.txtOtherType.Name = "txtOtherType";
            this.txtOtherType.Parmida_ActivePlusMultiKeys = false;
            this.txtOtherType.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtOtherType.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtOtherType.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtOtherType.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtOtherType.Properties.ReadOnly = true;
            this.txtOtherType.Size = new System.Drawing.Size(100, 24);
            this.txtOtherType.TabIndex = 0;
            // 
            // txtGandom
            // 
            this.txtGandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGandom.EditValue = "0";
            this.txtGandom.Location = new System.Drawing.Point(28, 238);
            this.txtGandom.Name = "txtGandom";
            this.txtGandom.Parmida_ActivePlusMultiKeys = false;
            this.txtGandom.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtGandom.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtGandom.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtGandom.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtGandom.Properties.ReadOnly = true;
            this.txtGandom.Size = new System.Drawing.Size(100, 24);
            this.txtGandom.TabIndex = 0;
            // 
            // txtNoMember
            // 
            this.txtNoMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoMember.EditValue = "0";
            this.txtNoMember.Location = new System.Drawing.Point(28, 118);
            this.txtNoMember.Name = "txtNoMember";
            this.txtNoMember.Parmida_ActivePlusMultiKeys = false;
            this.txtNoMember.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNoMember.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtNoMember.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtNoMember.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtNoMember.Properties.ReadOnly = true;
            this.txtNoMember.Size = new System.Drawing.Size(100, 24);
            this.txtNoMember.TabIndex = 0;
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.EditValue = "0";
            this.txtDate.Location = new System.Drawing.Point(28, 58);
            this.txtDate.Name = "txtDate";
            this.txtDate.Parmida_ActivePlusMultiKeys = false;
            this.txtDate.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtDate.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtDate.Properties.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(100, 24);
            this.txtDate.TabIndex = 0;
            // 
            // txtAhakfaleh
            // 
            this.txtAhakfaleh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAhakfaleh.EditValue = "0";
            this.txtAhakfaleh.Location = new System.Drawing.Point(28, 298);
            this.txtAhakfaleh.Name = "txtAhakfaleh";
            this.txtAhakfaleh.Parmida_ActivePlusMultiKeys = false;
            this.txtAhakfaleh.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAhakfaleh.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtAhakfaleh.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtAhakfaleh.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtAhakfaleh.Properties.ReadOnly = true;
            this.txtAhakfaleh.Size = new System.Drawing.Size(100, 24);
            this.txtAhakfaleh.TabIndex = 0;
            // 
            // txtFalaeh
            // 
            this.txtFalaeh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFalaeh.EditValue = "0";
            this.txtFalaeh.Location = new System.Drawing.Point(28, 178);
            this.txtFalaeh.Name = "txtFalaeh";
            this.txtFalaeh.Parmida_ActivePlusMultiKeys = false;
            this.txtFalaeh.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFalaeh.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtFalaeh.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtFalaeh.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtFalaeh.Properties.ReadOnly = true;
            this.txtFalaeh.Size = new System.Drawing.Size(100, 24);
            this.txtFalaeh.TabIndex = 0;
            // 
            // txtAhakPackat
            // 
            this.txtAhakPackat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAhakPackat.EditValue = "0";
            this.txtAhakPackat.Location = new System.Drawing.Point(28, 328);
            this.txtAhakPackat.Name = "txtAhakPackat";
            this.txtAhakPackat.Parmida_ActivePlusMultiKeys = false;
            this.txtAhakPackat.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAhakPackat.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtAhakPackat.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtAhakPackat.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtAhakPackat.Properties.ReadOnly = true;
            this.txtAhakPackat.Size = new System.Drawing.Size(100, 24);
            this.txtAhakPackat.TabIndex = 0;
            // 
            // txtMember
            // 
            this.txtMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMember.EditValue = "0";
            this.txtMember.Location = new System.Drawing.Point(28, 88);
            this.txtMember.Name = "txtMember";
            this.txtMember.Parmida_ActivePlusMultiKeys = false;
            this.txtMember.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMember.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtMember.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtMember.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtMember.Properties.ReadOnly = true;
            this.txtMember.Size = new System.Drawing.Size(100, 24);
            this.txtMember.TabIndex = 0;
            // 
            // txtPacket
            // 
            this.txtPacket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPacket.EditValue = "0";
            this.txtPacket.Location = new System.Drawing.Point(28, 208);
            this.txtPacket.Name = "txtPacket";
            this.txtPacket.Parmida_ActivePlusMultiKeys = false;
            this.txtPacket.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPacket.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.txtPacket.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtPacket.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtPacket.Properties.ReadOnly = true;
            this.txtPacket.Size = new System.Drawing.Size(100, 24);
            this.txtPacket.TabIndex = 0;
            // 
            // cbxSerial
            // 
            this.cbxSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSerial.EditValue = "[]";
            this.cbxSerial.Location = new System.Drawing.Point(28, 28);
            this.cbxSerial.Name = "cbxSerial";
            this.cbxSerial.Parmida_ActivePlusMultiKeys = false;
            this.cbxSerial.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxSerial.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxSerial.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxSerial.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbxSerial.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue;
            this.cbxSerial.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.cbxSerial.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.cbxSerial.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxSerial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSerial.Properties.NullText = "";
            this.cbxSerial.Properties.PopupFormSize = new System.Drawing.Size(450, 0);
            this.cbxSerial.Properties.PopupView = this.searchLookUpEdit1View;
            this.cbxSerial.Size = new System.Drawing.Size(100, 24);
            this.cbxSerial.TabIndex = 0;
            this.cbxSerial.EditValueChanged += new System.EventHandler(this.txtSerial_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.DetailTip.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.Empty.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.EvenRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FixedLine.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.GroupButton.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.GroupRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.HorzLine.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.OddRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.Preview.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.Row.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.VertLine.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSeriesName,
            this.colSeriesDateStart});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colSeriesName
            // 
            this.colSeriesName.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colSeriesName.Caption = "سریال فروش";
            this.colSeriesName.FieldName = "SeriesName";
            this.colSeriesName.Name = "colSeriesName";
            this.colSeriesName.Visible = true;
            this.colSeriesName.VisibleIndex = 0;
            this.colSeriesName.Width = 157;
            // 
            // colSeriesDateStart
            // 
            this.colSeriesDateStart.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colSeriesDateStart.Caption = "آغاز فروش";
            this.colSeriesDateStart.FieldName = "SeriesDateStart";
            this.colSeriesDateStart.Name = "colSeriesDateStart";
            this.colSeriesDateStart.Visible = true;
            this.colSeriesDateStart.VisibleIndex = 1;
            this.colSeriesDateStart.Width = 467;
            // 
            // FrmQueueList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 534);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmQueueList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "حواله های صادرشده";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOther.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClinker.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtherType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGandom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoMember.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAhakfaleh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFalaeh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAhakPackat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMember.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPacket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSerial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtOther;
        private DevExpress.XtraEditors.TextEdit txtGandom;
        private DevExpress.XtraEditors.TextEdit txtNoMember;
        private DevExpress.XtraEditors.TextEdit txtDate;
        private DevExpress.XtraEditors.TextEdit txtFalaeh;
        private DevExpress.XtraEditors.TextEdit txtMember;
        private DevExpress.XtraEditors.TextEdit txtPacket;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtClinker;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxSerial;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriesName;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriesDateStart;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtOtherType;
        private DevExpress.XtraEditors.TextEdit txtAhakfaleh;
        private DevExpress.XtraEditors.TextEdit txtAhakPackat;
    }
}