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
    public partial class frmInvoice : DevExpress.XtraEditors.XtraForm
    {
        PetData _petData;
        Pet _pet;
        List<ELItem> _items;
        public string _conclude;
        public string _doctor;
        
        public frmInvoice(List<ELItem> items, PetData petData)
        {
            InitializeComponent();
            _items = items;
            _petData = petData;
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            List<ELItem> medicals = _items;
            rptInvoice.SetDataSource(medicals);
            rptInvoice.SetParameterValue("pPetNumber", _petData.PetNumber);
            rptInvoice.SetParameterValue("pPetName", _petData.PetName);
            rptInvoice.SetParameterValue("pBreed", _petData.Breed);
            rptInvoice.SetParameterValue("pCustomer", _petData.CustomerName);
            rptInvoice.SetParameterValue("pAddress", _petData.Address);
            rptInvoice.SetParameterValue("pPhone", _petData.Phone);
            rptInvoice.SetParameterValue("pConclude", _conclude);
            rptInvoice.SetParameterValue("pStaff", _doctor);
            crvInvoice.ReportSource = rptInvoice;
            crvInvoice.Refresh();
        }

        private void frmInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}