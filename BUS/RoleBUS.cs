using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class RoleBUS
    {
        public static List<Role> GetRoles()
        {
            return RoleDAO.GetRoles();
        }

        public static Role GetRoleById(string id)
        {
            return RoleDAO.GetRoleById(id);
        }

        public static bool Save(Role role)
        {
            return RoleDAO.Save(role);
        }
        public static bool Update(Role role)
        {
            return RoleDAO.Update(role);
        }
        public static bool Delete(int roleId)
        {
            return RoleDAO.Delete(roleId);
        }
    }
}
