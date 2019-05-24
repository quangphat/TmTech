using DapperExtensions.Mapper;

namespace TmTech_v1.Model
{
    public class PaymentRequest : CoreEntry
    {
        public int PaymentRequestId { get; set; }
        public string RequestCode { get; set; }
        public string Email { get; set; }
        public string RequestContent { get; set; }
        public int CompanyId { get; set; }
        public string Title { get; set; }
        public string POCode { get; set; }
    }

   
    public class PaymentRequestMapper : ClassMapper<PaymentRequest>
    {
        public PaymentRequestMapper()
        {
            Table("PaymentRequest");
            AutoMap();
        }
    }

    
}

