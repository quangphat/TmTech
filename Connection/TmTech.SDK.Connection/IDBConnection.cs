using TmTech.SDK.Connection.Model;

namespace TmTech.SDK.Connection
{
    public interface IConnection
    {
       void Create();
        void SetConnection();
        void SetConnection(AuthenticationTypeMode authenticationTypeMode);
        bool TestConnect();
        bool TestConnect(AuthenticationTypeMode authenticationTypeMode);
        bool GetDbFromFile(string filename);

    }
}
