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
    public partial class frmPetInfor : DevExpress.XtraEditors.XtraForm
    {
        public frmPetInfor()
        {
            InitializeComponent();
        }

        private void frmPetInfor_Load(object sender, EventArgs e)
        {
            speciesPetBindingSource.DataSource = SpeciesBUS.GetData();
        }
    }
}