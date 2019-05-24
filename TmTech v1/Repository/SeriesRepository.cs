using System;
using System.Collections.Generic;
using System.Data;
using TmTech_v1.Interface;
using Dapper;
namespace TmTech_v1.Repository
{
    public class SeriesRepository : RepositoryBase<Model.Series>, ISeriesRepository
    {
        public SeriesRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Series entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            entity.SetCreate();
            //string insert = string.Format(@"insert into Series(SerieCode,SerieName,SubCategoryId,Note,CreateBy,CreateDate,ModifyBy,ModifyDate) output inserted.SerieId values (@SerieCode,@SerieName,@SubCategoryId,@Note,@CreateBy,@CreateDate,@ModifyBy,@ModifyDate)");
            //return Connection.ExecuteScalar<int>(insert, entity, Transaction);
            base.Insert(entity);
        }

        public List<Model.Series> All()
        {
            //return Connection.Query<Model.Series>("select * from Series", transaction: Transaction).ToList();
            return GetAll();
        }

        public Model.Series Find(int id)
        {
            //return Connection.Query<Model.Series>("select * from Series where SerieId = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
            return Get(p => p.SerieId, id);
        }

        public void Remove(int id)
        {
            Connection.Execute("delete from Series where SerieId =  @Id", param: new { Id = id }, transaction: Transaction);
            //Delete(p => p.SerieId, id);
        }

        public void Remove(Model.Series entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Delete(entity);
        }

        public void Update(Model.Series entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            entity.SetModify();
            //string update = string.Format(@"update  Series set SerieCode= @SerieCode,SerieName= @SerieName,SubCategoryId= @SubCategoryId,Note= @Note,CreateBy= @CreateBy,CreateDate= @CreateDate,ModifyBy= @ModifyBy,ModifyDate= @ModifyDate where SerieId=@SerieId");
            //Connection.Execute(update, entity, transaction: Transaction);
            Edit(entity);
        }




        public List<Model.Series> FindByCategory(int CateId)
        {
            //return Connection.Query<Model.Series>("select * from Series where SubCategoryId = @Id", new {@Id = subId }, transaction: Transaction).ToList();
            return FindbyParentId(p => p.CategoryId ,CateId);
        }
    }

}
