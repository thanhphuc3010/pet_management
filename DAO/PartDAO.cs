using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Dapper;
using System.Data.SqlClient;

namespace DAO
{
    public class PartDAO : BaseDAO<Part>
    {
        public List<Part> GetParts()
        {
            string query = "SELECT * FROM part";
            if (db.State == ConnectionState.Closed) db.Open();
            SetTypeMapper();
            try
            {
                List<Part> result = db.Query<Part>(query).ToList();
                db.Close();
                return result;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        public Part GetPartById(string id)
        {
            string sql = $"SELECT * FROM part WHERE id = {id}";
            return db.QuerySingle<Part>(sql);
        }
    }
}
