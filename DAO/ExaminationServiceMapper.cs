using DapperExtensions.Mapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class ExaminationServiceMapper : ClassMapper<ExaminationService>
    {
        public ExaminationServiceMapper()
        {
            Table("examination_service");
            Map(f => f.ExaminationId).Column("id_examination");
            Map(f => f.ServiceId).Column("id_service");
            Map(f => f.Tax).Column("tax");
            Map(f => f.Price).Column("price");
            Map(f => f.Discount).Column("discount");
            AutoMap();
        }
    }
}
