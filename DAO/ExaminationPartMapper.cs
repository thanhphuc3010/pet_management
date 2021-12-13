using DapperExtensions.Mapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ExaminationPartMapper : ClassMapper<ExaminationPart>
    {
        public ExaminationPartMapper()
        {
            Table("examination_part");
            Map(f => f.ExaminationId).Column("id_examination").Key(KeyType.Assigned);
            Map(f => f.PartId).Column("id_part").Key(KeyType.Assigned);
            Map(f => f.Quantity).Column("quantity");
            Map(f => f.Price).Column("price");
            Map(f => f.ServiceUsedId).Column("use_for_service");
            AutoMap();
        }
    }
}
