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
    public partial class frmBreed : Form
    {
        private string id;
        public frmBreed()
        {
            InitializeComponent();
        }

        private void frmBreed_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM species";
            cboBreed.FillCombo(query, "id", "name", null);
            cboBreed.SelectedIndex = 0;
            id = cboBreed.SelectedValue.ToString();
        }

        private void cboBreed_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = cboBreed.SelectedValue.ToString();
            MessageBox.Show(id);
        }
    }
}
