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
    public partial class frmExaminationItemDetail : DevExpress.XtraEditors.XtraForm
    {
        private Part part;
        private readonly frmSelectPart frmSelectPart;
        public frmExaminationItemDetail(frmSelectPart frmSelectPart, Part part)
        {
            InitializeComponent();
            this.part = part;
            this.frmSelectPart = frmSelectPart;
        }

        private void frmExaminationItemDetail_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void InitializeData()
        {
            txtNumber.Text = part.PartNumber.ToString();
            txtName.Text = part.Name.ToString();
            if (frmSelectPart.detailItems != null)
            {
                var listServices = frmSelectPart.detailItems.Where(x => x.ItemType == "Dịch vụ").ToList();
                eLItemBindingSource.DataSource = listServices;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int inventory = part.Quantity;
            int quantity = Convert.ToInt32(txtQuantity.Text);
            int serviceUseId = Convert.ToInt32(gluServiceUse.EditValue);
            decimal taxRate = part.Tax;

            ExaminationPart exPart = new ExaminationPart();
            exPart.PartId = part.Id;
            exPart.Quantity = quantity;
            exPart.Price = part.Price;
            exPart.Tax = taxRate;

            // Start check service use id
            if (serviceUseId == 0)
            {
                exPart.ServiceUsedId = 0;
            } else
            {
                exPart.ServiceUsedId = serviceUseId;
            }
            // End check service use id

            if (quantity > inventory)
            {
                XtraMessageBox.Show($"Sản phầm trong kho không đủ. Tồn kho hiện tại là {inventory}");
            }
            if (frmSelectPart != null)
            {
                if (frmSelectPart.detailItems == null)
                {
                    frmSelectPart.AddPartToEx(exPart);
                } else
                {
                    var isExist = frmSelectPart.detailItems.FindIndex(x => x.ItemId == part.Id);
                    if (isExist == -1)
                    {
                        frmSelectPart.AddPartToEx(exPart);
                    }
                    else
                    {
                        frmSelectPart.UpdatePartEx(exPart);
                    }
                }
                this.Close();
            }
        }
    }
}