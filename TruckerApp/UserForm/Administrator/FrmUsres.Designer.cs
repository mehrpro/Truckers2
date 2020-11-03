namespace TruckerApp.UserForm.Administrator
{
    partial class FrmUsres
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnNewUser = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.dgvUserList = new DevExpress.XtraGrid.GridControl();
            this.gridViewUserList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSelect = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.userID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Roul = new DevExpress.XtraGrid.Columns.GridColumn();
            this.username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtLastname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbxRole = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btnNewUser);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.dgvUserList);
            this.groupControl1.Controls.Add(this.txtPassword);
            this.groupControl1.Controls.Add(this.txtUsername);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtLastname);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtPhoneNumber);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtFirstName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cbxRole);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1042, 568);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "مدیریت کاربران";
            // 
            // btnNewUser
            // 
            this.btnNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewUser.ImageOptions.Image = global::TruckerApp.Properties.Resources.newcontact_32x32;
            this.btnNewUser.Location = new System.Drawing.Point(859, 292);
            this.btnNewUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(100, 50);
            this.btnNewUser.TabIndex = 3;
            this.btnNewUser.Text = "جدید";
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageOptions.Image = global::TruckerApp.Properties.Resources.save_32x322;
            this.btnSave.Location = new System.Drawing.Point(751, 292);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvUserList
            // 
            this.dgvUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUserList.Location = new System.Drawing.Point(13, 40);
            this.dgvUserList.MainView = this.gridViewUserList;
            this.dgvUserList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSelect});
            this.dgvUserList.Size = new System.Drawing.Size(706, 515);
            this.dgvUserList.TabIndex = 2;
            this.dgvUserList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUserList});
            // 
            // gridViewUserList
            // 
            this.gridViewUserList.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.Empty.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.Preview.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.userID,
            this.FirstName,
            this.LastName,
            this.Phone,
            this.Roul,
            this.username,
            this.password});
            this.gridViewUserList.DetailHeight = 420;
            this.gridViewUserList.GridControl = this.dgvUserList;
            this.gridViewUserList.Name = "gridViewUserList";
            this.gridViewUserList.OptionsBehavior.ReadOnly = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.gridColumn1.ColumnEdit = this.btnSelect;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 37;
            // 
            // btnSelect
            // 
            this.btnSelect.AutoHeight = false;
            editorButtonImageOptions2.Image = global::TruckerApp.Properties.Resources.backward_16x16;
            serializableAppearanceObject5.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject6.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject7.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject8.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.btnSelect.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // userID
            // 
            this.userID.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.userID.Caption = "شناسه";
            this.userID.FieldName = "userID";
            this.userID.Name = "userID";
            this.userID.Visible = true;
            this.userID.VisibleIndex = 1;
            this.userID.Width = 104;
            // 
            // FirstName
            // 
            this.FirstName.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.FirstName.Caption = "نام";
            this.FirstName.FieldName = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 2;
            this.FirstName.Width = 104;
            // 
            // LastName
            // 
            this.LastName.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.LastName.Caption = "نام خانوادگی";
            this.LastName.FieldName = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.Visible = true;
            this.LastName.VisibleIndex = 3;
            this.LastName.Width = 104;
            // 
            // Phone
            // 
            this.Phone.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.Phone.Caption = "تلفن";
            this.Phone.FieldName = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.Visible = true;
            this.Phone.VisibleIndex = 4;
            this.Phone.Width = 104;
            // 
            // Roul
            // 
            this.Roul.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.Roul.Caption = "سطح دسترسی";
            this.Roul.FieldName = "Roul";
            this.Roul.Name = "Roul";
            this.Roul.Visible = true;
            this.Roul.VisibleIndex = 5;
            this.Roul.Width = 104;
            // 
            // username
            // 
            this.username.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.username.Caption = "نام کاربری";
            this.username.FieldName = "username";
            this.username.Name = "username";
            this.username.Visible = true;
            this.username.VisibleIndex = 6;
            this.username.Width = 113;
            // 
            // password
            // 
            this.password.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.password.Caption = "رمز عبور";
            this.password.FieldName = "password";
            this.password.Name = "password";
            this.password.Width = 99;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(736, 249);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Parmida_ActivePlusMultiKeys = false;
            this.txtPassword.Properties.MaxLength = 15;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(220, 24);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(736, 217);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Parmida_ActivePlusMultiKeys = false;
            this.txtUsername.Properties.MaxLength = 10;
            this.txtUsername.Size = new System.Drawing.Size(220, 24);
            this.txtUsername.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Location = new System.Drawing.Point(963, 253);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 17);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "رمز عبور";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(963, 220);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 17);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "نام کاربری";
            // 
            // txtLastname
            // 
            this.txtLastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastname.Location = new System.Drawing.Point(736, 121);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Parmida_ActivePlusMultiKeys = false;
            this.txtLastname.Properties.MaxLength = 50;
            this.txtLastname.Size = new System.Drawing.Size(220, 24);
            this.txtLastname.TabIndex = 1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "نام خانوادگی را وارد کنید";
            this.dxValidationProvider1.SetValidationRule(this.txtLastname, conditionValidationRule3);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(963, 189);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 17);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "مجوز";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(963, 124);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "نام خانوادگی";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(736, 153);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Parmida_ActivePlusMultiKeys = false;
            this.txtPhoneNumber.Properties.MaxLength = 10;
            this.txtPhoneNumber.Size = new System.Drawing.Size(220, 24);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(963, 157);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 17);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "تلفن تماس";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(846, 57);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Parmida_ActivePlusMultiKeys = false;
            this.txtID.Properties.MaxLength = 50;
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(110, 24);
            this.txtID.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Location = new System.Drawing.Point(963, 60);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 17);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "شناسه";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(736, 89);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Parmida_ActivePlusMultiKeys = false;
            this.txtFirstName.Properties.MaxLength = 50;
            this.txtFirstName.Size = new System.Drawing.Size(220, 24);
            this.txtFirstName.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "نام را وارد کنید";
            this.dxValidationProvider1.SetValidationRule(this.txtFirstName, conditionValidationRule1);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(963, 93);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "نام";
            // 
            // cbxRole
            // 
            this.cbxRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxRole.Location = new System.Drawing.Point(736, 185);
            this.cbxRole.Margin = new System.Windows.Forms.Padding(4);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Parmida_ActivePlusMultiKeys = false;
            this.cbxRole.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxRole.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxRole.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxRole.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxRole.Properties.Items.AddRange(new object[] {
            "admin",
            "manage",
            "user"});
            this.cbxRole.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxRole.Size = new System.Drawing.Size(220, 24);
            this.cbxRole.TabIndex = 1;
            // 
            // FrmUsres
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 568);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("B Yekan", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmUsres";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدیریت کاربران";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl dgvUserList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUserList;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtLastname;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbxRole;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSelect;
        private DevExpress.XtraGrid.Columns.GridColumn userID;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn LastName;
        private DevExpress.XtraGrid.Columns.GridColumn Phone;
        private DevExpress.XtraGrid.Columns.GridColumn Roul;
        private DevExpress.XtraGrid.Columns.GridColumn username;
        private DevExpress.XtraGrid.Columns.GridColumn password;
        private DevExpress.XtraEditors.SimpleButton btnNewUser;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}