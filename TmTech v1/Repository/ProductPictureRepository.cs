using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using Dapper;
namespace TmTech_v1.Repository
{
    public class ProductPictureRepository : RepositoryBase<Model.ProductPicture>, IProductPictureRepository
    {
        public ProductPictureRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.ProductPicture entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into productpicturetemp(ProductId,Picture) values (@productId,@picture)");
            Connection.Execute(insert, entity, Transaction);
            Connection.Execute("AddProductPicture", commandType: CommandType.StoredProcedure, transaction: Transaction);
            //base.Create(entity);
        }

        public List<Model.ProductPicture> All()
        {
            return Connection.Query<Model.ProductPicture>("", transaction: Transaction).ToList();
        }

        public Model.ProductPicture Find(int id)
        {
            return Connection.Query<Model.ProductPicture>("", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }
        public List<Model.ProductPicture> FindByProduct(Model.Product product)
        {
            return Connection.Query<Model.ProductPicture>("select * from ProductPicture where ProductId = @productId and Picture <> ''", new { productId = product.ProductId }, transaction: Transaction).ToList();
        }
        public void Remove(int id)
        {
            Connection.Execute("", param: new { Id = id }, transaction: Transaction);
        }

        public void Remove(Model.ProductPicture entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.ProductPictureId);
        }

        public void Update(Model.ProductPicture entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format(@"");
            Connection.Execute(update, entity, transaction: Transaction);
        }


    }

}
