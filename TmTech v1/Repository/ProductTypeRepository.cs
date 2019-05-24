using System;
using System.Collections.Generic;
using System.Linq;
using TmTech_v1.Interface;
using Dapper;
using System.Data;
using TmTech_v1.Model;namespace TmTech_v1.Repository
{
    public class ProductTypeRepository : RepositoryBase<ProductType>, IProductTypeRepository
    {
        public ProductTypeRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(ProductType entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //<SqlCreate>
            base.Insert(entity);
        }

        public List<ProductType> All()
        {
            //<SqlGetAll>
            return base.GetAll();
        }

        public ProductType Find(Guid id)
        {
            //<SqlFindById>
            return base.Get(p => p.ProductTyeID, id);
        }

        public void Remove(Guid id)
        {
           //<SqlRemoveById>
            base.Delete(p => p.ProductTyeID, id);
        }

        public void Remove(ProductType entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //<SqlRemove>
            base.Delete(entity);
        }

        public void Update(ProductType entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //<SqlUpdate>
            base.Edit(entity);
        }


    }

}

