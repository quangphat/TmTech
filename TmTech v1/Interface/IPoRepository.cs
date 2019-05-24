using System;
using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IPoRepository
    {
        void Add(Po entity);
        List<Po> All();
        Po Find(Guid id);
        List<Po> Find(Company com);
        void Remove(Guid id);
        void Remove(Po entity);
        void Remove(string poCode);
        void Update(Po entity);
        Guid CreateNew();
        List<Po> Search(DateTime fromDate, DateTime toDate);
        string GetPOCode(int companyId, DateTime dtmDateMake);
        List<Model.Po> Search(string searchStr);
        List<Model.Product> GetAllProduct(Model.Quotation quotation);
    }
}
