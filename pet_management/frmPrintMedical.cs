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
    public partial class frmPrintMedical : DevExpress.XtraEditors.XtraForm
    {
        PetData _petData;
        Pet _pet;
        List<ELItem> _items;
        public string _conclude;
        public string _doctor;

        public frmPrintMedical(List<ELItem> items, PetData petData)
        {
            InitializeComponent();
            _items = items;
            _petData = petData;
        }

        private void frmPrintMedical_Load(object sender, EventArgs e)
        {
            List<ELItem> medicals = _items.Where(x => (x.ItemType == "Hàng hóa") && (x.ServiceUsedId == 0)).ToList();
            rptMedical1.SetDataSource(medicals);
            rptMedical1.SetParameterValue("pPetNumber", _petData.PetNumber);
            rptMedical1.SetParameterValue("pPetName", _petData.PetName);
            rptMedical1.SetParameterValue("pBreed", _petData.Breed);
            rptMedical1.SetParameterValue("pCustomer", _petData.CustomerName);
            rptMedical1.SetParameterValue("pAddress", _petData.Address);
            rptMedical1.SetParameterValue("pPhone", _petData.Phone);
            rptMedical1.SetParameterValue("pConclude", _conclude);
            rptMedical1.SetParameterValue("pStaff", _doctor);
            crystalReportViewer.ReportSource = rptMedical1;
            crystalReportViewer.Refresh();
        }
    }
}