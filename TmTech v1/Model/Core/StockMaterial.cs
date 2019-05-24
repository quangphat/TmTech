using DapperExtensions.Mapper;

namespace TmTech_v1.Model
{
    public class StockMaterial : CoreEntry
    {
        public int StockId { get; set; }
        public int MaterialId { get; set; }
        public int InStock { get; set; }
    }
    public class StockMaterialMapper : ClassMapper<StockMaterial>
    {
        public StockMaterialMapper()
        {
            Table("StockMaterial");
            AutoMap();
        }
    }
}
