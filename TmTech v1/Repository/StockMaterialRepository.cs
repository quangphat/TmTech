using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using Dapper;
using TmTech_v1.Model;
namespace TmTech_v1.Repository
{
    public class StockMaterialRepository : RepositoryBase<StockMaterial>, IStockMaterialRepository
    {
        public StockMaterialRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.StockMaterial entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string insert = string.Format(@"");
            //Connection.Execute(insert, entity, Transaction);
            base.Insert(entity);
        }

        public List<Model.StockMaterial> All()
        {
            return Connection.Query<Model.StockMaterial>("select * from StockMaterial", transaction: Transaction).ToList();
        }

        public Model.StockMaterial Find(int id)
        {
            return Connection.Query<Model.StockMaterial>("", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Execute("", param: new { Id = id }, transaction: Transaction);
        }

        public void Remove(Model.StockMaterial entity)
        {
            //if (entity == null)
            //    throw new ArgumentNullException("entity");

            //Remove(entity.Id);
        }

        public void Update(Model.StockMaterial entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string update = string.Format(@"");
            //Connection.Execute(update, entity, transaction: Transaction);
            base.Edit(entity);
        }


        public List<StockMaterial> AllByStock(int StockId)
        {
            return Connection.Query<Model.StockMaterial>("select * from StockMaterial where StockId = @StockId", new {StockId = StockId }, transaction: Transaction).ToList();
        }

        public List<StockMaterial> AllByMaterial(int MaterialId)
        {
            return Connection.Query<Model.StockMaterial>("select * from StockMaterial where MaterialId = @MaterialId", new { MaterialId = MaterialId }, transaction: Transaction).ToList();
        }

        public StockMaterial Find(int StockId, int MaterialId)
        {
            return Connection.Query<Model.StockMaterial>("select * from StockMaterial where MaterialId = @MaterialId and StockId = @StockId", param: new { MaterialId = MaterialId, StockId = StockId }, transaction: Transaction).FirstOrDefault();
        }
    }

}
