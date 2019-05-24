using System.Collections.Generic;
using Tmtech.SDK.Core.Model;

namespace Tmtech.Data
{
    public interface IBaseRepository<T> where T : CoreEntry
    {
        void Insert(T entity);
        List<T> All();
        T GetById(string id);
        T GetById(List<string> ids);
        void Delete(T entity);
        void Update(T entity);
        void InsertOrUpdate(T entitry);
        void Comit();
        void RollBack();
    }

}