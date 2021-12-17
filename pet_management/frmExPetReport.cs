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
    public partial class frmExPetReport : DevExpress.XtraEditors.XtraForm
    {

        private ReportBUS reportBUS = new ReportBUS();
        private ExaminationBUS examinationBUS = new ExaminationBUS();
        private Customer customer;
        private Staff doctor;
        private Staff currentStaff;
        private string type;
        private DateTime FromDate;
        private DateTime ToDate;

        private List<ExaminationInfor> examinationInfors;

        public frmExPetReport(List<ExaminationInfor> data, Staff doctor, Customer customer, Staff currStaff, string type, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            this.examinationInfors = data;
            this.doctor = doctor;
            this.customer = customer;
            this.currentStaff = currStaff;
            this.type = type;
            this.FromDate = fromDate;
            this.ToDate = toDate;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            //var result = reportBUS.GetExaminationDatas();
            //var filter = result.Where(x => x.ExaminationDate.Month == 10).ToList();
            //result.Count();
            currentStaff.FullName = $"{currentStaff.FirstName} {currentStaff.LastName}";

            rptExaminationReport1.SetDataSource(examinationInfors);
            rptExaminationReport1.SetParameterValue("pFromDate", FromDate);
            rptExaminationReport1.SetParameterValue("fToDate", ToDate);
            rptExaminationReport1.SetParameterValue("fCustomerName", customer.Fullname);
            rptExaminationReport1.SetParameterValue("fDoctor", doctor.FullName);
            rptExaminationReport1.SetParameterValue("fType", type);
            rptExaminationReport1.SetParameterValue("pStaff", currentStaff.FullName);
            crystalReportViewer1.ReportSource = rptExaminationReport1;
            crystalReportViewer1.Refresh();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}