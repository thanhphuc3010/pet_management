using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace pet_management
{
    public partial class frmSpecies : Form
    {
        EntityState state = EntityState.Unchaged;
        public frmSpecies()
        {
            InitializeComponent();
        }

        #region handle event
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            HandleControl();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            state = EntityState.Added;
            btnAdd.Disable();
            resetInput();
            speciesBindingSource.Add(new Species());
            speciesBindingSource.MoveLast();
            txtId.Text = (SpeciesBUS.GetLastID() + 1).ToString();
            HandleControl();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            speciesBindingSource.EndEdit();
            Species species = speciesBindingSource.Current as Species;
            if (species != null)
            {
                if (state == EntityState.Added)
                {
                    bool isSuccess = SpeciesBUS.AddNewSpecies(species);
                }
                else if (state == EntityState.Changed)
                {
                    SpeciesBUS.Update(species);
                }
            }
            btnAdd.Enable();
            grcDemo.Refresh();
            state = EntityState.Unchaged;
            HandleControl();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            state = EntityState.Changed;
            HandleControl();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            state = EntityState.Deleted;
            Species species = speciesBindingSource.Current as Species;
            if (species != null)
            {
                string message = "Bạn có chắc chắn muốn xóa bản ghi này không?";
                DialogResult dialogResult = MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dialogResult == DialogResult.Yes)
                {
                    bool isSuccess = SpeciesBUS.Delete(species);
                    if (isSuccess)
                    {
                        speciesBindingSource.RemoveCurrent();
                        Helper.showSuccessMessage("Xóa bản ghi thành công");
                    }
                    grcDemo.Refresh();
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
                speciesBindingSource.RemoveCurrent();
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
        #endregion

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
                    break;
                case EntityState.Deleted:
                    break;
                default:
                    break;
            }
        }

        private void LoadData()
        {
            speciesBindingSource.DataSource = SpeciesBUS.GetData();
        }

        private void resetInput()
        {
            txtName.Text = null;
            txtDescription.Text = null;
        }
    }
}
