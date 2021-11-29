using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class PartBUS
    {
        PartDAO partDAO = new PartDAO();
        public List<Part> GetParts()
        {
            return partDAO.GetParts();
        }
    }
}
