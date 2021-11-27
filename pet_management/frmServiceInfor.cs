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
    public partial class frmServiceInfor : DevExpress.XtraEditors.XtraForm
    {
        public frmServiceInfor()
        {
            InitializeComponent();
        }

        private void frmServiceInfor_Load(object sender, EventArgs e)
        {
            groupServiceBindingSource.DataSource = GroupServiceBUS.GetGroupServices();
        }
    }
}