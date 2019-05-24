using System;
using System.Collections.Generic;
using System.Linq;
using TmTech_v1.Interface;
using Dapper;
using System.Data;
using TmTech_v1.Model;

namespace TmTech_v1.Repository
{
    public class QuotationRepository : RepositoryBase<Model.Quotation>, IQuotationRepository
    {
        public QuotationRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Quotation entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
//            string insert = string.Format(@"insert into Quotation(QuotationId,QuotationCode,QuotationName,CusId,ProjectName,ProjectAddress,Endtime,Note,ApproveDate,ApproveBy,CreateDate,CreateBy,ModifyDate,ModifyBy)
//             values (NEWID(),@QuotationCode,@QuotationName,@CusId,@ProjectName,@ProjectAddress,@Endtime,@Note,@ApproveDate,@ApproveBy,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
//          Connection.Execute(insert, entity, Transaction);
            base.Insert(entity);
        }

        public List<Model.Quotation> All()
        {
            return Connection.Query<Model.Quotation, Model.Company, Model.Quotation>("sp_GetQuotation", (q, c) => { q.Company = c; return q; }, splitOn: "CompanyId", commandType: CommandType.StoredProcedure, transaction: Transaction).ToList();
        }

        public Model.Quotation Find(int id)
        {
           // return Connection.Query<Model.Quotation>("select * from Quotation  where QuotationId  =@Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
            return base.Get(p => p.QuotationId, id);
        }
        public Model.Quotation Find(string code)
        {
            // return Connection.Query<Model.Quotation>("select * from Quotation  where QuotationId  =@Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
            return base.Get(p => p.QuotationCode, code);
        }
        public void Remove(int id)
        {
            //Connection.Execute("", param: new { Id = id }, transaction: Transaction);
            base.Delete(p => p.QuotationId,id);
        }

        public void Remove(Model.Quotation entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            base.Delete(entity);
        }
        public void DeleteNullQuotation(Model.Quotation quotation)
        {
            Connection.Execute("DeleteNullQuotation", new { @quotationCode = quotation.QuotationCode }, commandType: CommandType.StoredProcedure, transaction: Transaction);
        }
        public void Update(Model.Quotation entity)
        {
            if (entity == null)
                    throw new ArgumentNullException("entity");
//            string update = string.Format(@"update  Quotation set QuotationCode= @QuotationCode,QuotationName= @QuotationName,CusId= @CusId,ProjectName= @ProjectName
//,ProjectAddress= @ProjectAddress,Endtime= @Endtime,Note= @Note,ApproveDate= @ApproveDate,ApproveBy= @ApproveBy,CreateDate= @CreateDate,CreateBy= @CreateBy
//,ModifyDate= @ModifyDate,ModifyBy= @ModifyBy where QuotationCode =@QuotationCode");
//            Connection.Execute(update, entity, transaction: Transaction);
            base.Edit(entity);
        }


        public List<Model.Quotation> Search(string searchStr)
        {
            return Connection.Query<Model.Quotation, Model.Company, Model.Quotation>("LookForQuotation", (q, c) => { q.Company = c; return q; }, new { @searchStr = searchStr },splitOn:"CompanyName",commandType:CommandType.StoredProcedure, transaction: Transaction).ToList();
        }
        public List<Model.Quotation> LookByCompany(Model.Company company)
        {
            return Connection.Query<Model.Quotation, Model.Company, Model.Quotation>("LookForQuotationByCompany", (q, c) => { q.Company = c; return q; }, new { @companyId = company.CompanyId }, splitOn: "CompanyName", commandType: CommandType.StoredProcedure, transaction: Transaction).ToList();
        }
        public List<Model.Quotation> LookByDate(DateTime fromDate,DateTime toDate)
        {
            return Connection.Query<Model.Quotation, Model.Company, Model.Quotation>("LookForQuotationByDate", (q, c) => { q.Company = c; return q; }, new { @fromDate = fromDate, @toDate=toDate }, splitOn: "CompanyId", commandType: CommandType.StoredProcedure, transaction: Transaction).ToList();
        }
        public string GetQuotationCode(int companyId, DateTime dtmDateMake)
        {
            return Connection.Query<string>("select  [dbo].[fn_CreateQuotationCode](@companyId,@ngaytao)", new { @companyId = companyId, @ngaytao = dtmDateMake.ToString("yyyy-MM-dd") }, transaction: Transaction).FirstOrDefault();
        }
        public bool CodeExists(Model.Quotation quotation)
        {
            if (quotation == null) return false;
            bool exists = true;
            string code = Connection.ExecuteScalar<string>("select QuotationCode from Quotation where QuotationCode = @code and QuotationId <> @id", new { @code = quotation.QuotationCode, @id = quotation.QuotationId}, transaction: Transaction);
            if (string.IsNullOrWhiteSpace(code))
                exists = false;
            return exists;
        }

        public void Lock(Quotation quotation)
        {
            Connection.Execute("update Quotation set ApproveStatusId = @approveStatusId where QuotationCode = @quotationCode", new { quotationCode = quotation.QuotationCode, approveStatusId = quotation.ApproveStatusId }, transaction: Transaction);
        }
    }


}
