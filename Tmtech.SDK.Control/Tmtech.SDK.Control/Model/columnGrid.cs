
namespace Tmtech.SDK.Control.Model
{
    public class ColumnGrid
    {
        public string Name { get; set; }
        public string FieldName { get; set; }
        public string Caption { get; set; }
        public int Width { get; set; }
        public TypeColumn Type { get; set; }
    }

    public enum TypeColumn
    {
        Text,
        Image,
        Money,
        Number,
        Float
    }


}
