
namespace TmTech.SDK.Connection.Model
{
    public class AuthenticationTypeMode
    {
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string IdAddrees { get; set; }
        public int AuthenticationType { get; set; }
        public AuthenticationTypeMode()
        {
            AuthenticationType = TypeAuThentication.LocallWindown;
        }
    }

    public class DatabaseInfo
    {
        public string Server { get; set; }
        public string Port { get; set; }
        public int AuthenticationType { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DatabaseName { get; set; }
        public DatabaseInfo()
        {
            Server = Port = UserName = Password = DatabaseName = string.Empty;
            AuthenticationType = TypeAuThentication.LocallWindown;
        }
    }
}
