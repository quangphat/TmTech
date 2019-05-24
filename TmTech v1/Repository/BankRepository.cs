using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using TmTech_v1.Model;
namespace TmTech_v1.Repository
{
    public class BankBaseRepository : RepositoryBase<Bank>, IBankBaseRepository
    {
        public BankBaseRepository(IDbTransaction transaction) : base(transaction)
        {

        }

        public void Add(Bank entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            Insert(entity);
        }

        public int AddandGetRequestPaymentId(Bank entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into Bank(BankCode,BankName,Address,Fax,Email,Note,CreateDate,CreateBy,ModifyDate,ModifyBy
) output inserted.BankId values(@BankCode,@BankName,@Address,@Fax,@Email,@Note,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy
)
");
            return Connection.ExecuteScalar<int>(insert, entity, Transaction);
        }

        public List<Bank> All()
        {
            return Connection.Query<Model.Bank>("SELECT * FROM Bank", transaction: Transaction).ToList();
            //return Connection.Query<Model.Bank, BrankBank, Model.Bank>("select * from bank b left join BrankBank br on b.BankId = br.BankId", (b, br) => { return b; }, splitOn: "BrankID", transaction: Transaction).ToList();
        }

        public Bank Find(int id)
        {
            return Connection.Query<Bank>("select * from Bank where BankId = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(Bank entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.BankId);
        }

        public void Remove(int id)
        {
            //Delete(p => p.BankId, id);
            Connection.Query("sp_DeleteBank", new { @BankId = id }, transaction: Transaction, commandType: CommandType.StoredProcedure);
        }

        public void Update(Bank entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            Edit(entity);
        }

        public bool hasBranch(Bank bank)
        {
            BrankBank br = Connection.Query<BrankBank>("select * from BrankBank where BankId = @BankId", new { @BankId = bank.BankId }, transaction: Transaction).FirstOrDefault();
            if (br == null)
                return false;
            return true;
        }
    }
    public class BrankBankBaseRepository : RepositoryBase<BrankBank>, IBrankBankBaseRepository
    {
        public BrankBankBaseRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public void Add(BrankBank entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //Create(entity);
            string q = string.Format(@"INSERT INTO BrankBank(BrankName, BrankAddress, Phone, BankId, Note, CreateDate, CreateBy, ModifyDate, ModifyBy) 
                                        VALUES(@Name, @Address, @Phone, @BankId, @Note, @CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            Connection.Query(q, new
            {
                @Name = entity.BrankName,
                @Address = entity.BrankAddress,
                @Phone = entity.Phone,
                @BankId = entity.BankId,
                @Note = entity.Note,
                @CreateDate = entity.CreateDate,
                @CreateBy = entity.CreateBy,
                @ModifyDate = entity.ModifyDate,
                @ModifyBy = entity.ModifyBy
            }, transaction: Transaction);

        }

        public int AddandGetRequestPaymentId(BrankBank entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@" insert into BrankBank (BrankName,BrankAddress,Phone,BankId,Note,CreateDate,CreateBy,ModifyDate,ModifyBy)
 output inserted.BrankID values(@BrankName,@BrankAddress,@Phone,@BankId,@Note,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            return Connection.ExecuteScalar<int>(insert, entity, Transaction);
        }

        public List<BrankBank> All()
        {
            return Connection.Query<BrankBank, Bank, BrankBank>("SELECT br.*, b.BankName, b.BankId FROM BrankBank br RIGHT JOIN Bank b ON br.BankId = b.BankId", (br, b) => { br.Bank = b; return br; }, splitOn: "BankName", transaction: Transaction).ToList();
            //return Connection.Query<BrankBank, Bank, BrankBank>("select * from BrankBank br join Bank b  on br.BankId = b.BankId", (br, b) => { br.Bank = b; return br; }, splitOn: "BankId", transaction: Transaction).ToList();
            //return Connection.Query<BrankBank>("select * from vidu", transaction: Transaction).ToList();
        }

        public BrankBank Find(int id)
        {
            return Connection.Query<BrankBank>("select * from BrankBank where BrankID = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(BrankBank entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            Connection.Query("delete BrankBank where BrankId =@BrankId", new { @BrankId = entity.BrankBankID }, transaction: Transaction);
        }

        public void Remove(int id)
        {
            Connection.Query("DELETE BrankBank WHERE BrankID = @BrankID", param: new { @BrankID = id }, transaction: Transaction);
        }

        public void Update(BrankBank entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //Edit(entity);
            string sql = string.Format(@"update BrankBank set BrankName = @BrankName, BrankAddress=@BrankAddress, Phone=@Phone, ModifyDate=@ModifyDate,ModifyBy=@ModifyBy, Note=@Note where BrankID=@BrankID");
            Connection.Execute(sql, entity, transaction: Transaction);
        }

        public List<BrankBank> GetAllBrankByBankID(string id)
        {
            return Connection.Query<BrankBank, Bank, BrankBank>("select br.*, b.BankName from BrankBank br right join Bank b on br.BankId = b.BankId where b.BankId = @bankID", (br, b) => { br.Bank = b; return br; }, splitOn: "BankName", param: new { @bankID = id }, transaction: Transaction).ToList();
        }

        public List<BrankBank> Search(string searchStr)
        {
            return Connection.Query<BrankBank, Bank, BrankBank>("LookForBranchBank", (br, b) => { br.Bank = b; return br; }, new { @searchStr = searchStr }, splitOn: "BankId", commandType: CommandType.StoredProcedure, transaction: Transaction).ToList();
        }
    }
    public class BankCompanyBaseRepository : RepositoryBase<BankCompany>, IBankCompanyBaseRepository
    {
        public BankCompanyBaseRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public void Add(BankCompany entry)
        {
            throw new NotImplementedException();
        }

        public int AddandGetRequestPaymentId(BankCompany entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into BankCompany (BrankID,CompnayID,AccoutName,AccoutNumber,CreateDate,
CreateBy,ModifyDate,ModifyBy) output inserted.BankCompanyID  values (@BrankID,@CompnayID,@AccoutName,@AccoutNumber,@CreateDate,
@CreateBy,@ModifyDate,@ModifyBy)");
            return Connection.ExecuteScalar<int>(insert, entity, Transaction);
        }

        public List<BankCompany> All()
        {
            return GetAll();
        }

        public BankCompany Find(int id)
        {
            return Connection.Query<BankCompany>("select * from BankCompany where Id = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(BankCompany entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Delete(entity);
        }

        public void Remove(int id)
        {
            Delete(p => p.BankCompanyID, id);
        }

        public void Update(BankCompany entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            Edit(entity);
        }
    }
}
