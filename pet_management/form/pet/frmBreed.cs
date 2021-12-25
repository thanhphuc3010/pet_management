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
    public partial class frmBreed : DevExpress.XtraEditors.XtraForm
    {
        EntityState state = EntityState.Unchaged;
        Breed breed;
        public frmBreed()
        {
            InitializeComponent();
        }
        private void HandleControl()
        {
            txtId.ReadOnly = true;
            switch (state)
            {
                case EntityState.Unchaged:
                    txtName.ReadOnly = true;
                    txtDescription.ReadOnly = true;
                    btnUpdate.Disable();
                    break;
                case EntityState.Added:
                case EntityState.Changed:
                    txtName.ReadOnly = false;
                    txtDescription.ReadOnly = false;
                    txtName.Focus();
                    btnUpdate.Enable();
                    btnAdd.Disable();
                    break;
                case EntityState.Deleted:
                    break;
                default:
                    break;
            }
        }

        private void frmBreed_Load(object sender, EventArgs e)
        {
            LoadData();
            HandleControl();
        }

        private void cboBreed_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            state = EntityState.Added;
            btnAdd.Disable();
            ResetInput();
            breedBindingSource.Add(new Breed());
            breedBindingSource.MoveLast();
            Breed last = BreedBUS.GetBreeds().Last();
            txtId.Text = (last.Id + 1).ToString();
            HandleControl();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            breedBindingSource.EndEdit();
            //Breed breed = breedBindingSource.Current as Breed;

            if (this.breed == null)
            {
                Breed breed = new Breed();
                Species sp = (Species)cboSpecies.SelectedItem;
                breed.SpeciesId = sp.Id;
                breed.Name = txtName.GetTextTrim();
                breed.Description = txtDescription.GetTextTrim();
            }

            if (breed != null)
            {
                if (state == EntityState.Added)
                {
                    bool isSuccess = BreedBUS.AddNew(breed);
                }
                else if (state == EntityState.Changed)
                {
                    Species sp = (Species)cboSpecies.SelectedItem;
                    breed.SpeciesId = sp.Id;
                    breed.Name = txtName.GetTextTrim();
                    breed.Description = txtDescription.GetTextTrim();
                    BreedBUS.Update(this.breed);
                }
            }
            btnAdd.Enable();
            grcBreed.Refresh();
            breedBindingSource.DataSource = BreedBUS.GetBreeds();
            state = EntityState.Unchaged;
            HandleControl();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            state = EntityState.Changed;
            string breedId = gridView1.GetFocusedRowCellValue("Id").ToString();
            Breed breed = BreedBUS.GetBreedById(breedId);
            this.breed = breed;
            cboSpecies.SelectedValue = breed.SpeciesId;
            txtName.Text = breed.Name;
            txtDescription.Text = breed.Description;
            txtId.Text = breed.Id.ToString();
            HandleControl();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            state = EntityState.Deleted;
            Breed breed = breedBindingSource.Current as Breed;
            if (breed != null)
            {
                string message = "Bạn có chắc chắn muốn xóa bản ghi này không?";
                DialogResult dialogResult = MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dialogResult == DialogResult.Yes)
                {
                    bool isSuccess = BreedBUS.Delete(breed);
                    if (isSuccess)
                    {
                        breedBindingSource.RemoveCurrent();
                        MyHelper.showSuccessMessage("Xóa bản ghi thành công");
                    }
                    grcBreed.Refresh();
                    state = EntityState.Unchaged;
                    HandleControl();
                }
                else
                {
                    state = EntityState.Unchaged;
                    HandleControl();
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (state == EntityState.Added)
            {
                breedBindingSource.RemoveCurrent();
                state = EntityState.Unchaged;
            }
            if (state == EntityState.Changed)
            {
                LoadData();
                txtDescription.ReadOnly = true;
                txtName.ReadOnly = true;
                state = EntityState.Unchaged;
            }
            HandleControl();
        }

        private void LoadData()
        {
            breedBindingSource.DataSource = BreedBUS.GetBreeds();
            cboSpecies.DataSource = SpeciesBUS.GetData();
            cboSpecies.DisplayMember = "Name";
            cboSpecies.ValueMember = "Id";
        }

        private void ResetInput()
        {
            txtName.Text = null;
            cboSpecies.SelectedIndex = -1;
            txtDescription.Text = null;
        }
    }
}
