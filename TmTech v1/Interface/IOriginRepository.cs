using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IOriginRepository
    {
        void Add(Origin entity);
        List<Origin> All();
        Origin Find(int id);
        void Remove(int id);
        void Remove(Origin entity);
        void Update(Origin entity);
    }
}
