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
using DTO;
using BUS;

namespace pet_management
{
    public partial class frmPart : DevExpress.XtraEditors.XtraForm
    {
        PartBUS partBUS = new PartBUS();
        public frmPart()
        {
            InitializeComponent();
        }
        #region Handle Event
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            MyHelper.HandleSearch(gridViewPart, txtSearch);
        }

        private void frmPart_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion

        #region Handle Logic
        public void LoadData()
        {
            List<Part> parts = partBUS.GetParts();
            partBindingSource.DataSource = parts;
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPartInfor f = new frmPartInfor(this, null, isEditMode: false);
            f.ShowDialog();
        }

        private void rbtnDelete_Click(object sender, EventArgs e)
        {
            Part part = gridViewPart.GetFocusedRow() as Part;
            if (XtraMessageBox.Show($"Bạn có chắc chắn muốn xóa {part.Name} ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool isSuccess = partBUS.Delete(part.Id.ToString());
                if (isSuccess)
                {
                    LoadData();
                    XtraMessageBox.Show($"Xóa hàng hóa: {part.Name} thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void rtbnEdit_Click(object sender, EventArgs e)
        {
            Part part = gridViewPart.GetFocusedRow() as Part;
            frmPartInfor f = new frmPartInfor(this, part, isEditMode: true);
            f.ShowDialog();
        }
    }
}