using BUS;
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

namespace pet_management
{
    public partial class frmReceivePet : DevExpress.XtraEditors.XtraForm
    {
        private const string REGISTER_SUCCESS_MESSAGE = "Đăng ký thành công";
        private ReceivePetBUS receivePetBUS = new ReceivePetBUS();
        private ExaminationBUS examinationBUS = new ExaminationBUS();
        private int count;
        private string PREFIX = "PKDV";

        public frmReceivePet()
        {
            InitializeComponent();
            gluIdPet.EditValue = null;
        }

        private void frmReceivePet_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void InitializeData()
        {
            LoadPetGridLookUp();

            cboType.Properties.Items.AddRange(ExaminationType.GetListType());
            cboType.EditValue = cboType.Properties.Items[0];
            GenerateExamNumber();
            dtExaminationDate.DateTime = DateTime.Now;
            examinationBindingSource.DataSource = examinationBUS.GetExaminations();
            exTodayBindingSource.DataSource = examinationBUS.GetExaminationsToday();
            LoadListDoctor();
            LoadListReceptionlist();
        }

        private void LoadPetGridLookUp()
        {
            petBindingSource.DataSource = PetBUS.GetPets();
            List<Customer> customers = CustomerBUS.GetCustomers();
            foreach (Customer customer in customers)
            {
                customer.Fullname = $"{customer.Firstname} {customer.Lastname}";
            }
            customerBindingSource.DataSource = customers;
        }

        private void GenerateExamNumber()
        {
            DateTime current = DateTime.Now;
            count = examinationBUS.GetExaminationsToday().Count;
            string suffix = String.Format("{0:00}", (count + 1));
            string exNumber = $"{current.Day}{current.Month}{current.Year}{suffix}";
            txtIdNumber.Text = $"{PREFIX}{exNumber}";
        }

        private void gluIdPet_EditValueChanged(object sender, EventArgs e)
        {
            if (gluIdPet.EditValue == null)
            {
                return;
            }
            string id = gluIdPet.EditValue.ToString();
            PetData petData = receivePetBUS.GetPetData(id);
            BindPetData(petData);
        }

        private void BindPetData(PetData petData)
        {
            txtMicrochip.Text = petData.Microchip.ToString();
            txtPetName.Text = petData.PetName.ToString();
            txtBreed.Text = petData.Breed.ToString();
            txtSpecies.Text = petData.Species.ToString();
            txtWeight.Text = petData.Weight.ToString();
            txtAge.Text = petData.Age.ToString();
            txtCustomer.Text = petData.CustomerName.ToString();
            txtPhone.Text = petData.Phone.ToString();
            txtAddress.Text = petData.Address.ToString();
        }

        private void LoadListReceptionlist()
        {
            receptionlistBS.DataSource = StaffBUS.GetReceptionlist();
            gluReceptionlist.EditValue = gluReceptionlist.Properties.GetKeyValue(0);
        }

        private void LoadListDoctor()
        {
            doctorBindingSource.DataSource = StaffBUS.GetDoctors();
            gluDoctor.EditValue = gluDoctor.Properties.GetKeyValue(0);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateDataBeforeRegister();
            if (isValid)
            {
                RegisterExamination();
            }
        }

        private bool ValidateDataBeforeRegister()
        {
            string examinationNumber = txtIdNumber.GetTextTrim();
            if (gluIdPet.EditValue == null)
            {
                MyHelper.ShowErrorMessage("Vui lòng chọn thú cưng để đăng ký!", "Lỗi");
                return false;
            }
            if (string.IsNullOrEmpty(examinationNumber))
            {
                MyHelper.ShowErrorMessage("Mã phiếu khám là bắt buộc, vui lòng nhập mã phiếu khám!", "Lỗi");
                return false;
            }

            if (gluDoctor.EditValue.ToString() == "")
            {
                XtraMessageBox.Show($"Vui lòng chỉ định bác sĩ khám chữa bệnh");
                return false;
            }

            if (gluReceptionlist.EditValue.ToString() == "")
            {
                MyHelper.ShowErrorMessage("Nhân viên lễ tân không được để trống, vui lòng chọn lễ tân đón tiếp!", "Lỗi");
                return false;
            }
            return true;
        }

        private void RegisterExamination()
        {
            Examination examination = new Examination();
            examination.PetId = (int)gluIdPet.EditValue;
            examination.ExaminationNumber = txtIdNumber.GetTextTrim();
            examination.Type = cboType.EditValue.ToString();
            examination.ExaminationDate = dtExaminationDate.DateTime;
            examination.DoctorId = (int)gluDoctor.EditValue;
            examination.ReceptionistId = (int)gluReceptionlist.EditValue;
            examination.Status = ExaminationStatus.Pending;
            bool isSuccess = examinationBUS.Save(examination);
            if (isSuccess)
            {
                MyHelper.ShowSuccessMessage(REGISTER_SUCCESS_MESSAGE, "Thông báo");
                RefreshGridData();
                GenerateExamNumber();
            }
        }

        public void RefreshGridData()
        {
            examinationBindingSource.DataSource = examinationBUS.GetExaminations();
            exTodayBindingSource.DataSource = examinationBUS.GetExaminationsToday();
        }

        private void btnDoing_Click(object sender, EventArgs e)
        {
            List<Examination> examinations = examinationBUS.GetExaminationsToday();
            exTodayBindingSource.DataSource = examinations.Where(x => x.Status == ExaminationStatus.Doing).ToList();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            List<Examination> examinations = examinationBUS.GetExaminationsToday();
            exTodayBindingSource.DataSource = examinations;
        }

        private void btnWait_Click(object sender, EventArgs e)
        {
            List<Examination> examinations = examinationBUS.GetExaminationsToday();
            exTodayBindingSource.DataSource = examinations.Where(x => x.Status == ExaminationStatus.Pending).ToList();
        }

        private void btnPaymented_Click(object sender, EventArgs e)
        {
            List<Examination> examinations = examinationBUS.GetExaminationsToday();
            exTodayBindingSource.DataSource = examinations.Where(x => x.Status == ExaminationStatus.Paymented).ToList();

        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {

        }

        private void rbtnPayment_Click(object sender, EventArgs e)
        {
            Examination exam = gridView1.GetFocusedRow() as Examination;
            if (exam.Status == ExaminationStatus.Pending || exam.Status == ExaminationStatus.Doing)
            {
                MyHelper.ShowErrorMessage("Phiếu khám này chưa khám xong, chưa thể thanh toán", "Lỗi");
                return;
            } else
            {
                frmExaminationView f = new frmExaminationView(this, exam);
                f.ShowDialog();
            }
        }

        private void rbtnCancel_Click(object sender, EventArgs e)
        {
            Examination exam = gridView1.GetFocusedRow() as Examination;
            if (exam.Status == ExaminationStatus.Paymented)
            {
                MyHelper.ShowErrorMessage("Phiếu khám chữa bệnh này đã được thanh toán, không thể xóa", "Lỗi");
                return;
            }
            else
            {
                try
                {
                    examinationBUS.DeleteExamination(exam);
                    RefreshGridData();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void frmReceivePet_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmPetInfor f = new frmPetInfor(this, null, false);
            f.ShowDialog();
        }

        public void RefreshWhenCreateNewPet(string petId)
        {
            PetData petData = receivePetBUS.GetPetData(petId);
            LoadPetGridLookUp();
            BindPetData(petData);
            gluIdPet.EditValue = petId;
        }

        private void btnRefreshPet_Click(object sender, EventArgs e)
        {
            LoadPetGridLookUp();
        }
    }
}