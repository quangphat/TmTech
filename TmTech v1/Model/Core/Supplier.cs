using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public class Supplier : CoreEntry
    {
        public int SupplierId { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Taxcode { get; set; }
        public string BankAccount { get; set; }
        public string SwiftCode { get; set; }
        public int? Branch { get; set; }
        public decimal? TagetValue { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        private int typeId;
        public  Users User { get; set; }
        public Staff Staff { get; set; }
        public string Approver { get; set; }
        public bool isActive { get; set; }
        public int Benefic { get; set; } 
        public string ClassId { get; set; }
        public CompanyClass Class { get; set; }
        public int TypeId
        {
            get
            {
                return typeId;
            }
            set
            {
                typeId = 3;
            }
        }
        public int ApproveStatusId { get; set; }
        public string Photo { get; set; }
        public string PictureLogo { get; set; }
        public string BankName { get; set; }
        public int GroupId { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string ApproveBy { get; set; }
        public string AccountantPhone { get; set; }
        public string Accountant { get; set; }
        public string Status { get; set; }
        public SubSupplier SubSupplier { get; set; }
        public int NumberEmployee { get; set; }
        public float TargetValue { get; set; }
        public float SquareMeter { get; set; }
    }
    public class SupplierMapper : ClassMapper<Supplier>
    {
        public SupplierMapper()
        {
            Table("Supplier");
            Map(p => p.SubSupplier).Ignore();
            Map(p => p.User).Ignore();
            Map(p => p.Staff).Ignore();
            Map(p => p.Class).Ignore();
            AutoMap();
        }
    }
}
