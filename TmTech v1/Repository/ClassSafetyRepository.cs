using System;
using System.Collections.Generic;
using System.Data;
using TmTech_v1.Interface;

namespace TmTech_v1.Repository
{
    public class ClassSafetyRepository : RepositoryBase<Model.ClassSafety>, IClassSafetyRepository
    {
        public ClassSafetyRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.ClassSafety entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string insert = string.Format(@"");
            //Connection.Execute(insert, entity, Transaction);
            base.Insert(entity);
        }

        public List<Model.ClassSafety> All()
        {
            //return Connection.Query<Model.ClassSafety>("select * from ClassSafety", transaction: Transaction).ToList();
            return base.GetAll();
        }

        public Model.ClassSafety Find(int id)
        {
            //return Connection.Query<Model.ClassSafety>("", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
            return base.Get(p => p.ClassSafetyId, id);
        }

        public void Remove(int id)
        {
            //Connection.Execute("", param: new { Id = id }, transaction: Transaction);
            base.Delete(p => p.ClassSafetyId, id);
        }

        public void Remove(Model.ClassSafety entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            base.Delete(entity);
        }

        public void Update(Model.ClassSafety entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format(@"");
            //Connection.Execute(update, entity, transaction: Transaction);
            base.Edit(entity);
        }


    }

}
