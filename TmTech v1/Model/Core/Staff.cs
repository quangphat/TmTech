using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public class Staff : CoreEntry
    {
        public Staff()
        {
            Department = new Department();
            User = new Users();
            UserGroup = new UserGroup();
            UserType = new UserType();
        }
        public Staff(Users uer)
        {
            this.StaffName = uer.FullName;
            this.Email = uer.Email;
            this.Phone = uer.Phone;
            this.Address = uer.Address;
            this.Sex = uer.Sex;

        }
        public int StaffId { get; set; }
        public string StaffCode { get; set; }
        public string StaffName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Skype { get; set; }
        public string Address { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime? BeginDate { get; set; }
        public int? DepartmentId { get; set; }
        public int? PositionId { get; set; }
        public string Avatar { get; set; }
        public string SignaturePhoto { get; set; }
        public int? UserId { get; set; }
        public bool Sex { get; set; }

        public virtual Department Department { get; set; }
        public virtual Users User { get; set; }
        public virtual UserType UserType { get; set; }
        public virtual UserGroup UserGroup { get; set; }
        public virtual StaffPosition StaffPosition { get; set; }
    }

    public class StaffMapper : ClassMapper<Staff>
    {
        public StaffMapper()
        {
            Table("Staff");
            Map(p => p.Department).Ignore();
            Map(p => p.User).Ignore();
            Map(p => p.UserType).Ignore();
            Map(p => p.UserGroup).Ignore();
            Map(p => p.StaffPosition).Ignore();
            AutoMap();
        }
    }
}
