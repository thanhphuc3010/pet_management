using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class PetBUS
    {
        public static List<Pet> GetPets()
        {
            return PetDAO.GetPets();
        }
        public static bool Save(Pet p )
        {
            return PetDAO.Save(p);
        }
    }
}
