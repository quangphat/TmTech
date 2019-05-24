using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public class Po :CoreEntry
    {
        public Po()
        {
            PoId = Guid.Empty;
            PoCode = PoName = QuotationCode = TakePlace = Note = ApproveBy = string.Empty;
            CompanyId =  Quantity = 0;
            ApproveStatusId = (int)Utility.ApproveStatus.Wait;
            WarrantyPercent = 0;
            Company = new Company();
        }
        public Po(Po po)
        {
            PoId = Guid.Empty;
            PoCode = string.Empty;
            PoName = po.PoName;
            CompanyId = po.CompanyId;
            Company = po.Company;
            CreateDebt = po.CreateDebt;
            ApproveStatusId = (int)Utility.ApproveStatus.Wait;
            QuotationCode = po.QuotationCode;
            Quotation = po.Quotation;
            TakePlace = po.TakePlace;
            Note = po.Note;
            ApproveDate = null;
            ApproveBy = string.Empty;
            Quantity = po.Quantity;
            TotalValue = po.TotalValue;
            CreateDate = DateTime.Now;
            CreateBy = Utility.UserManagement.UserSession.UserName;
        }
        public Guid PoId { get; set; }
        public string PoCode { get; set; }
        public string PoName { get; set; }
        public int CompanyId { get; set; }
        public int ApproveStatusId { get; set; }
        public string QuotationCode { get; set; }
        public string TakePlace { get; set; }
        public bool? CreateDebt { get; set; }
        public string Note { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string ApproveBy { get; set; }
        public int Quantity { get; set; }
        public DateTime? DeliveryTime { get; set; }
        private double warrantyPercent;
        public double WarrantyPercent
        {
            get
            {
                return warrantyPercent * 100;
            }
            set
            {
                warrantyPercent = value / 100;
            }
        }
        public decimal TotalValue { get; set; }
        public Company Company { get; set; }
        public virtual Quotation Quotation { get; set; }

    }
    public sealed class PoMapper:ClassMapper<Po>
    {
        public PoMapper()
        {
            Table("PO");
            Map(p => p.TotalValue).Ignore();
            Map(p => p.Quantity).Ignore();
            Map(m => m.Company).Ignore();
            Map(p => p.Quotation).Ignore();
            Map(p => p.DeliveryTime).Ignore();
            //Map(p => p.ApproveStatus).Ignore();
            AutoMap();
        }
    }
}