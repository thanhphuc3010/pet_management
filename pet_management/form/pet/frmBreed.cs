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
    public partial class frmBreed : DevExpress.XtraEditors.XtraForm
    {
        private string id;
        public frmBreed()
        {
            InitializeComponent();
        }

        private void frmBreed_Load(object sender, EventArgs e)
        {
            
        }

        private void cboBreed_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = cboBreed.SelectedValue.ToString();
            MessageBox.Show(id);
        }

        private void lbBreed_Click(object sender, EventArgs e)
        {

        }
    }
}
