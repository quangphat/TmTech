using System;

namespace TmTech_v1.Model
{
    public class ProductPrice :CoreEntry
    {
        public int PriceId { get; set; }
        public string PriceCode { get; set; }
        public string PriceName { get; set; }
        public Guid ProductId { get; set; }
        public decimal? Price { get; set; }
        public DateTime? ActiveDate { get; set; }
        public bool? Active { get; set; }
        public int? UnitId { get; set; }
        public string Note { get; set; }


        public virtual Users User { get; set; }
        public virtual Product Product { get; set; }
        public virtual CurrencyUnit Currency { get; set; }
        public ProductPrice()
        {
            this.User = new Users();
            this.Product = new Product();
            this.Currency = new CurrencyUnit();
        }
    }
}
