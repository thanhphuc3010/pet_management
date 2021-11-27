using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DTO;

namespace DAO
{
    public class ServiceDAO : BaseDAO<Service>
    {
        public static List<Service> GetServices()
        {
            string query = "SELECT * FROM service";
            if (db.State == ConnectionState.Closed) db.Open();

            MapperColumn mapper = new MapperColumn();
            SqlMapper.SetTypeMap(typeof(Service), mapper.GetMap<Service>());

            List<Service> result = db.Query<Service>(query).ToList();
            db.Close();
            return result;
        }
        public static bool Save(Service service)
        {
            try
            {
                string sql = "INSERT INTO `service` (`id_service_group`, `name`, `description`, `id_unit`, `price`, `tax`) VALUES " +
                    "( @id_service_group , @name , @description , @id_unit , @price , @tax )";
                int result = DataProvider.Instance.ExcuteNonQuery(sql, new object[] { service.GroupServiceId, service.Name, service.Description, service.UnitId, service.Price, service.Tax });
                return result == 1;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
