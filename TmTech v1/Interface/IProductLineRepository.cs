using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IProductLineRepository
    {
        void Add(ProductLine entity);
        List<ProductLine> All();
        ProductLine Find(int id);
        void Remove(int id);
        void Remove(ProductLine entity);
        void Update(ProductLine entity);
        List<ProductLine> FindBySerie(int cateId);
    }
}
