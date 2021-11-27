using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class GroupServiceBUS
    {
        public static List<GroupService> GetGroupServices()
        {
            return GroupServiceDAO.GetGroupServices();
        }

        public static bool Save(GroupService value)
        {
            return GroupServiceDAO.Save(value);
        }
        public static bool Update(GroupService value)
        {
            return GroupServiceDAO.Update(value);
        }

        public static bool Delete(string id)
        {
            return GroupServiceDAO.Delete(id);
        }

        public static int GetLastID()
        {
            return GroupServiceDAO.GetLastID();
        }
    }
}
