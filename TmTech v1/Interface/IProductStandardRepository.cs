using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IProductStandardRepository
    {
        void Add(ProductStandard entity);
        List<ProductStandard> All();
        ProductStandard Find(int id);
        void Remove(int id);
        void Remove(ProductStandard entity);
        void Update(ProductStandard entity);
    }
}
