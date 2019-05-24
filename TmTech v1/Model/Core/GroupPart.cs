using DapperExtensions.Mapper;

namespace TmTech_v1.Model
{
    public class GroupPart : CoreEntry
    {

        public GroupPart()
        {
            ProductCount = 0;
            User = new Users();
        }
        public int GroupPartId { get; set; }
        public string GroupPartCode { get; set; }
        public string GroupPartName { get; set; }
        public string Note { get; set; }
        
        public int ProductCount { get; set; }
        public virtual Users User { get; set; }
    }
    public class GroupPartMapper : ClassMapper<GroupPart>
    {
        public GroupPartMapper()
        {
            Table("GroupPart");
            Map(m => m.User).Ignore();
            Map(m => m.ProductCount).Ignore();
            AutoMap();
        }
    }


}
