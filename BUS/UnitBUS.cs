using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class UnitBUS
    {
        public static List<Unit> GetUnits()
        {
            return UnitDAO.GetUnits();
        }

        public static Unit GetUnitById(string id)
        {
            return UnitDAO.GetUnitById(id);
        }
    }
}
