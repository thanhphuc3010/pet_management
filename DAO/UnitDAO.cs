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
    public class UnitDAO : BaseDAO<Unit>
    {
        public static List<Unit> GetUnits()
        {
            string query = "SELECT * FROM unit";
            if (db.State == ConnectionState.Closed) db.Open();

            MapperColumn mapper = new MapperColumn();
            SqlMapper.SetTypeMap(typeof(Unit), mapper.GetMap<Unit>());

            List<Unit> result = db.Query<Unit>(query).ToList();
            db.Close();
            return result;
        }
    }
}
