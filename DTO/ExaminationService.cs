using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExaminationService
    {
        public long ExaminationId { get; set; }
        public int ServiceId { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }

        public ELItem ToELItem()
        {
            ELItem elItem = new ELItem();
            elItem.ExaminationId = this.ExaminationId;
            elItem.ItemId = this.ServiceId;
            elItem.Price = this.Price;
            elItem.Quantity = 1;
            elItem.Tax = this.Tax;
            elItem.Discount = this.Discount;
            elItem.ItemType = "Dịch vụ";
            return elItem;
        }
    }
}
