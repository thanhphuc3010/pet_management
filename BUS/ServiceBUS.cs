using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class ServiceBUS
    {
        public static List<Service> GetServices()
        {
            return ServiceDAO.GetServices();
        }
        public static bool Save(Service service)
        {
            return ServiceBUS.Save(service);
        }
    }
}
