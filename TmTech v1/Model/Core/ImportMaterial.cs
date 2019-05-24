using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public class ImportMaterial : CoreEntry
    {
        public ImportMaterial()
        {
            Stock = new Stock();
            ImportId = Guid.Empty;
            Unit = new Unit();
            ApproveStatusId = ConstraintApproveStatus.ProcessStatus;
        }
        public Guid ImportId { get; set; }
        public string ImportCode { get; set; }
        public string ImportName { get; set; }
        public int StockId { get; set; }
        public int ApproveStatusId { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string ApproveBy { get; set; }

        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public virtual Stock Stock { get; set; }
        public virtual Unit Unit { get; set; }

    }

    public class ImportMaterialMapper : ClassMapper<ImportMaterial>
    {
        public ImportMaterialMapper()
        {
            Table("ImportMaterial");
            Map(p => p.Stock).Ignore();
            Map(p => p.Unit).Ignore();
            Map(p => p.Quantity).Ignore();
            Map(p => p.Total).Ignore();
            AutoMap();
        }
    }
}
