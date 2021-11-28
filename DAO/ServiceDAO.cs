﻿using System;
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
        public bool Update(Service service)
        {
            try
            {
                string sql = "UPDATE service SET " +
                             "id_service_group = @id_service_group , " +
                             "name = @name , " +
                             "description = @description , " +
                             "id_unit = @id_unit , " +
                             "price = @price , " +
                             "tax = @tax " +
                             "WHERE id = @id";
                int result = DataProvider.Instance.ExcuteNonQuery(sql, new object[] { service.GroupServiceId, service.Name, service.Description, service.UnitId, service.Price, service.Tax, service.Id });
                return result == 1;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public bool Delete(string id)
        {
            try
            {
                string delete = $"DELETE FROM service WHERE id = {id}";
                int result = DataProvider.Instance.ExcuteNonQuery(delete);
                return result == 1;
            }
            catch (Exception e)
            {
                throw e;
            }
        } 
    }
}
