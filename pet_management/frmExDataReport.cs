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
        public frmExDataReport()
        {
            InitializeComponent();
        }

        private void frmExDataReport_Load(object sender, EventArgs e)
        {
            List<ExaminationData> examinationDatas = reportBUS.GetExaminationDatas();
            foreach (ExaminationData exData in examinationDatas)
            {
                exData.Subtotal = exData.Total + exData.Tax - exData.Discount;
            }

            rptExaminationReport1.SetDataSource(examinationDatas.Where(x => x.Total > 0));
            rptExaminationReport1.SetParameterValue("pType", "Khám - chữa bệnh");
            rptExaminationReport1.SetParameterValue("pTime", "12/2021");
            //rptMedical1.SetParameterValue("pBreed", _petData.Breed);
            //rptMedical1.SetParameterValue("pCustomer", _petData.CustomerName);
            //rptMedical1.SetParameterValue("pAddress", _petData.Address);
            //rptMedical1.SetParameterValue("pPhone", _petData.Phone);
            crvExData.ReportSource = rptExaminationReport1;
            crvExData.Refresh();
        }
    }
}