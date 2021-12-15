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
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public int ServiceUsedId { get; set; }

        public ELItem ToELItem()
        {
            ELItem elItem = new ELItem();
            elItem.ExaminationId = this.ExaminationId;
            elItem.ItemId = this.PartId;
            elItem.Quantity = this.Quantity;
            elItem.Price = this.Price;
            elItem.ServiceUsedId = this.ServiceUsedId;
            elItem.DiscountRate = this.Discount;
            elItem.TaxRate = this.Tax;
            elItem.ItemType = "Hàng hóa";
            return elItem;
        }
    }
}
