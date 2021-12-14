using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperExtensions;
using DapperExtensions.Predicate;
using DTO;

namespace DAO
{
    public class ExaminationServiceDAO : BaseDAO<ExaminationService>
    {
        private static void SetMapper()
        {
            DapperExtensions.DapperExtensions.DefaultMapper = typeof(ExaminationServiceMapper);

            DapperExtensions.DapperExtensions.SetMappingAssemblies(new[]
            {
                typeof (ExaminationServiceMapper).Assembly
            });
            DapperExtensions.DapperExtensions.SqlDialect = new DapperExtensions.Sql.MySqlDialect();
        }

        public int Save(ExaminationService exService)
        {
            SetMapper();
            try
            {
                var result = db.Insert(new ExaminationService
                {
                    ExaminationId = exService.ExaminationId,
                    ServiceId = exService.ServiceId,
                    Tax = exService.Tax,
                    Price = exService.Price,
                    Discount = exService.Discount
                });
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ExaminationService> GetExaminationServicesDetail(long exId)
        {
            SetMapper();
            //var pg = new PredicateGroup { Operator = GroupOperator.And, Predicates = new List<IPredicate>() };
            var predicate = (Predicates.Field<ExaminationService>(f => f.ExaminationId, Operator.Eq, exId));
            List<ExaminationService> examinations = db.GetList<ExaminationService>(predicate).ToList();
            return examinations;
        }

        public bool Delete(ExaminationService exService)
        {
            SetMapper();
            var result = db.Delete(exService);
            return result;
        }

        public bool Update(ExaminationPart exPart)
        {
            SetMapper();
            var result = db.Update(exPart);
            return result;
        }
    }
}
