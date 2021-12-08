using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.entity
{
    public class Examination
    {
        public int Id { get; set; }
        public string ExaminationNumber { get; set; }
        public DateTime ExaminationDate { get; set; }
        public string Type { get; set; }
        public int PetId { get; set; }
        public int ReceptionistId { get; set; }
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
