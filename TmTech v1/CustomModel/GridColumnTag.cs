namespace TmTech_v1.CustomModel
{
    public class GridColumnTag
    {
        public string Value { get; set; }
        public int VisibleIndex { get; set; }
        public int Width { get; set; }
        public GridColumnTag()
        {
            Value = string.Empty;
            VisibleIndex = 0;
            Width = 0;
        }
        public GridColumnTag(string value,int index,int width)
        {
            Value = value;
            VisibleIndex = index;
            Width = width;
        }
    }
}
