
namespace pet_management
{
    partial class frmStaff
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
            this.grcStaff = new DevExpress.XtraGrid.GridControl();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewStaff = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStaffNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.roleStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grcStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleStaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // grcStaff
            // 
            this.grcStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcStaff.DataSource = this.staffBindingSource;
            this.grcStaff.Location = new System.Drawing.Point(12, 50);
            this.grcStaff.LookAndFeel.SkinName = "Office 2010 Blue";
            this.grcStaff.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grcStaff.MainView = this.gridViewStaff;
            this.grcStaff.Name = "grcStaff";
            this.grcStaff.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.grcStaff.Size = new System.Drawing.Size(776, 388);
            this.grcStaff.TabIndex = 0;
            this.grcStaff.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStaff});
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataSource = typeof(DTO.Staff);
            // 
            // gridViewStaff
            // 
            this.gridViewStaff.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colStaffNumber,
            this.colFirstName,
            this.colLastName,
            this.colBirthday,
            this.colPhone,
            this.colEmail,
            this.colAddress,
            this.colIdRole,
            this.colActive,
            this.colPassword,
            this.colCreatedDate,
            this.colUpdatedDate});
            this.gridViewStaff.GridControl = this.grcStaff;
            this.gridViewStaff.IndicatorWidth = 50;
            this.gridViewStaff.Name = "gridViewStaff";
            this.gridViewStaff.OptionsBehavior.Editable = false;
            this.gridViewStaff.OptionsView.ShowGroupPanel = false;
            this.gridViewStaff.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewStaff_CustomDrawRowIndicator);
            this.gridViewStaff.DoubleClick += new System.EventHandler(this.gridViewStaff_DoubleClick);
            // 
            // colId
            // 
            this.colId.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colId.AppearanceCell.Options.UseFont = true;
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Width = 94;
            // 
            // colStaffNumber
            // 
            this.colStaffNumber.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStaffNumber.AppearanceCell.Options.UseFont = true;
            this.colStaffNumber.FieldName = "StaffNumber";
            this.colStaffNumber.MinWidth = 25;
            this.colStaffNumber.Name = "colStaffNumber";
            this.colStaffNumber.Visible = true;
            this.colStaffNumber.VisibleIndex = 0;
            this.colStaffNumber.Width = 94;
            // 
            // colFirstName
            // 
            this.colFirstName.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFirstName.AppearanceCell.Options.UseFont = true;
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.MinWidth = 25;
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            this.colFirstName.Width = 94;
            // 
            // colLastName
            // 
            this.colLastName.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLastName.AppearanceCell.Options.UseFont = true;
            this.colLastName.FieldName = "LastName";
            this.colLastName.MinWidth = 25;
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            this.colLastName.Width = 94;
            // 
            // colBirthday
            // 
            this.colBirthday.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBirthday.AppearanceCell.Options.UseFont = true;
            this.colBirthday.FieldName = "Birthday";
            this.colBirthday.MinWidth = 25;
            this.colBirthday.Name = "colBirthday";
            this.colBirthday.Visible = true;
            this.colBirthday.VisibleIndex = 3;
            this.colBirthday.Width = 94;
            // 
            // colPhone
            // 
            this.colPhone.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPhone.AppearanceCell.Options.UseFont = true;
            this.colPhone.FieldName = "Phone";
            this.colPhone.MinWidth = 25;
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 4;
            this.colPhone.Width = 94;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmail.AppearanceCell.Options.UseFont = true;
            this.colEmail.FieldName = "Email";
            this.colEmail.MinWidth = 25;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            this.colEmail.Width = 94;
            // 
            // colAddress
            // 
            this.colAddress.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAddress.AppearanceCell.Options.UseFont = true;
            this.colAddress.FieldName = "Address";
            this.colAddress.MinWidth = 25;
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 6;
            this.colAddress.Width = 94;
            // 
            // colIdRole
            // 
            this.colIdRole.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIdRole.AppearanceCell.Options.UseFont = true;
            this.colIdRole.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colIdRole.FieldName = "IdRole";
            this.colIdRole.MinWidth = 25;
            this.colIdRole.Name = "colIdRole";
            this.colIdRole.Visible = true;
            this.colIdRole.VisibleIndex = 7;
            this.colIdRole.Width = 94;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.roleStaffBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemGridLookUpEdit1.ValueMember = "Id";
            // 
            // roleStaffBindingSource
            // 
            this.roleStaffBindingSource.DataSource = typeof(DTO.Role);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colActive
            // 
            this.colActive.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colActive.AppearanceCell.Options.UseFont = true;
            this.colActive.FieldName = "Active";
            this.colActive.MinWidth = 25;
            this.colActive.Name = "colActive";
            this.colActive.Width = 94;
            // 
            // colPassword
            // 
            this.colPassword.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPassword.AppearanceCell.Options.UseFont = true;
            this.colPassword.FieldName = "Password";
            this.colPassword.MinWidth = 25;
            this.colPassword.Name = "colPassword";
            this.colPassword.Width = 94;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCreatedDate.AppearanceCell.Options.UseFont = true;
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.MinWidth = 25;
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.Width = 94;
            // 
            // colUpdatedDate
            // 
            this.colUpdatedDate.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUpdatedDate.AppearanceCell.Options.UseFont = true;
            this.colUpdatedDate.FieldName = "UpdatedDate";
            this.colUpdatedDate.MinWidth = 25;
            this.colUpdatedDate.Name = "colUpdatedDate";
            this.colUpdatedDate.Width = 94;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(585, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 39);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(694, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 39);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grcStaff);
            this.Name = "frmStaff";
            this.Text = "Nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleStaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcStaff;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStaff;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colStaffNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthday;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRole;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private System.Windows.Forms.BindingSource roleStaffBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}