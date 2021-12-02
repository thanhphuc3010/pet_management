using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DTO;

namespace DAO
{
    public class MakeDAO : BaseDAO<Make>
    {
        public List<Make> GetMakes()
        {
            string query = "SELECT * FROM make";
            if (db.State == ConnectionState.Closed) db.Open();
            SetTypeMapper();
            try
            {
                List<Make> result = db.Query<Make>(query).ToList();
                db.Close();
                return result;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
    }
}
