using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ExaminationBUS
    {
        private ExaminationDAO dao = new ExaminationDAO();

        public bool Save(Examination examination)
        {
            int result = dao.Save(examination);
            return (result == 1);
        }
    }
}
