using DevExpress.Data;

namespace TmTech_v1.Model
{
    public interface IHandlerEventDatagridview
    {
        void HandlerEventRowSelect(object T);
        void HandlerEventDoubleClick(object T);
    }

    public class FooterParameter
    {
        public FooterParameter()
        {
            ItemType = SummaryItemType.None;
            Field = string.Empty;
            StringFormat = string.Empty;
            NameColumn = string.Empty;
            IndexColumn = -1;
        }
        public SummaryItemType ItemType { get; set; }
        public string Field { get; set; }
        public string StringFormat { get; set; }
        public string NameColumn { get; set; }
        public int IndexColumn { get; set; }
    }
}
