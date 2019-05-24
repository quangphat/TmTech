using System;
using System.Collections.Generic;
using System.Data;
using TmTech_v1.Interface;

namespace TmTech_v1.Repository
{
    public class ClassProductRepository : RepositoryBase<Model.ClassProduct>, IClassProductRepository
    {
        public ClassProductRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.ClassProduct entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string insert = string.Format(@"");
            //Connection.Execute(insert, entity, Transaction);
            base.Insert(entity);
        }

        public List<Model.ClassProduct> All()
        {
            //return Connection.Query<Model.ClassProduct>("select * from ClassProduct", transaction: Transaction).ToList();
             return base.GetAll();
        }

        public Model.ClassProduct Find(int id)
        {
            //return Connection.Query<Model.ClassProduct>("", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
            return base.Get(p => p.ClassProductId, id);
        }

        public void Remove(int id)
        {
            //Connection.Execute("", param: new { Id = id }, transaction: Transaction);
            base.Delete(p => p.ClassProductId, id);
        }

        public void Remove(Model.ClassProduct entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            base.Delete(entity);
        }

        public void Update(Model.ClassProduct entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string update = string.Format(@"");
            //Connection.Execute(update, entity, transaction: Transaction);
            base.Edit(entity);
        }


    }

}
