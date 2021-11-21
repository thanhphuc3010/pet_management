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
    public partial class frmPet : DevExpress.XtraEditors.XtraForm
    {
        public frmPet()
        {
            InitializeComponent();
        }

        private void frmPet_Load(object sender, EventArgs e)
        {
            petBindingSource.DataSource = PetBUS.GetPets();
        }

        private void searchControl1_TextChanged(object sender, EventArgs e)
        {
            string keySearch = txtSearch.Text.ToString().Trim();
            if (!string.IsNullOrEmpty(keySearch))
            {
                gridViewPet.ApplyFindFilter(keySearch);
            } else
            {
                gridViewPet.ClearFindFilter();
            }
        }
    }
}