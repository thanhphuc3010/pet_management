using Dapper;
using DapperExtensions;
using DapperExtensions.Predicate;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ExaminationDAO : BaseDAO<Examination>
    {
        private ExaminationPartDAO exPartDAO = new ExaminationPartDAO();
        private ExaminationServiceDAO exServiceDAO = new ExaminationServiceDAO();
        public int Save(Examination examination)
        {
            SetMapper();
            try
            {
                var result = db.Insert(new Examination
                {
                    ExaminationNumber = examination.ExaminationNumber,
                    ExaminationDate = examination.ExaminationDate,
                    Type = examination.Type,
                    PetId = examination.PetId,
                    DoctorId = examination.DoctorId,
                    ReceptionistId = examination.ReceptionistId,
                    Status = examination.Status
                });
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Examination> GetExaminationsToday()
        {
            SetMapper();
            var predicate = Predicates.Field<Examination>(f => f.ExaminationDate, Operator.Eq, DateTime.Today);
            List<Examination> examinations = db.GetList<Examination>(predicate).ToList();
            return examinations;
        }

        public List<Examination> GetExaminations()
        {
            SetMapper();
            List<Examination> examinations = db.GetList<Examination>().ToList();
            return examinations;
        }

        private static void SetMapper()
        {
            DapperExtensions.DapperExtensions.DefaultMapper = typeof(ExaminationMapper);

            DapperExtensions.DapperExtensions.SetMappingAssemblies(new[]
            {
                typeof (ExaminationMapper).Assembly
            });
            DapperExtensions.DapperExtensions.SqlDialect = new DapperExtensions.Sql.MySqlDialect();
        }

        public bool DeleteExamination(Examination examination)
        {
            SetMapper();
            try
            {
                string sql = $"CALL delete_examination({examination.Id})";
                int result = DataProvider.Instance.ExcuteNonQuery(sql);
                return result == 1;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool DoneExamination(Examination examination)
        {
            SetMapper();
            var result = db.Update(examination);
            return result;
        }

        public List<ExaminationInfor> GetExaminationInfors(DateTime fromDate, DateTime toDate)
        {
            IDbConnection dbd = DataProvider.Connect;
            string query = @"SELECT
                            e.id,
                            e.type,
                            e.id_receptionist AS receptionistId,
                            e.id_doctor AS doctorId,
                            e.status,
                            e.examination_number AS examinationNumber, 
                            e.examination_date AS examinationDate,
                            e.id_pet AS petId,
                            p.name AS petName, 
                            b.name AS breed, 
                            s.name AS species, 
                            CONCAT(c.first_name, ' ', c.last_name) AS customerName,
                            c.id AS customerId
                            FROM examination e
                            INNER JOIN pet p ON e.id_pet = p.id 
                            INNER JOIN customer c ON p.customer_id = c.id 
                            INNER JOIN breed b ON p.breed_id = b.id 
                            INNER JOIN species s ON b.species_id = s.id 
                            WHERE e.examination_date BETWEEN @FromDate AND @ToDate";
            if (dbd.State == ConnectionState.Closed) dbd.Open();
            //Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
            var parameters = new { FromDate = fromDate, ToDate = toDate };
            List<ExaminationInfor> result = dbd.Query<ExaminationInfor>(query, parameters).ToList();
            dbd.Close();
            return result;
        }

        public List<ExaminationPartReport> GetExPartDataReport()
        {
            IDbConnection con = DataProvider.Connect;
            string sql = @" SELECT
                                e.id,
                                e.examination_number AS examinationNumber,
                                e.examination_date AS examinationDate,
                                e.type AS examinationType,
                                e.id_doctor AS doctorId,
                                e.status,
                                p.id AS petId,
                                p.name AS petName,
                                p.pet_number AS petNumber,
                                ep.id_part AS partId,
                                ep.quantity AS quantity,
                                pa.part_number AS partNumber,
                                pa.name AS partName,
                                u.name AS unit,
                                ep.price,
                                ep.tax AS taxRate,
                                ep.discount AS discountRate,
                                s.name AS serviceUseId
                            FROM
                                examination e
                            INNER JOIN pet p ON
                                e.id_pet = p.id
                            INNER JOIN examination_part ep ON
                                e.id = ep.id_examination
                            INNER JOIN part pa ON
                                ep.id_part = pa.id
                            INNER JOIN unit u ON
                                pa.id_unit = u.id
                            LEFT JOIN service s ON
                                ep.use_for_service = s.id";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            List<ExaminationPartReport> data = con.Query<ExaminationPartReport>(sql).ToList();
            con.Close();
            return data;
        }

        public List<ExaminationData> GetExaminationDatas(int month, int year, string type)
        {
            IDbConnection dbd = DataProvider.Connect;
            string sql;

            if (month == 0)
            {
                sql = @" SELECT * FROM (
                            SELECT
                                e.examination_date AS examinationDate,
                                COUNT(*) AS quantity,
                                SUM(d.total) AS total,
                                SUM(d.tax) AS tax,
                                SUM(d.discount) AS discount
                            FROM
                                examination e
                            LEFT JOIN exam_total_summary d ON
                                e.id = d.id
                            WHERE e.type = @Type
                            AND e.status = 'Đã thanh toán'
                            GROUP BY
                                e.examination_date)
                            AS temp
                            WHERE YEAR(temp.examinationDate) = @Year";
                var parameters = new { Type = type, Year = year };
                if (dbd.State == ConnectionState.Closed) dbd.Open();
                List<ExaminationData> result = dbd.Query<ExaminationData>(sql, parameters).ToList();
                dbd.Close();
                return result;
            } else
            {
                sql = @" SELECT * FROM (
                            SELECT
                                e.examination_date AS examinationDate,
                                COUNT(*) AS quantity,
                                SUM(d.total) AS total,
                                SUM(d.tax) AS tax,
                                SUM(d.discount) AS discount
                            FROM
                                examination e
                            LEFT JOIN exam_total_summary d ON
                                e.id = d.id
                            WHERE e.type = @Type
                            AND e.status = 'Đã thanh toán'
                            GROUP BY
                                e.examination_date)
                            AS temp
                            WHERE MONTH(temp.examinationDate) = @Month AND YEAR(temp.examinationDate) = @Year";
                var parameters = new { Type = type, Month = month, Year = year };
                if (dbd.State == ConnectionState.Closed) dbd.Open();
                List<ExaminationData> result = dbd.Query<ExaminationData>(sql, parameters).ToList();
                dbd.Close();
                return result;
            }
        }
    }
}
