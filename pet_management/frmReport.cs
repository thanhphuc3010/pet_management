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
    public partial class frmReport : DevExpress.XtraEditors.XtraForm
    {

        private ReportBUS reportBUS = new ReportBUS();
        private ExaminationBUS examinationBUS = new ExaminationBUS();

        public frmReport()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<ExaminationInfor> examinationInfors = reportBUS.GetListExaminationInfor();

            foreach (ExaminationInfor exInfor in examinationInfors)
            {
                List<ELItem> Items = examinationBUS.GetDetail(exInfor.Id);
                exInfor.Total = Items.Sum(x => x.Total);
                exInfor.Tax = Items.Sum(x => x.Tax);
                exInfor.Discount = Items.Sum(x => x.Discount);
                exInfor.Subtotal = exInfor.Total + exInfor.Tax - exInfor.Discount;
            }

            rptExaminationReport1.SetDataSource(examinationInfors);
            //rptMedical1.SetParameterValue("pPetNumber", _petData.PetNumber);
            //rptMedical1.SetParameterValue("pPetName", _petData.PetName);
            //rptMedical1.SetParameterValue("pBreed", _petData.Breed);
            //rptMedical1.SetParameterValue("pCustomer", _petData.CustomerName);
            //rptMedical1.SetParameterValue("pAddress", _petData.Address);
            //rptMedical1.SetParameterValue("pPhone", _petData.Phone);
            crystalReportViewer1.ReportSource = rptExaminationReport1;
            crystalReportViewer1.Refresh();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            var result = reportBUS.GetExaminationDatas();
            result.Count();
        }
    }
}