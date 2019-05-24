using System.Collections.Generic;
using System.Data;
using TmTech_v1.Interface;
using Dapper;
using System;
using System.Linq;

namespace TmTech_v1.Repository
{
    public class CurrencyUnitRepository : RepositoryBase<Model.CurrencyUnit>, ICurrencyUnitRepository
    {
        public CurrencyUnitRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.CurrencyUnit entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"INSERT INTO CurrencyUnit(CurrencyName,CurrencyCode,Note) VALUES(@CurrencyName,@CurrencyCode,@Note)");
            Connection.Query(insert, new { CurrencyName = entity.CurrencyName, CurrencyCode = entity.CurrencyCode, Note = entity.Note }, transaction:Transaction);
            //Create(entity);
        }

        public List<Model.CurrencyUnit> All()
        {
            return Connection.Query<Model.CurrencyUnit>("select * from CurrencyUnit", transaction: Transaction).ToList();
        }

        public Model.CurrencyUnit Find(int id)
        {
            return Connection.Query<Model.CurrencyUnit>("", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Query("delete CurrencyUnit where CurrencyId= @CurrencyId", param: new { @CurrencyId = id }, transaction: Transaction);
        }

        public void Remove(Model.CurrencyUnit entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.CurrencyId);
        }

        public void Update(Model.CurrencyUnit entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string update = string.Format(@"");
            //Connection.Execute(update, entity, transaction: Transaction);
        }


    }

}
