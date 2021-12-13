using DapperExtensions;
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
            DapperExtensions.DapperExtensions.DefaultMapper = typeof(ExaminationMapper);

            DapperExtensions.DapperExtensions.SetMappingAssemblies(new[]
            {
                typeof (ExaminationMapper).Assembly
            });


            DapperExtensions.DapperExtensions.SqlDialect = new DapperExtensions.Sql.MySqlDialect();
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
    }
}
