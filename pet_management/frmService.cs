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

namespace pet_management
{
    public partial class frmService : DevExpress.XtraEditors.XtraForm
    {
        public frmService()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmServiceInfor f = new frmServiceInfor();
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
        }
    }
}