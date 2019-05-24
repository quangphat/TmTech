using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.Repository
{
    public class RequestPaymentBaseRepository : RepositoryBase<PaymentRequest>, IRequestPaymentBaseRepository
    {
        public RequestPaymentBaseRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public int AddandGetRequestPaymentId(PaymentRequest entity)
        {
            entity.CreateDate = DateTime.Now;
            entity.CreateBy = UserManagement.UserSession.UserName;
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into PaymentRequest(RequestCode,Email,RequestContent,CompanyId,
            Title,POCode,CreateDate,CreateBy,ModifyDate,ModifyBy) 
            values (@RequestCode,@Email,@RequestContent,@CompanyId,@Title,@POCode,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)"); 
            return Connection.ExecuteScalar<int>(insert, entity, Transaction);
        }

        public void Add(PaymentRequest entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            base.Insert(entity);
        }

        public List<PaymentRequest> All()
        {
            return Connection.Query<Model.PaymentRequest>("select * from PaymentRequest", transaction: Transaction).ToList();
        }

        public PaymentRequest Find(int id)
        {
            return Connection.Query<PaymentRequest>("select * from PaymentRequest where PaymentRequestId = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(PaymentRequest entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.PaymentRequestId);
        }

        public void Remove(int id)
        {
            Connection.Query("delete from PaymentRequest where PaymentRequestId =@RequestPaymentId", new { @RequestPaymentId = id }, transaction: Transaction);
        }

        public void Update(PaymentRequest entity)
        {
            entity.ModifyDate = DateTime.Now;
            entity.ModifyBy = UserManagement.UserSession.UserName;
            if (entity == null)
                throw new ArgumentNullException("entity");
            base.Edit(entity);
        }
        public string GetRequestPaymentCode(int companyId, DateTime dtmDateMake)
        {
            return Connection.Query<string>("select  [dbo].[fn_CreatePaymentRequestCode](@companyId,@ngaytao)", new { @companyId = companyId, @ngaytao = dtmDateMake}, transaction: Transaction).FirstOrDefault();
        }
    }
}
