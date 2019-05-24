using System.Data;
using DapperExtensions;
using System.Linq.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using TmTech_v1.Model;
using TmTech_v1.Utility;
using TmTech_v1.Interface;

namespace TmTech_v1.Repository
{
    public abstract class RepositoryBase<T> : IGenericRepository<T> where T :CoreEntry
    {
        protected IDbTransaction Transaction { get; private set; }
        protected IDbConnection Connection { get { return Transaction.Connection; } }

        public RepositoryBase(IDbTransaction transaction)
        {
            Transaction = transaction;
        }
        public void Insert(T model)
        {
            if(model.CreateDate==null)
            model.SetCreate();
            else
            {
                model.CreateBy = UserManagement.UserSession.UserName;
            }
            Connection.Insert(model, transaction: Transaction);
        }

        public void Edit(T model)
        {
            model.SetModify();
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
    

}
