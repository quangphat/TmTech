using DapperExtensions.Mapper;

namespace TmTech_v1.Model
{
   public class SeriesPart :CoreEntry
    {
        public int SeriesPartId { get; set; }
        public string SeriesPartCode { get; set; }
        public int GroupPartId { get; set; }
        public string SeriesPartName { get; set; }
        public int? TypePartId { get; set; }
        public string Note { get; set; }
        public virtual TypePart Typepart { get; set; }
        public virtual GroupPart Grouppart { get; set; }
        public SeriesPart()
        {
            this.Typepart = new TypePart();
            this.Grouppart = new GroupPart();
        }
        public class SeriesPartMapper : ClassMapper<SeriesPart>
        {
            public SeriesPartMapper()
            {
                Table("SeriesPart");
                Map(p => p.Typepart).Ignore();
                Map(p => p.Grouppart).Ignore();
                Map(f => f.SeriesPartId).Key(KeyType.Identity);
                AutoMap();
            }
        }
    }
}
