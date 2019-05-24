using System;
using System.Collections.Generic;
using System.Linq;
using TmTech_v1.Interface;
using Dapper;
using System.Data;
namespace TmTech_v1.Repository
{
    public class UnitRepository : RepositoryBase<Model.Unit>, IUnitRepository
    {
        public UnitRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Unit entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string insert = string.Format(@"");
            //Connection.Execute(insert, entity, Transaction);
            Insert(entity);
        }

        public List<Model.Unit> All()
        {
            //return Connection.Query<Model.Unit>("", transaction: Transaction).ToList();
            return GetAll();
        }

        public Model.Unit Find(int id)
        {
            return Connection.Query<Model.Unit>("select * from Unit where UnitId = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Execute("delete Unit where UnitId = @Id", param: new { Id = id }, transaction: Transaction);
            //Delete(p => p.UnitId, id);
        }

        public void Remove(Model.Unit entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.UnitId);
        }

        public void Update(Model.Unit entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string update = string.Format(@"update ");
            //Connection.Execute(update, entity, transaction: Transaction);
            Edit(entity);
        }


    }

}
