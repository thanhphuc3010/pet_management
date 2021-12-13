
namespace pet_management
{
    partial class frmSelectPart
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
            this.txtSearch = new DevExpress.XtraEditors.SearchControl();
            this.lblSearch = new DevExpress.XtraEditors.LabelControl();
            this.grcPart = new DevExpress.XtraGrid.GridControl();
            this.gridViewPart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMakeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUses = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(85, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.txtSearch.Properties.NullValuePrompt = "Nhập từ khóa tìm kiếm";
            this.txtSearch.Size = new System.Drawing.Size(382, 24);
            this.txtSearch.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(12, 12);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(67, 18);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // grcPart
            // 
            this.grcPart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcPart.DataSource = this.partBindingSource;
            this.grcPart.Location = new System.Drawing.Point(12, 39);
            this.grcPart.MainView = this.gridViewPart;
            this.grcPart.Name = "grcPart";
            this.grcPart.Size = new System.Drawing.Size(681, 380);
            this.grcPart.TabIndex = 3;
            this.grcPart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPart});
            // 
            // gridViewPart
            // 
            this.gridViewPart.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMakeId,
            this.colPartNumber,
            this.colName,
            this.colUnitId,
            this.colUses,
            this.colCost,
            this.colPrice,
            this.colQuantity,
            this.colTax});
            this.gridViewPart.GridControl = this.grcPart;
            this.gridViewPart.Name = "gridViewPart";
            this.gridViewPart.OptionsBehavior.Editable = false;
            this.gridViewPart.OptionsView.ShowGroupPanel = false;
            this.gridViewPart.DoubleClick += new System.EventHandler(this.gridViewPart_DoubleClick);
            // 
            // colId
            // 
            this.colId.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colId.AppearanceCell.Options.UseForeColor = true;
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colId.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.AppearanceHeader.Options.UseForeColor = true;
            this.colId.AppearanceHeader.Options.UseTextOptions = true;
            this.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Width = 94;
            // 
            // colMakeId
            // 
            this.colMakeId.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colMakeId.AppearanceCell.Options.UseForeColor = true;
            this.colMakeId.AppearanceHeader.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMakeId.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.colMakeId.AppearanceHeader.Options.UseFont = true;
            this.colMakeId.AppearanceHeader.Options.UseForeColor = true;
            this.colMakeId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMakeId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMakeId.Caption = "Nhà sản xuất";
            this.colMakeId.FieldName = "MakeId";
            this.colMakeId.MinWidth = 25;
            this.colMakeId.Name = "colMakeId";
            this.colMakeId.OptionsColumn.AllowEdit = false;
            this.colMakeId.Visible = true;
            this.colMakeId.VisibleIndex = 0;
            this.colMakeId.Width = 117;
            // 
            // colPartNumber
            // 
            this.colPartNumber.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colPartNumber.AppearanceCell.Options.UseForeColor = true;
            this.colPartNumber.AppearanceHeader.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPartNumber.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.colPartNumber.AppearanceHeader.Options.UseFont = true;
            this.colPartNumber.AppearanceHeader.Options.UseForeColor = true;
            this.colPartNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colPartNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPartNumber.Caption = "Mã hàng";
            this.colPartNumber.FieldName = "PartNumber";
            this.colPartNumber.MinWidth = 25;
            this.colPartNumber.Name = "colPartNumber";
            this.colPartNumber.OptionsColumn.AllowEdit = false;
            this.colPartNumber.Visible = true;
            this.colPartNumber.VisibleIndex = 1;
            this.colPartNumber.Width = 128;
            // 
            // colName
            // 
            this.colName.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colName.AppearanceCell.Options.UseForeColor = true;
            this.colName.AppearanceHeader.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colName.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.colName.AppearanceHeader.Options.UseFont = true;
            this.colName.AppearanceHeader.Options.UseForeColor = true;
            this.colName.AppearanceHeader.Options.UseTextOptions = true;
            this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.Caption = "Tên hàng";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            this.colName.Width = 213;
            // 
            // colUnitId
            // 
            this.colUnitId.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colUnitId.AppearanceCell.Options.UseForeColor = true;
            this.colUnitId.AppearanceHeader.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUnitId.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.colUnitId.AppearanceHeader.Options.UseFont = true;
            this.colUnitId.AppearanceHeader.Options.UseForeColor = true;
            this.colUnitId.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitId.Caption = "ĐVT";
            this.colUnitId.FieldName = "UnitId";
            this.colUnitId.MinWidth = 25;
            this.colUnitId.Name = "colUnitId";
            this.colUnitId.OptionsColumn.AllowEdit = false;
            this.colUnitId.Visible = true;
            this.colUnitId.VisibleIndex = 3;
            this.colUnitId.Width = 49;
            // 
            // colUses
            // 
            this.colUses.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colUses.AppearanceCell.Options.UseForeColor = true;
            this.colUses.AppearanceHeader.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUses.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.colUses.AppearanceHeader.Options.UseFont = true;
            this.colUses.AppearanceHeader.Options.UseForeColor = true;
            this.colUses.AppearanceHeader.Options.UseTextOptions = true;
            this.colUses.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUses.Caption = "Công dụng";
            this.colUses.FieldName = "Uses";
            this.colUses.MinWidth = 25;
            this.colUses.Name = "colUses";
            this.colUses.OptionsColumn.AllowEdit = false;
            this.colUses.Width = 282;
            // 
            // colCost
            // 
            this.colCost.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colCost.AppearanceCell.Options.UseForeColor = true;
            this.colCost.AppearanceHeader.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCost.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.colCost.AppearanceHeader.Options.UseFont = true;
            this.colCost.AppearanceHeader.Options.UseForeColor = true;
            this.colCost.AppearanceHeader.Options.UseTextOptions = true;
            this.colCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCost.Caption = "Giá nhập";
            this.colCost.DisplayFormat.FormatString = "N0";
            this.colCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCost.FieldName = "Cost";
            this.colCost.MinWidth = 25;
            this.colCost.Name = "colCost";
            this.colCost.OptionsColumn.AllowEdit = false;
            this.colCost.Width = 122;
            // 
            // colPrice
            // 
            this.colPrice.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colPrice.AppearanceCell.Options.UseForeColor = true;
            this.colPrice.AppearanceHeader.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPrice.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.colPrice.AppearanceHeader.Options.UseFont = true;
            this.colPrice.AppearanceHeader.Options.UseForeColor = true;
            this.colPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrice.Caption = "Giá bán";
            this.colPrice.DisplayFormat.FormatString = "N0";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 25;
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowEdit = false;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 4;
            this.colPrice.Width = 124;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colQuantity.AppearanceCell.Options.UseForeColor = true;
            this.colQuantity.AppearanceHeader.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQuantity.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.colQuantity.AppearanceHeader.Options.UseFont = true;
            this.colQuantity.AppearanceHeader.Options.UseForeColor = true;
            this.colQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantity.Caption = "Còn hàng";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 25;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.AllowEdit = false;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 5;
            // 
            // colTax
            // 
            this.colTax.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colTax.AppearanceCell.Options.UseForeColor = true;
            this.colTax.AppearanceHeader.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTax.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.colTax.AppearanceHeader.Options.UseFont = true;
            this.colTax.AppearanceHeader.Options.UseForeColor = true;
            this.colTax.AppearanceHeader.Options.UseTextOptions = true;
            this.colTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTax.Caption = "Thuế (%)";
            this.colTax.FieldName = "Tax";
            this.colTax.MinWidth = 25;
            this.colTax.Name = "colTax";
            this.colTax.OptionsColumn.AllowEdit = false;
            this.colTax.Width = 63;
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(DTO.Part);
            // 
            // frmSelectPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 431);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.grcPart);
            this.Name = "frmSelectPart";
            this.Text = "Chọn hàng hóa";
            this.Load += new System.EventHandler(this.frmSelectPart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchControl txtSearch;
        private DevExpress.XtraEditors.LabelControl lblSearch;
        private DevExpress.XtraGrid.GridControl grcPart;
        private System.Windows.Forms.BindingSource partBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPart;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMakeId;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitId;
        private DevExpress.XtraGrid.Columns.GridColumn colUses;
        private DevExpress.XtraGrid.Columns.GridColumn colCost;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTax;
    }
}