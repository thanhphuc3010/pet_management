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
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DTO;

namespace pet_management
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
            gridViewCustomer_RowClick(gridViewCustomer, null);
        }

        public void LoadData()
        {
            
            customerBindingSource.DataSource = CustomerBUS.GetCustomers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCustomer f = new frmAddCustomer(this, null);
            f.ShowDialog();
        }

        private void gridViewCustomer_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string id = (sender as GridView).GetFocusedRowCellValue("Id").ToString();
            //MessageBox.Show(id);
            Customer customer = CustomerBUS.GetCustomerByID(id);
        }

        private void gridViewCustomer_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            { 
                string id = view.GetFocusedRowCellValue("Id").ToString();
                Customer customer = CustomerBUS.GetCustomerByID(id);
                frmAddCustomer f = new frmAddCustomer(this, customer);
                f.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = gridViewCustomer.GetFocusedRowCellValue("Id").ToString();
            if (id == null) return;
            Helper.showDialogConfirmDelete("Bạn có chắc chắn muốn xóa khách hàng", DeleteCustomer, id);
        }

        private bool DeleteCustomer(string id)
        {
            bool result = CustomerBUS.Delete(id);
            if (result)
            {
                LoadData();
            }
            return result;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = gridViewCustomer.GetFocusedRowCellValue("Id").ToString();
            if (id == null) return;
            Customer customer = CustomerBUS.GetCustomerByID(id);
            frmAddCustomer f = new frmAddCustomer(this, customer);
            f.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
