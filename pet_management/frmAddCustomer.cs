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
    public partial class frmAddCustomer : Form
    {
        private readonly frmCustomer frmCustomer;
        private Customer customer;
        private bool isEdit = false;
        public frmAddCustomer(frmCustomer frmCustomer, Customer customer)
        {
            InitializeComponent();
            this.frmCustomer = frmCustomer;
            this.customer = customer;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerNumber = txtCustomerNumber.Text.ToString().Trim();
            customer.Firstname = txtFirstname.Text.ToString().Trim();
            customer.Lastname = txtLastname.Text.ToString().Trim();
            customer.Dob = dpDob.DateTime;
            customer.Phone = txtPhone.Text.ToString().Trim();
            customer.Email = txtEmail.Text.ToString().Trim();
            customer.Address = txtAddress.Text.ToString().Trim();
            customer.DiscountRate = Convert.ToDecimal(txtDiscount.Text);
            if (isEdit)
            {
                customer.Id = this.customer.Id;
                CustomerBUS.Update(customer);
            } else
            {
                CustomerBUS.Save(customer);
            }
            if (frmCustomer != null)
            {
                frmCustomer.LoadData();
                this.Close();
            }
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            txtCustomerNumber.ReadOnly = true;
            if (customer == null)
            {
                txtCustomerNumber.ReadOnly = true;
                string query = "SELECT * FROM customer ORDER BY customer_number DESC LIMIT 1";
                txtCustomerNumber.Text = Helper.GenerateId("KH", query, "customer_number");
            } else
            {
                this.Text = "Thông tin khách hàng";
                isEdit = true;
                bindCustomer();
            }
            txtFirstname.Focus();
        }

        private void bindCustomer()
        {
            txtCustomerNumber.Text = customer.CustomerNumber.ToString();
            txtDiscount.Text = customer.DiscountRate.ToString();
            txtFirstname.Text = customer.Firstname.ToString();
            txtLastname.Text = customer.Lastname.ToString();
            dpDob.DateTime = customer.Dob;
            txtPhone.Text = customer.Phone.ToString();
            txtEmail.Text = customer.Email.ToString();
            txtAddress.Text = customer.Address.ToString();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
