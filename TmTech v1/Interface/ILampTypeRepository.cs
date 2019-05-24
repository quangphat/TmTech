using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface ILampTypeRepository
    {
        void Add(LampTypes entity);
        List<LampTypes> All();
        LampTypes Find(int id);
        void Remove(int id);
        void Remove(LampTypes entity);
        void Update(LampTypes entity);
    }
}
