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
using DevExpress.XtraGrid.Views.Grid;

namespace pet_management
{
    public partial class frmPet : DevExpress.XtraEditors.XtraForm
    {
        public frmPet()
        {
            InitializeComponent();
        }

        private void frmPet_Load(object sender, EventArgs e)
        {
            petBindingSource.DataSource = PetBUS.GetPets();
            List<Customer> customers = CustomerBUS.GetCustomers();
            foreach (Customer customer in customers)
            {
                customer.Fullname = $"{customer.Firstname} {customer.Lastname}";
            }
            customerpetBindingSource.DataSource = customers;
            breedpetBindingSource.DataSource = BreedBUS.GetBreeds();
            
            
        }

        private void searchControl1_TextChanged(object sender, EventArgs e)
        {
            string keySearch = txtSearch.Text.ToString().Trim();
            if (!string.IsNullOrEmpty(keySearch))
            {
                gridViewPet.ApplyFindFilter(keySearch);
            } else
            {
                gridViewPet.ClearFindFilter();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPetInfor f = new frmPetInfor(this, null, false);
            f.ShowDialog();
        }

        public void ReloadData()
        {
            petBindingSource.DataSource = PetBUS.GetPets();
        }

        private void repoItemBtnEdit_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Pet p = gridViewPet.GetFocusedRow() as Pet;
            if (p == null)
            {
                return;
            }
            else
            {
                frmPetInfor f = new frmPetInfor(this, p, true);
                f.ShowDialog();
            }
        }

        private void repoItemBtnDelete_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Pet p = gridViewPet.GetFocusedRow() as Pet;
            if (p == null)
            {
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dialogResult == DialogResult.Yes)
                {
                    bool isSuccess = PetBUS.Delete(p.Id.ToString());
                    if (isSuccess)
                    {
                        petBindingSource.Remove(p);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void gridViewPet_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.Column.FieldName == "PetNumber")
            {
                e.Appearance.ForeColor = MyColor.Primary;
            }
        }
    }
}