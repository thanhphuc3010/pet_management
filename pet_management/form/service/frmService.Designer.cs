
namespace pet_management
{
    partial class frmService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmService));
            this.grcService = new DevExpress.XtraGrid.GridControl();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewService = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupServiceId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoGroupService = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.groupServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoUnit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSearch = new DevExpress.XtraEditors.SearchControl();
            this.lblSearch = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grcService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoGroupService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grcService
            // 
            this.grcService.DataSource = this.serviceBindingSource;
            this.grcService.Location = new System.Drawing.Point(12, 47);
            this.grcService.MainView = this.gridViewService;
            this.grcService.Name = "grcService";
            this.grcService.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoGroupService,
            this.repoUnit});
            this.grcService.Size = new System.Drawing.Size(1000, 640);
            this.grcService.TabIndex = 0;
            this.grcService.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewService});
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(DTO.Service);
            // 
            // gridViewService
            // 
            this.gridViewService.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colGroupServiceId,
            this.colName,
            this.colDescription,
            this.colUnitId,
            this.colPrice,
            this.colTax});
            this.gridViewService.GridControl = this.grcService;
            this.gridViewService.Name = "gridViewService";
            this.gridViewService.OptionsBehavior.Editable = false;
            this.gridViewService.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.AppearanceHeader.Options.UseTextOptions = true;
            this.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Width = 94;
            // 
            // colGroupServiceId
            // 
            this.colGroupServiceId.AppearanceHeader.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGroupServiceId.AppearanceHeader.Options.UseFont = true;
            this.colGroupServiceId.AppearanceHeader.Options.UseTextOptions = true;
            this.colGroupServiceId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGroupServiceId.Caption = "Nhóm dịch vụ";
            this.colGroupServiceId.ColumnEdit = this.repoGroupService;
            this.colGroupServiceId.FieldName = "GroupServiceId";
            this.colGroupServiceId.MinWidth = 25;
            this.colGroupServiceId.Name = "colGroupServiceId";
            this.colGroupServiceId.Visible = true;
            this.colGroupServiceId.VisibleIndex = 0;
            this.colGroupServiceId.Width = 153;
            // 
            // repoGroupService
            // 
            this.repoGroupService.AutoHeight = false;
            this.repoGroupService.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoGroupService.DataSource = this.groupServiceBindingSource;
            this.repoGroupService.DisplayMember = "Name";
            this.repoGroupService.Name = "repoGroupService";
            this.repoGroupService.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.repoGroupService.ValueMember = "Id";
            // 
            // groupServiceBindingSource
            // 
            this.groupServiceBindingSource.DataSource = typeof(DTO.GroupService);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.AppearanceHeader.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colName.AppearanceHeader.Options.UseFont = true;
            this.colName.AppearanceHeader.Options.UseTextOptions = true;
            this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.Caption = "Tên dịch vụ";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 227;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescription.Caption = "Mô tả";
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 25;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 298;
            // 
            // colUnitId
            // 
            this.colUnitId.AppearanceHeader.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUnitId.AppearanceHeader.Options.UseFont = true;
            this.colUnitId.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitId.Caption = "ĐVT";
            this.colUnitId.ColumnEdit = this.repoUnit;
            this.colUnitId.FieldName = "UnitId";
            this.colUnitId.MinWidth = 25;
            this.colUnitId.Name = "colUnitId";
            this.colUnitId.Visible = true;
            this.colUnitId.VisibleIndex = 4;
            this.colUnitId.Width = 71;
            // 
            // repoUnit
            // 
            this.repoUnit.AutoHeight = false;
            this.repoUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoUnit.DataSource = this.unitBindingSource;
            this.repoUnit.DisplayMember = "Name";
            this.repoUnit.Name = "repoUnit";
            this.repoUnit.PopupView = this.gridView2;
            this.repoUnit.ValueMember = "Id";
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(DTO.Unit);
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colPrice
            // 
            this.colPrice.AppearanceHeader.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPrice.AppearanceHeader.Options.UseFont = true;
            this.colPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrice.Caption = "Đơn giá";
            this.colPrice.DisplayFormat.FormatString = "N0";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 25;
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            this.colPrice.Width = 138;
            // 
            // colTax
            // 
            this.colTax.AppearanceHeader.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTax.AppearanceHeader.Options.UseFont = true;
            this.colTax.AppearanceHeader.Options.UseTextOptions = true;
            this.colTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTax.Caption = "Thuế";
            this.colTax.FieldName = "Tax";
            this.colTax.MinWidth = 25;
            this.colTax.Name = "colTax";
            this.colTax.Visible = true;
            this.colTax.VisibleIndex = 5;
            this.colTax.Width = 93;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(85, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.txtSearch.Size = new System.Drawing.Size(553, 24);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(12, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(67, 18);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Options.UseTextOptions = true;
            this.btnAdd.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnAdd.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAdd.ImageOptions.ImageToTextIndent = 10;
            this.btnAdd.Location = new System.Drawing.Point(1032, 47);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEdit.ImageOptions.ImageToTextIndent = 10;
            this.btnEdit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(1032, 87);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 34);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.ImageIndex = 10;
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDelete.ImageOptions.ImageToTextIndent = 10;
            this.btnDelete.Location = new System.Drawing.Point(1032, 127);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 34);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(1032, 653);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(97, 34);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "&Thoát";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 697);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.grcService);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmService";
            this.Text = "Danh mục dịch vụ";
            this.Load += new System.EventHandler(this.frmService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoGroupService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcService;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewService;
        private DevExpress.XtraEditors.SearchControl txtSearch;
        private DevExpress.XtraEditors.LabelControl lblSearch;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnQuit;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupServiceId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitId;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTax;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repoGroupService;
        private System.Windows.Forms.BindingSource groupServiceBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repoUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource unitBindingSource;
    }
}