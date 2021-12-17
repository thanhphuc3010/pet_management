
namespace pet_management
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnCloseAll = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnStaff = new DevExpress.XtraBars.BarButtonItem();
            this.btnRole = new DevExpress.XtraBars.BarButtonItem();
            this.btnPart = new DevExpress.XtraBars.BarButtonItem();
            this.btnGroupService = new DevExpress.XtraBars.BarButtonItem();
            this.btnService = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnPet = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDontiep = new DevExpress.XtraBars.BarButtonItem();
            this.txtStaffName = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.btnReportEx = new DevExpress.XtraBars.BarButtonItem();
            this.lbCompanyName = new DevExpress.XtraBars.BarStaticItem();
            this.txtRole = new DevExpress.XtraBars.BarStaticItem();
            this.txtCurrentDate = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpHR = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnLogout,
            this.btnCloseAll,
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnStaff,
            this.btnRole,
            this.btnPart,
            this.btnGroupService,
            this.btnService,
            this.btnCustomer,
            this.btnPet,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.btnDontiep,
            this.txtStaffName,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.btnReportEx,
            this.lbCompanyName,
            this.txtRole,
            this.txtCurrentDate});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 25;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbon.Size = new System.Drawing.Size(1285, 183);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Id = 1;
            this.btnLogout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogout.ImageOptions.SvgImage")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.Caption = "Đóng hết";
            this.btnCloseAll.Id = 2;
            this.btnCloseAll.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCloseAll.ImageOptions.SvgImage")));
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCloseAll_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Xem thông tin";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Đổi mật khẩu";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnStaff
            // 
            this.btnStaff.Caption = "Nhân viên";
            this.btnStaff.Id = 5;
            this.btnStaff.ImageOptions.SvgImage = global::pet_management.Properties.Resources.ic_staff;
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStaff_ItemClick);
            // 
            // btnRole
            // 
            this.btnRole.Caption = "Vai trò";
            this.btnRole.Id = 6;
            this.btnRole.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRole.ImageOptions.SvgImage")));
            this.btnRole.Name = "btnRole";
            this.btnRole.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRole_ItemClick);
            // 
            // btnPart
            // 
            this.btnPart.Caption = "Hàng hóa";
            this.btnPart.Id = 7;
            this.btnPart.ImageOptions.SvgImage = global::pet_management.Properties.Resources.icon_part_32x32;
            this.btnPart.Name = "btnPart";
            this.btnPart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPart_ItemClick);
            // 
            // btnGroupService
            // 
            this.btnGroupService.Caption = "Nhóm dịch vụ";
            this.btnGroupService.Id = 8;
            this.btnGroupService.ImageOptions.SvgImage = global::pet_management.Properties.Resources.Group_547;
            this.btnGroupService.Name = "btnGroupService";
            this.btnGroupService.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGroupService_ItemClick);
            // 
            // btnService
            // 
            this.btnService.Caption = "Dịch vụ";
            this.btnService.Id = 9;
            this.btnService.ImageOptions.SvgImage = global::pet_management.Properties.Resources.icon_technician;
            this.btnService.Name = "btnService";
            this.btnService.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnService_ItemClick);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Caption = "Khách hàng";
            this.btnCustomer.Id = 10;
            this.btnCustomer.ImageOptions.SvgImage = global::pet_management.Properties.Resources.icon_assign;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomer_ItemClick);
            // 
            // btnPet
            // 
            this.btnPet.Caption = "Thú cưng";
            this.btnPet.Id = 11;
            this.btnPet.ImageOptions.SvgImage = global::pet_management.Properties.Resources.ic_pet_color;
            this.btnPet.Name = "btnPet";
            this.btnPet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPet_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Danh mục giống";
            this.barButtonItem3.Id = 12;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Danh mục loài";
            this.barButtonItem4.Id = 13;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Danh mục đơn vị";
            this.barButtonItem5.Id = 14;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // btnDontiep
            // 
            this.btnDontiep.Caption = "Tiếp đón";
            this.btnDontiep.Id = 15;
            this.btnDontiep.ImageOptions.SvgImage = global::pet_management.Properties.Resources.icon_post_reward;
            this.btnDontiep.Name = "btnDontiep";
            this.btnDontiep.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDontiep_ItemClick);
            // 
            // txtStaffName
            // 
            this.txtStaffName.Caption = "---Staff Name---";
            this.txtStaffName.Id = 16;
            this.txtStaffName.Name = "txtStaffName";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Danh sách khám chữa bệnh";
            this.barButtonItem6.Id = 17;
            this.barButtonItem6.ImageOptions.SvgImage = global::pet_management.Properties.Resources.ic_chooseasset_2x;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Báo cáo thống kê";
            this.barButtonItem7.Id = 18;
            this.barButtonItem7.ImageOptions.SvgImage = global::pet_management.Properties.Resources.ic_report;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Báo cáo doanh thu";
            this.barButtonItem8.Id = 19;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Báo cáo hàng hóa sử dụng";
            this.barButtonItem9.Id = 20;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // btnReportEx
            // 
            this.btnReportEx.Caption = "BC sử dụng dịch vụ";
            this.btnReportEx.Id = 21;
            this.btnReportEx.Name = "btnReportEx";
            this.btnReportEx.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.Caption = "Bệnh viện thú y Sasaki";
            this.lbCompanyName.Id = 22;
            this.lbCompanyName.Name = "lbCompanyName";
            // 
            // txtRole
            // 
            this.txtRole.Caption = "--Staff role--";
            this.txtRole.Id = 23;
            this.txtRole.Name = "txtRole";
            // 
            // txtCurrentDate
            // 
            this.txtCurrentDate.Caption = "--CurrentDate--";
            this.txtCurrentDate.Id = 24;
            this.txtCurrentDate.Name = "txtCurrentDate";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Trang chính";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCloseAll);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ thống";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Thông tin người dùng";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpHR,
            this.ribbonPageGroup4,
            this.ribbonPageGroup6});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản lý danh mục";
            // 
            // rbpHR
            // 
            this.rbpHR.ItemLinks.Add(this.btnStaff);
            this.rbpHR.ItemLinks.Add(this.btnRole);
            this.rbpHR.Name = "rbpHR";
            this.rbpHR.Text = "Nhân sự";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnPart);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnGroupService);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnService);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Hàng hóa - Dịch vụ";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Danh mục chung";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup7});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Quản lý tiếp đón";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnCustomer);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnPet);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDontiep);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Quản lý tiếp đón";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Quản lý khám chữa bệnh";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Báo cáo - Thống kê";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup8.ItemLinks.Add(this.btnReportEx);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Báo cáo thống kê";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.lbCompanyName);
            this.ribbonStatusBar.ItemLinks.Add(this.txtStaffName);
            this.ribbonStatusBar.ItemLinks.Add(this.txtRole);
            this.ribbonStatusBar.ItemLinks.Add(this.txtCurrentDate);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 741);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1285, 38);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.AppearancePage.Header.Options.UseImage = true;
            this.tabbedView1.DocumentProperties.UseFormIconAsDocumentImage = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 779);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý khám chữa bệnh thú y";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpHR;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnCloseAll;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnStaff;
        private DevExpress.XtraBars.BarButtonItem btnRole;
        private DevExpress.XtraBars.BarButtonItem btnPart;
        private DevExpress.XtraBars.BarButtonItem btnGroupService;
        private DevExpress.XtraBars.BarButtonItem btnService;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnCustomer;
        private DevExpress.XtraBars.BarButtonItem btnPet;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnDontiep;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarStaticItem txtStaffName;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem btnReportEx;
        private DevExpress.XtraBars.BarStaticItem lbCompanyName;
        private DevExpress.XtraBars.BarStaticItem txtRole;
        private DevExpress.XtraBars.BarButtonItem txtCurrentDate;
    }
}