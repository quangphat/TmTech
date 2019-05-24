using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IDebtRepository
    {
        void Add(Debt entity);
        List<Debt> All();
        Debt Find(int id);
        List<DebtDetail> Find(Debt debt);
        void Remove(int id);
        void Remove(Debt entity);
        void Update(Debt entity);
        List<Debt> Search(string searchStr = "");
    }
}
