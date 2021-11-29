using DevExpress.XtraEditors;
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
using DTO;

namespace pet_management
{
    public partial class frmGroupService : DevExpress.XtraEditors.XtraForm
    {
        EntityState state = EntityState.Unchaged;
        public frmGroupService()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            groupServiceBindingSource.DataSource = GroupServiceBUS.GetGroupServices();
        }

        private void frmGroupService_Load(object sender, EventArgs e)
        {
            LoadData();
            HandleControl();
        }

        private void HandleControl()
        {
            switch (state)
            {
                case EntityState.Unchaged:
                    txtName.ReadOnly = true;
                    txtDescription.ReadOnly = true;
                    btnSave.Disable();
                    btnDel.Enable();
                    btnEdit.Enable();
                    btnCancel.Disable();
                    btnAdd.Enable();
                    break;
                case EntityState.Added:
                case EntityState.Changed:
                    txtName.ReadOnly = false;
                    txtDescription.ReadOnly = false;
                    txtName.Focus();
                    btnSave.Enable();
                    btnAdd.Disable();
                    btnEdit.Disable();
                    btnCancel.Enable();
                    break;
                case EntityState.Deleted:
                    break;
                default:
                    break;
            }
        }
        private void ResetInput()
        {
            txtDescription.Text = null;
            txtName.Text = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            state = EntityState.Added;
            HandleControl();
            ResetInput();
            string sql = "SELECT code FROM service_group ORDER BY code DESC LIMIT 1";
            string code = MyHelper.GenerateId("NVD", sql, "code");
            txtCode.Text = code;
            GroupService groupService = new GroupService();
            groupService.Code = code;
            groupServiceBindingSource.Add(groupService);
            groupServiceBindingSource.MoveLast();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            groupServiceBindingSource.EndEdit();
            GroupService groupService = groupServiceBindingSource.Current as GroupService;
            if (groupService != null)
            {
                if (state == EntityState.Added)
                {
                    bool isSuccess = GroupServiceBUS.Save(groupService);
                }
                else if (state == EntityState.Changed)
                {
                    GroupServiceBUS.Update(groupService);
                }
            }
            btnAdd.Enable();
            grcGroupService.Refresh();
            state = EntityState.Unchaged;
            HandleControl();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            state = EntityState.Deleted;
            GroupService groupService = groupServiceBindingSource.Current as GroupService;
            if (groupService != null)
            {
                string message = "Bạn có chắc chắn muốn xóa bản ghi này không?";
                DialogResult dialogResult = MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dialogResult == DialogResult.Yes)
                {
                    bool isSuccess = GroupServiceBUS.Delete(groupService.Code.ToString());
                    if (isSuccess)
                    {
                        groupServiceBindingSource.RemoveCurrent();
                        MyHelper.showSuccessMessage("Xóa bản ghi thành công");
                    }
                    grcGroupService.Refresh();
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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            state = EntityState.Changed;
            HandleControl();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (state == EntityState.Added)
            {
                groupServiceBindingSource.RemoveCurrent();
            }
            if (state == EntityState.Changed)
            {
                LoadData();
                txtDescription.ReadOnly = true;
                txtName.ReadOnly = true;
            }
            state = EntityState.Unchaged;
            HandleControl();
        }
    }
}