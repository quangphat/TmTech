using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public class Deputy :CoreEntry
    {
        public Deputy()
        {
            DeputyId = CompanyId = 0;
            DeputyCode = DeputyName = string.Empty;
            Address = Phone = Fax = Skype = Email = Note = string.Empty;
            user = new Users();
            Company = new Company();
        }
        public int DeputyId { get; set; }
        public string DeputyCode { get; set; }
        public string DeputyName { get; set; }
        public int CompanyId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public string Fax { get; set; }
        public string Skype { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public string SignaturePhoto { get; set; }
        public string Avatar { get; set; }
        public int UserId { get; set; }
        public bool IsActive { get; set; }
        public bool IsMain { get; set; }
        public bool Sex { get; set; }
        private Company company;
        public Company Company
        {
            get
            {
                company.CompanyId = this.CompanyId;
                return company;
            }
            set
            {
                company = value;
            }
        }
        private Users user;
        public Users User
        {
            get
            {
                user.UserId = this.UserId;
                return user;
            }
            set
            {
                user = value;
            }
        }
    }
 
    public class DeputyMapper:ClassMapper<Deputy>
    {
        public DeputyMapper()
        {
            Table("Deputy");
            Map(p => p.Company).Ignore();
            Map(p => p.User).Ignore();
            AutoMap();
        }
    }
     
}
