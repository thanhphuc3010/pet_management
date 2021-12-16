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
        public frmPartReport()
        {
            InitializeComponent();
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
            DateTime dt = new DateTime(2021, 12, 15);
            rptPartUseReport.SetDataSource(data.Where(x => x.ExaminationDate >= dt));
            //rptMedical1.SetParameterValue("pPetNumber", _petData.PetNumber);
            //rptMedical1.SetParameterValue("pPetName", _petData.PetName);
            //rptMedical1.SetParameterValue("pBreed", _petData.Breed);
            //rptMedical1.SetParameterValue("pCustomer", _petData.CustomerName);
            //rptMedical1.SetParameterValue("pAddress", _petData.Address);
            //rptMedical1.SetParameterValue("pPhone", _petData.Phone);
            crystalReportViewer2.ReportSource = rptPartUseReport;
            crystalReportViewer2.Refresh();
        }
    }
}