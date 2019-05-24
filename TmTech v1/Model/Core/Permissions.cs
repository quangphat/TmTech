namespace TmTech_v1.Model
{
    public class Permissions :CoreEntry
    {
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public bool ViewOwn { get; set; }
        public bool ViewAll { get; set; }
        public bool Create { get; set; }
        public bool Edit { get; set; }
        public bool Delete { get; set; }
        public bool Approve { get; set; }
        public int UserGroupId { get; set; }
        public string ObjectPermissionName { get; set; }
        public int? ObjectPermissionId { get; set; }
        public string Note { get; set; }
        public virtual ObjectPermission ObjectPermission {get;set;}
        public virtual UserGroup UserGroup { get; set; }

    }
}
