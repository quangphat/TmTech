using System;
using System.Collections.Generic;
using System.Linq;
using TmTech_v1.Interface;
using Dapper;
using System.Data;

namespace TmTech_v1.Repository
{
    public class UsersRepository : RepositoryBase<Model.Users>, IUsersRepository
    {
        public UsersRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Users entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into Users(UserName,Password,FullName,Phone,Email,UserGroupId,CreateDate,CreateBy,ModifyDate,ModifyBy) output inserted.UserId values (@UserName,@Password,@FullName,@Phone,@Email,@UserGroupId,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            //return Connection.ExecuteScalar<int>(insert, entity, Transaction);
            base.Insert(entity);
        }

        public int AddAndGetID(Model.Users entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into Users(UserName,Password,FullName,Phone,Email,UserGroupId,CreateDate,CreateBy,ModifyDate,ModifyBy) output inserted.UserId values (@UserName,@Password,@FullName,@Phone,@Email,@UserGroupId,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            //return Connection.ExecuteScalar<int>(insert, entity, Transaction);
            return Connection.ExecuteScalar<int>(insert, entity, Transaction);
        }

        public List<Model.Users> All()
        {
            //return Connection.Query<Model.Users, Model.UserType, Model.UserGroup, Model.Users>("select u.*,t.UserTypeName,g.UserGroupName from Users u left join UserType t on u.UserTypeId = t.UserTypeId inner join UserGroup g on u.UserGroupId = g.UserGroupId", (u, t, g) => { u.UserType = t; u.UserGroup = g; return u; },splitOn:"UserTypeName,UserGroupName", transaction: Transaction).ToList();
            //return base.All();
            return Connection.Query<Model.Users>("select * from Users", transaction: Transaction).ToList();

        }

        public Model.Users Find(int id)
        {
            //return Connection.Query<Model.Users>("select * from Users where UserId = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
            return Get(p => p.UserId, id);
            ///
        }

        public Model.Users FindUserName(string userName)
        {
            return Connection.Query<Model.Users>("select * from Users where UserName = @userName", param: new { userName = userName }, transaction: Transaction).FirstOrDefault();
            ///
        }
        public int Find(string username)
        {
            return Connection.Query<int>("SELECT UserId FROM Users WHERE Username = @Username1", param: new { Username1 = username }, transaction: Transaction).FirstOrDefault();
        }

        public Model.Users IsExist(string userName)
        {
            return Connection.Query<Model.Users>("select * from Users where UserName  = @UserName1", param: new { UserName1 = userName }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Execute("delete from Users where UserId = @Id", param: new { Id = id }, transaction: Transaction);
            //Delete(p => p.UserId, id);
        }

        public void Remove(Model.Users entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.UserId);
            //Delete(entity);
        }

        public void Update(Model.Users entity)
        {
            //if (entity == null)
            //    throw new ArgumentNullException("entity");
            //string update = string.Format(@"update  Users set UserName= @UserName,Password= @Password,FullName= @FullName,Phone= @Phone,Email= @Email,UserTypeId= @UserTypeId,UserGroupId= @UserGroupId,CreateDate= @CreateDate,CreateBy= @CreateBy,ModifyDate= @ModifyDate,ModifyBy= @ModifyBy where UserId =@UserId");
            //Connection.Execute(update, entity, transaction: Transaction);
            Edit(entity);
        }




        public List<Model.Users> FindByGroup(int userGroupId)
        {
            return Connection.Query<Model.Users>("select * from Users where UserGroupId = @userGroupId", new { userGroupId = userGroupId }, transaction: Transaction).ToList();
        }


        public Model.Users Login(string username, string password)
        {
            return Connection.Query<Model.Users, Model.UserGroup,  Model.Users>("spLogin", (u, g) => { u.UserGroup = g; return u; },
                new { @userName = username, @password = password }, splitOn: "UserGroupId", commandType: CommandType.StoredProcedure, transaction: Transaction).FirstOrDefault();
        }
    }

}
