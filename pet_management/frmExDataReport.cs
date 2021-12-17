using BUS;
using DevExpress.XtraEditors;
using DTO;
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
    public partial class frmExDataReport : DevExpress.XtraEditors.XtraForm
    {
        private ReportBUS reportBUS = new ReportBUS();
        private ExaminationBUS examinationBUS = new ExaminationBUS();
        private string type;
        private int month;
        private int year;
        private Staff staff;
        public frmExDataReport(string type, int month, int year, Staff s)
        {
            InitializeComponent();
            this.type = type;
            this.month = month;
            this.year = year;
            this.staff = s;
        }

        private void frmExDataReport_Load(object sender, EventArgs e)
        {
            List<ExaminationData> examinationDatas = reportBUS.GetExaminationDatas(month, year, type);
            foreach (ExaminationData exData in examinationDatas)
            {
                exData.Subtotal = exData.Total + exData.Tax - exData.Discount;
            }

            rptExaminationReport1.SetDataSource(examinationDatas.Where(x => x.Total > 0));
            rptExaminationReport1.SetParameterValue("pType", type);
            string time = (month == 0) ? $"{year}" : $"{month}/{year}";
            rptExaminationReport1.SetParameterValue("pTime", time);
            rptExaminationReport1.SetParameterValue("pStaff", staff.FullName);
            //rptMedical1.SetParameterValue("pBreed", _petData.Breed);
            crvExData.ReportSource = rptExaminationReport1;
            crvExData.Refresh();
        }
    }
}