using BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
        private Examination currentExamination = null;

        private List<ELItem> detailsItem = null;
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
            List<Examination> examinations = examinationBUS.GetExaminationsToday();
            examinations.Sort(new CompareExamination());
            examinationBindingSource.DataSource = examinations;
            staffBindingSource.DataSource = StaffBUS.GetDoctors();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            examinationBindingSource.DataSource = examinationBUS.GetExaminationsToday();
        }

        private void repoBtnStart_Click(object sender, EventArgs e)
        {
            Examination exam = gridViewExamination.GetFocusedRow() as Examination;
            if (currentExamination == null)
            {
                currentExamination = exam;

                XtraMessageBox.Show($"{currentExamination.PetId}");
                BindData(currentExamination);
            }
            else
            {
                XtraMessageBox.Show("Vui lòng hoàn thành phiên khám cũ trước khi bắt đầu khám cho bệnh nhân mới");
            }
        }

        private void BindData(Examination examination)
        {
            string petId = examination.PetId.ToString();
            PetData petData = receivePetBUS.GetPetData(petId);
            BindPetData(petData);

            txtID.Text = examination.ExaminationNumber.ToString();
            dtExaminationDate.DateTime = examination.ExaminationDate;
            txtType.Text = examination.Type.ToString();
            gluDoctor.EditValue = examination.DoctorId;

            Staff s = GetStaffCurrent();
            if (s.IdRole != 3)
            {
                gluDoctor.ReadOnly = true;
            }
            detailsItem = examinationBUS.GetDetail(currentExamination.Id);
            eLItemBindingSource.DataSource = detailsItem;
            BindSummaryPayment();
            gridViewDetail.Columns["ItemType"].GroupIndex = 0;
        }

        private Staff GetStaffCurrent()
        {
            frmMain f = (frmMain)this.ParentForm;
            return f.GetStaffLogined();
        }

        private void BindPetData(PetData petData)
        {
            txtPetId.Text = petData.PetNumber.ToString();
            txtMicrochip.Text = petData.Microchip.ToString();
            txtPetName.Text = petData.PetName.ToString();
            txtBreed.Text = petData.Breed.ToString();
            txtSpecies.Text = petData.Species.ToString();
            txtCustomerName.Text = petData.CustomerName.ToString();
            txtPhone.Text = petData.Phone.ToString();
            txtAddress.Text = petData.Address.ToString();
        }

        public void RefreshExDetail()
        {
            detailsItem = examinationBUS.GetDetail(currentExamination.Id);
            eLItemBindingSource.DataSource = detailsItem;
            gridViewDetail.Columns["ItemType"].GroupIndex = 0;
            BindSummaryPayment();
        }

        private void BindSummaryPayment()
        {
            txtTotal.Text = detailsItem.Sum(item => item.Price).ToString();
            txtTotal.ApplyFormatToView();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            frmSelectPart f = new frmSelectPart(this, currentExamination.Id);
            f.ShowDialog();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            frmSelectService f = new frmSelectService(this, currentExamination.Id);
            f.ShowDialog();
        }

        private void rbtnDelete_Click(object sender, EventArgs e)
        {
            ELItem item = gridViewDetail.GetFocusedRow() as ELItem;
            bool result = false;
            if (item.ItemType == "Hàng hóa")
            {
                result = examinationBUS.DeletePartDetail(item.ToExPart());
            }
            else if (item.ItemType == "Dịch vụ")
            {
                result = examinationBUS.DeleteServiceDetail(item.ToExService());
            }
            else
            {
                result = false;
            }
            if (result)
            {
                RefreshExDetail();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSymptom.Text) || string.IsNullOrEmpty(txtSymptom.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập đủ thông tin về triệu chứng và kết luận của bác sĩ!");
                return;
            }
            currentExamination.Status = ExaminationStatus.Done;
            currentExamination.Symptom = txtSymptom.GetTextTrim();
            currentExamination.Conclude = txtConclude.GetTextTrim();
            var isSuccess = examinationBUS.DoneExamination(currentExamination);
            if (isSuccess)
            {
                ResetAllFieldData();
            }
        }

        private void ResetAllFieldData()
        {
            txtPetId.Text = null;
            txtMicrochip.Text = null;
            txtPetName.Text = null;
            txtBreed.Text = null;
            txtSpecies.Text = null;
            txtCustomerName.Text = null;
            txtPhone.Text = null;
            txtAddress.Text = null;

            txtID.Text = null;
            dtExaminationDate.DateTime = DateTime.Today;
            txtType.Text = null;
            gluDoctor.EditValue = null;

            eLItemBindingSource.DataSource = null;
            currentExamination = null;
        }
    }
}