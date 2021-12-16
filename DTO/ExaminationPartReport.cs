using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExaminationPartReport
    {
        public long Id { get; set; }
        public string ExaminationNumber { get; set; }
        public DateTime ExaminationDate { get; set; }
        public string ExaminationType { get; set; }
        public string Status { get; set; }
        public int DoctorId { get; set; }

        public int PetId { get; set; }
        public string PetName { get; set; }
        public string PetNumber { get; set; }
        
        public int PartId { get; set; }
        public string PartNumber { get; set; }
        public string PartName { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxRate { get; set; }
        public decimal Subtotal { get; set; }
        public string ServiceUseId { get; set; }
    }
}
