using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExaminationPart    
    {
        public long ExaminationId { get; set; }
        public int PartId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int? ServiceUsedId { get; set; }

        public ELItem ToELItem()
        {
            ELItem elItem = new ELItem();
            elItem.ExaminationId = this.ExaminationId;
            elItem.ItemId = this.PartId;
            elItem.Quantity = this.Quantity;
            elItem.Price = this.Price;
            elItem.ServiceUsedId = this.ServiceUsedId;
            elItem.Discount = 0;
            elItem.Tax = 0;
            elItem.ItemType = "Hàng hóa";
            return elItem;
        }
    }
}
