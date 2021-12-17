using BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
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
        private PetData _petData;
        private Pet pet;
        private bool editable = false;

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
            petExBindingSource.DataSource = PetBUS.GetPets();
            staffExBindingSource.DataSource = StaffBUS.GetDoctors();
            dtFrom.DateTime = DateTime.Today;
            dtTo.DateTime = DateTime.Today;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            examinationBindingSource.DataSource = examinationBUS.GetExaminationsToday();
        }

        private void repoBtnStart_Click(object sender, EventArgs e)
        {
            
            Examination exam = gridViewExamination.GetFocusedRow() as Examination;
            editable = true;
            if (currentExamination == null || (exam != currentExamination && exam.Status == ExaminationStatus.Pending) || exam.Status == ExaminationStatus.Doing)
            {
                ResetAllFieldData();
                currentExamination = exam;

                currentExamination.Status = ExaminationStatus.Doing;
                var isSuccess = examinationBUS.DoneExamination(currentExamination);
                if (isSuccess)
                {
                    examinationBindingSource.DataSource = examinationBUS.GetExaminationsToday();
                }

                BindData(currentExamination);
                BindExDetail();
                gridViewDetail.Columns["ItemType"].GroupIndex = 0;
                if (detailsItem.Count == 0 || detailsItem == null)
                {
                    ResetSummaryPayment();
                } else
                {
                    BindSummaryPayment();
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng hoàn thành phiên khám cũ trước khi bắt đầu khám cho bệnh nhân mới");
            }
        }

        private void BindData(Examination examination)
        {
            string petId = examination.PetId.ToString();
            pet = PetBUS.GetPet(petId);
            PetData petData = receivePetBUS.GetPetData(petId);
            _petData = petData;
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
            gridViewDetail.Columns["ItemType"].GroupIndex = 0;
        }

        private void BindExDetail()
        {
            detailsItem = examinationBUS.GetDetail(currentExamination.Id);
            eLItemBindingSource.DataSource = detailsItem;
            unitBindingSource.DataSource = UnitBUS.GetUnits();
            ServiceBUS serviceBUS = new ServiceBUS();
            serviceBindingSource.DataSource = serviceBUS.GetServices();
        }

        private Staff GetStaffCurrent()
        {
            frmMain f = (frmMain)this.ParentForm;
            return f.GetStaffLogined();
        }

        public void BindPetData(PetData petData)
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
            unitBindingSource.DataSource = UnitBUS.GetUnits();
            BindSummaryPayment();
        }

        private void BindSummaryPayment()
        {
            var total = detailsItem.Sum(item => item.Total);
            var discount = detailsItem.Sum(x => x.Discount);
            var tax = detailsItem.Sum(x => x.Tax);
            txtTotal.Text = total.ToString();
            txtTotal.ApplyFormatToView();
            txtDiscount.Text = discount.ToString();
            txtDiscount.ApplyFormatToView();
            txtTax.Text = tax.ToString();
            txtTax.ApplyFormatToView();
            txtSubtotal.Text = (total - discount + tax).ToString();
            txtSubtotal.ApplyFormatToView();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            frmSelectPart f = new frmSelectPart(this, currentExamination.Id, detailsItem);
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
            currentExamination.Note = txtNote.GetTextTrim();
            currentExamination.Total = Convert.ToDecimal(txtSubtotal.GetTextTrim());
            var isSuccess = examinationBUS.DoneExamination(currentExamination);
            if (isSuccess)
            {
                examinationBindingSource.DataSource = examinationBUS.GetExaminationsToday();
                ResetAllFieldData();
                ResetSummaryPayment();
            }
        }

        private void ResetSummaryPayment()
        {
            txtTotal.Text = "0";
            txtDiscount.Text = "0";
            txtTax.Text = "0";
            txtSubtotal.Text = "0";
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
            txtConclude.Text = null;
            txtSymptom.Text = null;
            txtNote.Text = null;

            eLItemBindingSource.DataSource = null;
            currentExamination = null;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            examinationBindingSource.DataSource = examinationBUS.GetExaminationsToday();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            examinationBindingSource.DataSource = examinationBUS.GetExaminations();
        }

        private void gridViewExamination_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "Action")
            {
                string status = view.GetRowCellValue(e.RowHandle, "Status").ToString();
                if (status == ExaminationStatus.Done)
                    e.RepositoryItem = rbtnViewEdit;
                else
                    e.RepositoryItem = rbtnStart;
            }
        }

        private void rbtnViewEdit_Click(object sender, EventArgs e)
        {
            Examination exam = gridViewExamination.GetFocusedRow() as Examination;
            if (!editable)
            {
                currentExamination = exam;
                BindData(currentExamination);
                BindExDetail();
                BindSummaryPayment();
            } 
            else
            {
                XtraMessageBox.Show("Vui lòng hoàn thành phiên khám cũ trước khi bắt đầu khám cho bệnh nhân mới");
            }
        }

        private void rbtnEdit_Click(object sender, EventArgs e)
        {
            ELItem item = gridViewDetail.GetFocusedRow() as ELItem;
            {
                frmEditItemEx f = new frmEditItemEx(this, item);
                f.ShowDialog();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            editable = false;
            currentExamination.Symptom = txtSymptom.GetTextTrim();
            currentExamination.Conclude = txtConclude.GetTextTrim();
            currentExamination.Note = txtNote.GetTextTrim();
            currentExamination.Total = Convert.ToDecimal(txtSubtotal.GetTextTrim());
            var isSuccess = examinationBUS.DoneExamination(currentExamination);
            if (isSuccess)
            {
                examinationBindingSource.DataSource = examinationBUS.GetExaminationsToday();
                ResetAllFieldData();
                ResetSummaryPayment(); 
                MyHelper.ShowSuccessMessage("Lưu phiếu khám thành công", "Thông báo");
            } else
            {
                MyHelper.ShowErrorMessage("Đã có lỗi xảy ra. Vui lòng thử lại", "Lỗi");
            }
        }

        private void btnEditPet_Click(object sender, EventArgs e)
        {
            frmPetInfor f = new frmPetInfor(this, pet, true);
            f.ShowDialog();
        }

        public void RefeshListExWhenEditPetInfor()
        {
            InitailizeData();
        }

        private void btnDoing_Click(object sender, EventArgs e)
        {
            List<Examination> examinations = examinationBUS.GetExaminationsToday();
            examinationBindingSource.DataSource = examinations.Where(x => x.Status == ExaminationStatus.Doing).ToList();
        }

        private void btnWait_Click(object sender, EventArgs e)
        {
            List<Examination> examinations = examinationBUS.GetExaminationsToday();
            examinationBindingSource.DataSource = examinations.Where(x => x.Status == ExaminationStatus.Pending).ToList();
        }

        private void btnPrintMedical_Click(object sender, EventArgs e)
        {
            using (frmPrintMedical frm = new frmPrintMedical(detailsItem, _petData))
            {
                frm.ShowDialog();
            }
        }
    }
}