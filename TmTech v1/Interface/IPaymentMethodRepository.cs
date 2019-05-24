using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IPaymentMethodRepository
    {
        void Add(PaymentMethod entity);
        List<PaymentMethod> All();
        PaymentMethod Find(int id);
        void Remove(int id);
        void Remove(PaymentMethod entity);
        void Update(PaymentMethod entity);
    }
}
