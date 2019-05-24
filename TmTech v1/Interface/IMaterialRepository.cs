using System;
using System.Collections.Generic;
namespace TmTech_v1.Interface
{
    public interface IMaterialRepository
    {
        void Add(Model.Material entity);
        List<Model.Material> All();
        Model.Material Find(int id);
        void Remove(int id);
        void Remove(Model.Material entity);
        void Update(Model.Material entity);
        void AddToProduct(int materialId, Guid productId, int quantity, bool addnew);
        void RemoveFromProduct(int materialId, Guid productId);
        void RemoveFromProduct(int materialId);
        List<Model.Material> GetMaterialByProductId(Guid productId,int productQuantity = 0 );
        void CreateImport(Model.ImportMaterialDetail entity);
        List<Model.Material> GetAllForComboBox();
        void AddProductMaterial(Model.ProductMaterial productmaterial);
        void UpdateProductMaterial(Model.ProductMaterial productmaterial);
        Model.Material Find(string code);
    }
}
