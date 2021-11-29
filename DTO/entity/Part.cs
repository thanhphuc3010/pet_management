using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Part
    {
        public int Id { get; set; }
        [Description("id_make")]
        public int MakeId { get; set; }
        [Description("part_number")]
        public string PartNumber { get; set; }
        public string Name { get; set; }
        [Description("id_unit")]
        public int UnitId { get; set; }
        public string Uses { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Tax { get; set; }
        public Part() { }
    }
}
