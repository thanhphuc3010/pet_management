using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class SpeicesDAO
    {
        public static List<Species> GetAllSpeices()
        {
            var result = new List<Species>();
            try
            {
                string query = "SELECT * FROM species";
                DataTable data = DataProvider.Instance.ExcuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    Species speices = new Species(item);
                    result.Add(speices);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static int GetLastID()
        {
            string query = "SELECT id FROM species ORDER BY id DESC LIMIT 1";
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
        }
        public static bool InsertSpeices(Species speices)
        {
            bool result = false;
            try
            {
                string insert = "insert into species (name, description) VALUES ( @name , @description )";
                int n = DataProvider.Instance.ExcuteNonQuery(insert, new object[] { speices.Name, speices.Description});
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
