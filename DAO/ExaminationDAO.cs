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

        public bool DoneExamination(Examination examination)
        {
            SetMapper();
            var result = db.Update(examination);
            return result;
        }

        public List<ExaminationInfor> GetExaminationInfors()
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
                            CONCAT(c.first_name, ' ', c.last_name) AS customerName 
                            FROM examination e
                            INNER JOIN pet p ON e.id_pet = p.id 
                            INNER JOIN customer c ON p.customer_id = c.id 
                            INNER JOIN breed b ON p.breed_id = b.id 
                            INNER JOIN species s ON b.species_id = s.id";
            if (dbd.State == ConnectionState.Closed) dbd.Open();
            //Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

            List<ExaminationInfor> result = dbd.Query<ExaminationInfor>(query).ToList();
            dbd.Close();
            return result;
        }

        public List<ExaminationData> GetExaminationDatas()
        {
            IDbConnection dbd = DataProvider.Connect;
            string query = @"SELECT
                            e.examination_date AS examinationDate,
                            COUNT(*) AS quantity,
                            SUM(d.total) AS total,
                            SUM(d.tax) AS tax,
                            SUM(d.discount) AS discount
                            FROM
                            examination e
                            LEFT JOIN exam_total_summary d ON
                            e.id = d.id
                            GROUP BY
                            e.examination_date";
            if (dbd.State == ConnectionState.Closed) dbd.Open();
            //Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

            List<ExaminationData> result = dbd.Query<ExaminationData>(query).ToList();
            dbd.Close();
            return result;
        }
    }
}
