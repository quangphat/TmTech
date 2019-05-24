using System;
using System.Collections.Generic;
using System.Data;
using TmTech_v1.Interface;

namespace TmTech_v1.Repository
{
    public class LampTypeRepository : RepositoryBase<Model.LampTypes>, ILampTypeRepository
    {
        public LampTypeRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.LampTypes entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string insert = string.Format(@"");
            //Connection.Execute(insert, entity, Transaction);
            base.Insert(entity);
        }

        public List<Model.LampTypes> All()
        {
            //return Connection.Query<Model.LampType>("select * from LampType", transaction: Transaction).ToList();
            return base.GetAll();
        }

        public Model.LampTypes Find(int id)
        {
            //return Connection.Query<Model.LampType>("", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
            return base.Get(p => p.LampTypeId, id);
        }

        public void Remove(int id)
        {
            //Connection.Execute("", param: new { Id = id }, transaction: Transaction);
            base.Delete(p => p.LampTypeId, id);
        }

        public void Remove(Model.LampTypes entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            base.Delete(entity);
        }

        public void Update(Model.LampTypes entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string update = string.Format(@"");
            //Connection.Execute(update, entity, transaction: Transaction);
            base.Edit(entity);
        }


    }

}
