using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public class Payment:CoreEntry
    {
        public Payment()
        {
            Po = new Po();
            Company = new Company();
            Staff = new Staff();
            PaymentMethod = new PaymentMethod();
            Bank = new Bank();
        }
        public int PaymentId { get; set; }
        public string PaymentCode { get; set; }
        public string PaymentName { get; set; }
        public Guid? POId { get; set; }
        public int? CusId { get; set; }
        public double? Paid { get; set; }
        public int? StaffId { get; set; }
        public DateTime? PaidDate { get; set; }
        public int? PaymentMethodId { get; set; }
        public string Note { get; set; }
        public int? BankId { get; set; }

        public virtual Po Po { get; set; }
        public virtual Company Company { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual Bank Bank { get; set; }
    }

    public class PaymentMapper: ClassMapper<Payment>
    {
        public PaymentMapper()
        {
            Table("Payment");
            Map(p => p.Po).Ignore();
            Map(p => p.Company).Ignore();
            Map(p => p.Staff).Ignore();
            Map(p => p.PaymentMethod).Ignore();
            Map(p => p.Bank).Ignore();
            AutoMap();
        }
    }
}
