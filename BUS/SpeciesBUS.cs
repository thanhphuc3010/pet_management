using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public static class SpeciesBUS
    {
        public static List<Species> GetData()
        {
            return SpeicesDAO.GetAllSpeices();
        }

        public static bool AddNewSpecies(Species species)
        {
            return SpeicesDAO.InsertSpeices(species);
        }

        public static int GetLastID()
        {
            return SpeicesDAO.GetLastID();
        }

        public static bool Update(Species species)
        {
            return SpeicesDAO.Update(species);
        }

        public static bool Delete(Species species)
        {
            return SpeicesDAO.Delete(species);
        }
    }
}
