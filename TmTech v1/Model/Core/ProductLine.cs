
using DapperExtensions.Mapper;
namespace TmTech_v1.Model
{
    public class ProductLine : CoreEntry
    {
        public int ProductLineId { get; set; }
        public string ProductLineCode { get; set; }
        public string ProductLineName { get; set; }
        public string Note { get; set; }
        public int SerieId { get; set; }
    }
    public class ProductLineMapper : ClassMapper<ProductLine>
    {
        public ProductLineMapper()
        {
            Table("ProductLine");
            Map(p => p.ProductLineId).Key(KeyType.Identity);
            AutoMap();
        }
    }
}
