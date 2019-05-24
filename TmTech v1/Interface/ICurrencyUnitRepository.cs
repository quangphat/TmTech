using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface ICurrencyUnitRepository
    {
        void Add(CurrencyUnit entity);
        List<CurrencyUnit> All();
        CurrencyUnit Find(int id);
        void Remove(int id);
        void Remove(CurrencyUnit entity);
        void Update(CurrencyUnit entity);
    }
}
