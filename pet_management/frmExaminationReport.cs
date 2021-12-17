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
    public partial class frmExaminationReport : DevExpress.XtraEditors.XtraForm
    {
        private ExaminationBUS exBUS = new ExaminationBUS();
        private ReportBUS reportBUS = new ReportBUS();
        public frmExaminationReport()
        {
            InitializeComponent();
        }

        private void frmExaminationReport_Load(object sender, EventArgs e)
        {
            dtFromDate.DateTime = DateTime.Today;
            dtToDate.DateTime = DateTime.Today;
            LoadCustomer();
            LoadDoctor();
            LoadType();
        }

        private void LoadCustomer()
        {
            List<Customer> customers = CustomerBUS.GetCustomers();
            foreach (Customer customer in customers)
            {
                customer.Fullname = $"{customer.Firstname} {customer.Lastname}";
            }

            Customer c = new Customer();
            c.Fullname = "---Khách hàng---";
            c.Id = 0;
            customers.Add(c);

            cboCustomer.DataSource = customers;
            cboCustomer.ValueMember = "Id";
            cboCustomer.DisplayMember = "FullName";
        } 

        private void LoadDoctor()
        {
            List<Staff> doctors = StaffBUS.GetDoctors();

            Staff staff = new Staff();
            staff.FullName = "---Bác sĩ---";
            staff.Id = 0;
            doctors.Add(staff);

            cboDoctor.DataSource = doctors;
            cboDoctor.ValueMember = "Id";
            cboDoctor.DisplayMember = "FullName";
        }

        private void LoadType()
        {
            cboType.DataSource = ExaminationType.GetListType();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Staff doctor = (Staff)cboDoctor.SelectedItem;
            Customer customer = (Customer)cboCustomer.SelectedItem;
            string type = cboType.SelectedItem.ToString();
            DateTime fromDate = dtFromDate.DateTime;
            DateTime toDate = dtToDate.DateTime;


            List<ExaminationInfor> examinationInfors = reportBUS.GetListExaminationInfor(fromDate, toDate);

            List<ExaminationInfor> dataExport = examinationInfors;

            // Lấy tất cả các phiếu khám theo thời gian lọc và loại hình (type)
            if (doctor.Id == 0 && customer.Id == 0)
            {
                dataExport = examinationInfors.Where(x => x.Type == type).ToList();
            } else
            {
                if (doctor.Id != 0 && customer.Id == 0)
                {
                    
                    dataExport = examinationInfors.Where(x => (x.Type == type) && (x.DoctorId == doctor.Id)).ToList();
                }

                if (doctor.Id == 0 && customer.Id != 0)
                {

                    dataExport = examinationInfors.Where(x => (x.Type == type) && (x.CustomerId == customer.Id)).ToList();
                }

                if (doctor.Id != 0 && customer.Id != 0)
                {

                    dataExport = examinationInfors.Where(x => (x.Type == type) && (x.DoctorId == doctor.Id) && (x.CustomerId == customer.Id)).ToList();
                }
            }


            foreach (ExaminationInfor exInfor in dataExport)
            {
                List<ELItem> Items = exBUS.GetDetail(exInfor.Id);
                exInfor.Total = Items.Sum(x => x.Total);
                exInfor.Tax = Items.Sum(x => x.Tax);
                exInfor.Discount = Items.Sum(x => x.Discount);
                exInfor.Subtotal = exInfor.Total + exInfor.Tax - exInfor.Discount;
            }

            frmMain frmMain = (frmMain)Owner;
            Staff currStaff = frmMain.GetStaffLogined();

            frmExPetReport f = new frmExPetReport(dataExport, doctor, customer, currStaff, type, fromDate, toDate);
            f.ShowDialog(this);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}