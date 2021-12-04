using DevExpress.XtraBars;
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
        public frmMain()
        {
            InitializeComponent();
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
            f.MdiParent = this;
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

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
    }
}