using System;
using System.Collections.Generic;
using TmTech_v1.Interface;
using System.Data;
namespace TmTech_v1.Repository
{
    public class ProductStandardRepository : RepositoryBase<Model.ProductStandard>, IProductStandardRepository
    {
        public ProductStandardRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.ProductStandard entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string insert = string.Format(@"");
            //Connection.Execute(insert, entity, Transaction);
            base.Insert(entity);
        }

        public List<Model.ProductStandard> All()
        {
            //return Connection.Query<Model.ProductStandard>("select * from ProductStandard", transaction: Transaction).ToList();
            return base.GetAll();
        }

        public Model.ProductStandard Find(int id)
        {
            //return Connection.Query<Model.ProductStandard>("", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
            return base.Get(p => p.StandardId, id);
        }

        public void Remove(int id)
        {
            //Connection.Execute("", param: new { Id = id }, transaction: Transaction);
            base.Delete(p => p.StandardId, id);
        }

        public void Remove(Model.ProductStandard entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            base.Delete(entity);
        }

        public void Update(Model.ProductStandard entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string update = string.Format(@"");
            //Connection.Execute(update, entity, transaction: Transaction);
            base.Edit(entity);
        }


    }

}
