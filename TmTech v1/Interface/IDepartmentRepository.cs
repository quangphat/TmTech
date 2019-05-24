using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IDepartmentRepository
    {
        void Add(Department entity);
        List<Department> All();
        Department Find(int id);
        void Remove(int id);
        void Remove(Department entity);
        void Update(Department entity);
    }
}
