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
    public partial class ucPartUseReport : DevExpress.XtraEditors.XtraUserControl
    {
        private StaffBUS staffBUS = new StaffBUS();
        public ucPartUseReport()
        {
            InitializeComponent();
        }

        public Staff SelectedDoctor
        {
            get
            {
                return (Staff)cboDoctor.SelectedItem;
            }
        }

        public DateTime FromDate
        {
            get
            {
                return dtFromDate.DateTime;
            }
        }
        public DateTime ToDate
        {
            get
            {
                return dtToDate.DateTime;
            }
        }

        private void ucPartUseReport_Load(object sender, EventArgs e)
        {
            dtToDate.DateTime = DateTime.Today;
            dtFromDate.DateTime = DateTime.Today;
            List<Staff> doctors = StaffBUS.GetDoctors();

            Staff staff = new Staff();
            staff.FullName = "---Bác sĩ---";
            staff.Id = 0;
            doctors.Add(staff);
            
            cboDoctor.DataSource = doctors;
            cboDoctor.ValueMember = "Id";
            cboDoctor.DisplayMember = "FullName";
        }

        private void cbEnableStaff_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
