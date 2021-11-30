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
using DevExpress.XtraEditors.Repository;

namespace pet_management
{
    public partial class frmPartInfor : DevExpress.XtraEditors.XtraForm
    {
        private readonly frmPart frmPart;
        private Part part;
        private bool isEditMode;
        public frmPartInfor(frmPart frmPart, Part part, bool isEditMode)
        {
            InitializeComponent();
            this.frmPart = frmPart;
            this.part = part;
            this.isEditMode = isEditMode;
            InitializeData();
        }

        private void InitializeData()
        {
            unitBindingSource.DataSource = UnitBUS.GetUnits();
            txtPartNumber.Text = (part == null && !isEditMode) ? GenerateId() : part.PartNumber;
        }

        private string GenerateId()
        {
            string query = "SELECT* FROM part ORDER BY part_number DESC LIMIT 1";
            return MyHelper.GenerateId("HH", query, "part_number");
        }

        private void luUnit_QueryPopUp(object sender, CancelEventArgs e)
        {
           
        }
    }
}