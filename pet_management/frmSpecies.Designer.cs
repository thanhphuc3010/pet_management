
namespace pet_management
{
    partial class frmSpecies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpecies));
            this.grcDemo = new DevExpress.XtraGrid.GridControl();
            this.speciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.lytInput = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.grcDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytInput)).BeginInit();
            this.lytInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            this.SuspendLayout();
            // 
            // grcDemo
            // 
            this.grcDemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcDemo.DataSource = this.speciesBindingSource;
            this.grcDemo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.grcDemo.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grcDemo.Location = new System.Drawing.Point(6, 152);
            this.grcDemo.MainView = this.gridView1;
            this.grcDemo.Margin = new System.Windows.Forms.Padding(5);
            this.grcDemo.Name = "grcDemo";
            this.grcDemo.Size = new System.Drawing.Size(717, 219);
            this.grcDemo.TabIndex = 2;
            this.grcDemo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // speciesBindingSource
            // 
            this.speciesBindingSource.DataSource = typeof(DTO.Species);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colDescription});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.grcDemo;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.AppearanceCell.Options.UseTextOptions = true;
            this.colId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colId.AppearanceHeader.Options.UseForeColor = true;
            this.colId.Caption = "Mã";
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 40;
            // 
            // colName
            // 
            this.colName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colName.AppearanceHeader.Options.UseForeColor = true;
            this.colName.Caption = "Tên loài";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 150;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colDescription.AppearanceHeader.Options.UseForeColor = true;
            this.colDescription.Caption = "Mô tả";
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 25;
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 497;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Roboto", 8F);
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(5, 380);
            this.btnAdd.LookAndFeel.SkinName = "Office 2007 Blue";
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Roboto", 8F);
            this.btnUpdate.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Appearance.Options.UseForeColor = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(156, 380);
            this.btnUpdate.LookAndFeel.SkinName = "Office 2007 Blue";
            this.btnUpdate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 38);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Roboto", 8F);
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(307, 380);
            this.simpleButton3.LookAndFeel.SkinName = "Office 2007 Blue";
            this.simpleButton3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(113, 38);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Sửa";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Roboto", 8F);
            this.simpleButton4.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Appearance.Options.UseForeColor = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(458, 380);
            this.simpleButton4.LookAndFeel.SkinName = "Office 2007 Blue";
            this.simpleButton4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(113, 38);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "Xoá";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Roboto", 8F);
            this.simpleButton5.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Appearance.Options.UseForeColor = true;
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(609, 380);
            this.simpleButton5.LookAndFeel.SkinName = "Office 2007 Blue";
            this.simpleButton5.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(113, 38);
            this.simpleButton5.TabIndex = 3;
            this.simpleButton5.Text = "Huỷ";
            // 
            // lytInput
            // 
            this.lytInput.Controls.Add(this.txtId);
            this.lytInput.Controls.Add(this.txtName);
            this.lytInput.Controls.Add(this.txtDescription);
            this.lytInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.lytInput.Location = new System.Drawing.Point(0, 0);
            this.lytInput.Name = "lytInput";
            this.lytInput.Root = this.Root;
            this.lytInput.Size = new System.Drawing.Size(728, 156);
            this.lytInput.TabIndex = 4;
            this.lytInput.Text = "dataLayoutControl1";
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.speciesBindingSource, "Id", true));
            this.txtId.Location = new System.Drawing.Point(12, 34);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Options.UseTextOptions = true;
            this.txtId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtId.Properties.Mask.EditMask = "N0";
            this.txtId.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtId.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtId.Size = new System.Drawing.Size(164, 26);
            this.txtId.StyleController = this.lytInput;
            this.txtId.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.speciesBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(180, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(536, 26);
            this.txtName.StyleController = this.lytInput;
            this.txtName.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.speciesBindingSource, "Description", true));
            this.txtDescription.Location = new System.Drawing.Point(12, 86);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(704, 58);
            this.txtDescription.StyleController = this.lytInput;
            this.txtDescription.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(728, 156);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForId,
            this.ItemForDescription,
            this.ItemForName});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(708, 136);
            // 
            // ItemForId
            // 
            this.ItemForId.Control = this.txtId;
            this.ItemForId.Location = new System.Drawing.Point(0, 0);
            this.ItemForId.Name = "ItemForId";
            this.ItemForId.Size = new System.Drawing.Size(168, 52);
            this.ItemForId.Text = "Id";
            this.ItemForId.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForId.TextSize = new System.Drawing.Size(77, 19);
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.Control = this.txtDescription;
            this.ItemForDescription.Location = new System.Drawing.Point(0, 52);
            this.ItemForDescription.Name = "ItemForDescription";
            this.ItemForDescription.Size = new System.Drawing.Size(708, 84);
            this.ItemForDescription.Text = "Description";
            this.ItemForDescription.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForDescription.TextSize = new System.Drawing.Size(77, 19);
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.txtName;
            this.ItemForName.Location = new System.Drawing.Point(168, 0);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(540, 52);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForName.TextSize = new System.Drawing.Size(77, 19);
            // 
            // frmSpecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 435);
            this.Controls.Add(this.lytInput);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grcDemo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSpecies";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytInput)).EndInit();
            this.lytInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl grcDemo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.BindingSource speciesBindingSource;
        private DevExpress.XtraDataLayout.DataLayoutControl lytInput;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
    }
}

