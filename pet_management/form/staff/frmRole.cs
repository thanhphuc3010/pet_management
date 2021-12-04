using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DTO;

namespace pet_management
{
    public partial class frmRole : DevExpress.XtraEditors.XtraForm
    {
        EntityState state = EntityState.Unchaged;
        public frmRole()
        {
            InitializeComponent();
        }

        #region handle event
        private void frmRole_Load(object sender, EventArgs e)
        {
            LoadData();
            this.MaximizeBox = false;
            HandleControl();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            state = EntityState.Added;
            btnAdd.Disable();
            resetInput();
            roleBindingSource.Add(new Role());
            roleBindingSource.MoveLast();
            HandleControl();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            roleBindingSource.EndEdit();
            Role role = roleBindingSource.Current as Role;
            if (role != null)
            {
                if (state == EntityState.Added)
                {
                    bool isSuccess = RoleBUS.Save(role);
                }
                else if (state == EntityState.Changed)
                {
                    RoleBUS.Update(role);
                }
            }
            btnAdd.Enable();
            grcRole.Refresh();
            state = EntityState.Unchaged;
            HandleControl();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            state = EntityState.Changed;
            HandleControl();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            state = EntityState.Deleted;
            Role role = roleBindingSource.Current as Role;
            if (role != null)
            {
                string message = "Bạn có chắc chắn muốn xóa bản ghi này không?";
                DialogResult dialogResult = MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dialogResult == DialogResult.Yes)
                {
                    bool isSuccess = RoleBUS.Delete(role.Id);
                    if (isSuccess)
                    {
                        roleBindingSource.RemoveCurrent();
                        MyHelper.showSuccessMessage("Xóa bản ghi thành công");
                    }
                    grcRole.Refresh();
                    state = EntityState.Unchaged;
                    HandleControl();
                }
                else
                {
                    state = EntityState.Unchaged;
                    HandleControl();
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (state == EntityState.Added)
            {
                roleBindingSource.RemoveCurrent();
                state = EntityState.Unchaged;
            }
            if (state == EntityState.Changed)
            {
                LoadData();
                txtDescription.ReadOnly = true;
                txtName.ReadOnly = true;
                state = EntityState.Unchaged;
            }
            HandleControl();
        }
        #endregion

        private void HandleControl()
        {
            txtCode.ReadOnly = true;
            btnAdd.Enable();
            switch (state)
            {
                case EntityState.Unchaged:
                    txtName.ReadOnly = true;
                    txtDescription.ReadOnly = true;
                    btnUpdate.Disable();
                    break;
                case EntityState.Added:
                case EntityState.Changed:
                    txtCode.ReadOnly = false;
                    txtName.ReadOnly = false;
                    txtDescription.ReadOnly = false;
                    txtName.Focus();
                    btnUpdate.Enable();
                    break;
                case EntityState.Deleted:
                    break;
                default:
                    break;
            }
        }

        private void LoadData()
        {
            roleBindingSource.DataSource = RoleBUS.GetRoles();
        }

        private void resetInput()
        {
            txtCode.Text = null;
            txtName.Text = null;
            txtDescription.Text = null;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                string name = view.GetFocusedRowCellValue("Id").ToString();
                MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, name));
            }
        }

        private void gridViewRole_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            MessageBox.Show(e.CellValue.ToString());
        }

        private void gridViewRole_RowClick(object sender, RowClickEventArgs e)
        {
            string id = (sender as GridView).GetFocusedRowCellValue("Code").ToString();
            MessageBox.Show(id);
        }
    }
}
