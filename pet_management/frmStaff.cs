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
            frmStaffInfo f = new frmStaffInfo(this, null, isEditMode: false);
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
                frmStaffInfo f = new frmStaffInfo(this, staff, isEditMode: true);
                f.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = gridViewStaff.GetFocusedRowCellValue("Id").ToString();
            if (id == null) return;
            Helper.showDialogConfirmDelete("Bạn có chắc chắn muốn xóa bản ghi này không ?", DeleteStaff, id);
        }

        private bool DeleteStaff(string id)
        {
            bool result = StaffBUS.Delete(id);
            if (result)
            {
                LoadData();
            }
            return result;
        }

        private void gridViewStaff_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.IsDataRow(e.RowHandle))
            {
                e.Info.DisplayText = (view.GetVisibleIndex(e.RowHandle) + 1).ToString();
                //e.Info.ImageIndex = -1;
            }
            var pen = view.PaintAppearance.HorzLine.GetBackPen(e.Cache);
            var startPoint = new Point(e.Bounds.Location.X, e.Bounds.Bottom - (int)pen.Width);
            var endPoint = new Point(e.Bounds.Right, e.Bounds.Bottom - (int)pen.Width);
            e.DefaultDraw();
            e.Cache.DrawLine(pen, startPoint, endPoint);
            e.Handled = true;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keySearch = txtSearch.Text.ToString();
            if (!string.IsNullOrEmpty(keySearch))
            {
                gridViewStaff.ApplyFindFilter(keySearch);
            }
            else
            {
                gridViewStaff.ClearFindFilter();
            }
        }
    }
}
