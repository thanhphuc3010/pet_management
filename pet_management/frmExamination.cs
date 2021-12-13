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
    public partial class frmExamination : DevExpress.XtraEditors.XtraForm
    {
        private ExaminationBUS examinationBUS = new ExaminationBUS();
        private ReceivePetBUS receivePetBUS = new ReceivePetBUS();
        public frmExamination()
        {
            InitializeComponent();
        }

        private void dateEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmExamination_Load(object sender, EventArgs e)
        {
            InitailizeData();
        }

        private void InitailizeData()
        {
            grcExamination.DataSource = examinationBUS.GetExaminationsToday();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            grcExamination.DataSource = examinationBUS.GetExaminationsToday();
        }

        private void repoBtnStart_Click(object sender, EventArgs e)
        {
            Examination exam = gridViewExamination.GetFocusedRow() as Examination;
            XtraMessageBox.Show($"{exam.PetId}");
            string id = exam.Id.ToString();
            PetData petData = receivePetBUS.GetPetData(id);
            BinData(petData);
        }

        private void BinData(PetData petData)
        {
            throw new NotImplementedException();
        }
    }
}