using DapperExtensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TmTech.Core;

namespace TmTech.SDK.Connection1
{
    public abstract class RepositoryBase<T> : IGenericRepository<T> where T : CoreEntry
    {
        protected IDbTransaction Transaction { get; private set; }
        protected IDbConnection Connection { get { return Transaction.Connection; } }


        public RepositoryBase(IDbTransaction transaction)
        {
           
            Transaction = transaction;
        }
        public void Create(T model)
        {

            model.CreateDate = DateTime.Now;
            model.CreateBy = "nghiait06";
            Connection.Insert(model, transaction: Transaction);
        }

        public void Edit(T model)
        {
            model.ModifyDate = DateTime.Now;
            model.ModifyBy = "nghiait06";
            Connection.Update(model, transaction: Transaction);
        }

        public void Delete(T model)
        {
            Connection.Delete(model, transaction: Transaction);
        }
        public void Delete(Expression<Func<T, object>> filter, object value)
        {
            var predicate = Predicates.Field(filter, Operator.Eq, value);
            Connection.Delete(predicate, transaction: Transaction);
        }
        public List<T> RetrieveMany(Expression<Func<T, object>> filter, object value)
        {
            var predicate = Predicates.Field(filter, Operator.Eq, value);
            return Connection.GetList<T>(predicate, transaction: Transaction).ToList();
        }

        public T Get(Expression<Func<T, object>> filter, object value)
        {
            var predicate = Predicates.Field(filter, Operator.Eq, value);
            return Connection.GetList<T>(predicate, transaction: Transaction).FirstOrDefault();
        }
        public List<T> FindbyParentId(Expression<Func<T, object>> filter, object value)
        {
            var predicate = Predicates.Field(filter, Operator.Eq, value);
            return Connection.GetList<T>(predicate, transaction: Transaction).ToList();
        }
        public virtual List<T> GetAll()
        {
            return Connection.GetList<T>(transaction: Transaction).ToList();
        }

    }
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        T Get(Expression<Func<T, object>> filter, object value);
        void Create(T entity);
        void Delete(T entity);
        void Edit(T entity);
       
    }
}
