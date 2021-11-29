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

namespace pet_management
{
    public partial class frmPart : DevExpress.XtraEditors.XtraForm
    {
        public frmPart()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keySearch = txtSearch.Text.ToString().Trim();
            if (!string.IsNullOrEmpty(keySearch))
            {
                gridViewPart.ApplyFindFilter(keySearch);
            }
            else
            {
                gridViewPart.ClearFindFilter();
            }
        }
    }
}