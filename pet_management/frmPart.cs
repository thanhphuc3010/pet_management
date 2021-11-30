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
    }
}