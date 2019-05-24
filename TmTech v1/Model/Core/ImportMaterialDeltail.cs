using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public class ImportMaterialDetail : CoreEntry
    {
        public ImportMaterialDetail()
        {
            Material = new Material();
            
            Quantity = 1;
            ImportDetailId = Guid.Empty;
            ImportId = Guid.Empty;
           
        }
        public Guid ImportDetailId { get; set; }
        public Guid ImportId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int? MaterialId { get; set; }
        private decimal thanhtien;
        public decimal Thanhtien
        {
            get
            {
                return Quantity * Price;
            }
            set
            {
                thanhtien = value;
            }
        }
        public virtual Material Material { get; set; }
    }

    public enum ImportMaterialDetailFilerSearch
    {

    }
    public class ImportMaterialDetailMapper : ClassMapper<ImportMaterialDetail>
    {
        public ImportMaterialDetailMapper()
        {
            Table("ImportMaterialDetail");
            Map(p => p.Thanhtien).Ignore();
            Map(p => p.Material).Ignore();
            AutoMap();
        }
    }
}
