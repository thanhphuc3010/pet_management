using DevExpress.XtraBars;
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
            InitializeLoginForm();
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
            BindBottomStatusBar();
        }

        private void BindBottomStatusBar()
        {
            txtStaffName.Caption = $"{ staff.FirstName} {staff.LastName}";
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
            OpenFormAsDialog(typeof(frmReport));
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmExDataReport));
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmPartReport));
        }
    }
}