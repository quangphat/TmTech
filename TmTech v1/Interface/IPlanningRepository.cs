using System;
using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IPlanningRepository
    {
        void Add(Planning entity);
        List<Planning> All();
        Planning Find(Guid id);
        void Remove(Guid id);
        void Remove(Planning entity);
        void Update(Planning entity);
        List<Model.Planning> All(DateTime fromDate, DateTime toDate);
        List<Model.QuotationDetail> GetAllProduct(string planningCode);
        void AddProductFromPOToPlanning(Planning planning, Po po);
        void CreateFromPO(Po po);
        List<Model.Planning> Search(string searchStr);
    }
}
