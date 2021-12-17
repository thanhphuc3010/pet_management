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
    public partial class frmPartReport : DevExpress.XtraEditors.XtraForm
    {
        private ReportBUS reportBUS = new ReportBUS();
        private DateTime fromDate;
        private DateTime toDate;
        private Staff doctor;
        private Staff currentStaff;
        public frmPartReport(DateTime fromDate, DateTime toDate, Staff staff, Staff currentStaff)
        {
            InitializeComponent();
            this.fromDate = fromDate;
            this.toDate = toDate;
            this.doctor = staff;
            this.currentStaff = currentStaff;
        }

        private void frmPartReport_Load(object sender, EventArgs e)
        {
            List<ExaminationPartReport> data = reportBUS.GetExaminationPartReports();

            foreach (ExaminationPartReport item in data)
            {
                decimal sum = (item.Quantity * item.Price);
                item.Total = sum;
                item.Tax = sum * item.TaxRate / 100;
                item.Discount = sum * item.DiscountRate / 100;
                item.Subtotal = sum + item.Tax - item.Discount;
            }

            List<ExaminationPartReport> filterByDate = data.Where(x => (x.ExaminationDate >= fromDate) && (x.ExaminationDate <= toDate)).ToList();

            if (doctor.Id == 0)
            {
                rptPartUseReport.SetDataSource(filterByDate);
            } else
            {
                rptPartUseReport.SetDataSource(filterByDate.Where(x => x.DoctorId == doctor.Id));
            }
            rptPartUseReport.SetParameterValue("fDoctorName", doctor.FullName);
            rptPartUseReport.SetParameterValue("fFromDate", fromDate);
            rptPartUseReport.SetParameterValue("fToDate", toDate);

            rptPartUseReport.SetParameterValue("pStaff", currentStaff.FullName);
            crystalReportViewer2.ReportSource = rptPartUseReport;
            crystalReportViewer2.Refresh();
        }
    }
}