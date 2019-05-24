using System;
using System.Data;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using Dapper;
using System.Collections.Generic;
using System.Linq;
namespace TmTech_v1.Repository
{
    public class DeputyRepository : RepositoryBase<Deputy>, IDeputyRepository
    {
        public DeputyRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Deputy entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            base.Insert(entity);
        }

        public List<Deputy> All()
        {
            string query = string.Format("select * from Deputy d left join Users u on d.UserId = u.UserId");
            return Connection.Query<Deputy, Users, Deputy>(query, (d, u) => { d.User = u; return d; }, splitOn: "UserName", transaction: Transaction).ToList();
        }

        public Deputy Find(int id)
        {
            return Get(p => p.DeputyId, id);
        }
        public Deputy Find(string account)
        {
            return Connection.Query<Deputy>("select * from  Deputy left join Users on Deputy.UserId = Users.UserId and  Users.UserName = @Id", param: new { Id = account }, transaction: Transaction).FirstOrDefault();
        }
        public Deputy FindMainDeputy(int id)
        {
            return Connection.Query<Deputy>("select  * from Deputy  where IsMain = 1 and  CompanyId = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Execute("delete from Deputy  where DeputyId = @Id", param: new { Id = id }, transaction: Transaction);
            //Delete(p => p.DeputyId, id);
        }

        public void Remove(Deputy entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            Delete(entity);

        }

        public void Update(Deputy entity)
        {

            if (entity == null)
                throw new ArgumentNullException("entity");
            Edit(entity);
        }

        public List<Deputy> GetByCompany(Company company)
        {
            return Connection.Query<Deputy, Company, Users, Deputy>(@"Select d.*,c.CompanyName,u.* from Deputy d 
            inner join Company c on d.CompanyId = c.CompanyId 
			inner join Users u on d.UserId = u.UserId 
			where d.CompanyId =@CompanyId"
                , (d, c, u) => { d.Company = c; d.User = u; return d; }, new { @CompanyId = company.CompanyId }
                , splitOn: "CompanyName,UserName", transaction: Transaction).ToList();
        }

        public bool CheckIsMain(int companyId)
        {
            var list = Connection.Query<Deputy>("select  * from     Deputy  where IsMain = 1 and  CompanyId = @Id", param: new { Id = companyId }, transaction: Transaction).ToList();
            return list.Count > 1;
        }
    }
}
