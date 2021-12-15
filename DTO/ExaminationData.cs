using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExaminationData
    {
        public DateTime ExaminationDate { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Paymented { get; set; }
    }
}
