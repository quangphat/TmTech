using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using Dapper;
namespace TmTech_v1.Repository
{
    public class PlanningDetailRepository : RepositoryBase<Model.PlanningDetail>, IPlanningDetailRepository
    {
        public PlanningDetailRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.PlanningDetail entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
//            string insert = string.Format(@"insert into PlanningDetail(PlanningDetailId,PlanningCode,ProductId,ProductQuantity,CreateDate,CreateBy,ModifyDate,ModifyBy)
//            values (NEWID(),@PlanningCode,@ProductId,@ProductQuantity,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            //Connection.Execute(insert, entity, Transaction);
            base.Insert(entity);
        }

        public List<Model.PlanningDetail> All()
        {
            return Connection.Query<Model.PlanningDetail>("", transaction: Transaction).ToList();
        }

        public Model.PlanningDetail Find(Guid id)
        {
            return Connection.Query<Model.PlanningDetail>("", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(Guid id)
        {
            Connection.Execute("delete from PlanningDetail where PlanningDetailId = @Id", param: new { Id = id }, transaction: Transaction);
        }
        public void RemovebyPlanning(Model.Planning planning)
        {
            Connection.Execute("delete from PlanningDetail where PlanningCode = @code", param: new { code = planning.PlanningCode }, transaction: Transaction);
        }
        public void Remove(Model.PlanningDetail entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.PlanningDetailId);
        }

        public void Update(Model.PlanningDetail entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string update = string.Format(@"");
            //Connection.Execute(update, entity, transaction: Transaction);
            base.Edit(entity);
        }


    }

}
