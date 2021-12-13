using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ELItem
    {
        public long ExaminationId { get; set; }
        public int ItemId { get; set; }
        public string ItemType { get; set; }
        public string ItemNumber { get; set; }
        public string ItemName { get; set; }
        public int UnitId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Discount { get; set; }
        public int? ServiceUsedId { get; set; }

        public ExaminationPart ToExPart()
        {
            ExaminationPart examinationPart = new ExaminationPart();
            examinationPart.ExaminationId = this.ExaminationId;
            examinationPart.PartId = this.ItemId;

            examinationPart.Quantity = this.Quantity;
            examinationPart.Price = this.Price;
            examinationPart.ServiceUsedId = this.ServiceUsedId;
            return examinationPart;
        }

        public ExaminationService ToExService()
        {
            ExaminationService examinationService = new ExaminationService();
            examinationService.ExaminationId = this.ExaminationId;
            examinationService.ServiceId = this.ItemId;
            examinationService.Price = this.Price;
            examinationService.Tax = (this.Tax == null) ? 0 : (decimal)this.Tax;
            examinationService.Discount = (this.Discount == null) ? 0 : (decimal)this.Discount;
            return examinationService;
        }
    }
}
