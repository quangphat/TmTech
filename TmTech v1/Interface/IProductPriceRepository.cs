using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IProductPriceRepository
    {
        void Add(ProductPrice entity);
        List<ProductPrice> All();
        ProductPrice Find(int id);
        void Remove(int id);
        void Remove(ProductPrice entity);
        int Update(ProductPrice entity);

        List<ProductPrice> FindByProduct(string searchStr);
    }
}
