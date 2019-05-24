using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using Dapper;
using TmTech_v1.Model;

namespace TmTech_v1.Repository
{
    public class ImportMaterialDetailRepository : RepositoryBase<Model.ImportMaterialDetail>, IImportMaterialDetailRepository
    {
        public ImportMaterialDetailRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }

        public List<ImportMaterialDetail> All()
        {
            string sql = string.Format(@"select imde.*, mt.MaterialCode, mt.MaterialName, mt.Photo, sup.SupplierName from ImportMaterialDetail imde join Material mt on imde.MaterialId = mt.MaterialId join Supplier sup on mt.SupplierId = sup.SupplierId");
            return Connection.Query<ImportMaterialDetail, Model.Material, Supplier, ImportMaterialDetail>(sql, (imde, mt, sup) => { imde.Material = mt; mt.Supplier = sup; return imde; }, splitOn: "MaterialCode,SupplierName", transaction: Transaction).ToList();
        }

        public List<ImportMaterialDetail> All(Guid ImportId)
        {
            string sql = string.Format(@"select d.*,mt.MaterialCode,mt.MaterialName,mt.UnitId, sup.SupplierName,u.UnitName 
                        from ImportMaterialDetail d inner join Material mt 
                        on d.MaterialId = mt.MaterialId join Supplier sup 
                        on mt.SupplierId = sup.SupplierId 
                        inner join Unit u on mt.UnitId = u.UnitId where d.ImportId = @ImportId");
            return Connection.Query<ImportMaterialDetail, Model.Material, Supplier, Unit, ImportMaterialDetail>(sql, (imde, mt, sup, u) => { imde.Material = mt; mt.Supplier = sup;mt.UnitMaterial = u ; return imde; }, new { @ImportId = ImportId }, splitOn: "MaterialCode,SupplierName,UnitName", transaction: Transaction).ToList();
        }
    }

}
