namespace TmTech_v1.Model
{
    public class ColumnInforModel
    {
        public string Caption { get; set; }
        public string FieldName { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public TypeColumn TypeColumn { get; set; }
        public bool AllowEdit { get; set; }
        public int Width { get; set; }
        public bool Vissible { get; set; }
        public string Format { get; set; }
        public object Tag { get; set; }
        public string PathPhoTo { get; set; }
        public int VissibleIndex { get; set; }
    }

    public enum TypeColumn
    {
        TEXT,
        CHECKBOX,
        IMAGE,
        SMART

    }

}
