using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public partial class DebtDetail:CoreEntry
    {
        public int DebtDetailId { get; set; }
        public int DebtId { get; set; }
        public string RequestPaymentCode { get; set; }
        public string Note { get; set; }
        public decimal Payment { get; set; }
        public DateTime? PaymentDate { get; set; }
    }


    public class DebtDetailMapper : ClassMapper<DebtDetail>
    {
        public DebtDetailMapper()
        {
            Table("DebtDetail");
            AutoMap();
        }
    }
}
