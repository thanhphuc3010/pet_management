using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class MakeBUS : BaseBUS<MakeDAO, Make>
    {
        private MakeDAO MakeDAO => baseDAO;

        public List<Make> GetMakes() => MakeDAO.GetMakes();
    }
}
