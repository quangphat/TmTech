using System;
using TmTech.SDK.Connection.Model;
using System.Data;
using System.Data.SqlClient;

namespace TmTech.SDK.Connection
{
    public class Connection : IConnection
    {
        IDbConnection idb

        public void Create()
        {
            throw new NotImplementedException();
        }

        public bool GetDbFromFile(string filename)
        {
            throw new NotImplementedException();
        }

        public void SetConnection()
        {
            throw new NotImplementedException();
        }

        public void SetConnection(AuthenticationTypeMode authenticationTypeMode)
        {
            throw new NotImplementedException();
        }


        public bool TestConnect()
        {
            throw new NotImplementedException();
        }

        public bool TestConnect(AuthenticationTypeMode authenticationTypeMode)
        {
            throw new NotImplementedException();
        }

    }
}
