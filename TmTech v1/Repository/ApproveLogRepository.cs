using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using Dapper;
namespace TmTech_v1.Repository
{
    public class ApproveLogRepository : RepositoryBase<Model.ApproveLog>, IApproveLogRepository
    {
        public ApproveLogRepository(IDbTransaction transaction)
            : base(transaction)
        {

        }
        public void Add(Model.ApproveLog entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"");
            //Connection.Execute(insert, entity, Transaction);
            base.Insert(entity);
        }

        public List<Model.ApproveLog> All()
        {
            //return Connection.Query<Model.ApproveLog>("", transaction: Transaction).ToList();
            return base.GetAll();
        }

        public Model.ApproveLog Find(int id)
        {
            return Connection.Query<Model.ApproveLog>("", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }
    }

}
