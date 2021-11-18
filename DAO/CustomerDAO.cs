using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DTO;

namespace DAO
{
    public class CustomerDAO : BaseDAO<Customer>
    {
        public static Customer GetCustomerByID(string id)
        {
            Customer result;
            try
            {
                string query = "SELECT * FROM customer WHERE id = @id";
                DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { id });
                if (data.Rows.Count > 0)
                {
                    result = new Customer(data.Rows[0]);
                } else
                {
                    result = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static bool Update(Customer customer)
        {
            try
            {
                string update =
                    "UPDATE customer SET " +
                    "customer_number = @customer_number , " +
                    "first_name = @first_name , " +
                    "last_name = @last_name , " +
                    "date_of_birth = @date_of_birth , " +
                    "phone = @phone , " +
                    "email = @email , " +
                    "address = @address , " +
                    "discount_rate = @discount_rate , " +
                    "updated_date = @updated_date " +
                    "WHERE id = @id";
                int result = DataProvider.Instance.ExcuteNonQuery(update, new object[] {customer.CustomerNumber, customer.Firstname,
                                 customer.Lastname, customer.Dob, customer.Phone, customer.Email, customer.Address, customer.DiscountRate,
                                 DateTime.Now, customer.Id});
                return result == 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Delete(string id)
        {
            string delete = "DELETE FROM customer WHERE id = @id";
            int result = DataProvider.Instance.ExcuteNonQuery(delete, new object[] { id });
            return result == 1;
        }

        public static List<Customer> GetCustomers()
        {
            var result = new List<Customer>();
            try
            {
                string query = "SELECT * FROM customer";
                DataTable data = DataProvider.Instance.ExcuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    Customer customer = new Customer(item);
                    result.Add(customer);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static List<Customer> GetCustomersDapper()
        {
            string query = "SELECT * FROM staff";
            if (db.State == ConnectionState.Closed) db.Open();
            //Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

            MapperColumn mapper = new MapperColumn();
            SqlMapper.SetTypeMap(typeof(Customer), mapper.GetMap<Customer>());

            List<Customer> result = db.Query<Customer>(query).ToList();
            db.Close();
            return result;
        }

        public static bool Save(Customer customer)
        {
            bool result = false;
            try
            {
                string insert =
                    "insert into customer (customer_number, first_name, last_name, date_of_birth, phone, email, address, discount_rate) " +
                    "VALUES ( @customer_number , @first_name , @last_name , @date_of_birth , @phone , @email , @address , @discount_rate )";
                int n = DataProvider.Instance.ExcuteNonQuery(insert, new object[] { customer.CustomerNumber, customer.Firstname, customer.Lastname,
                        customer.Dob, customer.Phone, customer.Email, customer.Address, customer.DiscountRate});
                result = n == 1;
            }
            catch (Exception e)
            {

                throw e;
            }
            return result;
        }
    }
}
