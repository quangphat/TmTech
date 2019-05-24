using DapperExtensions.Mapper;
using System.Drawing;

namespace TmTech_v1.Model
{
    public class Part : CoreEntry
    {
        public int SeriesPartID { get; set; }
        public string PartNumber { get; set; }
        public int PartID { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public decimal Pricespart { get; set; }
        public string PartName { get; set; }


    }
    public class PartBackUp : CoreEntry
    {
        public int SeriesPartID { get; set; }
        public string PartNumber { get; set; }
        public int PartID { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public decimal Pricespart { get; set; }
        public string PartName { get; set; }
        public Image ImageBackUp { get; set; }


    }


    public class PartMapper : ClassMapper<Part>
    {
        public PartMapper()
        {
            Table("Part");
            Map(f => f.PartID).Key(KeyType.Identity);
            AutoMap();
        }
    }



    public class Sourcing : CoreEntry
    {
        public int SouringID { get; set; }
        public int PartID { get; set; }
        public int SupplierID { get; set; }
        public string Note { get; set; }
    }


    public class SourcingMapper : ClassMapper<Sourcing>
    {
        public SourcingMapper()
        {
            Table("Sourcing");
            Map(f => f.SouringID).Key(KeyType.Identity);
            AutoMap();
        }
    }

}
