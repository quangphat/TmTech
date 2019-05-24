using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using Dapper;
namespace TmTech_v1.Repository
{
    public class MaterialRepository : RepositoryBase<Model.Material>, IMaterialRepository
    {
        public MaterialRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Material entity)
        {
            base.Insert(entity);
        }

        public List<Model.Material> All()
        {
            return Connection.Query<Model.Material, Model.Supplier, Model.Material>("select m.*,s.SupplierCode,s.SupplierName from Material m left join Supplier s on m.SupplierId = s.SupplierId",
                (m, s) => { m.Supplier = s; return m; }, splitOn: "SupplierCode"
                , transaction: Transaction).ToList();
        }

        public Model.Material Find(int id)
        {
            //return Connection.Query<Model.Material>("", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
            return base.Get(p => p.MaterialId,id);
        }

        public void Remove(int id)
        {
            base.Delete(p => p.MaterialId,id);
        }

        public void Remove(Model.Material entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            base.Delete(entity);
        }

        public void Update(Model.Material entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string update = string.Format(@"");
            //Connection.Execute(update, entity, transaction: Transaction);
            base.Edit(entity);
        }
        public void AddProductMaterial(Model.ProductMaterial productmaterial)
        {
            Connection.Execute("insert into ProductMaterial(ProductId,MaterialId,MaterialQuantity) values (@ProductId,@MaterialId,@MaterialQuantity)", productmaterial, transaction: Transaction);
        }
        public void UpdateProductMaterial(Model.ProductMaterial productmaterial)
        {
            Connection.Execute("update  ProductMaterial set MaterialQuantity= @MaterialQuantity where ProductId= @ProductId and MaterialId= @MaterialId", productmaterial, transaction: Transaction);
        }
        public void AddToProduct(int materialId, Guid productId,int quantity, bool addnew)
        {
            if(addnew==true)
            {
                Connection.Execute("insert into ProductMaterial(ProductId,MaterialId,MaterialQuantity) values (@productId,@materialId,@quantity)", new { materialId = materialId, productId = productId, quantity = quantity }, transaction: Transaction);
            }
            else
            {
                Connection.Execute("update ProductMaterial set MaterialQuantity = @quantity where ProductId = @productId and MaterialId = @materialId", new { quantity = quantity, productId = productId, materialId = materialId }, transaction: Transaction);
            }
        }
        public void RemoveFromProduct(int materialId, Guid productId)
        {
            Connection.Execute("delete from ProductMaterial where  ProductId = @productId and MaterialId = @materialId", new {productId = productId, materialId = materialId }, transaction: Transaction);
        }
        public void RemoveFromProduct(int materialId)
        {
            Connection.Execute("delete from ProductMaterial where  MaterialId = @materialId", new {materialId = materialId }, transaction: Transaction);
        }
        public List<Model.Material> GetMaterialByProductId(Guid productId, int productQuantity = 0)
        {
            return Connection.Query<Model.Material, Model.Supplier, Model.Material>("GetMaterialByProductId", (m, s) => { m.Supplier = s; return m; }, new { @productId = productId, @productQuantity = productQuantity },splitOn:"SupplierName", commandType: CommandType.StoredProcedure, transaction: Transaction).ToList();
        }
        public void CreateImport(Model.ImportMaterialDetail entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into ImportMaterial(ImportBy,ImportDate) values (@ImportBy,@ImportDate)");
            Connection.Execute(insert, entity, Transaction);
        }

        public List<Model.Material> GetAllForComboBox()
        {
            string sql = string.Format(@"select mt.MaterialId,mt.UnitId, mt.MaterialCode, mt.MaterialName, mt.SupplierId, mt.Price, su.SupplierName,u.UnitName
                                        from Material mt join Supplier su on mt.SupplierId = su.SupplierId
                                        inner join Unit u on mt.UnitId = u.UnitId");
            return Connection.Query<Model.Material, Model.Supplier, Model.Unit, Model.Material>(sql, (mt, su, u) => { mt.Supplier = su; mt.UnitMaterial = u; return mt; }, splitOn: "SupplierName,UnitName", transaction: Transaction).ToList();
        }

        public Model.Material Find(string code)
        {
            string sql = string.Format(@"select mt.*, sup.SupplierName from Material mt join Supplier sup on mt.SupplierId = sup.SupplierId where mt.MaterialCode = @code");
            return Connection.Query<Model.Material, Model.Supplier, Model.Material>(sql, (mt, sup) => { mt.Supplier = sup; return mt; },new {@code = code }, splitOn: "SupplierName", transaction: Transaction).FirstOrDefault();
        }
    }

}
