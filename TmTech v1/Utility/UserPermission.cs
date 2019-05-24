namespace TmTech_v1.Utility
{
    public class UserPermission
    {
        public enum ObjectPermission
        {
            AppAccount = 1,
            Product = 2
        }
        public bool ViewOwn { get; set; }
        public bool ViewAll { get; set; }
        public bool Create { get; set; }
        public bool Edit { get; set; }
        public bool Delete { get; set; }
        public bool Approve { get; set; }
        public UserPermission()
        {
            ViewOwn = ViewAll = Create = Edit = Delete = false;
        }
    }
}
