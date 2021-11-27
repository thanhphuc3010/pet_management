using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Service
    {
        public int Id { get; set; }
        [Description("id_service_group")]
        public int GroupServiceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Description("id_unit")]
        public int UnitId { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
    }
}
