
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Tmtech.SDK.Core.Model;
using DapperExtensions;
using Tmtech.Data.Model;

namespace Tmtech.Data
{
    public class BaseRepository<T> : IBaseRepository<T> where T : CoreEntry
    {

        protected IDbTransaction Transaction { get; private set; }
        private bool _disposed = false;
        protected IDbConnection Connection { get; set; }
        public BaseRepository(/*IDbTransaction transaction*/)
        {
            IDbConnectionData connection1 = new DbConnectionData();
            DatabaseInfor info = new DatabaseInfor()
            {
                ServerName = "192.168.1.41",
                User = "Tmtech",
                DatabaseName = "TmTech",
                Password = "number8"

            };
            Connection = connection1.CreateConnection(info);
            Connection.Open();
            Transaction = Connection.BeginTransaction();

        }
        public void Insert(T entity)
        {
            try
            {
                Connection.Insert(entity, Transaction);
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                    throw (ex.InnerException);
            }
        }
        public List<T> All()
        {
            return Connection.GetList<T>(transaction: Transaction).ToList();
        }


        public T GetById(string id)
        {
            var entry = Connection.Query<T>("select * from " + typeof(T).Name + " where " + CoreEntryOrderBy.Id + " = @" + CoreEntryOrderBy.Id, param: new { Id = id }, transaction: Transaction).FirstOrDefault();
            return entry;

        }
        public T GetById(List<string> ids)
        {
            throw new NotImplementedException();
        }
        public void Delete(T entity)
        {
            Connection.Delete(entity, transaction: Transaction);
        }
        public void Update(T entity)
        {
            Connection.Update(entity, transaction: Transaction);
        }
        public void InsertOrUpdate(T entitry)
        {
        }
        public void Comit()
        {
            try
            {
                Transaction.Commit();
            }
            catch
            {
                Transaction.Rollback();
                throw;
            }
            finally
            {
                Transaction.Dispose();
                Transaction = Connection.BeginTransaction();
                Reset();
            }
        }
        public void RollBack()
        {
            if (Transaction == null)
            {
                return;
            }
            Transaction.Rollback();
            Reset();
        }

        private void Reset()
        {

        }

        ~BaseRepository()
        {
            Dispose(false);
        }
        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (Transaction != null)
                    {
                        Transaction.Dispose();
                        Transaction = null;
                    }
                    if (Connection != null)
                    {
                        Connection.Dispose();
                    }
                }
                _disposed = true;
            }
        }

    }
}
