using System;

namespace TmTech_v1.Model
{
    public class ProductMaterial
    {
        public Guid ProductId { get; set; }
        public int MaterialId { get; set; }
        public int MaterialQuantity { get; set; }
    }

}
