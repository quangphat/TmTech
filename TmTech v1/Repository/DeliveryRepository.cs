using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using Dapper;
using TmTech_v1.Model;

namespace TmTech_v1.Repository
{
    public class DeliveryRepository : RepositoryBase<Model.Delivery>, IDeliveryRepository
    {
        public DeliveryRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Delivery entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into Delivery(DeliveryId,DeliveryCode,CompanyId,POCode,DeliveryDate,CreateDate,CreateBy,ModifyDate,ModifyBy) 
values (NEWID(),@DeliveryCode,@CompanyId,@POCode,@DeliveryDate,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            //base.Create(entity);
            Connection.Execute(insert, entity, Transaction);
        }

        public List<Model.Delivery> All()
        {
            return Connection.Query<Model.Delivery>("", transaction: Transaction).ToList();
        }

        public string CreateCode(Company company, DateTime createday)
        {
            return Connection.ExecuteScalar<string>("select [dbo].fn_CreateDeliveryCode(@companyId,@ngaytao)", new { @companyId = company.CompanyId, @ngaytao = createday }, transaction: Transaction);
        }

        public Model.Delivery Find(Guid id)
        {
            return Connection.Query<Model.Delivery>("", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(Guid id)
        {
            Connection.Execute("", param: new { Id = id }, transaction: Transaction);
        }

        public void Remove(Model.Delivery entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            Remove(entity.DeliveryId);
        }

        public void Update(Model.Delivery entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format(@"");
            Connection.Execute(update, entity, transaction: Transaction);
        }


    }

}
