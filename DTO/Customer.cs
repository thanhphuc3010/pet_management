using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        public Customer(DataRow item)
        {
            this.Id = Convert.ToInt32(item.GetValueInCell("id"));
            this.CustomerNumber = item.GetValueInCell("customer_number").ToString();
            this.Firstname = item.GetValueInCell("first_name").ToString();
            this.Lastname = item.GetValueInCell("last_name").ToString();
            this.Dob = Convert.ToDateTime(item.GetValueInCell("date_of_birth"));
            this.Phone = item.GetValueInCell("phone").ToString();
            this.Email = item.GetValueInCell("email").ToString();
            this.Address = item.GetValueInCell("address").ToString();
            this.DiscountRate = Convert.ToDecimal(item.GetValueInCell("discount_rate"));
        }

        public int Id { get; set; }
        public string CustomerNumber { get; set; }
        public string Firstname { get; set;  }
        public string Lastname { get; set; }
        public DateTime Dob { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public decimal DiscountRate { get; set; }

        public Customer(int id, string customerNumber, string firstname, string lastname, DateTime dob, string phone, string email, string address, decimal discountRate)
        {
            Id = id;
            CustomerNumber = customerNumber;
            Firstname = firstname;
            Lastname = lastname;
            Dob = dob;
            Phone = phone;
            Email = email;
            Address = address;
            DiscountRate = discountRate;
        }

        public Customer()
        {
        }
    }
}
