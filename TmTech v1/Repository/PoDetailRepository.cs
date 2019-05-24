using System;
using System.Collections.Generic;
using TmTech_v1.Interface;
using Dapper;
using System.Data;
namespace TmTech_v1.Repository
{
    public class PoDetailRepository : RepositoryBase<Model.PoDetail>, IPoDetailRepository
    {
        public PoDetailRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public Guid Add(Model.PoDetail entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into PODetail(PODetailId,PoDetailCode,QuotationId,POId,ProductId,Quantity,POPrice,UnitId,Note,CreateDate,CreateBy,ModifyDate,ModifyBy)
            output inserted.PoDetailId
            values (NewID(),@PoDetailCode,@QuotationId,@POId,@ProductId,@Quantity,@POPrice,@UnitId,@Note,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            return Connection.ExecuteScalar<Guid>(insert, entity, Transaction);
        }

        public List<Model.PoDetail> All()
        {
            //return Connection.Query<Model.PoDetail>("", transaction: Transaction).ToList();
           return base.GetAll();
        }

        public Model.PoDetail Find(Guid id)
        {
            //return Connection.Query<Model.PoDetail>("select * from PODetail where PoDetailId = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
            return base.Get(p => p.PODetailId, id);
        }

        public void Remove(Guid id)
        {
            //Connection.Execute("delete from PODetail where PODetailId = @Id", param: new { Id = id }, transaction: Transaction);
            base.Delete(p => p.PODetailId, id);
        }

        public void Remove(Model.PoDetail entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            base.Delete(entity);
        }

        public void Update(Model.PoDetail entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string update = string.Format(@"update  PODetail set PoDetailCode= @PoDetailCode,POId= @POId,ProductId= @ProductId,QuotationId=@QuotationId,Quantity= @Quantity,POPrice= @POPrice,UnitId= @UnitId,Note= @Note,CreateDate= @CreateDate,CreateBy= @CreateBy,ModifyDate= @ModifyDate,ModifyBy= @ModifyBy where PODetailId= @PODetailId");
            //Connection.Execute(update, entity, transaction: Transaction);
            base.Edit(entity);
        }


        public void CopyPO(Model.Po origin, Model.Po copy)
        {
            if (origin == null || copy == null)
                return;
            Connection.Execute("CopyPO", new { @originCode = origin.PoCode, @copyCode = copy.PoCode }, commandType: CommandType.StoredProcedure, transaction: Transaction);
        }
    }

}
