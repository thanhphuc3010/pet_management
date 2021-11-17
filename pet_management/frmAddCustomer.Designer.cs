
namespace pet_management
{
    partial class frmAddCustomer
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
            this.dtcCustomer = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.txtCustomerNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtFirstname = new DevExpress.XtraEditors.TextEdit();
            this.txtLastname = new DevExpress.XtraEditors.TextEdit();
            this.dpDob = new DevExpress.XtraEditors.DateEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.txtDiscount = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCustomerNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFirstName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLastName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDiscountRate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForDob = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuit = new DevExpress.XtraEditors.SimpleButton();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtcCustomer)).BeginInit();
            this.dtcCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpDob.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpDob.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiscountRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtcCustomer
            // 
            this.dtcCustomer.Controls.Add(this.txtCustomerNumber);
            this.dtcCustomer.Controls.Add(this.txtFirstname);
            this.dtcCustomer.Controls.Add(this.txtLastname);
            this.dtcCustomer.Controls.Add(this.dpDob);
            this.dtcCustomer.Controls.Add(this.txtPhone);
            this.dtcCustomer.Controls.Add(this.txtEmail);
            this.dtcCustomer.Controls.Add(this.txtAddress);
            this.dtcCustomer.Controls.Add(this.txtDiscount);
            this.dtcCustomer.DataSource = this.customerBindingSource;
            this.dtcCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtcCustomer.Location = new System.Drawing.Point(0, 0);
            this.dtcCustomer.Name = "dtcCustomer";
            this.dtcCustomer.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.dtcCustomer.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.dtcCustomer.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.dtcCustomer.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.dtcCustomer.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.dtcCustomer.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dtcCustomer.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dtcCustomer.Root = this.layoutControlGroup1;
            this.dtcCustomer.Size = new System.Drawing.Size(651, 249);
            this.dtcCustomer.TabIndex = 1;
            this.dtcCustomer.Text = "dataLayoutControl1";
            // 
            // txtCustomerNumber
            // 
            this.txtCustomerNumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "CustomerNumber", true));
            this.txtCustomerNumber.Location = new System.Drawing.Point(116, 12);
            this.txtCustomerNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerNumber.Name = "txtCustomerNumber";
            this.txtCustomerNumber.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerNumber.Properties.Appearance.Options.UseFont = true;
            this.txtCustomerNumber.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtCustomerNumber.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.txtCustomerNumber.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.txtCustomerNumber.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtCustomerNumber.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtCustomerNumber.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtCustomerNumber.Size = new System.Drawing.Size(140, 24);
            this.txtCustomerNumber.StyleController = this.dtcCustomer;
            this.txtCustomerNumber.TabIndex = 4;
            // 
            // txtFirstname
            // 
            this.txtFirstname.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Firstname", true));
            this.txtFirstname.Location = new System.Drawing.Point(116, 50);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Properties.Appearance.Options.UseFont = true;
            this.txtFirstname.Size = new System.Drawing.Size(140, 24);
            this.txtFirstname.StyleController = this.dtcCustomer;
            this.txtFirstname.TabIndex = 5;
            // 
            // txtLastname
            // 
            this.txtLastname.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Lastname", true));
            this.txtLastname.Location = new System.Drawing.Point(374, 50);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Properties.Appearance.Options.UseFont = true;
            this.txtLastname.Size = new System.Drawing.Size(265, 24);
            this.txtLastname.StyleController = this.dtcCustomer;
            this.txtLastname.TabIndex = 6;
            // 
            // dpDob
            // 
            this.dpDob.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Dob", true));
            this.dpDob.EditValue = null;
            this.dpDob.Location = new System.Drawing.Point(116, 88);
            this.dpDob.Margin = new System.Windows.Forms.Padding(4);
            this.dpDob.Name = "dpDob";
            this.dpDob.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDob.Properties.Appearance.Options.UseFont = true;
            this.dpDob.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpDob.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpDob.Size = new System.Drawing.Size(207, 24);
            this.dpDob.StyleController = this.dtcCustomer;
            this.dpDob.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Phone", true));
            this.txtPhone.Location = new System.Drawing.Point(431, 88);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Size = new System.Drawing.Size(208, 24);
            this.txtPhone.StyleController = this.dtcCustomer;
            this.txtPhone.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(116, 126);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(523, 24);
            this.txtEmail.StyleController = this.dtcCustomer;
            this.txtEmail.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Address", true));
            this.txtAddress.Location = new System.Drawing.Point(116, 164);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Size = new System.Drawing.Size(523, 73);
            this.txtAddress.StyleController = this.dtcCustomer;
            this.txtAddress.TabIndex = 10;
            // 
            // txtDiscount
            // 
            this.txtDiscount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "DiscountRate", true));
            this.txtDiscount.EditValue = "0";
            this.txtDiscount.Location = new System.Drawing.Point(374, 12);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Properties.Appearance.Options.UseFont = true;
            this.txtDiscount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDiscount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDiscount.Properties.Mask.EditMask = "G";
            this.txtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDiscount.Size = new System.Drawing.Size(109, 24);
            this.txtDiscount.StyleController = this.dtcCustomer;
            this.txtDiscount.TabIndex = 11;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(651, 249);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCustomerNumber,
            this.ItemForFirstName,
            this.ItemForAddress,
            this.ItemForLastName,
            this.ItemForDiscountRate,
            this.ItemForEmail,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.emptySpaceItem5,
            this.emptySpaceItem6,
            this.ItemForDob,
            this.ItemForPhone,
            this.emptySpaceItem7});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(631, 229);
            // 
            // ItemForCustomerNumber
            // 
            this.ItemForCustomerNumber.AppearanceItemCaption.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemForCustomerNumber.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForCustomerNumber.Control = this.txtCustomerNumber;
            this.ItemForCustomerNumber.Location = new System.Drawing.Point(0, 0);
            this.ItemForCustomerNumber.Name = "ItemForCustomerNumber";
            this.ItemForCustomerNumber.Size = new System.Drawing.Size(248, 28);
            this.ItemForCustomerNumber.Text = "Mã khách hàng";
            this.ItemForCustomerNumber.TextSize = new System.Drawing.Size(101, 18);
            // 
            // ItemForFirstName
            // 
            this.ItemForFirstName.AppearanceItemCaption.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemForFirstName.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForFirstName.Control = this.txtFirstname;
            this.ItemForFirstName.Location = new System.Drawing.Point(0, 38);
            this.ItemForFirstName.Name = "ItemForFirstName";
            this.ItemForFirstName.Size = new System.Drawing.Size(248, 28);
            this.ItemForFirstName.Text = "Họ đệm";
            this.ItemForFirstName.TextSize = new System.Drawing.Size(101, 18);
            // 
            // ItemForAddress
            // 
            this.ItemForAddress.AppearanceItemCaption.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemForAddress.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForAddress.Control = this.txtAddress;
            this.ItemForAddress.Location = new System.Drawing.Point(0, 152);
            this.ItemForAddress.Name = "ItemForAddress";
            this.ItemForAddress.Size = new System.Drawing.Size(631, 77);
            this.ItemForAddress.Text = "Address";
            this.ItemForAddress.TextSize = new System.Drawing.Size(101, 18);
            // 
            // ItemForLastName
            // 
            this.ItemForLastName.AppearanceItemCaption.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemForLastName.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForLastName.Control = this.txtLastname;
            this.ItemForLastName.Location = new System.Drawing.Point(258, 38);
            this.ItemForLastName.Name = "ItemForLastName";
            this.ItemForLastName.Size = new System.Drawing.Size(373, 28);
            this.ItemForLastName.Text = "Tên";
            this.ItemForLastName.TextSize = new System.Drawing.Size(101, 18);
            // 
            // ItemForDiscountRate
            // 
            this.ItemForDiscountRate.AppearanceItemCaption.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemForDiscountRate.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForDiscountRate.Control = this.txtDiscount;
            this.ItemForDiscountRate.Location = new System.Drawing.Point(258, 0);
            this.ItemForDiscountRate.Name = "ItemForDiscountRate";
            this.ItemForDiscountRate.Size = new System.Drawing.Size(217, 28);
            this.ItemForDiscountRate.Text = "Chiết khấu";
            this.ItemForDiscountRate.TextSize = new System.Drawing.Size(101, 18);
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.AppearanceItemCaption.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemForEmail.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForEmail.Control = this.txtEmail;
            this.ItemForEmail.Location = new System.Drawing.Point(0, 114);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(631, 28);
            this.ItemForEmail.Text = "Email";
            this.ItemForEmail.TextSize = new System.Drawing.Size(101, 18);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(475, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(156, 28);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 28);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(631, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 66);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(631, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 142);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(631, 10);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(248, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(10, 28);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(248, 38);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(10, 28);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForDob
            // 
            this.ItemForDob.AppearanceItemCaption.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemForDob.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForDob.Control = this.dpDob;
            this.ItemForDob.Location = new System.Drawing.Point(0, 76);
            this.ItemForDob.Name = "ItemForDob";
            this.ItemForDob.Size = new System.Drawing.Size(315, 28);
            this.ItemForDob.Text = "Ngày sinh";
            this.ItemForDob.TextSize = new System.Drawing.Size(101, 18);
            // 
            // ItemForPhone
            // 
            this.ItemForPhone.AppearanceItemCaption.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemForPhone.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForPhone.Control = this.txtPhone;
            this.ItemForPhone.Location = new System.Drawing.Point(315, 76);
            this.ItemForPhone.Name = "ItemForPhone";
            this.ItemForPhone.Size = new System.Drawing.Size(316, 28);
            this.ItemForPhone.Text = "Phone";
            this.ItemForPhone.TextSize = new System.Drawing.Size(101, 18);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(0, 104);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(631, 10);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(477, 267);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 37);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Ghi nhận";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.Appearance.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Appearance.Options.UseFont = true;
            this.btnQuit.Location = new System.Drawing.Point(562, 267);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(77, 37);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(DTO.Customer);
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 312);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtcCustomer);
            this.Name = "frmAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddCustomer";
            this.Load += new System.EventHandler(this.frmAddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtcCustomer)).EndInit();
            this.dtcCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpDob.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpDob.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiscountRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dtcCustomer;
        private DevExpress.XtraEditors.TextEdit txtCustomerNumber;
        private DevExpress.XtraEditors.TextEdit txtFirstname;
        private DevExpress.XtraEditors.TextEdit txtLastname;
        private DevExpress.XtraEditors.DateEdit dpDob;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.MemoEdit txtAddress;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustomerNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFirstName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLastName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDiscountRate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDob;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnQuit;
        private DevExpress.XtraEditors.TextEdit txtDiscount;
        private System.Windows.Forms.BindingSource customerBindingSource;
    }
}