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
        public static Staff GetStaffAuthentication(string email, string password)
        {
            return StaffDAO.GetStaffAuthentication(email, password);
        }
        public static bool Save(Staff s)
        {
            if (string.IsNullOrWhiteSpace(s.Address))
            {
                s.Address = null;
            }
            return StaffDAO.Save(s);
        }
        public static bool Update(Staff s)
        {
            if (string.IsNullOrWhiteSpace(s.Address))
            {
                s.Address = null;
            }
            return StaffDAO.Update(s);
        }
        public static bool Delete(string id)
        {
            return StaffDAO.Delete(id);
        }
    }
}
