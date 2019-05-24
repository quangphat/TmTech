using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IUnitRepository
    {
        void Add(Unit entity);
        List<Unit> All();
        Unit Find(int id);
        void Remove(int id);
        void Remove(Unit entity);
        void Update(Unit entity);
    }
}
