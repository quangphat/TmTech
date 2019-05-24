using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using Dapper;
namespace TmTech_v1.Repository
{
    public class DebtDetailRepository : RepositoryBase<Model.DebtDetail>, IDebtDetailRepository
    {
        public DebtDetailRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.DebtDetail entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"");
            //Connection.Execute(insert, entity, Transaction);
            base.Insert(entity);
        }

        public List<Model.DebtDetail> All()
        {
            return Connection.Query<Model.DebtDetail>("", transaction: Transaction).ToList();
        }

        public Model.DebtDetail Find(int id)
        {
            return Connection.Query<Model.DebtDetail>("select * from DebtDetail where DebtDetailId = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Execute("delete from DebtDetail where DebtDetailId = @Id", param: new { Id = id }, transaction: Transaction);
        }

        public void Remove(Model.DebtDetail entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.DebtDetailId);
        }

        public void Update(Model.DebtDetail entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format(@"");
            //Connection.Execute(update, entity, transaction: Transaction);
            base.Edit(entity);
        }


    }

}
