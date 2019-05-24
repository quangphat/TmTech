using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.Repository
{
    public class PaymentRepository : RepositoryBase<Payment>, IPaymentRepository
    {
        public PaymentRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Payment entity)
        {
            string insert = string.Format(@"insert into Payment(PaymentCode,PaymentName,POId,CusId,Paid,StaffId,PaidDate,PaymentMethodId,Note,BankId,CreateDate,CreateBy,ModifyDate,ModifyBy) values (@PaymentCode,@PaymentName,@POId,@CusId,@Paid,@StaffId,@PaidDate,@PaymentMethodId,@Note,@BankId,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            Connection.Execute(insert, entity, Transaction);
        }

        public List<Model.Payment> All()
        {
            return Connection.Query<Payment, Po, Staff, Bank, PaymentMethod, Company, Payment>("sp_GetAllPayment", (pay, p, st, b, pm, com) => { pay.Po = p; pay.Staff = st; pay.Bank = b; pay.PaymentMethod = pm; pay.Company = com; return pay; }, splitOn: "POId,StaffId,BankId,PaymentMethodId,CompanyId", commandType: CommandType.StoredProcedure, transaction: Transaction).ToList();
        }

        public Model.Payment Find(int id)
        {
            string find = string.Format(@"select pay.*, p.PoCode, com.CompanyName, st.StaffName, pm.Name, b.BankName from Payment pay 
                                        join PO p on pay.POId = p.POId
                                        join Company com on pay.CusId = com.CompanyId
                                        join Staff st on pay.StaffId = st.StaffId
                                        join PaymentMethod pm on pay.PaymentMethodId = pm.PaymentMethodId
                                        join Bank b on pay.BankId = b.BankId
                                        where pay.PaymentId = @Id");
            return Connection.Query<Payment, Po, Company, Staff, PaymentMethod, Bank, Payment>(find, (pay, p, com, st, pm, b) => { pay.Po = p; pay.Company = com; pay.Staff = st; pay.PaymentMethod = pm; pay.Bank = b; return pay; }, param: new { Id = id }, splitOn: "PoCode,CompanyName,StaffName,Name,BankName", transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Execute("delete from Payment where PaymentId = @Id", param: new { Id = id }, transaction: Transaction);
        }

        public void Remove(Model.Payment entity)
        {
            Remove(entity.PaymentId);
        }

        public void Update(Model.Payment entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format(@"update  Payment set PaymentCode= @PaymentCode,PaymentName= @PaymentName,POId= @POId,CusId= @CusId,Paid= @Paid,StaffId= @StaffId,PaidDate= @PaidDate,PaymentMethodId= @PaymentMethodId,Note= @Note,BankId= @BankId,CreateDate= @CreateDate,CreateBy= @CreateBy,ModifyDate= @ModifyDate,ModifyBy= @ModifyBy where PaymentId = @PaymentId");
            Connection.Execute(update, entity, transaction: Transaction);
        }

        public List<Payment> All(Guid poid)
        {
            string all = string.Format(@"select pay.*, p.PoCode, com.CompanyName, st.StaffName, pm.Name, b.BankName from Payment pay 
                                        join PO p on pay.POId = p.POId
                                        join Company com on pay.CusId = com.CompanyId
                                        join Staff st on pay.StaffId = st.StaffId
                                        join PaymentMethod pm on pay.PaymentMethodId = pm.PaymentMethodId
                                        join Bank b on pay.BankId = b.BankId
                                        where pay.POId = @Id");
            return Connection.Query<Payment, Po, Company, Staff, PaymentMethod, Bank, Payment>(all, (pay, p, com, st, pm, b) => { pay.Po = p; pay.Company = com; pay.Staff = st; pay.PaymentMethod = pm; pay.Bank = b; return pay; }, 
                param: new { Id = poid }, splitOn: "PoCode,CompanyName,StaffName,Name,BankName", transaction: Transaction).ToList();
        }

        public List<Payment> Search(string txtSearch)
        {
            return Connection.Query<Payment, Company, Po, Staff, PaymentMethod, Bank, Payment>("sp_SearchPayment", (pay, com, p, st, pm, b) => { pay.Company = com; pay.Po = p; pay.Staff = st; pay.PaymentMethod = pm; pay.Bank = b; return pay; },
                new { @txtSearch = txtSearch }, splitOn: "CompanyName,PoCode,StaffName,Name,BankName", commandType: CommandType.StoredProcedure, transaction: Transaction).ToList();
        }
    }

}
