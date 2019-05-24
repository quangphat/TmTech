using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public class PoDetail:CoreEntry
    {
        public Guid PODetailId { get; set; }
        public string PoDetailCode { get; set; }
        public Guid POId { get; set; }
        public Guid ProductId { get; set; }
        public int QuotationId { get; set; }
        public decimal POPrice { get; set; }
        public int Quantity { get; set; }
        public int? UnitId { get; set; }
        public string Note { get; set; }
        private decimal totalPrice;
        public decimal TotalPrice
        {
            get
            {
                return POPrice * Quantity;
            }
            set
            {
                totalPrice = value;
            }
        }
        public virtual Po PO { get; set; }
        public virtual Product Product {get;set;}
    }
    public class PoDetailMapper : ClassMapper<PoDetail>
    {
        public PoDetailMapper()
        {
            Table("PODetail");
            Map(p => p.TotalPrice).Ignore();
            Map(p => p.PO).Ignore();
            Map(p => p.Product).Ignore();
            AutoMap();
        }
    }
}
