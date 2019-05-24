using DapperExtensions.Mapper;

namespace TmTech_v1.Model
{
    public class UserGroup:CoreEntry
    {
        public int UserGroupId { get; set; }
        public string USerGroupCode { get; set; }
        public string UserGroupName { get; set; }
        public string Note { get; set; }
        public virtual Users Users { get; set; }
    }

    public class UserGroupMapper: ClassMapper<UserGroup>
    {
        public UserGroupMapper()
        {
            Table("UserGroup");
            Map(p => p.Users).Ignore();
            AutoMap();
        }
    }
}
