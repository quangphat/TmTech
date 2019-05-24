using DapperExtensions.Mapper;

namespace TmTech_v1.Model
{
    public class Stock : CoreEntry
    {
        public int StockId { get; set; }
        public string StockName { get; set; }
        public string StockCode { get; set; }
    }

    public class ApproveStatusModel
    {

       
        public int StatusId { get; set; }
        public string StatusName { get; set; }
       
    }

    public class StockMapper : ClassMapper<Stock>
    {
        public StockMapper()
        {
            Table("Stock");
            AutoMap();
        }
    }
}
