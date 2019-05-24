using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using Dapper;
namespace TmTech_v1.Repository
{
    public class ProductPriceRepository : RepositoryBase<Model.ProductPrice>, IProductPriceRepository
    {
        public ProductPriceRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.ProductPrice entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string insert = string.Format(@"insert into ProductPrice(PriceCode,PriceName,ProductId,Price,ActiveDate,Active,UnitId,Note,CreateDate,CreateBy,ModifyDate,ModifyBy) values (@PriceCode,@PriceName,@ProductId,@Price,@ActiveDate,@Active,@UnitId,@Note,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            //Connection.Execute(insert, entity, Transaction);
            base.Insert(entity);
        }

        public List<Model.ProductPrice> All()
        {
            //return Connection.Query<Model.ProductPrice>("select * from ProductPrice", transaction: Transaction).ToList();
            return base.GetAll();
        }

        public Model.ProductPrice Find(int id)
        {
            //return Connection.Query<Model.ProductPrice>("select * from ProductPrice where PriceId = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
            return base.Get(p => p.PriceId, id);
        }

        public void Remove(int id)
        {
            //Connection.Execute("", param: new { Id = id }, transaction: Transaction);
            base.Delete(p => p.PriceId, id);
        }

        public void Remove(Model.ProductPrice entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            base.Delete(entity);
        }

        public int Update(Model.ProductPrice entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format("sp_UpdatePrice");
            return Connection.ExecuteScalar<int>("sp_UpdatePrice", new { @priceId = entity.PriceId, @productId = entity.ProductId, @Price = entity.Price, @username = entity.CreateBy}, commandType:CommandType.StoredProcedure, transaction: Transaction);
        }




        public List<Model.ProductPrice> FindByProduct(string searchStr)
        {
            return Connection.Query<Model.ProductPrice, Model.Product, Model.ProductPrice>("sp_FindPriceByProduct", (pr, p) => { pr.Product = p; return pr; },new {@searchStr = searchStr},splitOn:"ProductCode",commandType:CommandType.StoredProcedure, transaction: Transaction).ToList();
        }
    }

}
