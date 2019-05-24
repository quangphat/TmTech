using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IClassSafetyRepository
    {
        void Add(ClassSafety entity);
        List<ClassSafety> All();
        ClassSafety Find(int id);
        void Remove(int id);
        void Remove(ClassSafety entity);
        void Update(ClassSafety entity);
    }
}
