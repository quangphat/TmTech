using System;
using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IDeliveryRepository
    {
        void Add(Delivery entity);
        List<Delivery> All();
        Delivery Find(Guid id);
        void Remove(Guid id);
        void Remove(Delivery entity);
        void Update(Delivery entity);
        string CreateCode(Company company,DateTime createday);
    }
}
