namespace TmTech.Core
{
    public class DatabaseInfo
    {
        public string IdAddrees { get; set; }

        public string ServerName { get; set; }
        public string Port { get; set; }
        public int AuthenticationType { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DatabaseName { get; set; }
        public DatabaseInfo()
        {
            ServerName = Port = UserName = Password = DatabaseName = string.Empty;
            AuthenticationType = TypeAuThentication.LocallWindown;
        }
    }
}

