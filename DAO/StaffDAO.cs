﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.ComponentModel;

namespace DAO
{
    public class StaffDAO : BaseDAO<Staff>
    {
        public static List<Staff> GetStaffs()
        {
            IDbConnection dbd = DataProvider.Connect;
            string query = "SELECT * FROM staff";
            if (dbd.State == ConnectionState.Closed) dbd.Open();
            //Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

            MapperColumn mapper = new MapperColumn();
            SqlMapper.SetTypeMap(typeof(Staff), mapper.GetMap<Staff>());

            List<Staff> result = dbd.Query<Staff>(query).ToList();
            dbd.Close();
            return result;
        }
        public static Staff GetStaffById(string id)
        {
            string sql = "SELECT * FROM staff WHERE id = " + id;
            return db.QuerySingle<Staff>(sql);
        }
        public static bool Save(Staff s)
        {
            try
            {
                string insert = "INSERT INTO staff " +
                                "( staff_number , first_name , last_name , birthday , phone , email , address , id_role , active , password ) VALUES " +
                                "( @staff_number , @first_name , @last_name , @birthday , @phone , @email , @address , @id_role , @active , @password )";
                int result =
                    DataProvider.Instance.ExcuteNonQuery(insert,
                    new object[] { s.StaffNumber, s.FirstName, s.LastName, s.Birthday, s.Phone, s.Email, s.Address, s.IdRole, s.Active, s.Password });
                return result == 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool Update(Staff s)
        {
            try
            {
                string sql = "UPDATE staff SET " +
                             "staff_number = @staff_number , " +
                             "first_name = @first_name , " +
                             "last_name = @last_name , " +
                             "birthday = @birthday , " +
                             "phone = @phone , " +
                             "email = @email , " +
                             "address = @address , " +
                             "id_role = @id_role , " +
                             "updated_date = @updated_date " +
                             "WHERE id = @id";
                int result = DataProvider.Instance.ExcuteNonQuery(sql, new object[] { s.StaffNumber, s.FirstName, s.LastName, s.Birthday, s.Phone, s.Email, s.Address, s.IdRole, DateTime.Now, s.Id });
                return result == 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool Delete(string id)
        {
            try
            {
                string sql = "DELETE FROM staff WHERE id = @id";
                int result = DataProvider.Instance.ExcuteNonQuery(sql, new object[] { id });
                return result == 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static object ToDBNull(object value)
        {
            if (null != value)
                return value;
            return DBNull.Value;
        }
    }
}