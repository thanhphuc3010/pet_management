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
        private PartDAO PartDAO => baseDAO;
        public List<Part> GetParts() => PartDAO.GetParts();
        public override bool Save(Part entity) => Save(entity);
        public override bool Update(Part entity) => Update(entity);
        public override bool Delete(string id) => PartDAO.Delete(id);
    }
}
