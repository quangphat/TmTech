using System;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IRequestPaymentBaseRepository : IBaseRepository<PaymentRequest>
    {
        string GetRequestPaymentCode(int companyId, DateTime dtmDateMake);
    }

} 