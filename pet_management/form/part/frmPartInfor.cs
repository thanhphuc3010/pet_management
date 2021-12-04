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
using DevExpress.XtraEditors.Repository;

namespace pet_management
{
    public partial class frmPartInfor : DevExpress.XtraEditors.XtraForm
    {
        private readonly frmPart frmPart;
        private Part part;
        private bool isEditMode;

        private MakeBUS makeBUS = new MakeBUS();
        private PartBUS partBUS = new PartBUS();
        public frmPartInfor(frmPart frmPart, Part part, bool isEditMode)
        {
            InitializeComponent();
            this.frmPart = frmPart;
            this.part = part;
            this.isEditMode = isEditMode;
        }

        private void InitializeData()
        {
            List<Unit> units = UnitBUS.GetUnits();
            unitBindingSource.DataSource = units;

            List<Make> makes = makeBUS.GetMakes();
            makeBindingSource.DataSource = makes;
            luUnit.EditValue = units.First().Id;
            txtPartNumber.Text = (part == null && !isEditMode) ? GenerateId() : part.PartNumber;
            if (part == null && !isEditMode)
            {
                return;
            }
            BindPartData();
        }

        private Part GetPartDataFromControl()
        {
            Part part = new Part();
            part.PartNumber = txtPartNumber.GetTextTrim();
            part.MakeId = Convert.ToInt32(gluMake.EditValue);
            part.UnitId = Convert.ToInt32(luUnit.EditValue);
            part.Name = txtName.GetTextTrim();
            part.Cost = txtCost.ToDecimal();
            part.Price = txtPrice.ToDecimal();
            part.Quantity = txtQuantity.ToInt();
            part.Tax = txtTax.ToDecimal();
            part.Uses = txtUses.GetTextTrim();
            return part;
        }

        private void BindPartData()
        {
            gluMake.EditValue = this.part.MakeId;
            luUnit.EditValue = this.part.UnitId;
            txtName.Text = this.part.Name;
            txtCost.Text = this.part.Cost.ToString();
           
            txtPrice.Text = this.part.Price.ToString();
           
            txtQuantity.Text = this.part.Quantity.ToString();
            
            txtTax.Text = this.part.Tax.ToString();
            
            txtUses.Text = this.part.Uses;
        }

        private void InitializeControl()
        {
            txtCost.ApplyFormatToView();
            //txtCost.FormatCurrency();
            txtPrice.ApplyFormatToView();
            //txtPrice.FormatCurrency();
            txtQuantity.ApplyFormatToView();
            txtTax.ApplyFormatToView();
        }

        private string GenerateId()
        {
            string query = "SELECT* FROM part ORDER BY part_number DESC LIMIT 1";
            return MyHelper.GenerateId("HH", query, "part_number");
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePart();
        }

        private void SavePart()
        {
            Part part = GetPartDataFromControl();
            bool isSuccess;
            if (!isEditMode)
            {
                isSuccess = partBUS.Save(part);
            }
            else
            {
                part.Id = this.part.Id;
                isSuccess = partBUS.Update(part);
            }
            if (isSuccess)
            {
                if (frmPart != null)
                {
                    frmPart.LoadData();
                    this.Close();
                }
            }
        }

        private void frmPartInfor_Load(object sender, EventArgs e)
        {
            InitializeControl();
            InitializeData();
        }

        private void txtCost_Validating(object sender, CancelEventArgs e)
        {
            var edit = sender as TextEdit;
            Decimal d;
            e.Cancel = !Decimal.TryParse(edit.EditValue.ToString(), out d);
            if (!e.Cancel)
                edit.EditValue = d;
        }
    }
}