using DapperExtensions;
using DapperExtensions.Predicate;
using DTO;
using System;
using System.Collections.Generic;
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
    }
}
