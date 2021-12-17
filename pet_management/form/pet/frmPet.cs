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
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace pet_management
{
    public partial class frmPet : DevExpress.XtraEditors.XtraForm
    {
        private ExaminationBUS examinationBUS = new ExaminationBUS();
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
            staffBindingSource.DataSource = StaffBUS.GetStaffs();
            gridView4.BestFitColumnsEx();
            
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
                    try
                    {
                        bool isSuccess = PetBUS.Delete(p.Id.ToString());
                        if (isSuccess)
                        {
                            petBindingSource.Remove(p);
                        }
                    }
                    catch (Exception ex)
                    {
                        if (ex.GetType() == typeof(MySqlException))
                        {
                            MyHelper.ShowErrorMessage("Thú nuôi đã phát sinh giao dịch sử dụng dịch vụ, không thể xóa!", "Lỗi");
                        }
                        else
                        {
                            MyHelper.ShowErrorMessage(ex.Message, "Lỗi");
                        }
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

        private void gridViewPet_RowClick(object sender, RowClickEventArgs e)
        {
            string petId = (sender as GridView).GetFocusedRowCellValue("Id").ToString();
            List<Examination> history = examinationBUS.GetExaminationByPetId(petId);
            exPetHistoryBindingSource.DataSource = history;
        }
    }
}