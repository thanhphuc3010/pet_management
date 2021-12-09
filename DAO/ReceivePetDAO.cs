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
    public class ReceivePetDAO
    {
        public static IDbConnection db = DataProvider.Connect;

        MapperColumn mapper = new MapperColumn();
        private void SetTypeMapper<T>() => SqlMapper.SetTypeMap(typeof(T), mapper.GetMap<T>());

        public PetData GetPetData(string id)
        {
            SetTypeMapper<PetData>();
            string sql = @" SELECT p.id, p.pet_number, p.microchip, p.name, p.weight, p.age, 
                            b.name AS breed_name, 
                            s.name AS species_name, 
                            c.first_name, c.last_name, c.address, c.phone 
                            FROM pet p 
                            JOIN breed b ON p.breed_id = b.id 
                            JOIN species s ON b.species_id = s.id 
                            JOIN customer c ON p.customer_id = c.id 
                            WHERE p.id = " + id;
            return db.QuerySingle<PetData>(sql);
        }
        public int GetCountExaminationToday()
        {
            string sql = @"SELECT COUNT(*) FROM examination WHERE examination_date = @examination_date ";
            var result = DataProvider.Instance.ExecuteScalar(sql, new object[] { DateTime.Now });
            if (!DBNull.Value.Equals(result))
            {
                return Convert.ToInt32(result);
            } else {
                return 0;
            }
        }
    }
}
