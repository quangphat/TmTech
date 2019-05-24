using System;
using System.Collections.Generic;
using System.Linq;
using TmTech_v1.Interface;
using Dapper;
using System.Data;

namespace TmTech_v1.Repository
{
    public class PermissionsRepository : RepositoryBase<Model.Permissions>, IPermissionsRepository
    {
        public PermissionsRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Permissions entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"");
            Connection.Execute(insert, entity, Transaction);
        }

        public List<Model.Permissions> All()
        {
            return Connection.Query<Model.Permissions>("", transaction: Transaction).ToList();
        }

        public Model.Permissions Find(int id)
        {
            return Connection.Query<Model.Permissions>("", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Execute("", param: new { Id = id }, transaction: Transaction);
        }

        public void Remove(Model.Permissions entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.PermissionId);
        }

        public void Update(Model.Permissions entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format(@"");
            Connection.Execute(update, entity, transaction: Transaction);
        }

        public List<Model.Permissions> GetPermission(int userGroupId)
        {
            return Connection.Query<Model.Permissions>("getPermission", new { @userGroupId = userGroupId }, transaction: Transaction, commandType: CommandType.StoredProcedure).ToList();
        }
    }


}


