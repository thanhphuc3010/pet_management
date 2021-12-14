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
    public partial class frmEditItemEx : DevExpress.XtraEditors.XtraForm
    {
        private ELItem item;
        private ELItem itemToUpdate = new ELItem();
        private readonly frmExamination frmExamination;
        private ExaminationBUS examinationBUS = new ExaminationBUS();
        private int inventory = 0;

        public frmEditItemEx(frmExamination frmExamination, ELItem item)
        {
            InitializeComponent();
            this.frmExamination = frmExamination;
            this.item = item;
        }

        private void frmEditItemEx_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void InitializeData()
        {
            txtItemName.Text = item.ItemName.ToString();
            txtPrice.Text = item.Price.ToString();
            txtPrice.ApplyFormatToView();
            if (item.ItemType == "Hàng hóa")
            {
                PartBUS partBUS = new PartBUS();
                Part p = partBUS.GetPartById(item.ItemId.ToString());
                lblInventory.Visible = true;
                inventory = p.Quantity + item.Quantity;
                lblInventory.Text = $"Có sẵn để bán: {p.Quantity + item.Quantity}";
            } else
            {
                lblInventory.Visible = false;
            }
            txtSaleNumber.Text = item.Quantity.ToString();
            txtSaleNumber.ApplyFormatToView();
            txtDiscountRate.Text = item.DiscountRate.ToString();
            txtDiscount.Text = (item.Quantity * item.Price * (item.DiscountRate / 100)).ToString();
            txtDiscountRate.ApplyFormatToView();
            txtDiscount.ApplyFormatToView();
            txtTotal.Text = (item.Quantity * item.Price).ToString();
            txtTotal.ApplyFormatToView();
            
            txtTaxRate.Text = item.TaxRate.ToString();
            txtTax.Text = (item.Quantity * item.Price * (item.TaxRate / 100)).ToString();
            txtTax.ApplyFormatToView();
            txtSubTotal.Text = item.Total.ToString();
            txtSubTotal.ApplyFormatToView();
            itemToUpdate = this.item;
        }

        private void txtItemName_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            decimal price;
            if (String.IsNullOrEmpty(txtPrice.GetTextTrim()))
            {
                itemToUpdate.Price = 0;
                price = 0;
            }
            else
            {
                price = Convert.ToDecimal(txtPrice.GetTextTrim());
                itemToUpdate.Price = price;
            }

            CalculateWhenValueChanged();
        }

        private void CalculateWhenValueChanged()
        {
            // Calculate tax
            decimal taxRate = (itemToUpdate.TaxRate == null) ? 0 : (decimal)itemToUpdate.TaxRate;
            decimal tax = (item.TaxRate == 0) ? 0 : (itemToUpdate.Quantity * itemToUpdate.Price * (taxRate / 100));

            // Calculate discount
            decimal discountRate = (itemToUpdate.DiscountRate == null) ? 0 : (decimal)itemToUpdate.DiscountRate;
            decimal discount = (item.DiscountRate == 0) ? 0 : (itemToUpdate.Quantity * itemToUpdate.Price * (discountRate / 100));

            decimal total = (itemToUpdate.Quantity * itemToUpdate.Price);
            itemToUpdate.Total = total;
            itemToUpdate.Tax = tax;
            itemToUpdate.Discount = discount;

            // Thành tiền = tổng tiền hàng - chiết khấu + thuế
            decimal subtotal = itemToUpdate.Total - itemToUpdate.Discount + itemToUpdate.Tax;
            txtDiscount.Text = item.Discount.ToString();
            txtTax.Text = item.Tax.ToString();
            txtTotal.Text = total.ToString();
            txtSubTotal.Text = subtotal.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (itemToUpdate.Quantity > inventory)
            {
                MyHelper.showErrorMessage($"Tồn kho không đủ. Số lượng có thể bán là : {inventory}", "Lỗi");
                return;
            }
            bool isSuccess = examinationBUS.UpdatePartDetail(itemToUpdate.ToExPart());
            if (isSuccess)
            {
                if (frmExamination != null)
                {
                    frmExamination.RefreshExDetail();
                }
                this.Close();
            }
        }

        private void txtSaleNumber_TextChanged(object sender, EventArgs e)
        {
            int saleNumber;
            if (String.IsNullOrEmpty(txtSaleNumber.GetTextTrim()))
            {
                itemToUpdate.Quantity = 0;
                saleNumber = 0;
            }
            else
            {
                saleNumber = Convert.ToInt32(txtSaleNumber.GetTextTrim());
                itemToUpdate.Quantity = saleNumber;
            }

            CalculateWhenValueChanged();
        }

        private void txtDiscountRate_TextChanged(object sender, EventArgs e)
        {
            decimal discountRate = 0;
            if (String.IsNullOrEmpty(txtDiscountRate.GetTextTrim()))
            {
                itemToUpdate.DiscountRate = 0;
                discountRate = 0;
            }
            else
            {
                discountRate = Convert.ToInt32(txtDiscountRate.GetTextTrim());
            }


            // Khi discount rate thay đổi => Tính lại discount => Tính lại subtotal
            decimal discount = (itemToUpdate.Quantity * itemToUpdate.Price * (discountRate / 100));
            decimal total = itemToUpdate.Quantity * itemToUpdate.Price;
            decimal subtotal = total - discount + itemToUpdate.Tax;

            itemToUpdate.DiscountRate = discountRate;
            itemToUpdate.Discount = discount;
            txtDiscount.Text = discount.ToString();
            txtSubTotal.Text = subtotal.ToString();
        }

        private void txtTaxRate_TextChanged(object sender, EventArgs e)
        {
            decimal taxRate;
            if (String.IsNullOrEmpty(txtTaxRate.GetTextTrim()))
            {
                itemToUpdate.TaxRate = 0;
                taxRate = 0;
            }
            else
            {
                taxRate = Convert.ToInt32(txtTaxRate.GetTextTrim());
                itemToUpdate.TaxRate = taxRate;
            }

            // Khi tax rate thay đổi => Tính lại tax => Tính lại subtotal
            decimal tax = (itemToUpdate.Quantity * itemToUpdate.Price * (taxRate / 100));
            itemToUpdate.TaxRate = taxRate;
            itemToUpdate.Tax = tax;
            decimal total = itemToUpdate.Quantity * itemToUpdate.Price;
            decimal subtotal = total - itemToUpdate.Discount + tax;
            txtTax.Text = tax.ToString();
            txtSubTotal.Text = subtotal.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}