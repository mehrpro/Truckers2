namespace TruckerApp.UserForm.Fish
{
    partial class FrmResid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResid));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbxListNumber = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbxSerial = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSereisID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriesName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.queuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxListNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSerial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queuesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("B Yekan", 16F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(782, 403);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "رسید حواله فروش";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 120);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(778, 281);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.gridColumn2,
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.gridColumn2.Caption = "سریال فروش";
            this.gridColumn2.FieldName = "Serial";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.gridColumn1.Caption = "شماره نوبت";
            this.gridColumn1.FieldName = "Number";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.gridColumn3.Caption = "نام";
            this.gridColumn3.FieldName = "Name";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.gridColumn4.Caption = "پلاک";
            this.gridColumn4.FieldName = "Tag";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.gridColumn5.Caption = "تاریخ";
            this.gridColumn5.FieldName = "Date";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbxListNumber);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cbxSerial);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 39);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(778, 81);
            this.panelControl1.TabIndex = 0;
            // 
            // cbxListNumber
            // 
            this.cbxListNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxListNumber.EditValue = "";
            this.cbxListNumber.Location = new System.Drawing.Point(152, 25);
            this.cbxListNumber.Name = "cbxListNumber";
            this.cbxListNumber.Parmida_ActivePlusMultiKeys = false;
            this.cbxListNumber.Properties.AllowMultiSelect = true;
            this.cbxListNumber.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.cbxListNumber.Properties.Appearance.Options.UseFont = true;
            this.cbxListNumber.Properties.AppearanceDisabled.Font = new System.Drawing.Font("B Yekan", 12F);
            this.cbxListNumber.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cbxListNumber.Properties.AppearanceDropDown.Font = new System.Drawing.Font("B Yekan", 12F);
            this.cbxListNumber.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxListNumber.Properties.AppearanceFocused.Font = new System.Drawing.Font("B Yekan", 12F);
            this.cbxListNumber.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbxListNumber.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("B Yekan", 12F);
            this.cbxListNumber.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cbxListNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxListNumber.Size = new System.Drawing.Size(337, 30);
            this.cbxListNumber.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.labelControl1.Location = new System.Drawing.Point(671, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "سریال فروش";
            // 
            // cbxSerial
            // 
            this.cbxSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSerial.Location = new System.Drawing.Point(510, 25);
            this.cbxSerial.Name = "cbxSerial";
            this.cbxSerial.Parmida_ActivePlusMultiKeys = false;
            this.cbxSerial.Properties.Appearance.Font = new System.Drawing.Font("B Yekan", 12F);
            this.cbxSerial.Properties.Appearance.Options.UseFont = true;
            this.cbxSerial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSerial.Properties.View = this.gridLookUpEdit1View;
            this.cbxSerial.Size = new System.Drawing.Size(155, 30);
            this.cbxSerial.TabIndex = 0;
            this.cbxSerial.EditValueChanged += new System.EventHandler(this.cbxSerial_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.DetailTip.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.DetailTip.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.Empty.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.Empty.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Empty.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.EvenRow.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.EvenRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.FilterCloseButton.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.FilterPanel.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.FilterPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.FixedLine.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.FixedLine.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.FocusedCell.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.FocusedCell.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.FocusedRow.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.FocusedRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.FooterPanel.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.FooterPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.GroupButton.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.GroupButton.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.GroupFooter.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.GroupFooter.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.GroupPanel.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.GroupPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.GroupRow.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.GroupRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.HideSelectionRow.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.HorzLine.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.HorzLine.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.OddRow.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.OddRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.Preview.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.Preview.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Preview.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Row.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.RowSeparator.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.RowSeparator.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.SelectedRow.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.SelectedRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.TopNewRow.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.TopNewRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.VertLine.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.VertLine.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.ViewCaption.Font = new System.Drawing.Font("B Yekan", 10F);
            this.gridLookUpEdit1View.Appearance.ViewCaption.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSereisID,
            this.colSeriesName,
            this.colDateStart});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colSereisID
            // 
            this.colSereisID.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colSereisID.Caption = "کد سیستم";
            this.colSereisID.FieldName = "SereisID";
            this.colSereisID.Name = "colSereisID";
            this.colSereisID.Visible = true;
            this.colSereisID.VisibleIndex = 0;
            // 
            // colSeriesName
            // 
            this.colSeriesName.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colSeriesName.Caption = "سریال فروش";
            this.colSeriesName.FieldName = "SeriesName";
            this.colSeriesName.Name = "colSeriesName";
            this.colSeriesName.Visible = true;
            this.colSeriesName.VisibleIndex = 1;
            // 
            // colDateStart
            // 
            this.colDateStart.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colDateStart.Caption = "تاریخ";
            this.colDateStart.FieldName = "SeriesDateStart";
            this.colDateStart.Name = "colDateStart";
            this.colDateStart.Visible = true;
            this.colDateStart.VisibleIndex = 2;
            // 
            // queuesBindingSource
            // 
            this.queuesBindingSource.DataSource = typeof(TruckerApp.Queue);
            // 
            // FrmResid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmResid";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "FrmResid";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxListNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSerial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queuesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit cbxSerial;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colSereisID;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriesName;
        private DevExpress.XtraGrid.Columns.GridColumn colDateStart;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbxListNumber;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource queuesBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}