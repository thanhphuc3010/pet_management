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
        private ReceivePetBUS receivePetBUS = new ReceivePetBUS();
        private ExaminationBUS examinationBUS = new ExaminationBUS();
        private int count;
        private string PREFIX = "PKDV";
        public frmReceivePet()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void frmReceivePet_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void InitializeData()
        {
            petBindingSource.DataSource = PetBUS.GetPets();
            cboType.Properties.Items.AddRange(ExaminationType.GetListType());
            GenerateExamNumber();
            dtExaminationDate.DateTime = DateTime.Now;
            LoadListDoctor();
            LoadListReceptionlist();
        }

        private void GenerateExamNumber()
        {
            DateTime current = DateTime.Now;
            count = receivePetBUS.GetCountExaminationToday();
            string suffix = String.Format("{0:00}", (count + 1));
            string exNumber = $"{current.Day}{current.Month}{current.Year}{suffix}";
            txtIdNumber.Text = $"{PREFIX}{exNumber}";
        }

        private void gluIdPet_EditValueChanged(object sender, EventArgs e)
        {
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
        }

        private void LoadListDoctor()
        {
            doctorBindingSource.DataSource = StaffBUS.GetDoctors();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (gluDoctor.EditValue.ToString() == "")
            {
                XtraMessageBox.Show($"Vui lòng chỉ định bác sĩ khám chữa bệnh");
                return;
            }

            RegisterExamination();
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
            examination.Status = "Chưa khám";
            examinationBUS.Save(examination);
        }
    }
}