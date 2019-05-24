using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.Repository
{
    public class SuggestionRepository : RepositoryBase<Suggestion>, ISuggestionRepository
    {
        public SuggestionRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Suggestion entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into Suggestion(MyName,DepartmentId,PurposeSuggestionId,Content,MoneyNum,MoneyNumWrite,ReturnMoneyNum,ReturnMoneyNumWrite) values (@MyName,@DepartmentId,@PurposeSuggestionId,@Content,@MoneyNum,@MoneyNumWrite,@ReturnMoneyNum,@ReturnMoneyNumWrite)");
            Connection.Execute(insert, entity, Transaction);
        }

        public List<Model.Suggestion> All()
        {
            return Connection.Query<Model.Suggestion>("select * from Suggestion", transaction: Transaction).ToList();
        }

        public Model.Suggestion Find(int id)
        {
            return Connection.Query<Model.Suggestion>("select * from Suggestion where SuggstionId = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Execute("delete from Suggestion where SuggstionId = @Id", param: new { Id = id }, transaction: Transaction);
        }

        public void Remove(Model.Suggestion entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.SuggestionId);
        }

        public void Update(Model.Suggestion entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format(@"update  Suggestion set MyName= @MyName,DepartmentId= @DepartmentId,PurposeSuggestionId= @PurposeSuggestionId,Content= @Content,MoneyNum= @MoneyNum,MoneyNumWrite= @MoneyNumWrite,ReturnMoneyNum= @ReturnMoneyNum,ReturnMoneyNumWrite= @ReturnMoneyNumWrite where SuggestionId = @SuggestionId");
            Connection.Execute(update, entity, transaction: Transaction);
        }


    }

}
