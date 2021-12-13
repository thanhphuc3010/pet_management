using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ExaminationMapper : ClassMapper<Examination>
    {
        public ExaminationMapper()
        {
            Table("examination");
            Map(f => f.Id).Key(KeyType.Identity);
            Map(f => f.ExaminationNumber).Column("examination_number");
            Map(f => f.ExaminationDate).Column("examination_date");
            Map(f => f.PetId).Column("id_pet");
            Map(f => f.ReceptionistId).Column("id_receptionist");
            Map(f => f.DoctorId).Column("id_doctor");
            Map(f => f.CreatedDate).Column("created_date");
            Map(f => f.UpdatedDate).Column("updated_date");
            AutoMap();
        }
    }
}
