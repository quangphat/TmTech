using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IClassProductRepository
    {
        void Add(ClassProduct entity);
        List<ClassProduct> All();
        ClassProduct Find(int id);
        void Remove(int id);
        void Remove(ClassProduct entity);
        void Update(ClassProduct entity);
    }
}
