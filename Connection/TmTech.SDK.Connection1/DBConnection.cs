
using Newtonsoft.Json;
using System;
using System.Data;
using System.Data.SqlClient;
using TmTech.Core;
using TmTech.HanldlerFile;

namespace TmTech.SDK.Connection1
{
    public class Connection : IConnection
    {
        IDbConnection iDbConnection;
        IUtilityFunction iUtilityFunction;
        public Connection()
        {
            iUtilityFunction = new UtilityFunction();
        }
        public IDbConnection Create()
        {
            var conStr = string.Empty;
            if (iDbConnection == null)
            {
                return new SqlConnection(conStr); ;
            }
            if (iDbConnection != null)
            {
                if (!string.IsNullOrEmpty(iDbConnection.ConnectionString))
                    return iDbConnection;
                else
                {
                    SetConnection();
                }
            }
            return iDbConnection;
        }
        public void SetConnection( DatabaseInfo databaseInfo = null)
        {
            if (databaseInfo == null)
                return;
            string conStr = string.Empty;
            if (databaseInfo.AuthenticationType == 1)
                conStr = string.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True", databaseInfo.ServerName, databaseInfo.DatabaseName);
            else
            {
                conStr = string.Format(@"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", databaseInfo.ServerName, databaseInfo.DatabaseName, databaseInfo.UserName, databaseInfo.Password);
            }
            if (conStr == string.Empty)
                iDbConnection = null;
            else
                iDbConnection = new SqlConnection(conStr);
        }
        public bool TestConnect(DatabaseInfo databaseInfo =null)
        {
            var AuthenticationType = databaseInfo.AuthenticationType;
            var serverName = databaseInfo.ServerName;
            var databaseName = databaseInfo.DatabaseName;
            var id = databaseInfo.IdAddrees;
            var password = databaseInfo.Password;
            string connectionString = string.Empty;
            if (id != "" && password != "")
                connectionString = string.Format(@"Data Source={0};Initial Catalog={1};User ID={2};password={3}", serverName, databaseName, id, password);
            else
            {
                connectionString = string.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True;", serverName, databaseName);
            }
            IDbConnection databaseTest = new SqlConnection(connectionString);
            try
            {
                databaseTest.Open();
            }
            catch
            {
                return false;
            }
            if (databaseTest.State == ConnectionState.Open)
            {
                return true;
            }
            else
                return false;
        }
        public bool ConnectDb(DatabaseInfo databaseInfo)
        {

            var AuthenticationType = databaseInfo.AuthenticationType;
            var serverName = databaseInfo.ServerName;
            var databaseName = databaseInfo.DatabaseName;
            var id = databaseInfo.IdAddrees;
            var password = databaseInfo.Password;
            if (string.IsNullOrEmpty(serverName))
                return false;
            if (string.IsNullOrEmpty(databaseName))
                return false;
            if (databaseInfo.AuthenticationType == TypeAuThentication.LocallWindown)
            {
                if (id == "" || password == "")
                    return false;
            }
            SetConnection(databaseInfo);
            iUtilityFunction.WriteDbInfo(databaseInfo);
            return true;
        }
        public bool Authorization( )
        {
           var databaseInfo = iUtilityFunction.ReadDbInfo();
            if (databaseInfo == null)
                return false;
            SetConnection(databaseInfo);
            return true;
        }
    }
}
