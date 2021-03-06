
namespace pet_management
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grcCustomer = new DevExpress.XtraGrid.GridControl();
            this.gridViewCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(DTO.Customer);
            // 
            // grcCustomer
            // 
            this.grcCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcCustomer.DataSource = this.customerBindingSource;
            this.grcCustomer.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.grcCustomer.Location = new System.Drawing.Point(15, 68);
            this.grcCustomer.MainView = this.gridViewCustomer;
            this.grcCustomer.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.grcCustomer.Name = "grcCustomer";
            this.grcCustomer.Size = new System.Drawing.Size(1067, 610);
            this.grcCustomer.TabIndex = 1;
            this.grcCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustomer});
            // 
            // gridViewCustomer
            // 
            this.gridViewCustomer.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.gridViewCustomer.Appearance.HeaderPanel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.gridViewCustomer.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewCustomer.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewCustomer.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewCustomer.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewCustomer.Appearance.Row.BorderColor = System.Drawing.Color.Black;
            this.gridViewCustomer.Appearance.Row.Options.UseBorderColor = true;
            this.gridViewCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCustomerNumber,
            this.colFirstname,
            this.colLastname,
            this.colDob,
            this.colPhone,
            this.colEmail,
            this.colAddress,
            this.colDiscountRate});
            this.gridViewCustomer.DetailHeight = 767;
            this.gridViewCustomer.GridControl = this.grcCustomer;
            this.gridViewCustomer.Name = "gridViewCustomer";
            this.gridViewCustomer.OptionsBehavior.Editable = false;
            this.gridViewCustomer.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gridViewCustomer.OptionsView.ShowGroupPanel = false;
            this.gridViewCustomer.OptionsView.ShowIndicator = false;
            this.gridViewCustomer.PaintStyleName = "Skin";
            this.gridViewCustomer.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewCustomer_RowClick);
            this.gridViewCustomer.DoubleClick += new System.EventHandler(this.gridViewCustomer_DoubleClick);
            // 
            // colId
            // 
            this.colId.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.colId.AppearanceHeader.Options.UseForeColor = true;
            this.colId.AppearanceHeader.Options.UseTextOptions = true;
            this.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 49;
            this.colId.Name = "colId";
            this.colId.Width = 182;
            // 
            // colCustomerNumber
            // 
            this.colCustomerNumber.AppearanceCell.BorderColor = System.Drawing.Color.Black;
            this.colCustomerNumber.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCustomerNumber.AppearanceCell.Options.UseBorderColor = true;
            this.colCustomerNumber.AppearanceCell.Options.UseFont = true;
            this.colCustomerNumber.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.colCustomerNumber.AppearanceHeader.Options.UseForeColor = true;
            this.colCustomerNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomerNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerNumber.Caption = "Mã KH";
            this.colCustomerNumber.FieldName = "CustomerNumber";
            this.colCustomerNumber.MinWidth = 49;
            this.colCustomerNumber.Name = "colCustomerNumber";
            this.colCustomerNumber.Visible = true;
            this.colCustomerNumber.VisibleIndex = 0;
            this.colCustomerNumber.Width = 182;
            // 
            // colFirstname
            // 
            this.colFirstname.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFirstname.AppearanceCell.Options.UseFont = true;
            this.colFirstname.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.colFirstname.AppearanceHeader.Options.UseForeColor = true;
            this.colFirstname.AppearanceHeader.Options.UseTextOptions = true;
            this.colFirstname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFirstname.Caption = "Họ đệm";
            this.colFirstname.FieldName = "Firstname";
            this.colFirstname.MinWidth = 49;
            this.colFirstname.Name = "colFirstname";
            this.colFirstname.Visible = true;
            this.colFirstname.VisibleIndex = 1;
            this.colFirstname.Width = 182;
            // 
            // colLastname
            // 
            this.colLastname.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLastname.AppearanceCell.Options.UseFont = true;
            this.colLastname.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.colLastname.AppearanceHeader.Options.UseForeColor = true;
            this.colLastname.AppearanceHeader.Options.UseTextOptions = true;
            this.colLastname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLastname.Caption = "Tên";
            this.colLastname.FieldName = "Lastname";
            this.colLastname.MinWidth = 49;
            this.colLastname.Name = "colLastname";
            this.colLastname.Visible = true;
            this.colLastname.VisibleIndex = 2;
            this.colLastname.Width = 182;
            // 
            // colDob
            // 
            this.colDob.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDob.AppearanceCell.Options.UseFont = true;
            this.colDob.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.colDob.AppearanceHeader.Options.UseForeColor = true;
            this.colDob.AppearanceHeader.Options.UseTextOptions = true;
            this.colDob.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDob.Caption = "Ngày sinh";
            this.colDob.FieldName = "Dob";
            this.colDob.MinWidth = 49;
            this.colDob.Name = "colDob";
            this.colDob.Visible = true;
            this.colDob.VisibleIndex = 3;
            this.colDob.Width = 182;
            // 
            // colPhone
            // 
            this.colPhone.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPhone.AppearanceCell.Options.UseFont = true;
            this.colPhone.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.colPhone.AppearanceHeader.Options.UseForeColor = true;
            this.colPhone.AppearanceHeader.Options.UseTextOptions = true;
            this.colPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPhone.Caption = "Số điện thoại";
            this.colPhone.FieldName = "Phone";
            this.colPhone.MinWidth = 49;
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 4;
            this.colPhone.Width = 182;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmail.AppearanceCell.Options.UseFont = true;
            this.colEmail.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.colEmail.AppearanceHeader.Options.UseForeColor = true;
            this.colEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmail.FieldName = "Email";
            this.colEmail.MinWidth = 49;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            this.colEmail.Width = 182;
            // 
            // colAddress
            // 
            this.colAddress.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAddress.AppearanceCell.Options.UseFont = true;
            this.colAddress.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.colAddress.AppearanceHeader.Options.UseForeColor = true;
            this.colAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddress.Caption = "Địa chỉ";
            this.colAddress.FieldName = "Address";
            this.colAddress.MinWidth = 49;
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 6;
            this.colAddress.Width = 182;
            // 
            // colDiscountRate
            // 
            this.colDiscountRate.AppearanceCell.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDiscountRate.AppearanceCell.Options.UseFont = true;
            this.colDiscountRate.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.colDiscountRate.AppearanceHeader.Options.UseForeColor = true;
            this.colDiscountRate.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiscountRate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiscountRate.Caption = "Chiết khấu";
            this.colDiscountRate.FieldName = "DiscountRate";
            this.colDiscountRate.MinWidth = 49;
            this.colDiscountRate.Name = "colDiscountRate";
            this.colDiscountRate.Visible = true;
            this.colDiscountRate.VisibleIndex = 7;
            this.colDiscountRate.Width = 182;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnAdd.Location = new System.Drawing.Point(711, 18);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnEdit.Location = new System.Drawing.Point(811, 18);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 36);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnDelete.Location = new System.Drawing.Point(901, 18);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnRefresh.Location = new System.Drawing.Point(987, 18);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 36);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 18);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tìm kiếm:";
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(89, 24);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.NullValuePrompt = "Nhập từ khóa để tìm kiếm";
            this.searchControl1.Size = new System.Drawing.Size(471, 24);
            this.searchControl1.TabIndex = 4;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 695);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grcCustomer);
            this.IconOptions.SvgImage = global::pet_management.Properties.Resources.icon_assign;
            this.Name = "frmCustomer";
            this.Text = "Khách hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DevExpress.XtraGrid.GridControl grcCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCustomer;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstname;
        private DevExpress.XtraGrid.Columns.GridColumn colLastname;
        private DevExpress.XtraGrid.Columns.GridColumn colDob;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountRate;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
    }
}