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
    public partial class frmPetInfor : DevExpress.XtraEditors.XtraForm
    {
        private readonly frmPet frmPet;
        private Pet pet;
        private bool isEditMode;
        public frmPetInfor(frmPet frmPet, Pet pet, bool isEditMode)
        {
            InitializeComponent();
            this.frmPet = frmPet;
            this.pet = pet;
            this.isEditMode = isEditMode;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            BeginInvoke(new MethodInvoker(() =>
            {
                txtMicro.FocusEnd();
            }));
        }

        private void frmPetInfor_Load(object sender, EventArgs e)
        {
            speciesPetBindingSource.DataSource = SpeciesBUS.GetData();
            breedBindingSource.DataSource = BreedBUS.GetBreeds();

            List<Customer> customers = CustomerBUS.GetCustomers();
            foreach (Customer c in customers)
            {
                c.Fullname = $"{c.Firstname} {c.Lastname}";
            }
            customerPetBindingSource.DataSource = customers;

            if (!isEditMode)
            {
                string query = "SELECT * FROM pet ORDER BY pet_number DESC LIMIT 1";
                txtId.Text = MyHelper.GenerateId("TC-", query, "pet_number");
            }
            else
            {
                BindPetData();
            }
        }

        private void BindPetData()
        {
            txtId.Text = pet.PetNumber;
            txtMicro.Text = pet.Microchip;
            cboBreed.EditValue = pet.BreedId;
            Breed breed = BreedBUS.GetBreedById(pet.BreedId.ToString());
            cboSpecies.EditValue = breed.SpeciesId;
            cboCustomer.EditValue = pet.CustomerId;
            txtName.Text = pet.Name;
            txtAge.Text = pet.Age;
            txtWeight.Text = pet.Weight;
            txtFeatherColor.Text = pet.FeatherColor;
            txtHistory.Text = pet.MedicalHistory;
            txtNote.Text = pet.Note;
        }

        private void SavePet()
        {
            Pet p = new Pet();
            p.PetNumber = txtId.Text.ToString().Trim();
            p.Microchip = txtMicro.Text.ToString().Trim();
            p.BreedId = Convert.ToInt32(cboBreed.GetColumnValue("Id"));
            p.CustomerId = Convert.ToInt32(cboCustomer.EditValue);
            p.Name = txtName.Text.ToString().Trim();
            p.Age = txtAge.Text.ToString().Trim();
            p.Weight = txtWeight.Text.ToString().Trim();
            p.FeatherColor = txtFeatherColor.Text.ToString().Trim();
            p.MedicalHistory = txtHistory.Text.ToString().Trim();
            p.Note = txtNote.Text.ToString().Trim();

            bool isSuccess = false;

            if (!isEditMode)
            {
                isSuccess = PetBUS.Save(p);
            } else
            {
                p.Id = pet.Id;
                isSuccess = PetBUS.Update(p);
            }
            if (isSuccess)
            {
                if (frmPet != null)
                {
                    frmPet.ReloadData();
                    this.Close();
                }
            }
        }

        private void cboCustomer_EditValueChanged(object sender, EventArgs e)
        {
            string id = cboCustomer.EditValue.ToString();
            Customer c = CustomerBUS.GetCustomerByID(id);
            txtPhone.Text = c.Phone.ToString();
            txtAddress.Text = c.Address.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePet();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}