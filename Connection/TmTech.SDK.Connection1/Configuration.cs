using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmTech.SDK.Connection1
{
    public class Configuration
    {
        public static string FileNameConnection { get { return ReadConfig(Constraint.fileConnection); } }
        private static string ReadConfig( string keyName )
        {
          var valueConfig=  ConfigurationManager.AppSettings.Get(keyName);
            if (valueConfig == null)
                return string.Empty;
            return valueConfig;
        }
    }
}
