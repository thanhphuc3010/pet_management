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
        ServiceDAO serviceDAO = new ServiceDAO();
        public static List<Service> GetServices()
        {
            return ServiceDAO.GetServices();
        }
        public Service GetServiceById(string id)
        {
            return serviceDAO.GetServiceById(id);
        }
        public static bool Save(Service service)
        {
            return ServiceDAO.Save(service);
        }
        public bool Update(Service service)
        {
            return serviceDAO.Update(service);
        }
        public bool Delete(string id)
        {
            return serviceDAO.Delete(id);
        }
    }
}
