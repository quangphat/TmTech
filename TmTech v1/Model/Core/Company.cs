using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public class Company : CoreEntry
    {
        public int CompanyId { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Taxcode { get; set; }
        public string SwiftCode { get; set; }
        public int? NumberOfEmployee { get; set; }
        public double? DebitValue { get; set; }
        public int? ParentCompanyId { get; set; }
        public int? Branch { get; set; }
        public decimal TagetValue { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public int? TypeId { get; set; }
        public bool? isActive { get; set; }
        public string Photo { get; set; }
        public string PictureLogo { get; set; }
        public string BankName { get; set; }
        public string BankAccount { get; set; }
        public int? ClassId { get; set; }
        public int ApproveStatusId { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string ApproveBy { get; set; }
        public string Accountant { get; set; }
        public string AccountantPhone { get; set; }
        public Deputy MainDeputy { get; set; }
        public CompanyClass Class { get; set; }
        public CompanyType CompanyType { get; set; }
    }
    public class CompanyClass : CoreEntry
    {
        public int CompanyClassId { get; set; }
        public string CompanyClassCode { get; set; }
        public double CompanyClassRate { get; set; }
        public string Note { get; set; }

    }
    public class CompanyMapper : ClassMapper<Company>
    {
        public CompanyMapper()
        {
            Table("Company");
            Map(p => p.MainDeputy).Ignore();
            Map(p => p.Class).Ignore();
            Map(p => p.CompanyType).Ignore();
            AutoMap();
        }
    }

}
