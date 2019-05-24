using System;
using System.Collections.Generic;
using System.Data;
using TmTech_v1.Interface;
using Dapper;

namespace TmTech_v1.Repository
{
    public class ProductLineRepository : RepositoryBase<Model.ProductLine>, IProductLineRepository
    {
        public ProductLineRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.ProductLine entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            entity.SetCreate();
            //string insert = string.Format(@"insert into ProductLine(ProductLineCode,ProductLineName,SerieId,CreateDate,CreateBy,ModifyDate,ModifyBy) output inserted.ProductLineId values (@ProductLineCode,@ProductLineName,@SerieId,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            //return Connection.ExecuteScalar<int>(insert, entity, Transaction);
            base.Insert(entity);
        }

        public List<Model.ProductLine> All()
        {
            //return Connection.Query<Model.ProductLine>("select * from SubCategory", transaction: Transaction).ToList();
            return base.GetAll();
        }

        public Model.ProductLine Find(int id)
        {
            //return Connection.Query<Model.ProductLine>("select * from ProductLine where ProductLineId = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
            return base.Get(p => p.ProductLineId,id);
        }

        public void Remove(int id)
        {
            Connection.Execute("delete from ProductLine where ProductLineId = @Id", param: new { Id = id }, transaction: Transaction);
            //base.Delete(p => p.ProductLineId,id);
        }

        public void Remove(Model.ProductLine entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            base.Delete(entity);
        }

        public void Update(Model.ProductLine entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string update = string.Format(@"update  SubCategory set SubCode= @SubCode,SubName= @SubName,CategoryId= @CategoryId,Note= @Note,CreateBy= @CreateBy,CreateDate= @CreateDate,ModifyBy= @ModifyBy,ModifyDate= @ModifyDate where SubId = @SubId");
            //Connection.Execute(update, entity, transaction: Transaction);
            base.Edit(entity);
        }




        public List<Model.ProductLine> FindBySerie(int serieId)
        {
            //return Connection.Query<Model.SubCategory>("select * from SubCategory where CategoryId = @Id", new {Id = cateId }, transaction: Transaction).ToList();
            return base.FindbyParentId(p => p.SerieId, serieId);
        }
    }

}
