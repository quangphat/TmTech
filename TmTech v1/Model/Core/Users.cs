using DapperExtensions.Mapper;


namespace TmTech_v1.Model
{
    public class Users :CoreEntry
    {
        public Users()
        {
            UserGroup = new UserGroup();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool Sex { get; set; }
        public int UserGroupId { get; set; }
        public virtual UserGroup UserGroup { get; set; }

    }
    public class UsersMapper:ClassMapper<Users>
    {
        public UsersMapper()
        {
            Table("Users");
            Map(p => p.UserGroup).Ignore();
            AutoMap();
        }
    }
    public class UserSession
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int UserTypeId  { get; set; }
        public string UserType { get; set; }
        public string ThemeName { get; set; }
        public UserSession()
        {
            Id = 0;
            UserName = FullName = Email = GroupName = string.Empty;
            GroupId = 0;
            UserType = string.Empty;
            ThemeName = string.Empty;
            UserTypeId = 0;

        }
    }
}
