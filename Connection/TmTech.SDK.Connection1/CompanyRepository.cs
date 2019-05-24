using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmTech.Core;
using System.Data;

namespace TmTech.SDK.Connection1
{

    public class Company : CoreEntry
    {
        public int CompanyId { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string Taxcode { get; set; }
        public string SwiftCode { get; set; }
        public int? NumberOfEmployee { get; set; }
        public double? DebitValue { get; set; }
        public int ParentCompanyId { get; set; }
        public int Branch { get; set; }
        public decimal TagetValue { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public int? TypeId { get; set; }
        public Boolean isActive { get; set; }
        public int BankID { get; set; }
        public string PictureLogo { get; set; }
        public string Photo { get; set; }
        public int ClassId { get; set; }
    }
    public class CompanyMapper : ClassMapper<Company>
    {
        public CompanyMapper()
        {
            Table("Company");
            AutoMap();
        }
    }
    public interface ICompanyRepository : IGenericRepository<Company>

    { 

    }
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(IDbTransaction transaction) : base(transaction)
        {
        }
    }
}
