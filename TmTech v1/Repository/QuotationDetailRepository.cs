using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using TmTech_v1.Interface;

namespace TmTech_v1.Repository
{
    public class QuotationDetailRepository : RepositoryBase<Model.QuotationDetail>, IQuotationDetailRepository
    {
        public QuotationDetailRepository(IDbTransaction transaction)
            : base(transaction)
        {


        }
        public void Add(Model.QuotationDetail entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
//            string insert = string.Format(@"insert into QuotationDetail(QuotationDetailId,QuotationDetailCode,QuotationCode,ProductId,SupplierId,Quantity,Standard,BasePrice,QuotationPrice
//,LampType,ClassSafety,Angle,ClassProduct,Temperature,IPRate,IKRate,Control,ProfileHousing,Housing,Head,Watt,Cri,InputVoltage,Dimension,BranchOfLed,ColorHousing,Color
//,Enec,Pixel,Discount,Note,CreateDate,CreateBy,ModifyDate,ModifyBy) values (NEWID(),@QuotationDetailCode,@QuotationCode,@ProductId,@SupplierId,@Quantity
//,@Standard,@BasePrice,@QuotationPrice,@LampType,@ClassSafety,@Angle,@ClassProduct,@Temperature,@IPRate,@IKRate,@Control,@ProfileHousing,@Housing,@Head,@Watt,@Cri
//,@InputVoltage,@Dimension,@BranchOfLed,@ColorHousing,@Color,@Enec,@Pixel,@Discount,@Note,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
//           return Connection.ExecuteScalar<int>(insert, entity, Transaction);
            base.Insert(entity);
        }

        public List<Model.QuotationDetail> All()
        {
            //return Connection.Query<Model.QuotationDetail>("", transaction: Transaction).ToList();
            return base.GetAll();
        }

        public List<Model.QuotationDetail> AllList(int quotationId)
        {
            //return Connection.Query<Model.QuotationDetail>("select  * from QuotationDetail where QuotationId  =@Id", param: new { Id = Quoation }, transaction: Transaction).ToList();
            //return base.FindbyParentId(p => p.QuotationId ,quotationId);
            return null;
        }

        public Model.QuotationDetail Find(int id)
        {
            //return Connection.Query<Model.QuotationDetail>("select  * from QuotationDetail where QuotationDetailId = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
            return base.Get(p => p.QuotationDetailId, id);
        }
        public Model.QuotationDetail Find(Model.Quotation quotation,Model.Product product)
        {
            return Connection.Query<Model.QuotationDetail>("select  * from QuotationDetail where QuotationCode = @quotationCode and ProductId=@productId", param: new { quotationCode = quotation.QuotationCode,productId=product.ProductId }, transaction: Transaction).FirstOrDefault();
        }
        public List<Model.QuotationDetail> Find(Model.Quotation quotation)
        {
            if (quotation == null) return null;
            return Connection.Query<Model.QuotationDetail, Model.Product, Model.Unit, Model.QuotationDetail>("GetAllProductByQuotation", (qd, p, u) => { qd.Product = p; p.Unit = u ; return qd; }
                , param: new { @quotationCode = quotation.QuotationCode },splitOn:"ProductCode,UnitName", commandType: CommandType.StoredProcedure, transaction: Transaction).ToList();

        }
        public void Remove(int id)
        {
           // Connection.Execute("DELETE FROM QuotationDetail WHERE QuotationDetailId = @Id", param: new { Id = id }, transaction: Transaction);
            base.Delete(p => p.QuotationDetailId, id);
        }

        public void Remove(Model.QuotationDetail entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            base.Delete(entity);
        }
        public void Update(Model.QuotationDetail entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

//            string update = string.Format(@"update  QuotationDetail set QuotationDetailCode= @QuotationDetailCode,QuotationId= @QuotationId
//            ,ProductId= @ProductId,Quantity= @Quantity,StandardId= @StandardId,BasePrice= @BasePrice,QuotationPrice= @QuotationPrice
//            ,Discount= @Discount,Note= @Note,CreateDate= @CreateDate,CreateBy= @CreateBy,ModifyDate= @ModifyDate,ModifyBy= @ModifyBy 
//            where QuotationDetailId =@QuotationDetailId");
            //Connection.Execute(update, entity, transaction: Transaction);
            base.Edit(entity);
        }
        public void CopyQuotation(Model.Quotation fromquotation,Model.Quotation toQuotation)
        {
            if (fromquotation == null) return;
            Connection.Execute("CopyQuotation", new { @FromQuotationCode = fromquotation.QuotationCode, @ToQuotationCode=toQuotation.QuotationCode }, commandType: CommandType.StoredProcedure, transaction: Transaction);
        }

    }

}
