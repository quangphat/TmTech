using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.Repository
{
    public class CompanyTypeRepository : RepositoryBase<CompanyType>, ICompanyTypeRepository
    {
        public CompanyTypeRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.CompanyType entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into CompanyType(CompanyTypeName,Description) values (@CompanyTypeName,@Description)");
            Connection.Execute(insert, entity, Transaction);
        }

        public List<Model.CompanyType> All()
        {
            return Connection.Query<Model.CompanyType>("select * from CompanyType", transaction: Transaction).ToList();
        }

        public Model.CompanyType Find(int id)
        {
            return Connection.Query<Model.CompanyType>("", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Execute("delete from CompanyType where CompanyTypeId = @Id", param: new { Id = id }, transaction: Transaction);
        }

        public void Remove(Model.CompanyType entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            Remove(entity.CompanyTypeId);
        }

        public void Update(Model.CompanyType entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format(@"update  CompanyType set CompanyTypeName= @CompanyTypeName,Description= @Description where CompanyTypeId = @CompanyTypeId");
            Connection.Execute(update, entity, transaction: Transaction);
        }


    }

}
