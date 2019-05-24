using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public class Quotation : CoreEntry
    {
        public Quotation()
        {
            Company = new Company();
            QuotationCode = string.Empty;
            QuotationName = string.Empty;
            CusId = 0;
            ProjectName = string.Empty;
            ProjectAddress = string.Empty;
            ProjectValue = 0;
            Note = string.Empty;
            Quantity = 0;
            TotalValue = 0;
        }
        public Quotation(Quotation quotation)
        {
            this.QuotationCode = quotation.QuotationCode;
            this.QuotationName = quotation.QuotationName;
            this.CusId = quotation.CusId;
            this.ProjectName = quotation.ProjectName;
            this.ProjectAddress = quotation.ProjectAddress;
            this.ProjectValue = quotation.ProjectValue;
            this.Note = quotation.Note;
            this.ApproveBy = quotation.ApproveBy;
            this.ApproveDate = quotation.ApproveDate;
            this.Quantity = quotation.Quantity;
            this.TotalValue = quotation.TotalValue;
            this.Company = quotation.Company;
        }
        public Guid QuotationId { get; set; }
        public string QuotationCode { get; set; }
        public string QuotationName { get; set; }
        public int CusId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectAddress { get; set; }
        public decimal ProjectValue { get; set; }
        public string Note { get; set; }
        public int ApproveStatusId { get;set;}
        public DateTime? ApproveDate { get; set; }
        public string ApproveBy { get; set; }
        public int Quantity { get; set; }
        public decimal TotalValue { get; set; }
        private Company company;
        public Company Company
        {
            get
            {
                if(company==null)
                {
                    company = new Company();
                }
                if(CusId>0)
                    company.CompanyId = CusId;
                return company;
            }
            set
            {
                company = value;
            }
        }
        
    }
    public class QuotationMapper : ClassMapper<Quotation>
    {
        public QuotationMapper()
        {
            Table("Quotation");
            Map(p => p.Quantity).Ignore();
            Map(p => p.TotalValue).Ignore();
            Map(p => p.Company).Ignore();
            AutoMap();
        }
    }
}
