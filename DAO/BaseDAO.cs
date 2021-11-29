using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DAO
{
    public abstract class BaseDAO<T>
    {
        public static IDbConnection db = DataProvider.Connect;

        MapperColumn mapper = new MapperColumn();
        public void SetTypeMapper()
        {
            SqlMapper.SetTypeMap(typeof(T), mapper.GetMap<T>());
        }
    }
}
