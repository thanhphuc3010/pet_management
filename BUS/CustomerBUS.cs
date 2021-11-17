using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class CustomerBUS
    {
        public static List<Customer> GetCustomers()
        {
            return CustomerDAO.GetCustomers();
        }
        public static Customer GetCustomerByID(string id)
        {
            return CustomerDAO.GetCustomerByID(id);
        }

        public static bool Save(Customer customer)
        {
            return CustomerDAO.Save(customer);
        }

        public static bool Delete(string id)
        {
            return CustomerDAO.Delete(id);
        }

        public static bool Update(Customer customer)
        {
            return CustomerDAO.Update(customer);
        }
    }
}
