using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Examination
    {
        [Key]
        public long Id { get; set; }

        [Description("examination_number")]
        public string ExaminationNumber { get; set; }
        [Description("examination_date")]
        public DateTime ExaminationDate { get; set; }
        public string Type { get; set; }
        [Description("id_pet")]
        public int PetId { get; set; }
        [Description("id_receptionist")]
        public int ReceptionistId { get; set; }
        [Description("id_doctor")]
        public int DoctorId { get; set; }
        public string Symptom { get; set; }
        public string Conclude { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
        public decimal Payment { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
