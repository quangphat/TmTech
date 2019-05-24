using System;
using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IPaymentRepository
    {
        void Add(Payment entity);
        List<Payment> All();
        List<Payment> All(Guid poid);
        Payment Find(int id);
        void Remove(int id);
        void Remove(Payment entity);
        void Update(Payment entity);
        List<Payment> Search(string txtSearch);
    }
}
