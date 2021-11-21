using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Dapper;
using System.Data;

namespace DAO
{
    public class BreedDAO : BaseDAO<Breed>
    {
        public static List<Breed> GetBreeds()
        {
            string query = "SELECT * FROM breed";
            if (db.State == ConnectionState.Closed) db.Open();
            //Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

            MapperColumn mapper = new MapperColumn();
            SqlMapper.SetTypeMap(typeof(Breed), mapper.GetMap<Breed>());

            List<Breed> result = db.Query<Breed>(query).ToList();
            db.Close();
            return result;
        }
    }
}
