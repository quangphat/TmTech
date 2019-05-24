using System;
using System.Data;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using TmTech_v1.Utility;
namespace TmTech_v1.Repository
{
    public partial class CategoryRepository:RepositoryBase<Category>,ICategoryRepository
    {
        public CategoryRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Category entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string insert = string.Format(@"insert into Category(CategoryCode,CategoryName,Note,CreateDate,CreateBy,ModifyDate,ModifyBy) output inserted.CategoryId values (@CategoryCode,@CategoryName,@Note,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            //return Connection.ExecuteScalar<int>(insert,entity,Transaction);
            base.Insert(entity);
        }

        public List<Model.Category> All()
        {
            //string username = FormUtility.getAllByUser(rsxTableName.Category);
            //List<Category> lstCate = Connection.Query<Model.Category>("select * from Category", new { @username = username }, transaction: Transaction).ToList();
            ////foreach(Category cate in lstCate)
            ////{
            ////    cate.Parent = Connection.Query<Model.Category>("select CategoryId, CategoryName from Category where CategoryId = @ParentId", new { @ParentId = cate.ParentId }, transaction: Transaction).FirstOrDefault();
            ////}
            //return lstCate;
            return base.GetAll();
        }

        public Model.Category Find(int id)
        {
            //return Connection.Query<Model.Category>("Select * from Category where CategoryId = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
            return base.Get(p => p.CategoryId, id);
        }

        public void Remove(int id)
        {
            Connection.Execute("DELETE FROM Category WHERE CategoryId = @Id", param: new { Id = id }, transaction: Transaction);
            //base.Delete(p => p.CategoryId== id);
        }

        public void Remove(Model.Category entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            base.Delete(entity);
        }

        public void Update(Model.Category entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string update = string.Format(@"update  Category set CategoryCode= @CategoryCode,CategoryName= @CategoryName,Note= @Note,CreateDate= @CreateDate,CreateBy= @CreateBy,ModifyDate= @ModifyDate,ModifyBy= @ModifyBy where CategoryId = @CategoryId");
            //Connection.Execute(update, entity, transaction: Transaction);
            base.Edit(entity);
        }




        //public List<Category> AllRootCategory()
        //{
        //    return Connection.Query<Model.Category>("select * from Category where ParentId is null or ParentId ='' or ParentId =0", transaction: Transaction).ToList();
        //}

        public List<Category> FindByParentId(int rootId)
        {
            return Connection.Query<Model.Category>("select * from Category where ParentId = @Id", new { Id = rootId }, transaction: Transaction).ToList();
        }


        public List<Category> Own()
        {
            string username = UserManagement.UserSession.UserName;
            return Connection.Query<Model.Category>("Select * from Category where CreateBy = @Username", new{@Username = username }, transaction: Transaction).ToList();
        }


        public bool FindExist(Category entity)
        {
            List<Category> lstCategory;
            lstCategory = Connection.Query<Model.Category>("select * from Category where CategoryCode = @CategoryCode and CategoryId<>@Id", new { CategoryCode = entity.CategoryCode, Id = entity.CategoryId }, transaction: Transaction).ToList();
            if (lstCategory == null || lstCategory.Count > 0)
                return true;
            return false;
        }


        public List<Category> AllRootCategory()
        {
            throw new NotImplementedException();
        }
    }
  
  
}
