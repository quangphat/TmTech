using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using Dapper;
using TmTech_v1.Model;

namespace TmTech_v1.Repository
{
    public class ImportMaterialRepository : RepositoryBase<Model.ImportMaterial>, IImportMaterialRepository
    {
        public ImportMaterialRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public List<ImportMaterial> All()
        {
            string sql = string.Format(@"select im.ApproveStatusId,im.ImportId, im.ImportCode,im.CreateDate, im.StockId, Count(*) as Quantity, Sum(imde.Quantity * imde.Price) as Total, st.StockName
                                        from ImportMaterial im join Stock st on im.StockId = st.StockId
                                        join ImportMaterialDetail imde on imde.ImportId = im.ImportId                        
                                        group by im.ApproveStatusId,im.CreateDate, im.ImportCode, im.ImportId, im.StockId, st.StockName");
            return Connection.Query<ImportMaterial, Stock, ImportMaterial>(sql, (im, st) => { im.Stock = st; return im; }, splitOn: "StockName", transaction: Transaction).ToList();
        }

        public ImportMaterial GetByID(Guid  importMaterialId)
        {
            string sql = string.Format(@"select im.ApproveStatusId,im.ImportId, im.ImportCode,im.CreateDate, im.StockId, Count(*) as Quantity, Sum(imde.Quantity * imde.Price) as Total, st.StockName
                                        from ImportMaterial im join Stock st on im.StockId = st.StockId
                                        join ImportMaterialDetail imde on imde.ImportId = im.ImportId
                                        where  im.ImportId =  CONVERT(uniqueidentifier," + "'" +importMaterialId+ "')" +
                                        " group by im.ApproveStatusId,im.CreateDate, im.ImportCode, im.ImportId, im.StockId, st.StockName");
            return Connection.Query<ImportMaterial, Stock, ImportMaterial>(sql, (im, st) => { im.Stock = st; return im; }, splitOn: "StockName", transaction: Transaction).FirstOrDefault();
        }


        public List<ImportMaterial> GetAllByDate(DateTime dt)
        {


            string sql = string.Format(@"select im.ImportCode,im.CreateDate, Count(*) as Quantity, Sum(imde.Quantity * imde.Price) as Total, st.StockName
                                        from ImportMaterial im join Stock st on im.StockId = st.StockId
                                        join ImportMaterialDetail imde on imde.ImportId = im.ImportId      
                                        where format(im.CreateDate,'dd-MM-yyyy') = format(@dt,'dd-MM-yyyy')                         
                                        group by im.CreateDate, im.ImportCode, im.ImportId, im.StockId, st.StockName");
            return Connection.Query<ImportMaterial, Stock, ImportMaterial>(sql, (im, st) => { im.Stock = st; return im; }, new { @dt = dt }, splitOn: "StockName", transaction: Transaction).ToList();
        }

        public List<ImportMaterial> GetAllFind(Model.ImportMaritalQuerry dt)
        {
            string querry = @"select im.ImportCode,im.CreateDate, Count(*) as Quantity, Sum(imde.Quantity * imde.Price) as Total, st.StockName
                                        from ImportMaterial im join Stock st on im.StockId = st.StockId
                                        join ImportMaterialDetail imde on imde.ImportId = im.ImportId";
            querry+= "  where ";

            if (dt.Stock!=string.Empty)
            {
                querry += " st.StockName like '%" +dt.Stock  +"%'" + "and";
            }
            if( dt._Token !=string.Empty)
            {
                querry += " im.ImportCode  like '%" + dt._Token + "%'" + "and";
            }
            if(dt.dtpFrom.HasValue)
            {
                querry += @"format(im.CreateDate,'dd-MM-yyyy') = format(@dt,'dd-MM-yyyy')                         
                                        group by im.CreateDate, im.ImportCode, im.ImportId, im.StockId, st.StockName" +'"' +")";
            }
            
            if(querry.EndsWith("and"))
            {
                querry = querry.Remove(querry.Length - "and".Length, "and".Length);
            }
            querry += " 	  group by im.CreateDate, im.ImportCode, im.ImportId, im.StockId, st.StockName";
            string sql = string.Format(querry);
            return Connection.Query<ImportMaterial, Stock, ImportMaterial>(sql, (im, st) => { im.Stock = st; return im; }, new { @dt = dt }, splitOn: "StockName", transaction: Transaction).ToList();
        }

        public ImportMaterial GetExistCode(string code)
        {
            return Connection.Query<ImportMaterial>("select * from ImportMaterial where  ImportCode  =@codeCheck", new { codeCheck = code }, Transaction).FirstOrDefault();


        }

        public string GetCode(int stockID,DateTime dateCreate)
        {
            return Connection.Query<string>("SELECT dbo.fn_CreateImportMaritalCode(@stockId,@ngaytao)", new { stockId = stockID, ngaytao = dateCreate }, Transaction).FirstOrDefault();
        }
    }

}
