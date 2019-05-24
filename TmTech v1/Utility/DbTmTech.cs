using System.Data;
using System.Data.SqlClient;
using TmTech_v1.Model;

namespace TmTech_v1.Utility
{

    public interface IDbTmTech
    {
        void Create();
        void SetConnection();
        void SetConnection(AuthenticationTypeMode authenticationTypeMode);
        bool TestConnect();
        bool TestConnect(AuthenticationTypeMode authenticationTypeMode);
        bool GetDbFromFile(string filename);
    }


    public class AuthenticationTypeMode
    {
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string IdAddrees { get; set; }
        public int TypeAuThen { get; set; }
        public AuthenticationTypeMode()
        {
            TypeAuThen = TypeAuThentication.SqlServer;
        }
    }


    public class TypeAuThentication
    {
        public const int SqlServer = 1;

        public const int LocallWindown = 2;
    }

    public static class DbTmTech
    {
        public static IDbConnection DbCon = null;
        public static DatabaseInfo _dbInfo;
        private static readonly string ConStr = string.Empty;
        public static IDbConnection Create()
        {
            if (DbCon != null)
            {
                if (!string.IsNullOrEmpty(DbCon.ConnectionString))
                    return DbCon;
                else
                {
                    SetConnection();
                }
            }
            if (DbCon == null)
            {
                DbCon = new SqlConnection(ConStr);
                return DbCon;
            }
            return DbCon;
        }
        public static void SetConnection()
        {
            if (_dbInfo == null)
                return;
            string conStr = string.Empty;
            if (_dbInfo.AuthenticationType == 1)
                conStr = string.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True", _dbInfo.Server, _dbInfo.DatabaseName);
            else
            {
                conStr = string.Format(@"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", _dbInfo.Server, _dbInfo.DatabaseName, _dbInfo.UserName, _dbInfo.Password);
            }
            if (conStr == string.Empty)
                DbCon = null;
            else
                DbCon = new SqlConnection(conStr);
        }
        public static void SetConnection(string serverName, string databaseName, string id, string password, int AuthenticationType = 1)
        {   
            string conStr = string.Empty;
            if (AuthenticationType == 1)
                conStr = string.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True;", serverName, databaseName);
            else
                conStr = string.Format(@"Data Source={0};Initial Catalog={1};User ID={2};password={3}", serverName, databaseName, id, password);
            DbCon = new SqlConnection(conStr);
        }
        public static bool TestConnect(string serverName, string databaseName, int Authenticationtype = 1, string id = "", string password = "")
        {
            string conStr = string.Empty;
            if (id != "" && password != "")
                conStr = string.Format(@"Data Source={0};Initial Catalog={1};User ID={2};password={3}", serverName, databaseName, id, password);
            else
            {
                conStr = string.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True;", serverName, databaseName);
            }
            IDbConnection dbtest = new SqlConnection(conStr);
            try
            {
                dbtest.Open();
            }
            catch
            {
                return false;
            }
            if (dbtest.State == ConnectionState.Open)
            {
                return true;
            }
            else
                return false;
        }
        public static bool TestConnect()
        {
            string conStr = string.Empty;
            if (_dbInfo.AuthenticationType == 2 && _dbInfo.UserName != string.Empty && _dbInfo.Password != string.Empty)
                conStr = string.Format(@"Data Source={0};Initial Catalog={1};User ID={2};password={3}", _dbInfo.Server, _dbInfo.DatabaseName, _dbInfo.UserName, _dbInfo.Password);
            else
            {
                conStr = string.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True;", _dbInfo.Server, _dbInfo.DatabaseName);
            }
            IDbConnection dbtest = new SqlConnection(conStr);
            try
            {
                dbtest.Open();
            }
            catch
            {
                return false;
            }
            if (dbtest.State != ConnectionState.Open)
                return false;
            return true;
        }
        public static bool ConnectDb(string serverName, string databaseName, int Authenticationtype = 1, string id = "", string password = "")
        {
            if (string.IsNullOrEmpty(serverName))
                return false;
            if (string.IsNullOrEmpty(databaseName))
                return false;
            if (Authenticationtype == 2)
            {
                if (id == "" || password == "")
                    return false;
            }
            _dbInfo = new DatabaseInfo();
            _dbInfo.Server = serverName;
            _dbInfo.DatabaseName = databaseName;
            _dbInfo.AuthenticationType = Authenticationtype;
            _dbInfo.UserName = id;
            _dbInfo.Password = password;
            if (_dbInfo == null)
                return false;
            else
            {
                SetConnection();
                UtilityFunction.WriteDbInfo(_dbInfo);
                return true;
            }
        }
        public static bool GetDbFromFile(string filename = "connectinfo")
        {
            _dbInfo = UtilityFunction.ReadDbInfo();
            if (_dbInfo == null) return false;
            SetConnection();
            return true;
        }
    }
}
