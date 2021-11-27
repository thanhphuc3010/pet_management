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
    public class GroupServiceDAO : BaseDAO<GroupService>
    {
        public static List<GroupService> GetGroupServices()
        {
            string query = "SELECT * FROM service_group";
            if (db.State == ConnectionState.Closed) db.Open();

            List<GroupService> result = db.Query<GroupService>(query).ToList();
            db.Close();
            return result;
        }

        public static bool Delete(string code)
        {
            try
            {
                string sql = "DELETE FROM service_group WHERE code = @code";
                int result = DataProvider.Instance.ExcuteNonQuery(sql, new object[] { code });
                return result == 1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int GetLastID()
        {
            string query = "SELECT * FROM service ORDER BY id DESC LIMIT 1";
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
        }

        public static bool Save(GroupService value)
        {
            bool result = false;
            try
            {
                string insert = "INSERT INTO service_group (`code`, `name`, `description`) VALUES ( @code , @name , @description );";
                int n = DataProvider.Instance.ExcuteNonQuery(insert, new object[] { value.Code, value.Name, value.Description });
                result = n == 1;
            }
            catch (Exception e)
            {

                throw e;
            }
            return result;
        }
        public static bool Update(GroupService value)
        {
            try
            {
                string sql = "UPDATE `service_group` SET " +
                             "name = @name , " +
                             "description = @description " +
                             "WHERE code = @code ";
                int result = DataProvider.Instance.ExcuteNonQuery(sql, new object[] { value.Name, value.Description, value.Code });
                return result == 1;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
