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
    public partial class frmExaminationView : DevExpress.XtraEditors.XtraForm
    {
        private Examination examination;
        private readonly ReceivePetBUS receivePetBUS = new ReceivePetBUS();
        private readonly ExaminationBUS examinationBUS = new ExaminationBUS();
        private readonly XtraForm frm;
        private decimal subtotal;
        private List<ELItem> detailsItem = null;
        public frmExaminationView(XtraForm frm, Examination examination)
        {
            InitializeComponent();
            this.examination = examination;
            this.frm = frm;
        }

        private void frmExaminationView_Load(object sender, EventArgs e)
        {
            if (examination.Status != ExaminationStatus.Paymented)
            {
                btnPayment.Enable();
            } else
            {
                btnPayment.Disable();
                txtPayment.Text = examination.Payment.ToString();
                txtPayment.ApplyFormatToView();
                txtPayment.ReadOnly = true;
            }
            InitializeData();
        }

        private void InitializeData()
        {
            staffBindingSource.DataSource = StaffBUS.GetDoctors();
            BindData(examination);
            BindExDetail();
            BindSummaryPayment();
        }

        private void BindData(Examination examination)
        {
            string petId = examination.PetId.ToString();
            Pet pet = PetBUS.GetPet(petId);
            PetData petData = receivePetBUS.GetPetData(petId);


            BindPetData(petData);

            txtID.Text = examination.ExaminationNumber.ToString();
            dtExaminationDate.DateTime = examination.ExaminationDate;
            txtType.Text = examination.Type.ToString();
            gluDoctor.EditValue = examination.DoctorId;
            gridViewDetail.Columns["ItemType"].GroupIndex = 0;
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

        private void BindExDetail()
        {
            detailsItem = examinationBUS.GetDetail(examination.Id);
            eLItemBindingSource.DataSource = detailsItem;
            unitBindingSource.DataSource = UnitBUS.GetUnits();
            ServiceBUS serviceBUS = new ServiceBUS();
            serviceBindingSource.DataSource = serviceBUS.GetServices();
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
            subtotal = total - discount + tax;
            txtSubtotal.Text = (total - discount + tax).ToString();
            txtSubtotal.ApplyFormatToView();
        }

        private void DoPayment()
        {
            
            examination.Payment = Convert.ToDecimal(txtPayment.GetTextTrim());
            examination.Status = ExaminationStatus.Paymented;
            var isSuccess = examinationBUS.DoneExamination(examination);
            if (isSuccess)
            {
                MyHelper.ShowSuccessMessage("Lưu phiếu khám thành công", "Thông báo");
                (frm as frmReceivePet).RefreshGridData();
                this.Close();
            }
            else
            {
                MyHelper.ShowErrorMessage("Đã có lỗi xảy ra. Vui lòng thử lại", "Lỗi");
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPayment.GetTextTrim()))
            {
                MyHelper.ShowErrorMessage("Vui lòng nhập số tiền thanh toán", "Cảnh báo");
                return;
            }
            decimal payment = Convert.ToDecimal(txtPayment.GetTextTrim());
            if (payment > subtotal)
            {
                MyHelper.ShowErrorMessage($"Số tiền thanh toán đang lớn hơn giá trị phải trả", "Lỗi");
                return;
            } else
            {
                DoPayment();
            }
        }

        private void frmExaminationView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}