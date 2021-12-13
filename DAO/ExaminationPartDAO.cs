using DapperExtensions;
using DapperExtensions.Predicate;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ExaminationPartDAO : BaseDAO<ExaminationPart>
    {
        private static void SetMapper()
        {
            DapperExtensions.DapperExtensions.DefaultMapper = typeof(ExaminationPartMapper);

            DapperExtensions.DapperExtensions.SetMappingAssemblies(new[]
            {
                typeof (ExaminationPartMapper).Assembly
            });
            DapperExtensions.DapperExtensions.SqlDialect = new DapperExtensions.Sql.MySqlDialect();
        }

        public int Save(ExaminationPart exPart)
        {
            SetMapper();
            try
            {
                var result = db.Insert(new ExaminationPart
                {
                    ExaminationId = exPart.ExaminationId,
                    PartId = exPart.PartId,
                    Quantity = exPart.Quantity,
                    Price = exPart.Price,
                    ServiceUsedId = exPart.ServiceUsedId
                });
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(ExaminationPart exPart)
        {
            SetMapper();
            var result = db.Delete(exPart);
            return result;
        }

        public List<ExaminationPart> GetExaminationPartsDetail(long exId)
        {
            SetMapper();
            //var pg = new PredicateGroup { Operator = GroupOperator.And, Predicates = new List<IPredicate>() };
            var predicate = (Predicates.Field<ExaminationPart>(f => f.ExaminationId, Operator.Eq, exId));
            List<ExaminationPart> examinations = db.GetList<ExaminationPart>(predicate).ToList();
            return examinations;
        }
    }
}
