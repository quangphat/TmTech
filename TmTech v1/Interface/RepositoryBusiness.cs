using System.Collections.Generic;

namespace TmTech_v1.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        int AddandGetRequestPaymentId(T entity);
        void Add(T entity);
        List<T> All();
        T Find(int id);
        void Remove(T entity);
        void Remove(int id);
        void Update(T entity);


    }
}
