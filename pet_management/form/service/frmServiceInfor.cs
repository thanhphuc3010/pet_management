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
using BUS;
using DTO;

namespace pet_management
{
    public partial class frmServiceInfor : DevExpress.XtraEditors.XtraForm
    {
        private readonly frmService frmService;
        private Service service;
        private bool isEditMode;

        private ServiceBUS serviceBUS = new ServiceBUS();
        public frmServiceInfor(frmService frmService, Service service, bool isEditMode)
        {
            InitializeComponent();
            this.frmService = frmService;
            this.service = service;
            this.isEditMode = isEditMode;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            BeginInvoke(new MethodInvoker(() =>
            {
                gluGroupService.FocusEnd();
            }));
        }

        #region Handle event
        private void frmServiceInfor_Load(object sender, EventArgs e)
        {
            groupServiceBindingSource.DataSource = GroupServiceBUS.GetGroupServices();
            unitBindingSource.DataSource = UnitBUS.GetUnits();

            if (!isEditMode)
            {
                txtId.Text = (GroupServiceBUS.GetLastID() + 1).ToString();
            }
            else
            {
                BindServiceData();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveService();
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Handle data
        private void BindServiceData()
        {
            txtId.Text = service.Id.ToString();
            txtName.Text = service.Name.ToString();
            txtDescription.Text = service.Description;
            txtPrice.Text = service.Price.ToString();
            txtTax.Text = service.Tax.ToString();
            gluGroupService.EditValue = service.GroupServiceId;
            gluUnit.EditValue = service.UnitId;
        }
        private void SaveService()
        {
            Service s = new Service();
            s.Id = Convert.ToInt32(txtId.Text.ToString().Trim());
            s.Name = txtName.Text.ToString().Trim();
            s.Description = txtDescription.Text.ToString().Trim();
            s.Price = Convert.ToDecimal(txtPrice.Text);
            s.Tax = Convert.ToDecimal(txtTax.Text);
            s.GroupServiceId = Convert.ToInt32(gluGroupService.EditValue);
            s.UnitId = Convert.ToInt32(gluUnit.EditValue);

            bool isSuccess = false;

            if (!isEditMode)
            {
                isSuccess = ServiceBUS.Save(s);
            }
            else
            {
                s.Id = service.Id;
                isSuccess = serviceBUS.Update(s);
            }
            if (isSuccess)
            {
                if (frmService != null)
                {
                    frmService.LoadData();
                    this.Close();
                }
            }
        }
        #endregion
    }
}