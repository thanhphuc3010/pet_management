using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StaffBUS
    {
        public static List<Staff> GetStaffs()
        {
            List<Staff> result = StaffDAO.GetStaffs();
            return result;
        }
        public static Staff GetStaffById(string id)
        {
            return StaffDAO.GetStaffById(id);
        }
        public static bool Save(Staff s)
        {
            return StaffDAO.Save(s);
        }
    }
}
