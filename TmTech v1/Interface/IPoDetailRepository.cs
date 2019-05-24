using System;
using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IPoDetailRepository
    {
        Guid Add(PoDetail entity);
        List<PoDetail> All();
        PoDetail Find(Guid id);
        void Remove(Guid id);
        void Remove(PoDetail entity);
        void Update(PoDetail entity);
        void CopyPO(Po origin, Po copy);
    }
}
