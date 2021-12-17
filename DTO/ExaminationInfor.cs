using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExaminationInfor
    {
        public long Id { get; set; }
        public string ExaminationNumber { get; set; }
        public DateTime ExaminationDate { get; set; }
        public string Type { get; set; }
        public int PetId { get; set; }
        public string PetName { get; set; }
        public int ReceptionistId { get; set; }
        public int DoctorId { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal Payment { get; set; }
        public decimal Subtotal { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Breed { get; set; }
        public string Species { get; set; }
        public string ReceptionistName { get; set; }
        public string DoctorName { get; set; }

        public void MapperData(Examination ex)
        {
            Id = ex.Id;
            ExaminationNumber = ex.ExaminationNumber;
            ExaminationDate = ex.ExaminationDate;
            Type = ex.Type;
            PetId = PetId;
            ReceptionistId = ReceptionistId;
            DoctorId = ex.DoctorId;
        }
    }
}
