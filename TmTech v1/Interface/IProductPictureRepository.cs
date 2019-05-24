using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IProductPictureRepository
    {
        void Add(ProductPicture entity);
        List<ProductPicture> All();
        ProductPicture Find(int id);
        List<Model.ProductPicture> FindByProduct(Model.Product product);
        void Remove(int id);
        void Remove(ProductPicture entity);
        void Update(ProductPicture entity);
    }
}
