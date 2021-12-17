using BUS;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet_management
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Staff staff;
        private Role role;
        public bool isLogin = false;
        public frmMain()
        {
            InitializeComponent();
        }

        public Staff GetStaffLogined()
        {
            if (staff != null)
            {
                return this.staff;
            }
            else
            {
                return null;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void InitializeData()
        {
            if (!isLogin)
            {
                InitializeLoginForm();
            }
            else
            {
                InitializeView();
            }
        }

        private void InitializeView()
        {
            role = RoleBUS.GetRoleById(staff.IdRole.ToString());
            if (role.Code != "ADMIN")
            {
                rbpHR.Visible = false;
            }
            else
            {
                rbpHR.Visible = true;
            }
        }

        private void InitializeLoginForm()
        {
            frmLogin f = new frmLogin();
            f.ShowDialog(this);
        }

        private void OpenForm(Type frmType)
        {
            foreach (Form form in MdiChildren)
            {
                if (form.GetType() == frmType)
                {
                    form.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(frmType);
            f.MdiParent = this;
            f.Show();
        }

        public void DisposeAllForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
                frm.Close();
            }
            foreach (XtraForm frm in this.MdiChildren)
            {
                frm.Dispose();
                frm.Close();
            }
        }

        private void OpenFormAsDialog(Type frmType)
        {
            Form f = (Form)Activator.CreateInstance(frmType);
            f.ShowDialog();
        }

        private void btnStaff_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmStaff));
        }

        private void btnRole_ItemClick(object sender, ItemClickEventArgs e)
        {
            //OpenForm(typeof(frmRole));
            OpenFormAsDialog(typeof(frmRole));
        }

        private void btnPart_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmPart));
        }

        private void btnCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmCustomer));
        }

        internal void SetLoginInfor(Staff s)
        {
            staff = s;
            isLogin = true;
            InitializeView();
            BindBottomStatusBar();
        }
        internal void ResetLoginSession()
        {
            this.staff = null;
            isLogin = false;
        }

        private void BindBottomStatusBar()
        {
            if (staff == null)
            {
                txtStaffName.Caption = "";
                txtRole.Caption = "";
                
            } else
            {
                txtStaffName.Caption = $"{ staff.FirstName} {staff.LastName}";
                txtRole.Caption = role.Name;
            }
            lbCompanyName.Caption = "Bệnh viện thú y Sasaki";
            txtCurrentDate.Caption = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void btnPet_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmPet));
        }

        private void btnDontiep_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmReceivePet));
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmExamination));
        }

        private void btnGroupService_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFormAsDialog(typeof(frmGroupService));
        }

        private void btnService_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFormAsDialog(typeof(frmService));
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFormAsDialog(typeof(frmSpecies));
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFormAsDialog(typeof(frmBreed));
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDTReport f = new frmDTReport();
            f.ShowDialog(this);
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmExaminationReport f = new frmExaminationReport();
            f.ShowDialog(this);
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReports f = new frmReports();
            f.ShowDialog(this);
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            ResetLoginSession();
            DisposeAllForm();
            InitializeData();
            BindBottomStatusBar();
        }

        private void btnCloseAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            DisposeAllForm();
        }
    }
}