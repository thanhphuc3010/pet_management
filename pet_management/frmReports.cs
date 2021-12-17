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
    public partial class frmReports : DevExpress.XtraEditors.XtraForm
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Staff doctor = ucPartUseReport1.SelectedDoctor;
            DateTime fromDate = ucPartUseReport1.FromDate;
            DateTime toDate = ucPartUseReport1.ToDate;
            frmMain f = (frmMain)Owner;
            Staff currentStaff = f.GetStaffLogined();
            currentStaff.FullName = currentStaff.FirstName + " " + currentStaff.LastName;

            frmPartReport fReport = new frmPartReport(fromDate, toDate, doctor, currentStaff);
            fReport.Show();
        }
    }
}