
namespace pet_management
{
    partial class frmExaminationItemDetail
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.gluServiceUse = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.eLItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colExaminationId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceUsedId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluServiceUse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtNumber);
            this.layoutControl1.Controls.Add(this.txtQuantity);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.gluServiceUse);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(525, 145);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.emptySpaceItem5,
            this.emptySpaceItem1,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(525, 145);
            this.Root.TextVisible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(387, 24);
            this.txtName.StyleController = this.layoutControl1;
            this.txtName.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 38);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(505, 28);
            this.layoutControlItem1.Text = "Tên hàng hóa:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(110, 18);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(126, 88);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(88, 24);
            this.txtQuantity.StyleController = this.layoutControl1;
            this.txtQuantity.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtQuantity;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 76);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(206, 28);
            this.layoutControlItem2.Text = "Số lượng:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(110, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gluServiceUse;
            this.layoutControlItem3.Location = new System.Drawing.Point(206, 76);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(299, 28);
            this.layoutControlItem3.Text = "Dịch vụ sử dụng:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(110, 18);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(126, 12);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(215, 24);
            this.txtNumber.StyleController = this.layoutControl1;
            this.txtNumber.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtNumber;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(333, 28);
            this.layoutControlItem4.Text = "Mã hàng hóa:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(110, 18);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 28);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(505, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 66);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(505, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 104);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(505, 10);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 114);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(505, 11);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(363, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 31);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Ghi nhận";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(441, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(333, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(172, 28);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // gluServiceUse
            // 
            this.gluServiceUse.Location = new System.Drawing.Point(332, 88);
            this.gluServiceUse.Name = "gluServiceUse";
            this.gluServiceUse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gluServiceUse.Properties.DataSource = this.eLItemBindingSource;
            this.gluServiceUse.Properties.DisplayMember = "ItemName";
            this.gluServiceUse.Properties.NullText = "";
            this.gluServiceUse.Properties.PopupView = this.gridLookUpEdit1View;
            this.gluServiceUse.Properties.ValueMember = "ItemId";
            this.gluServiceUse.Size = new System.Drawing.Size(181, 24);
            this.gluServiceUse.StyleController = this.layoutControl1;
            this.gluServiceUse.TabIndex = 6;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colExaminationId,
            this.colItemId,
            this.colItemType,
            this.colItemNumber,
            this.colItemName,
            this.colUnitId,
            this.colQuantity,
            this.colPrice,
            this.colTax,
            this.colDiscount,
            this.colServiceUsedId});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // eLItemBindingSource
            // 
            this.eLItemBindingSource.DataSource = typeof(DTO.ELItem);
            // 
            // colExaminationId
            // 
            this.colExaminationId.FieldName = "ExaminationId";
            this.colExaminationId.Name = "colExaminationId";
            // 
            // colItemId
            // 
            this.colItemId.FieldName = "ItemId";
            this.colItemId.Name = "colItemId";
            this.colItemId.Visible = true;
            this.colItemId.VisibleIndex = 0;
            // 
            // colItemType
            // 
            this.colItemType.FieldName = "ItemType";
            this.colItemType.Name = "colItemType";
            // 
            // colItemNumber
            // 
            this.colItemNumber.FieldName = "ItemNumber";
            this.colItemNumber.Name = "colItemNumber";
            // 
            // colItemName
            // 
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            // 
            // colUnitId
            // 
            this.colUnitId.FieldName = "UnitId";
            this.colUnitId.Name = "colUnitId";
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            // 
            // colTax
            // 
            this.colTax.FieldName = "Tax";
            this.colTax.Name = "colTax";
            // 
            // colDiscount
            // 
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            // 
            // colServiceUsedId
            // 
            this.colServiceUsedId.FieldName = "ServiceUsedId";
            this.colServiceUsedId.Name = "colServiceUsedId";
            // 
            // frmExaminationItemDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 190);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmExaminationItemDetail";
            this.Text = "frmExaminationItemDetail";
            this.Load += new System.EventHandler(this.frmExaminationItemDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluServiceUse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.GridLookUpEdit gluServiceUse;
        private System.Windows.Forms.BindingSource eLItemBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colExaminationId;
        private DevExpress.XtraGrid.Columns.GridColumn colItemId;
        private DevExpress.XtraGrid.Columns.GridColumn colItemType;
        private DevExpress.XtraGrid.Columns.GridColumn colItemNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitId;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTax;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceUsedId;
    }
}