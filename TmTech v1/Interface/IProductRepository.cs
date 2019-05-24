using System;
using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IProductRepository
    {
        void Add(Product entity);
        List<Product> All();
        List<Product> FindByLine(int subId);
        List<Product> FindBySerie(int serieId);
        List<Product> FindByCategory(int cateId);
        Product Find(Guid id);
        void Remove(Guid id);
        void Remove(Product entity);
        void Update(Product entity);
        Product FindByCode(string code);
        Product FindByBarcode(string barcode);
        List<CustomModel.CustomProduct> FindToCustom(string name);
        List<Model.Product> FindByName(string name);
        List<CustomModel.ProductProperty> getProperty(string propertyName,Product product);
        void InsertProductProperty(CustomModel.ProductProperty value);
    }
}
