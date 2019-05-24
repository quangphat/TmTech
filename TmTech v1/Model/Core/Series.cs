using DapperExtensions.Mapper;

namespace TmTech_v1.Model
{
    public class Series :CoreEntry
    {
        public int SerieId { get; set; }
        public string SerieCode { get; set; }
        public string SerieName { get; set; }
        public int CategoryId { get; set; }
        public string Note { get; set; }
        public virtual Category Category { get; set; }
        public Series()
        {
            this.Category = new Category();
        }
        public class SeriesMapper:ClassMapper<Series>
        {
            public SeriesMapper()
            {
                Table("Series");
                Map(p => p.Category).Ignore();
                AutoMap();
            }
        }
    }
}
