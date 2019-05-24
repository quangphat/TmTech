using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using TmTech_v1.Interface;
using System.Data;
namespace TmTech_v1.Repository
{
    public class OriginRepository : RepositoryBase<Model.Origin>, IOriginRepository
    {
        public OriginRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Origin entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string insert = string.Format(@"");
            //Connection.Execute(insert, entity, Transaction);
            base.Insert(entity);
        }

        public List<Model.Origin> All()
        {
            //return Connection.Query<Model.Origin>("", transaction: Transaction).ToList();
            return base.GetAll();
        }

        public Model.Origin Find(int id)
        {
            return Connection.Query<Model.Origin>("", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Execute("", param: new { Id = id }, transaction: Transaction);
        }

        public void Remove(Model.Origin entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.OriginId);
        }

        public void Update(Model.Origin entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format(@"");
            Connection.Execute(update, entity, transaction: Transaction);
        }


    }

}
