
namespace pet_management
{
    partial class frmServiceInfor
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
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.txtTax = new DevExpress.XtraEditors.TextEdit();
            this.gluUnit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.gluGroupService = new DevExpress.XtraEditors.GridLookUpEdit();
            this.groupServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lytTax = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluGroupService.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtId);
            this.layoutControl1.Controls.Add(this.txtTax);
            this.layoutControl1.Controls.Add(this.gluUnit);
            this.layoutControl1.Controls.Add(this.txtPrice);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.gluGroupService);
            this.layoutControl1.Controls.Add(this.txtDescription);
            this.layoutControl1.Location = new System.Drawing.Point(-1, 5);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(621, 245);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(111, 12);
            this.txtId.Name = "txtId";
            this.txtId.Properties.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(197, 24);
            this.txtId.StyleController = this.layoutControl1;
            this.txtId.TabIndex = 10;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(421, 88);
            this.txtTax.Name = "txtTax";
            this.txtTax.Properties.DisplayFormat.FormatString = "N2";
            this.txtTax.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTax.Properties.Mask.EditMask = "n";
            this.txtTax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTax.Size = new System.Drawing.Size(188, 24);
            this.txtTax.StyleController = this.layoutControl1;
            this.txtTax.TabIndex = 9;
            // 
            // gluUnit
            // 
            this.gluUnit.EditValue = "";
            this.gluUnit.Location = new System.Drawing.Point(421, 50);
            this.gluUnit.Name = "gluUnit";
            this.gluUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gluUnit.Properties.DataSource = this.unitBindingSource;
            this.gluUnit.Properties.DisplayMember = "Name";
            this.gluUnit.Properties.PopupView = this.gridLookUpEdit2View;
            this.gluUnit.Properties.ValueMember = "Id";
            this.gluUnit.Size = new System.Drawing.Size(188, 24);
            this.gluUnit.StyleController = this.layoutControl1;
            this.gluUnit.TabIndex = 8;
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(DTO.Unit);
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(111, 88);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.DisplayFormat.FormatString = "N0";
            this.txtPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPrice.Properties.Mask.EditMask = "n0";
            this.txtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrice.Size = new System.Drawing.Size(197, 24);
            this.txtPrice.StyleController = this.layoutControl1;
            this.txtPrice.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 24);
            this.txtName.StyleController = this.layoutControl1;
            this.txtName.TabIndex = 5;
            // 
            // gluGroupService
            // 
            this.gluGroupService.EditValue = "Chọn nhóm dịch vụ";
            this.gluGroupService.Location = new System.Drawing.Point(421, 12);
            this.gluGroupService.Name = "gluGroupService";
            this.gluGroupService.Properties.AutoHeight = false;
            this.gluGroupService.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gluGroupService.Properties.DataSource = this.groupServiceBindingSource;
            this.gluGroupService.Properties.DisplayMember = "Name";
            this.gluGroupService.Properties.PopupFormMinSize = new System.Drawing.Size(0, 200);
            this.gluGroupService.Properties.PopupFormSize = new System.Drawing.Size(0, 200);
            this.gluGroupService.Properties.PopupView = this.gridLookUpEdit1View;
            this.gluGroupService.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.gluGroupService.Properties.ValueMember = "Id";
            this.gluGroupService.Size = new System.Drawing.Size(188, 24);
            this.gluGroupService.StyleController = this.layoutControl1;
            this.gluGroupService.TabIndex = 4;
            // 
            // groupServiceBindingSource
            // 
            this.groupServiceBindingSource.DataSource = typeof(DTO.GroupService);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCode,
            this.colName,
            this.colDescription});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colCode
            // 
            this.colCode.Caption = "Mã/Code";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "Tên nhóm dịch vụ";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(111, 126);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(498, 97);
            this.txtDescription.StyleController = this.layoutControl1;
            this.txtDescription.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.lytTax,
            this.layoutControlItem6,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.emptySpaceItem5,
            this.emptySpaceItem6,
            this.emptySpaceItem7,
            this.emptySpaceItem8});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(621, 245);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 215);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(601, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gluGroupService;
            this.layoutControlItem1.Location = new System.Drawing.Point(310, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(291, 28);
            this.layoutControlItem1.Text = "Nhóm dịch vụ:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(96, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 38);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(300, 28);
            this.layoutControlItem2.Text = "Tên dịch vụ:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(96, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtDescription;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 114);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(601, 101);
            this.layoutControlItem3.Text = "Mô tả:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(96, 18);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gluUnit;
            this.layoutControlItem5.Location = new System.Drawing.Point(310, 38);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(291, 28);
            this.layoutControlItem5.Text = "Đơn vị:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(96, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtPrice;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 76);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(300, 28);
            this.layoutControlItem4.Text = "Đơn giá:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(96, 18);
            // 
            // lytTax
            // 
            this.lytTax.Control = this.txtTax;
            this.lytTax.Location = new System.Drawing.Point(310, 76);
            this.lytTax.Name = "lytTax";
            this.lytTax.Size = new System.Drawing.Size(291, 28);
            this.lytTax.Text = "Thuế (%):";
            this.lytTax.TextSize = new System.Drawing.Size(96, 18);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtId;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(300, 28);
            this.layoutControlItem6.Text = "Mã/Id:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(96, 18);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(300, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 114);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 28);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(300, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 66);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(300, 10);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 104);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(300, 10);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(310, 28);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(291, 10);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(310, 66);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(291, 10);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(310, 104);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(291, 10);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(401, 257);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Ghi nhận";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(514, 257);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(94, 29);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "&Thoát";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmServiceInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 308);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "frmServiceInfor";
            this.Text = "ServiceInfor";
            this.Load += new System.EventHandler(this.frmServiceInfor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluGroupService.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GridLookUpEdit gluUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.GridLookUpEdit gluGroupService;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit txtTax;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraLayout.LayoutControlItem lytTax;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnQuit;
        private System.Windows.Forms.BindingSource groupServiceBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private System.Windows.Forms.BindingSource unitBindingSource;
    }
}