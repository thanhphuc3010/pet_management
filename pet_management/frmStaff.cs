using BUS;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            List<Staff> result = StaffBUS.GetStaffs();
            staffBindingSource.DataSource = result;
            roleStaffBindingSource.DataSource = RoleBUS.GetRoles();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmStaffInfo f = new frmStaffInfo(this, null);
            f.ShowDialog();
        }

        private void gridViewStaff_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string id = view.GetFocusedRowCellValue("Id").ToString();
                Staff staff = StaffBUS.GetStaffById(id);
                frmStaffInfo f = new frmStaffInfo(this, staff);
                f.ShowDialog();
            }
        }
    }
}
