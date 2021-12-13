using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class PartBUS : BaseBUS<PartDAO, Part>
    {
        private PartDAO partDAO => baseDAO;
        public List<Part> GetParts() => partDAO.GetParts();
        public Part GetPartById(string id) => partDAO.GetPartById(id);
        public bool Save(Part entity) => partDAO.Save(entity);
          
        public bool Update(Part entity) => partDAO.Update(entity);
        public bool Delete(string id) => partDAO.Delete(id);
    }
}
