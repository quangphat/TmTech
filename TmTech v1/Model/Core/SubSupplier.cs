using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public class SubSupplier :CoreEntry
    {
        public SubSupplier()
        {
            user = new Users();
            Supplier = new Supplier();
        }
        public int SubSupplierId { get; set; }
        public string SubSupplierCode { get; set; }
        public string SubSupplierName { get; set; }
        public int? SupplierId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public string Fax { get; set; }
        public string Skype { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public int UserId { get; set; }
        public virtual Supplier Supplier { get; set; }
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
        public Boolean IsActive { get; set; }
        public Boolean IsMain { get; set; }
        public Boolean Sex { get; set; }

    }

    public class SubSupplierMapper : ClassMapper<SubSupplier>
    {
        public SubSupplierMapper()
        {
            Table("SubSupplier");
            Map(p => p.User).Ignore();
            Map(p => p.Supplier).Ignore();
            AutoMap();
        }
    }

}
