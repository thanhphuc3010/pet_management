using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BreedBUS
    {
        public static List<Breed> GetBreeds()
        {
            return BreedDAO.GetBreeds();
        }

        public static List<Breed> GetBreedsBySpeices(string speciesId)
        {
            return BreedDAO.GetBreedsBySpeices(speciesId);
        }

        public static Breed GetBreedById(string id)
        {
            return BreedDAO.GetBreedById(id);
        }

        public static bool AddNew(Breed breed) => BreedDAO.Insert(breed);
        public static bool Update(Breed breed) => BreedDAO.Update(breed);
        public static bool Delete(Breed breed) => BreedDAO.Delete(breed);
    }
}
