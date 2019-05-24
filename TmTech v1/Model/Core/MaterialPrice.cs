using System;

namespace TmTech_v1.Model
{
    public class MaterialPrice :CoreEntry
    {
        public int? MaterialPriceId { get; set; }
        public decimal? Price { get; set; }
        public DateTime? ActiveDate { get; set; }
        public int? MaterialId { get; set; }

    }
}
