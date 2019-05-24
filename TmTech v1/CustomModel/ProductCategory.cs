namespace TmTech_v1.CustomModel
{
    public class ProductCategory
    {
        public enum ProductCategoryType { Category = 1, SubCategory = 2, Serie = 3 };
        public int Id { get; set; }
        public string Name { get; set; }
        private ProductCategoryType categoryType;
        public ProductCategoryType CategoryType
        {
            get
            {
                return categoryType;
            }
            set
            {
                categoryType = value;
            }
        }
    }
}
