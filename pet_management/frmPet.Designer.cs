
namespace pet_management
{
    partial class frmPet
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
            this.groupPet = new DevExpress.XtraEditors.GroupControl();
            this.grcPet = new DevExpress.XtraGrid.GridControl();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMicrochip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBreedId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFeatherColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicalHistory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gpExaminationHistory = new DevExpress.XtraEditors.GroupControl();
            this.txtSearch = new DevExpress.XtraEditors.SearchControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupPet)).BeginInit();
            this.groupPet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpExaminationHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPet
            // 
            this.groupPet.Controls.Add(this.grcPet);
            this.groupPet.Location = new System.Drawing.Point(12, 12);
            this.groupPet.Name = "groupPet";
            this.groupPet.Size = new System.Drawing.Size(1023, 326);
            this.groupPet.TabIndex = 0;
            this.groupPet.Text = "Danh sách thú cưng trong hệ thống";
            // 
            // grcPet
            // 
            this.grcPet.DataSource = this.petBindingSource;
            this.grcPet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcPet.Location = new System.Drawing.Point(2, 26);
            this.grcPet.MainView = this.gridViewPet;
            this.grcPet.Name = "grcPet";
            this.grcPet.Size = new System.Drawing.Size(1019, 298);
            this.grcPet.TabIndex = 0;
            this.grcPet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPet});
            // 
            // petBindingSource
            // 
            this.petBindingSource.DataSource = typeof(DTO.Pet);
            // 
            // gridViewPet
            // 
            this.gridViewPet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPetNumber,
            this.colMicrochip,
            this.colBreedId,
            this.colCustomerId,
            this.colName,
            this.colAge,
            this.colWeight,
            this.colFeatherColor,
            this.colNote,
            this.colMedicalHistory,
            this.colCreatedDate,
            this.colUpdatedDate});
            this.gridViewPet.GridControl = this.grcPet;
            this.gridViewPet.Name = "gridViewPet";
            this.gridViewPet.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 94;
            // 
            // colPetNumber
            // 
            this.colPetNumber.FieldName = "PetNumber";
            this.colPetNumber.MinWidth = 25;
            this.colPetNumber.Name = "colPetNumber";
            this.colPetNumber.Visible = true;
            this.colPetNumber.VisibleIndex = 1;
            this.colPetNumber.Width = 94;
            // 
            // colMicrochip
            // 
            this.colMicrochip.FieldName = "Microchip";
            this.colMicrochip.MinWidth = 25;
            this.colMicrochip.Name = "colMicrochip";
            this.colMicrochip.Visible = true;
            this.colMicrochip.VisibleIndex = 2;
            this.colMicrochip.Width = 94;
            // 
            // colBreedId
            // 
            this.colBreedId.FieldName = "BreedId";
            this.colBreedId.MinWidth = 25;
            this.colBreedId.Name = "colBreedId";
            this.colBreedId.Visible = true;
            this.colBreedId.VisibleIndex = 3;
            this.colBreedId.Width = 94;
            // 
            // colCustomerId
            // 
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.MinWidth = 25;
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.Visible = true;
            this.colCustomerId.VisibleIndex = 4;
            this.colCustomerId.Width = 94;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 5;
            this.colName.Width = 94;
            // 
            // colAge
            // 
            this.colAge.FieldName = "Age";
            this.colAge.MinWidth = 25;
            this.colAge.Name = "colAge";
            this.colAge.Visible = true;
            this.colAge.VisibleIndex = 6;
            this.colAge.Width = 94;
            // 
            // colWeight
            // 
            this.colWeight.FieldName = "Weight";
            this.colWeight.MinWidth = 25;
            this.colWeight.Name = "colWeight";
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 7;
            this.colWeight.Width = 94;
            // 
            // colFeatherColor
            // 
            this.colFeatherColor.FieldName = "FeatherColor";
            this.colFeatherColor.MinWidth = 25;
            this.colFeatherColor.Name = "colFeatherColor";
            this.colFeatherColor.Visible = true;
            this.colFeatherColor.VisibleIndex = 8;
            this.colFeatherColor.Width = 94;
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 25;
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 9;
            this.colNote.Width = 94;
            // 
            // colMedicalHistory
            // 
            this.colMedicalHistory.FieldName = "MedicalHistory";
            this.colMedicalHistory.MinWidth = 25;
            this.colMedicalHistory.Name = "colMedicalHistory";
            this.colMedicalHistory.Visible = true;
            this.colMedicalHistory.VisibleIndex = 10;
            this.colMedicalHistory.Width = 94;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.MinWidth = 25;
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.Visible = true;
            this.colCreatedDate.VisibleIndex = 11;
            this.colCreatedDate.Width = 94;
            // 
            // colUpdatedDate
            // 
            this.colUpdatedDate.FieldName = "UpdatedDate";
            this.colUpdatedDate.MinWidth = 25;
            this.colUpdatedDate.Name = "colUpdatedDate";
            this.colUpdatedDate.Visible = true;
            this.colUpdatedDate.VisibleIndex = 12;
            this.colUpdatedDate.Width = 94;
            // 
            // gpExaminationHistory
            // 
            this.gpExaminationHistory.Location = new System.Drawing.Point(12, 352);
            this.gpExaminationHistory.Name = "gpExaminationHistory";
            this.gpExaminationHistory.Size = new System.Drawing.Size(1023, 314);
            this.gpExaminationHistory.TabIndex = 0;
            this.gpExaminationHistory.Text = "Lịch sử khám chữa bệnh / sử dụng dịch vụ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(95, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.txtSearch.Properties.NullValuePrompt = "Nhập từ khóa tìm kiếm...";
            this.txtSearch.Size = new System.Drawing.Size(423, 24);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.searchControl1_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 18);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tìm kiếm";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(931, 29);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.gpExaminationHistory);
            this.layoutControl1.Controls.Add(this.groupPet);
            this.layoutControl1.Location = new System.Drawing.Point(-1, 64);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1047, 678);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1047, 678);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupPet;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1027, 330);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 330);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1027, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gpExaminationHistory;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 340);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1027, 318);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 742);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtSearch);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmPet";
            this.Text = "frmPet";
            this.Load += new System.EventHandler(this.frmPet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupPet)).EndInit();
            this.groupPet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpExaminationHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupPet;
        private DevExpress.XtraEditors.GroupControl gpExaminationHistory;
        private DevExpress.XtraEditors.SearchControl txtSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl grcPet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPet;
        private System.Windows.Forms.BindingSource petBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colPetNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMicrochip;
        private DevExpress.XtraGrid.Columns.GridColumn colBreedId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAge;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colFeatherColor;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicalHistory;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedDate;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}