using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.Repository
{
    public class RequestSentRepository : RepositoryBase<RequestSent>, IRequestSentRepository
    {
        public RequestSentRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.RequestSent entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into RequestSent(TableName,RequestBy,RequestTo,Detail,IdValue) values (@TableName,@RequestBy,@RequestTo,@Detail,@IdValue)");
            Connection.Query(insert, entity, Transaction);
        }

        public List<Model.RequestSent> All()
        {
            return Connection.Query<Model.RequestSent>("select * from RequestSent", transaction: Transaction).ToList();
        }

        public Model.RequestSent Find(int id)
        {
            return Connection.Query<Model.RequestSent>("select * from RequestSent where RequestSentId = @RequestSentId", param: new { @RequestSentId = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Execute("delete from RequestSent where RequestSentId = @RequestSentId", param: new { Id = id }, transaction: Transaction);
        }

        public void Remove(Model.RequestSent entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.RequestSentId);
        }

        public void Update(Model.RequestSent entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format(@"update  RequestSent set TableName= @TableName,RequestBy= @RequestBy,RequestTo= @RequestTo,Detail= @Detail,IdValue= @IdValue where RequestSentId = @RequestSentId");
            Connection.Execute(update, entity, transaction: Transaction);
        }


    }

}
