using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IStockMaterialRepository
    {
        void Add(StockMaterial entity);
        List<StockMaterial> All();
        List<StockMaterial> AllByStock(int StockId);
        List<StockMaterial> AllByMaterial(int MaterialId);
        StockMaterial Find(int StockId,int MaterialId);
        void Remove(int id);
        void Remove(StockMaterial entity);
        void Update(StockMaterial entity);
    }
}
