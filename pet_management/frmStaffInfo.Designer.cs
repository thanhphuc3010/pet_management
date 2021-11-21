
namespace pet_management
{
    partial class frmStaffInfo
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
            this.dtcStaff = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtFirstname = new DevExpress.XtraEditors.TextEdit();
            this.txtLastname = new DevExpress.XtraEditors.TextEdit();
            this.dtBirthday = new DevExpress.XtraEditors.DateEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.cboRole = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForStaffNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFirstname = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLastname = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBirthday = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForRoleId = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuit = new DevExpress.XtraEditors.SimpleButton();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtcStaff)).BeginInit();
            this.dtcStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStaffNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFirstname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLastname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRoleId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtcStaff
            // 
            this.dtcStaff.Controls.Add(this.txtNumber);
            this.dtcStaff.Controls.Add(this.txtFirstname);
            this.dtcStaff.Controls.Add(this.txtLastname);
            this.dtcStaff.Controls.Add(this.dtBirthday);
            this.dtcStaff.Controls.Add(this.txtPhone);
            this.dtcStaff.Controls.Add(this.txtEmail);
            this.dtcStaff.Controls.Add(this.txtAddress);
            this.dtcStaff.Controls.Add(this.cboRole);
            this.dtcStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtcStaff.Location = new System.Drawing.Point(0, 0);
            this.dtcStaff.LookAndFeel.SkinName = "Office 2010 Blue";
            this.dtcStaff.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dtcStaff.Name = "dtcStaff";
            this.dtcStaff.Root = this.Root;
            this.dtcStaff.Size = new System.Drawing.Size(717, 236);
            this.dtcStaff.TabIndex = 0;
            this.dtcStaff.Text = "dataLayoutControl1";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(106, 12);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Properties.Appearance.Options.UseFont = true;
            this.txtNumber.Size = new System.Drawing.Size(139, 24);
            this.txtNumber.StyleController = this.dtcStaff;
            this.txtNumber.TabIndex = 5;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(78, 50);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(278, 24);
            this.txtFirstname.StyleController = this.dtcStaff;
            this.txtFirstname.TabIndex = 6;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(426, 50);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(279, 24);
            this.txtLastname.StyleController = this.dtcStaff;
            this.txtLastname.TabIndex = 7;
            // 
            // dtBirthday
            // 
            this.dtBirthday.EditValue = null;
            this.dtBirthday.Location = new System.Drawing.Point(315, 12);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dtBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBirthday.Size = new System.Drawing.Size(176, 24);
            this.dtBirthday.StyleController = this.dtcStaff;
            this.dtBirthday.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(78, 88);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(278, 24);
            this.txtPhone.StyleController = this.dtcStaff;
            this.txtPhone.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(426, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(279, 24);
            this.txtEmail.StyleController = this.dtcStaff;
            this.txtEmail.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(78, 136);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(627, 88);
            this.txtAddress.StyleController = this.dtcStaff;
            this.txtAddress.TabIndex = 11;
            // 
            // cboRole
            // 
            this.cboRole.Location = new System.Drawing.Point(561, 12);
            this.cboRole.Name = "cboRole";
            this.cboRole.Properties.Appearance.Options.UseTextOptions = true;
            this.cboRole.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cboRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboRole.Properties.DataSource = this.roleBindingSource;
            this.cboRole.Properties.DisplayMember = "Name";
            this.cboRole.Properties.NullText = "";
            this.cboRole.Properties.PopupSizeable = false;
            this.cboRole.Properties.ValueMember = "Id";
            this.cboRole.Size = new System.Drawing.Size(144, 24);
            this.cboRole.StyleController = this.dtcStaff;
            this.cboRole.TabIndex = 12;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(717, 236);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForStaffNumber,
            this.ItemForFirstname,
            this.ItemForPhone,
            this.ItemForAddress,
            this.ItemForLastname,
            this.ItemForBirthday,
            this.ItemForEmail,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.ItemForRoleId});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal;
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 0;
            this.layoutControlGroup1.Size = new System.Drawing.Size(697, 216);
            // 
            // ItemForStaffNumber
            // 
            this.ItemForStaffNumber.Control = this.txtNumber;
            this.ItemForStaffNumber.Location = new System.Drawing.Point(0, 0);
            this.ItemForStaffNumber.Name = "ItemForStaffNumber";
            this.ItemForStaffNumber.Size = new System.Drawing.Size(237, 28);
            this.ItemForStaffNumber.Text = "Mã nhân viên";
            this.ItemForStaffNumber.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.ItemForStaffNumber.TextSize = new System.Drawing.Size(89, 18);
            this.ItemForStaffNumber.TextToControlDistance = 5;
            // 
            // ItemForFirstname
            // 
            this.ItemForFirstname.Control = this.txtFirstname;
            this.ItemForFirstname.Location = new System.Drawing.Point(0, 38);
            this.ItemForFirstname.Name = "ItemForFirstname";
            this.ItemForFirstname.Size = new System.Drawing.Size(348, 28);
            this.ItemForFirstname.Text = "Họ đệm";
            this.ItemForFirstname.TextSize = new System.Drawing.Size(66, 18);
            // 
            // ItemForPhone
            // 
            this.ItemForPhone.Control = this.txtPhone;
            this.ItemForPhone.Location = new System.Drawing.Point(0, 76);
            this.ItemForPhone.Name = "ItemForPhone";
            this.ItemForPhone.Size = new System.Drawing.Size(348, 28);
            this.ItemForPhone.Text = "Phone";
            this.ItemForPhone.TextSize = new System.Drawing.Size(66, 18);
            // 
            // ItemForAddress
            // 
            this.ItemForAddress.Control = this.txtAddress;
            this.ItemForAddress.Location = new System.Drawing.Point(0, 124);
            this.ItemForAddress.Name = "ItemForAddress";
            this.ItemForAddress.Size = new System.Drawing.Size(697, 92);
            this.ItemForAddress.Text = "Address";
            this.ItemForAddress.TextSize = new System.Drawing.Size(66, 18);
            // 
            // ItemForLastname
            // 
            this.ItemForLastname.Control = this.txtLastname;
            this.ItemForLastname.Location = new System.Drawing.Point(348, 38);
            this.ItemForLastname.Name = "ItemForLastname";
            this.ItemForLastname.Size = new System.Drawing.Size(349, 28);
            this.ItemForLastname.Text = "Tên";
            this.ItemForLastname.TextSize = new System.Drawing.Size(66, 18);
            // 
            // ItemForBirthday
            // 
            this.ItemForBirthday.Control = this.dtBirthday;
            this.ItemForBirthday.Location = new System.Drawing.Point(237, 0);
            this.ItemForBirthday.Name = "ItemForBirthday";
            this.ItemForBirthday.Size = new System.Drawing.Size(246, 28);
            this.ItemForBirthday.Text = "Ngày sinh";
            this.ItemForBirthday.TextSize = new System.Drawing.Size(66, 18);
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.txtEmail;
            this.ItemForEmail.Location = new System.Drawing.Point(348, 76);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(349, 28);
            this.ItemForEmail.Text = "Email";
            this.ItemForEmail.TextSize = new System.Drawing.Size(66, 18);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 114);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(697, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 104);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(697, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 66);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(697, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 28);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(697, 10);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForRoleId
            // 
            this.ItemForRoleId.Control = this.cboRole;
            this.ItemForRoleId.Location = new System.Drawing.Point(483, 0);
            this.ItemForRoleId.Name = "ItemForRoleId";
            this.ItemForRoleId.Size = new System.Drawing.Size(214, 28);
            this.ItemForRoleId.Text = "Vai trò";
            this.ItemForRoleId.TextSize = new System.Drawing.Size(66, 18);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(500, 249);
            this.btnSave.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Ghi nhận";
            this.btnSave.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(611, 249);
            this.btnQuit.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btnQuit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(94, 40);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(DTO.Role);
            // 
            // frmStaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 301);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtcStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmStaffInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStaffInfo";
            this.Load += new System.EventHandler(this.frmStaffInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtcStaff)).EndInit();
            this.dtcStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStaffNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFirstname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLastname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBirthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRoleId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dtcStaff;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private DevExpress.XtraEditors.TextEdit txtFirstname;
        private DevExpress.XtraEditors.TextEdit txtLastname;
        private DevExpress.XtraEditors.DateEdit dtBirthday;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.MemoEdit txtAddress;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStaffNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFirstname;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRoleId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLastname;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBirthday;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnQuit;
        private DevExpress.XtraEditors.LookUpEdit cboRole;
        private System.Windows.Forms.BindingSource roleBindingSource;
    }
}