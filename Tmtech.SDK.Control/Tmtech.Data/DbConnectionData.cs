using System;
using System.Data;
using System.Data.SqlClient;
using Tmtech.Data.Model;

namespace Tmtech.Data
{
  public class DbConnectionData : IDbConnectionData
  {
        public IDbConnection CreateConnection(DatabaseInfor requestDatabaseInfor)
        {
            var connection = string.Format("Data Source={0};Initial Catalog={1};User id={2};Password={3};", requestDatabaseInfor.ServerName,
                requestDatabaseInfor.DatabaseName, requestDatabaseInfor.User, requestDatabaseInfor.Password);
              
            IDbConnection idbConnection = null;
            try
            {
                idbConnection = new SqlConnection(connection);
            }
            catch (Exception e)
            {
                idbConnection = null;
            }
            return idbConnection;
        }
    }
}
