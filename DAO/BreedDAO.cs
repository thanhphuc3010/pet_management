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

        public static List<Breed> GetBreedsBySpeices(string speciesId)
        {
            string query = $"SELECT * FROM breed WHERE species_id = {speciesId}";
            if (db.State == ConnectionState.Closed) db.Open();
            //Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

            MapperColumn mapper = new MapperColumn();
            SqlMapper.SetTypeMap(typeof(Breed), mapper.GetMap<Breed>());

            List<Breed> result = db.Query<Breed>(query).ToList();
            db.Close();
            return result;
        }

        public static Breed GetBreedById(string id)
        {
            string sql = $"SELECT * FROM breed WHERE id = {id}";
            return db.QuerySingle<Breed>(sql); ;
        }

        public static bool Delete(Breed breed)
        {
            string sql = "DELETE FROM breed WHERE id = @Id";
            var parameters = new { Id = breed.Id };
            if (db.State == ConnectionState.Closed) db.Open();
            //Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

            MapperColumn mapper = new MapperColumn();
            SqlMapper.SetTypeMap(typeof(Breed), mapper.GetMap<Breed>());
            try
            {
                db.Execute(sql, parameters);
                db.Close();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool Update(Breed breed)
        {
            string sql = "UPDATE breed SET name = @name , description = @description , species_id = @speciesId WHERE id = @id";
            var parameters = new { name = breed.Name, description = breed.Description, speciesId = breed.SpeciesId, id = breed.Id };
            if (db.State == ConnectionState.Closed) db.Open();
            MapperColumn mapper = new MapperColumn();
            SqlMapper.SetTypeMap(typeof(Breed), mapper.GetMap<Breed>());
            try
            {
                db.Execute(sql, parameters);
                db.Close();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Insert(Breed breed)
        {
            string sql = "INSERT INTO `breed` (`id`, `species_id`, `name`, `description`) VALUES (@id, @speciesId, @name, @description)";
            var parameters = new { name = breed.Name, description = breed.Description, speciesId = breed.SpeciesId, id = breed.Id };
            if (db.State == ConnectionState.Closed) db.Open();
            MapperColumn mapper = new MapperColumn();
            SqlMapper.SetTypeMap(typeof(Breed), mapper.GetMap<Breed>());
            try
            {
                db.Execute(sql, parameters);
                db.Close();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
