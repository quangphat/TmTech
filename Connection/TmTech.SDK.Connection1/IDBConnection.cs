using System.Data;
using TmTech.Core;

namespace TmTech.SDK.Connection1
{
    public interface IConnection
    {
        IDbConnection Create();
        void SetConnection(DatabaseInfo databaseInfo);
        bool TestConnect(DatabaseInfo databaseInfo);
        bool Authorization();
    }
}
