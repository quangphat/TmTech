using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.Repository
{
    public class GroupSupplierRepository : RepositoryBase<GroupSupplier>, IGroupSupplierRepository
    {
        private IDbTransaction _transaction;
        public GroupSupplierRepository(IDbTransaction transaction) : base(transaction)
        {
            this._transaction = transaction;
        }

        public List<GroupSupplier> ChildOfGroup(int parrentGroupId)
        {
            List<GroupSupplier> lisrResulf;
            lisrResulf = Connection.Query<GroupSupplier>("select * from GroupSupplier  where ParentGroup = " + parrentGroupId , transaction: Transaction).ToList();
            return lisrResulf;


        }
        public List<GroupSupplier> ParrentOfGroup()
        {
            List<GroupSupplier> lisrResulf;
            lisrResulf = Connection.Query<GroupSupplier>("select DISTINCT(ParentGroup) from GroupSupplier", transaction: Transaction).ToList();
            return lisrResulf;
        }

        public List<GroupSupplier> ParrentOfGroupRoot()
        {
            List<GroupSupplier> lisrResulf;
            lisrResulf = Connection.Query<GroupSupplier>("select * from GroupSupplier where ParentGroup =0", transaction: Transaction).ToList();
            return lisrResulf;
        }
        public List<string> ParrentOfGroupLoad()
        {
            List<string> lisrResulf;   
            lisrResulf = Connection.Query<string>("select DISTINCT(ParentGroup) from GroupSupplier", transaction: Transaction).ToList();
            return lisrResulf;
        }

       
    }
}
