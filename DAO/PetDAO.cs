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

            MapperColumn mapper = new MapperColumn();
            SqlMapper.SetTypeMap(typeof(Pet), mapper.GetMap<Pet>());

            List<Pet> result = db.Query<Pet>(query).ToList();
            db.Close();
            return result;
        }

        public static Pet GetPetByNumber(string petNumber)
        {
            MapperColumn mapper = new MapperColumn();
            SqlMapper.SetTypeMap(typeof(Pet), mapper.GetMap<Pet>());

            string sql = $"SELECT * FROM pet WHERE pet_number = '{petNumber}'";
            return db.QuerySingle<Pet>(sql);
        }

        public static Pet GetPetById(string id)
        {
            MapperColumn mapper = new MapperColumn();
            SqlMapper.SetTypeMap(typeof(Pet), mapper.GetMap<Pet>());

            string sql = $"SELECT * FROM pet WHERE id = {id}";
            return db.QuerySingle<Pet>(sql);
        }

        public static bool Delete(string id)
        {
            string sql = $"DELETE FROM pet WHERE id = {id}";
            return DataProvider.Instance.ExcuteNonQuery(sql) == 1;
        }

        public static bool Update(Pet p)
        {
            string sql =
                "UPDATE `pet` SET " +
                "`pet_number` = @pet_number , " +
                "`microchip` = @microchip , " +
                "`breed_id` = @breed_id , " +
                "`customer_id` = @customer_id , " +
                "`name` = @name , " +
                "`age` = @age , " +
                "`weight` = @weight , " +
                "`feather_color` = @feather_color , " +
                "`note` = @note , " +
                "`medical_history` = @medical_history , " +
                "`updated_date` = @updated_date WHERE `id` = @id ";
            int result = DataProvider.Instance.ExcuteNonQuery(sql,
                         new object[] { p.PetNumber, p.Microchip, p.BreedId, p.CustomerId, p.Name, p.Age, p.Weight, p.FeatherColor, p.Note, p.MedicalHistory, DateTime.Now, p.Id });
            return result == 1;
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
