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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFishPrint));
            this.timer_process = new System.Windows.Forms.Timer(this.components);
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.txtTag = new DevExpress.XtraEditors.TextEdit();
            this.cbxCargoType = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtComossin = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.lblWH = new System.Windows.Forms.Label();
            this.picPlateLast = new System.Windows.Forms.PictureBox();
            this.Res4 = new System.Windows.Forms.Label();
            this.Res2 = new System.Windows.Forms.Label();
            this.Res3 = new System.Windows.Forms.Label();
            this.Res1 = new System.Windows.Forms.Label();
            this.btnPuse = new DevExpress.XtraEditors.SimpleButton();
            this.btnPlayVideo = new DevExpress.XtraEditors.SimpleButton();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectPlate = new DevExpress.XtraEditors.SimpleButton();
            this.picture = new System.Windows.Forms.PictureBox();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtserial = new DevExpress.XtraEditors.TextEdit();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtDateRegister = new DevExpress.XtraEditors.TextEdit();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtTagNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtHosmand = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.chkMandeh = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCargoType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComossin.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMandeh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_process
            // 
            this.timer_process.Tick += new System.EventHandler(this.timer_process_Tick);
            // 
            // txtTag
            // 
            this.txtTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTag.Location = new System.Drawing.Point(664, 254);
            this.txtTag.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTag.Name = "txtTag";
            this.txtTag.Parmida_ActivePlusMultiKeys = false;
            this.txtTag.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtTag.Properties.Appearance.Options.UseForeColor = true;
            this.txtTag.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTag.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtTag.Properties.ReadOnly = true;
            this.txtTag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTag.Size = new System.Drawing.Size(225, 24);
            this.txtTag.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule1.ErrorText = "پلاک معتبر نیست";
            conditionValidationRule1.Value1 = "!";
            this.dxValidationProvider1.SetValidationRule(this.txtTag, conditionValidationRule1);
            // 
            // cbxCargoType
            // 
            this.cbxCargoType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCargoType.Location = new System.Drawing.Point(664, 74);
            this.cbxCargoType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbxCargoType.Name = "cbxCargoType";
            this.cbxCargoType.Parmida_ActivePlusMultiKeys = false;
            this.cbxCargoType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCargoType.Properties.DisplayMember = "Type";
            this.cbxCargoType.Properties.PopupFormSize = new System.Drawing.Size(250, 0);
            this.cbxCargoType.Properties.PopupView = this.gridView1;
            this.cbxCargoType.Properties.ValueMember = "TypeID";
            this.cbxCargoType.Size = new System.Drawing.Size(224, 24);
            this.cbxCargoType.TabIndex = 0;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule2.ErrorText = "نوع محموله را انتخاب کنید";
            conditionValidationRule2.Value1 = ((byte)(0));
            this.dxValidationProvider1.SetValidationRule(this.cbxCargoType, conditionValidationRule2);
            this.cbxCargoType.EditValueChanged += new System.EventHandler(this.cbxCargoType_EditValueChanged);
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
            this.gridColumn1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AllowFindPanel = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.gridColumn1.Caption = "نوع محموله";
            this.gridColumn1.FieldName = "Type";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // txtComossin
            // 
            this.txtComossin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComossin.EditValue = "0";
            this.txtComossin.Location = new System.Drawing.Point(664, 326);
            this.txtComossin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtComossin.Name = "txtComossin";
            this.txtComossin.Parmida_ActivePlusMultiKeys = false;
            this.txtComossin.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtComossin.Properties.Appearance.Options.UseForeColor = true;
            this.txtComossin.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.txtComossin.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.txtComossin.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.txtComossin.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtComossin.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtComossin.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.txtComossin.Properties.ReadOnly = true;
            this.txtComossin.Size = new System.Drawing.Size(225, 24);
            this.txtComossin.TabIndex = 1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule3.ErrorText = "حق کمیسیون نمی تواند صفر باشد";
            conditionValidationRule3.Value1 = 0;
            this.dxValidationProvider1.SetValidationRule(this.txtComossin, conditionValidationRule3);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.lblWH);
            this.groupControl1.Controls.Add(this.picPlateLast);
            this.groupControl1.Controls.Add(this.Res4);
            this.groupControl1.Controls.Add(this.Res2);
            this.groupControl1.Controls.Add(this.Res3);
            this.groupControl1.Controls.Add(this.Res1);
            this.groupControl1.Controls.Add(this.btnPuse);
            this.groupControl1.Controls.Add(this.btnPlayVideo);
            this.groupControl1.Controls.Add(this.btnStop);
            this.groupControl1.Controls.Add(this.btnSelectPlate);
            this.groupControl1.Controls.Add(this.picture);
            this.groupControl1.Controls.Add(this.btnPrint);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl2);
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
            this.groupControl1.Controls.Add(this.cbxCargoType);
            this.groupControl1.Controls.Add(this.txtComossin);
            this.groupControl1.Controls.Add(this.chkMandeh);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(980, 467);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "صدور نوبت جدید";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(664, 402);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 65;
            this.btnClose.Text = "بستن";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lblWH
            // 
            this.lblWH.AutoSize = true;
            this.lblWH.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWH.Location = new System.Drawing.Point(26, 113);
            this.lblWH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWH.Name = "lblWH";
            this.lblWH.Size = new System.Drawing.Size(55, 17);
            this.lblWH.TabIndex = 64;
            this.lblWH.Text = "800*600";
            // 
            // picPlateLast
            // 
            this.picPlateLast.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picPlateLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlateLast.Location = new System.Drawing.Point(170, 55);
            this.picPlateLast.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.picPlateLast.Name = "picPlateLast";
            this.picPlateLast.Size = new System.Drawing.Size(220, 40);
            this.picPlateLast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlateLast.TabIndex = 47;
            this.picPlateLast.TabStop = false;
            // 
            // Res4
            // 
            this.Res4.AutoSize = true;
            this.Res4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Res4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Res4.Location = new System.Drawing.Point(535, 61);
            this.Res4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.Res2.Location = new System.Drawing.Point(447, 61);
            this.Res2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.Res3.Location = new System.Drawing.Point(491, 61);
            this.Res3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.Res1.Location = new System.Drawing.Point(403, 61);
            this.Res1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Res1.Name = "Res1";
            this.Res1.Size = new System.Drawing.Size(34, 24);
            this.Res1.TabIndex = 43;
            this.Res1.Text = "P1";
            // 
            // btnPuse
            // 
            this.btnPuse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPuse.ImageOptions.Image")));
            this.btnPuse.Location = new System.Drawing.Point(120, 55);
            this.btnPuse.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnPuse.Name = "btnPuse";
            this.btnPuse.Size = new System.Drawing.Size(40, 40);
            this.btnPuse.TabIndex = 4;
            this.btnPuse.Visible = false;
            this.btnPuse.Click += new System.EventHandler(this.btnPlayVideo_Click);
            // 
            // btnPlayVideo
            // 
            this.btnPlayVideo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayVideo.ImageOptions.Image")));
            this.btnPlayVideo.Location = new System.Drawing.Point(120, 55);
            this.btnPlayVideo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnPlayVideo.Name = "btnPlayVideo";
            this.btnPlayVideo.Size = new System.Drawing.Size(40, 40);
            this.btnPlayVideo.TabIndex = 4;
            this.btnPlayVideo.Click += new System.EventHandler(this.btnPlayVideo_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.ImageOptions.Image = global::TruckerApp.Properties.Resources.stop_32x321;
            this.btnStop.Location = new System.Drawing.Point(70, 55);
            this.btnStop.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(40, 40);
            this.btnStop.TabIndex = 4;
            this.btnStop.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnSelectPlate
            // 
            this.btnSelectPlate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectPlate.ImageOptions.Image")));
            this.btnSelectPlate.Location = new System.Drawing.Point(20, 55);
            this.btnSelectPlate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSelectPlate.Name = "btnSelectPlate";
            this.btnSelectPlate.Size = new System.Drawing.Size(40, 40);
            this.btnSelectPlate.TabIndex = 4;
            this.btnSelectPlate.Click += new System.EventHandler(this.btnRefreshPlayer_Click);
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.BackColor = System.Drawing.SystemColors.Control;
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Location = new System.Drawing.Point(20, 106);
            this.picture.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(633, 346);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 3;
            this.picture.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.ImageOptions.Image = global::TruckerApp.Properties.Resources.defaultprinter_32x32;
            this.btnPrint.Location = new System.Drawing.Point(783, 402);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(106, 50);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "ثبت و چاپ";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(896, 293);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 17);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "شماره تلفن";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(896, 329);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "کمسیون";
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Location = new System.Drawing.Point(896, 221);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(23, 17);
            this.labelControl8.TabIndex = 2;
            this.labelControl8.Text = "پلاک";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Location = new System.Drawing.Point(894, 41);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(25, 17);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "تاریخ";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(895, 77);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "نوع محموله";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Location = new System.Drawing.Point(895, 113);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(69, 17);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "سریال فروش";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(895, 149);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 17);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "کارت هوشمند";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(895, 185);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "نام راننده";
            // 
            // txtserial
            // 
            this.txtserial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtserial.Location = new System.Drawing.Point(794, 110);
            this.txtserial.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtserial.Name = "txtserial";
            this.txtserial.Parmida_ActivePlusMultiKeys = false;
            this.txtserial.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtserial.Properties.Appearance.Options.UseForeColor = true;
            this.txtserial.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtserial.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtserial.Properties.ReadOnly = true;
            this.txtserial.Size = new System.Drawing.Size(94, 24);
            this.txtserial.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumber.Location = new System.Drawing.Point(664, 110);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Parmida_ActivePlusMultiKeys = false;
            this.txtNumber.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtNumber.Properties.Appearance.Options.UseForeColor = true;
            this.txtNumber.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtNumber.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtNumber.Properties.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(120, 24);
            this.txtNumber.TabIndex = 1;
            // 
            // txtDateRegister
            // 
            this.txtDateRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateRegister.Location = new System.Drawing.Point(664, 38);
            this.txtDateRegister.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDateRegister.Name = "txtDateRegister";
            this.txtDateRegister.Parmida_ActivePlusMultiKeys = false;
            this.txtDateRegister.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtDateRegister.Properties.Appearance.Options.UseForeColor = true;
            this.txtDateRegister.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtDateRegister.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtDateRegister.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtDateRegister.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtDateRegister.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtDateRegister.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtDateRegister.Properties.ReadOnly = true;
            this.txtDateRegister.Size = new System.Drawing.Size(220, 24);
            this.txtDateRegister.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(664, 290);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Parmida_ActivePlusMultiKeys = false;
            this.txtPhoneNumber.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.Properties.Appearance.Options.UseForeColor = true;
            this.txtPhoneNumber.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtPhoneNumber.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtPhoneNumber.Properties.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(225, 24);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // txtTagNumber
            // 
            this.txtTagNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTagNumber.Location = new System.Drawing.Point(664, 218);
            this.txtTagNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTagNumber.Name = "txtTagNumber";
            this.txtTagNumber.Parmida_ActivePlusMultiKeys = false;
            this.txtTagNumber.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtTagNumber.Properties.Appearance.Options.UseForeColor = true;
            this.txtTagNumber.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTagNumber.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtTagNumber.Properties.Mask.EditMask = "\\d\\d-[آ-م]-\\d\\d\\d-\\d\\d";
            this.txtTagNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtTagNumber.Properties.ReadOnly = true;
            this.txtTagNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTagNumber.Size = new System.Drawing.Size(225, 24);
            this.txtTagNumber.TabIndex = 1;
            // 
            // txtHosmand
            // 
            this.txtHosmand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHosmand.Location = new System.Drawing.Point(663, 146);
            this.txtHosmand.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtHosmand.Name = "txtHosmand";
            this.txtHosmand.Parmida_ActivePlusMultiKeys = false;
            this.txtHosmand.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtHosmand.Properties.Appearance.Options.UseForeColor = true;
            this.txtHosmand.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtHosmand.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtHosmand.Properties.ReadOnly = true;
            this.txtHosmand.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHosmand.Size = new System.Drawing.Size(224, 24);
            this.txtHosmand.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(664, 182);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtName.Name = "txtName";
            this.txtName.Parmida_ActivePlusMultiKeys = false;
            this.txtName.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtName.Properties.Appearance.Options.UseForeColor = true;
            this.txtName.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtName.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtName.Properties.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(224, 24);
            this.txtName.TabIndex = 1;
            // 
            // chkMandeh
            // 
            this.chkMandeh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMandeh.EditValue = "0";
            this.chkMandeh.Location = new System.Drawing.Point(664, 362);
            this.chkMandeh.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkMandeh.Name = "chkMandeh";
            this.chkMandeh.Parmida_ActivePlusMultiKeys = false;
            this.chkMandeh.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chkMandeh.Properties.Appearance.Options.UseForeColor = true;
            this.chkMandeh.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.chkMandeh.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.chkMandeh.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.chkMandeh.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkMandeh.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.chkMandeh.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.chkMandeh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.chkMandeh.Properties.Caption = "قابل تمدید";
            this.chkMandeh.Properties.ReadOnly = true;
            this.chkMandeh.Size = new System.Drawing.Size(225, 21);
            this.chkMandeh.TabIndex = 66;
            // 
            // FrmFishPrint
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 467);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("B Yekan", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmFishPrint";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "صدور حواله";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFishPrint_FormClosing);
            this.Load += new System.EventHandler(this.FrmFishPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCargoType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComossin.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMandeh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnSelectPlate;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox picPlateLast;
        private System.Windows.Forms.Label Res4;
        private System.Windows.Forms.Label Res2;
        private System.Windows.Forms.Label Res3;
        private System.Windows.Forms.Label Res1;
        private System.Windows.Forms.Label lblWH;
        private System.Windows.Forms.Timer timer_process;
        private DevExpress.XtraEditors.SimpleButton btnStop;
        private DevExpress.XtraEditors.TextEdit txtTagNumber;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtHosmand;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxCargoType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnPlayVideo;
        private DevExpress.XtraEditors.SimpleButton btnPuse;
        private DevExpress.XtraEditors.CheckEdit chkMandeh;
    }
}
