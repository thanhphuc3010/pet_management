using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Dapper;
using System.Data.SqlClient;

namespace DAO
{
    public class PartDAO : BaseDAO<Part>
    {
        public List<Part> GetParts()
        {
            string query = "SELECT * FROM part";
            if (db.State == ConnectionState.Closed) db.Open();
            SetTypeMapper();
            try
            {
                List<Part> result = db.Query<Part>(query).ToList();
                db.Close();
                return result;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        public Part GetPartById(string id)
        {
            SetTypeMapper();
            string sql = $"SELECT * FROM part WHERE id = {id}";
            return db.QuerySingle<Part>(sql);
        }
        public bool Save(Part p)
        {
            string sql = "INSERT INTO `part` (`id_make`, `part_number`, `name`, `id_unit`, `uses`, `cost`, `price`, `quantity`, `tax`) VALUES ( @id_make , @part_number , @name , @id_unit , @uses , @cost , @price , @quantity , @tax )";
            try
            {
                int value = DataProvider.Instance.ExcuteNonQuery(sql, new object[] { p.MakeId, p.PartNumber, p.Name, p.UnitId, p.Uses, p.Cost, p.Price, p.Quantity, p.Tax });
                return value == 1;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        public bool Update(Part p)
        {
            string sql = "UPDATE `part` SET " +
                         "`id_make` = @id_make , " +
                         "`part_number` = @part_number , " +
                         "`name` = @name , " +
                         "`id_unit` = @id_unit , " +
                         "`uses` = @uses , " +
                         "`cost` = @cost , " +
                         "`price` = @price , " +
                         "`quantity` = @quantity , " +
                         "`tax` = @tax " +
                         "WHERE `part`.`id` = @id ";
            try
            {
                int value = DataProvider.Instance.ExcuteNonQuery(sql, new object[] { p.MakeId, p.PartNumber, p.Name, p.UnitId, p.Uses, p.Cost, p.Price, p.Quantity, p.Tax, p.Id });
                return value == 1;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        public bool Delete(string id)
        {
            string sql = $"DELETE FROM part WHERE id = {id}";
            int value = DataProvider.Instance.ExcuteNonQuery(sql);
            return value == 1;
        }
    }
}
