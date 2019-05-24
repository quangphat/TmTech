using System;
using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IImportMaterialRepository : IGenericRepository<ImportMaterial>
    {
        List<ImportMaterial> All();
        ImportMaterial GetByID(Guid importMaterialId);
        List<ImportMaterial> GetAllByDate(DateTime dt);
        List<ImportMaterial> GetAllFind(Model.ImportMaritalQuerry dt);
        ImportMaterial GetExistCode(string code);
        string GetCode( int stockID,DateTime dateCreate);
    }
    

}