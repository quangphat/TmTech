using System;
using System.Collections.Generic;
using TmTech_v1.Interface;
using System.Data;
namespace TmTech_v1.Repository
{
    public class UserGroupRepository : RepositoryBase<Model.UserGroup>, IUserGroupRepository
    {
        public UserGroupRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.UserGroup entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string insert = string.Format(@"insert into UserGroup(GroupName,Note,CreateDate,CreateBy,ModifyDate,ModifyBy) values (@GroupName,@Note,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            //Connection.Execute(insert, entity, Transaction);
            Insert(entity);
        }

        public List<Model.UserGroup> All()
        {
            //return Connection.Query<Model.UserGroup>("select * from UserGroup", transaction: Transaction).ToList();
            return GetAll();
        }

        public Model.UserGroup Find(int id)
        {
           // return Connection.Query<Model.UserGroup>("select * from UserGroup where Id =@Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
            return Get(p => p.UserGroupId, id);
        }

        public void Remove(int id)
        {
           // Connection.Execute("delete from UserGroup where Id =@Id", param: new { Id = id }, transaction: Transaction);
            Delete(p => p.UserGroupId, id);
        }

        public void Remove(Model.UserGroup entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Delete(entity);
        }

        public void Update(Model.UserGroup entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string update = string.Format(@"update  UserGroup set GroupName= @GroupName,Note= @Note,CreateDate= @CreateDate,CreateBy= @CreateBy,ModifyDate= @ModifyDate,ModifyBy= @ModifyBy where Id =@Id");
            //Connection.Execute(update, entity, transaction: Transaction);
            Edit(entity);
        }


    }

}
