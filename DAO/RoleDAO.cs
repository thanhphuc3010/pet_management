using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class RoleDAO
    {
        public static List<Role> GetRoles()
        {
            var result = new List<Role>();
            try
            {
                string query = "SELECT * FROM role";
                DataTable data = DataProvider.Instance.ExcuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    Role role = new Role(item);
                    result.Add(role);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static bool Save(Role role)
        {
            try
            {
                string insert = "INSERT INTO role (code, name, description) VALUES ( @code , @name , @description ) ";
                return DataProvider.Instance.ExcuteNonQuery(insert, new object[] { role.Code, role.Name, role.Description }) == 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool Update(Role role)
        {
            string update = "UPDATE role SET code = @code , name = @name , description = @description WHERE id = @id";
            return DataProvider.Instance.ExcuteNonQuery(update, new object[] { role.Code, role.Name, role.Description, role.Id }) == 1;
        }
        public static bool Delete(int roleID)
        {
            string delete = "DELETE FROM role WHERE id = @id";
            return DataProvider.Instance.ExcuteNonQuery(delete, new object[] { roleID }) == 1;
        }
    }
}
