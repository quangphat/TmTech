using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface ISeriesRepository
    {
        void Add(Series entity);
        List<Series> All();
        Series Find(int id);
        void Remove(int id);
        void Remove(Series entity);
        void Update(Series entity);
        List<Series> FindByCategory(int CateId);
    }
}
