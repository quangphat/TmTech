using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using Dapper;
using TmTech_v1.Model;

namespace TmTech_v1.Repository
{
    public class PoRepository : RepositoryBase<Model.Po>, IPoRepository
    {
        public PoRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Po entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
//            string insert = string.Format(@"insert into PO(POId,PoCode,PoName,CompanyId,ApproveStatusId,QuotationCode,DeliveryDate,PoBegin,TakePlace,Note,ApproveDate,ApproveBy,CreateDate,CreateBy,ModifyDate,ModifyBy) 
//                                             values (NEWID(),@PoCode,@PoName,@CompanyId,@ApproveStatusId,@QuotationCode,@DeliveryDate,@PoBegin,@TakePlace,@Note,@ApproveDate,@ApproveBy,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
//            Connection.Execute(insert, entity, Transaction);
            base.Insert(entity);
        }

        public List<Model.Po> All()
        {
            string all = string.Format(@"select p.*, com.CompanyName from PO p
                                        join Company com on p.CompanyId = com.CompanyId");
            return Connection.Query<Model.Po,Company,Po>(all,(p,com)=> { p.Company = com; return p; },splitOn:"CompanyName", transaction: Transaction).ToList();
            //return base.GetAll();
        }

        public Model.Po Find(Guid id)
        {
           // return Connection.Query<Model.Po>("", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
            return base.Get(p => p.PoId, id);
        }

        public List<Model.Po> Find(Model.Company com)
        {
            return Connection.Query<Model.Po>("select * from PO where CompanyId = @CompanyId", new { @CompanyId = com.CompanyId }, transaction: Transaction).ToList();
        }

        public void Remove(Guid id)
        {
            //Connection.Execute("sp_DeletePO", param: new { @poId = id },commandType:CommandType.StoredProcedure, transaction: Transaction);
            base.Delete(p => p.PoId, id);
        }

        public void Remove(Model.Po entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            base.Delete(entity);
        }
        public void Remove(string poCode)
        {
            Connection.Execute("delete from PO where POCode = @pocode", new { pocode = poCode }, transaction: Transaction);
        }
        public void Update(Model.Po entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format(@"update  PO set PoCode= @PoCode,PoName= @PoName,CompanyId= @CompanyId
,ApproveStatusId= @ApproveStatusId,QuotationCode= @QuotationCode,DeliveryDate= @DeliveryDate,PoBegin= @PoBegin,TakePlace= @TakePlace,Note= @Note
,ApproveDate= @ApproveDate,ApproveBy= @ApproveBy,CreateDate= @CreateDate,CreateBy= @CreateBy,ModifyDate= @ModifyDate,ModifyBy= @ModifyBy where PoCode=@PoCode ");
            //Connection.Execute(update, entity, transaction: Transaction);
            base.Edit(entity);
        }

        public Guid CreateNew()
        {
            return Connection.ExecuteScalar<Guid>("sp_CreateNewPO", commandType: CommandType.StoredProcedure, transaction: Transaction);
        }


        public List<Model.Po> Search(DateTime fromDate, DateTime toDate)
        {
            return Connection.Query<Model.Po, Model.Company, Model.Quotation, Model.Po>("LookForPOByDate", (p, c, q) => { p.Company = c; p.Quotation = q; ; return p; }
                , new { @fromDate = fromDate, @toDate = toDate }, splitOn: "CompanyName,ProjectName", commandType: CommandType.StoredProcedure, transaction: Transaction).ToList();
        }
        public string GetPOCode(int companyId, DateTime dtmDateMake)
        {
            return Connection.Query<string>("select  [dbo].[fn_CreatePOCode](@companyId,@ngaytao)", new { @companyId = companyId, @ngaytao = dtmDateMake.ToString("yyyy-MM-dd") }, transaction: Transaction).FirstOrDefault();
        }
        public List<Model.Po> Search(string searchStr)
        {
            return Connection.Query<Model.Po, Model.Company, Model.Quotation, Model.Po>("LookForPOByName", (p, c, q) => { p.Company = c; p.Quotation = q; return p; }
                , new { @name = searchStr }, splitOn: "CompanyName,ProjectName", commandType: CommandType.StoredProcedure, transaction: Transaction).ToList();
        }
        public List<Model.Product> GetAllProduct(Model.Quotation quotation)
        {
            return Connection.Query<Model.Product>(@"select p.ProductId,ProductCode,Photo,pd.Quantity from Product p
 inner join QuotationDetail pd on p.ProductId = pd.ProductId 
 where pd.QuotationCode = @quotationCode", new { quotationCode = quotation.QuotationCode }, transaction: Transaction).ToList();
        }
    }

}
