
using System.Collections.Generic;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.Bussiness
{
    public partial interface IBaseBussiness<T> : IGenericRepository<T> where T:class 
    {
      
    }

    public class BaseBussiness<T> : IBaseBussiness<T> where T : class
    {
        private readonly IGenericRepository<T> _baseRepository;
        public BaseBussiness(IGenericRepository<T> baseRepository)
        {
           _baseRepository = baseRepository;
        }
       
        public virtual List<T> GetAll()
        {
            return _baseRepository.GetAll();
        }

        public T Get(System.Linq.Expressions.Expression<System.Func<T, object>> filter, object value)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(T entity)
        {
           _baseRepository.Insert(entity);
        }

        public void Delete(T entity)
        {
            _baseRepository.Delete(entity);
        }

        public void Edit(T entity)
        {
           _baseRepository.Edit(entity);
        }
    }





    public  interface IUser1 : IBaseBussiness<Model.Users>
    {
        
    }

    public partial class BaseUser : BaseBussiness<Model.Users>
    {
        public BaseUser(IGenericRepository<Users> baseRepository) : base(baseRepository)
        {
         
        }
    }
}
