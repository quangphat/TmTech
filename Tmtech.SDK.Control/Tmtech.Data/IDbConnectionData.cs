
using System.Data;
using Tmtech.Data.Model;

namespace Tmtech.Data
{
   public interface IDbConnectionData
   {
       IDbConnection CreateConnection(DatabaseInfor requestDatabaseInfor);
   }
}
