using System;
using System.Data;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace TmTech_v1.Repository
{
    public class ProductRepository : RepositoryBase<Model.Product>, IProductRepository
    {
        public ProductRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Product entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
//            string insert = string.Format(@"insert into Product(ProductId,Barcode,ProductCode,ProductName,CategoryId,SubCategoryId,SeriesId,DataSheet
//            ,InstallGuide,PhotoMeter,Photo,Note,Card3d,CreateDate,CreateBy,ModifyDate,ModifyBy,UnitId,OriginId) output inserted.ProductId values (@ProductId,@Barcode,@ProductCode
//            ,@ProductName,@CategoryId,@SubCategoryId,@SeriesId,@DataSheet,@InstallGuide,@PhotoMeter,@Photo,@Note,@Card3d,@CreateDate,@CreateBy,@ModifyDate
//            ,@ModifyBy,@UnitId,@OriginId)");
//           return Connection.ExecuteScalar<Guid>(insert, entity, Transaction);
            base.Insert(entity);
        }

        public List<Model.Product> All()
        {
            //string select = string.Empty;
            //if (UserManagement.AllowViewAll(rsxTableName.Product) == true)
            //    select = "select * from Product";
            //if (UserManagement.AllowViewAll(rsxTableName.Product) == false && UserManagement.AllowViewOwn(rsxTableName.Product) == true)
            //    select = "select * from Product where createby =" + UserManagement.UserSession.UserName;
            //return Connection.Query<Model.Product>(select,transaction:Transaction).ToList();
            return base.GetAll();
        }

        public Model.Product Find(Guid id)
        {
            return Connection.Query<Product, Category, Series, ProductLine, Unit, Product>(@"LookForProductById", (p, c, s, l, u) => { p.Category = c; p.Series = s; p.Productline = l; p.Unit = u; ; return p; }
                , new { @productId = id }, splitOn: "CategoryName,SerieName,ProductLineName,UnitName",commandType:CommandType.StoredProcedure, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(Guid id)
        {
            //Connection.Execute("DELETE FROM Product WHERE ProductId = @Id", param: new { Id = id }, transaction: Transaction);
            base.Delete(p => p.ProductId, id);
        }

        public void Remove(Model.Product entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            base.Delete(entity);
        }

        public void Update(Model.Product entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
//            string update = string.Format(@"update  Product set Barcode= @Barcode,ProductCode= @ProductCode,ProductName= @ProductName,
//                            CategoryId= @CategoryId,SubCategoryId= @SubCategoryId,SeriesId= @SeriesId,Watt= @Watt,InputVoltage= @InputVoltage,Temperature= @Temperature,
//                            CRI= @CRI,Angle= @Angle,Head= @Head,DataSheet= @DataSheet,InstallGuide= @InstallGuide,Dimension= @Dimension,StandardId= @StandardId,
//                            IPRate= @IPRate,IKRate= @IKRate,Pixel= @Pixel,Control= @Control,PhotoMeter= @PhotoMeter,Photo= @Photo,Note= @Note,Housing= @Housing,
//                            Profilehousing= @Profilehousing,ColorHousing= @ColorHousing,LampTypeId= @LampTypeId,Card3d= @Card3d,CreateDate= @CreateDate,CreateBy= @CreateBy,
//                            ModifyDate= @ModifyDate,ModifyBy= @ModifyBy where ProductId = @ProductId");
//            Connection.Execute(update, entity, transaction: Transaction);
            base.Edit(entity);
        }



        public List<Product> FindByLine(int lineId)
        {
            return Connection.Query<Product, Category, Series, ProductLine, Product>(@"Select p.*,c.CategoryName,s.SerieName,l.ProductLineName from Product p inner join Series s on p.SeriesId = s.SerieId
                    left join ProductLine l on p.ProductLineId = l.ProductLineId inner join Category c on s.CategoryId= c.CategoryId where p.ProductLineId = @lineId", (p, c, s, l) => { p.Category = c; p.Series = s; p.Productline = l; return p; }
                , param: new { @lineId = lineId }, splitOn: "CategoryName,SerieName,ProductLineName", transaction: Transaction).ToList();
        }
        public List<Product> FindBySerie(int serieId)
        {
            return Connection.Query<Product, Category, Series, ProductLine, Product>(@"Select p.*,c.CategoryName,s.SerieName,l.ProductLineName from Product p inner join Series s on p.SeriesId = s.SerieId
                    left join ProductLine l on p.ProductLineId = l.ProductLineId inner join Category c on s.CategoryId= c.CategoryId where p.SeriesId = @serieId", (p, c, s, l) => { p.Category = c; p.Series = s; p.Productline = l; return p; }
                , param: new { @serieId = serieId }, splitOn: "CategoryName,SerieName,ProductLineName", transaction: Transaction).ToList();
        }

        public Product FindByCode(string code)
        {
            //return Connection.Query<Model.Product, Category, SubCategory, Series, Model.Product>("LookForProductByCode",
            //    (p, c, sub, sr) => { p.Category = c; p.Productline = sub; p.Series = sr; return p; },
            //    param: new { @code = code }, splitOn: "CategoryName,SubName,SerieName",
            //    commandType: CommandType.StoredProcedure, transaction: Transaction).FirstOrDefault();
            return null;
        }

        public Product FindByBarcode(string barcode)
        {
            //return Connection.Query<Model.Product, Category, SubCategory, Series, Model.Product>("LookForProductByBarcode", 
            //    (p, c, sub, sr) => { p.Category = c; p.Productline = sub; p.Series = sr; return p; }, 
            //    param: new { @barcode = barcode }, splitOn: "CategoryName,SubName,SerieName", 
            //    commandType: CommandType.StoredProcedure, transaction: Transaction).FirstOrDefault();
            return null;
        }

        public List<CustomModel.CustomProduct> FindToCustom(string name)
        {
            return null;
            //return Connection.Query<CustomModel.CustomProduct, Category, SubCategory, Series, CustomModel.CustomProduct>("LookForProduct", (p, c, sub, sr) => { p.Category = c; p.Productline = sub; p.Series = sr; return p; }, param: new { @searchStr = name }, splitOn: "CategoryName,SubName,SerieName", commandType: CommandType.StoredProcedure, transaction: Transaction).ToList();
        }
        public List<Model.Product> FindByName(string name)
        {
            //return null;
            return Connection.Query<Product, Category, Series, ProductLine, Product>("LookForProduct", (p, c, s, l) => { p.Category = c; p.Series = s; p.Productline = l; return p; }, param: new { @searchStr = name }, splitOn: "CategoryName,SerieName,ProductLineName", commandType: CommandType.StoredProcedure, transaction: Transaction).ToList();
        }

        public List<Product> FindByCategory(int cateId)
        {
            return Connection.Query<Product, Category, Series, ProductLine, Product>(@"Select p.*,c.CategoryName,s.SerieName,l.ProductLineName from Product p inner join Series s on p.SeriesId = s.SerieId
                    left join ProductLine l on p.ProductLineId = l.ProductLineId inner join Category c on s.CategoryId= c.CategoryId where p.SeriesId in (select SerieId from Series where CategoryId = @cateId)",(p, c, s, l) => { p.Category = c; p.Series = s; p.Productline = l; return p; }
                , param: new { @cateId = cateId }, splitOn: "CategoryName,SerieName,ProductLineName", transaction: Transaction).ToList();
        }
        public List<CustomModel.ProductProperty> getProperty(string propertyName,Product product)
        {
            return Connection.Query<CustomModel.ProductProperty>("GetProductProperty", new { @propertyName = propertyName,@productId = product.ProductId }, commandType: CommandType.StoredProcedure, transaction: Transaction).ToList();
        }
        public void InsertProductProperty(CustomModel.ProductProperty value)
        {
            string insert = "insert into " + value.TableName + " values (@value,@productId)";
            Connection.Execute(insert, new { @value = value.Value, @productId = value.ProductId}, transaction: Transaction);
        }
    }
}
