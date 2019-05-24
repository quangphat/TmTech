namespace TmTech_v1.Model
{
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
            AuthenticationType = 0;
        }
    }
}
