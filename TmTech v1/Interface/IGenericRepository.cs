using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace TmTech_v1.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        T Get(Expression<Func<T, object>> filter, object value);
        void Insert(T entity);
        void Delete(T entity);
        void Edit(T entity);
    }
}
