using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IDebtDetailRepository
    {
        void Add(DebtDetail entity);
        List<DebtDetail> All();
        DebtDetail Find(int id);
        void Remove(int id);
        void Remove(DebtDetail entity);
        void Update(DebtDetail entity);
    }
}
