using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmTech.Core;

namespace TmTech.SDK.Connection1
{
    public abstract class UnitOfWork<T> : RepositoryBase<T>, IunitOfWork where T : CoreEntry
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;
        
        public UnitOfWork(IDbTransaction transaction) : base(transaction)
        {

        }

        ~UnitOfWork()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
                ResetRepositories();
            }
        }
        
        private void ResetRepositories()
        {
          
        }

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
                ResetRepositories();
            }
        }

    }
}
