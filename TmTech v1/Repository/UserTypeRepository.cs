using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
namespace TmTech_v1.Repository
{
    public class UserTypeRepository : RepositoryBase<Model.UserType>, IUserTypeRepository
    {
        public UserTypeRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.UserType entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            Insert(entity);
        }

        public List<Model.UserType> All()
        {
            return Connection.Query<Model.UserType>("select * from UserType", transaction: Transaction).ToList();
        }

        public Model.UserType Find(int id)
        {
            return Get(p => p.Id, id);
        }

        public void Remove(int id)
        {
            Delete(p => p.Id,id);
        }

        public void Remove(Model.UserType entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Delete(entity);
        }

        public void Update(Model.UserType entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string update = string.Format(@"update  UserType set Name= @Name where Id = Id");
            //Connection.Execute(update, entity, transaction: Transaction);
            Edit(entity);
        }


    }

}
