using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.Repository
{
    public class PaymentMethodRepository : RepositoryBase<PaymentMethod>, IPaymentMethodRepository
    {
        public PaymentMethodRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.PaymentMethod entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into PaymentMethod(MethodCode,Name,Note) values (@MethodCode,@Name,@Note)");
            Connection.Execute(insert, entity, Transaction);
        }

        public List<Model.PaymentMethod> All()
        {
            return Connection.Query<Model.PaymentMethod>("select * from PaymentMethod", transaction: Transaction).ToList();
        }

        public Model.PaymentMethod Find(int id)
        {
            return Connection.Query<Model.PaymentMethod>("select * from PaymentMethod where PaymentMethodId = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Execute("delete from PaymentMethod where PaymentMethodId = @Id", param: new { Id = id }, transaction: Transaction);
        }

        public void Remove(Model.PaymentMethod entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.PaymentMethodId);
        }

        public void Update(Model.PaymentMethod entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format(@"update  PaymentMethod set MethodCode= @MethodCode,Name= @Name,Note= @Note where PaymentMethodId = @PaymentMethodId");
            Connection.Execute(update, entity, transaction: Transaction);
        }


    }

}
