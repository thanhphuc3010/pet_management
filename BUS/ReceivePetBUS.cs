using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class ReceivePetBUS
    {
        private ReceivePetDAO dao = new ReceivePetDAO();
        public PetData GetPetData(string id)
        {
            PetData petData = dao.GetPetData(id);
            petData.CustomerName = $"{petData.FirstName} {petData.LastName}";
            return petData;
        }

        public int GetCountExaminationToday() => dao.GetCountExaminationToday();
    }
}
