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
    public partial class frmService : DevExpress.XtraEditors.XtraForm
    {
        private ServiceBUS serviceBUS = new ServiceBUS();
        public frmService()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmServiceInfor f = new frmServiceInfor(this, null, false);
            f.ShowDialog();
        }

        private void frmService_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            serviceBindingSource.DataSource = ServiceBUS.GetServices();
            groupServiceBindingSource.DataSource = GroupServiceBUS.GetGroupServices();
            unitBindingSource.DataSource = UnitBUS.GetUnits();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = gridViewService.GetFocusedRowCellValue("Id").ToString();
            if (id == null) return;
            MyHelper.showDialogConfirmDelete("Bạn có chắc chắn muốn xóa bản ghi này không ?", DeleteService, id);
        }

        private bool DeleteService(string id)
        {
            bool result = serviceBUS.Delete(id);
            if (result)
            {
                LoadData();
            }
            return result;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = gridViewService.GetFocusedRowCellValue("Id").ToString();
            if (id != null)
            {
                Service service = serviceBUS.GetServiceById(id);
                frmServiceInfor f = new frmServiceInfor(this, service, isEditMode: true);
                f.ShowDialog();
            }
            else return;
        }
    }
}