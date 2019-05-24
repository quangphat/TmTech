using System;
using TmTech_v1.Model;

namespace TmTech_v1.CustomModel
{
    public class ProductTag
    {
        public Guid ProductId { get; set; }
        public string ProductCode { get; set; }
        public string Photo { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public Series Serie { get; set; }
        public ProductLine Line { get; set; }
    }
}
