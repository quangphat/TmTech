using System;
using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IImportMaterialDetailRepository : IGenericRepository<ImportMaterialDetail>
    {
        List<ImportMaterialDetail> All();
        List<ImportMaterialDetail> All(Guid ImportId);
    }

   
}