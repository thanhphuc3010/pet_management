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
    public class PetDAO : BaseDAO<Pet>
    {
        public static List<Pet> GetPets()
        {
            string query = "SELECT * FROM pet";
            if (db.State == ConnectionState.Closed) db.Open();
            //Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

            MapperColumn mapper = new MapperColumn();
            SqlMapper.SetTypeMap(typeof(Pet), mapper.GetMap<Pet>());

            List<Pet> result = db.Query<Pet>(query).ToList();
            db.Close();
            return result;
        }
        public static bool Save(Pet p)
        {
            try
            {
                string insert =
                    "INSERT INTO `pet` (`pet_number`, `microchip`, `breed_id`, `customer_id`, `name`, `age`, `weight`, `feather_color`, `note`, `medical_history`) " +
                    "VALUES ( @pet_number , @microchip , @breed_id , @customer_id , @name , @age , @weight , @feather_color , @note , @medical_history ) ";
                int result =
                    DataProvider.Instance.ExcuteNonQuery(insert,
                    new object[] { p.PetNumber, p.Microchip, p.BreedId, p.CustomerId, p.Name, p.Age, p.Weight, p.FeatherColor, p.Note, p.MedicalHistory });
                return result == 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
