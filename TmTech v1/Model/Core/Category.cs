using DapperExtensions.Mapper;

namespace TmTech_v1.Model
{
    public class Category :CoreEntry
    {
        public Category()
        {
            ProductCount = 0;
        }
        public int CategoryId { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public string Note { get; set; }
        public int ProductCount { get; set; }
    }
    public class CategoryMapper : ClassMapper<Category>
    {
        public CategoryMapper()
        {
            Table("Category");
            Map(m => m.ProductCount).Ignore();
            AutoMap();
        }
    }
}