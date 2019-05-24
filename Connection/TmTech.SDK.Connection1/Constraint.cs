using System;

namespace TmTech.SDK.Connection1
{
   
    public class TypeAuThentication
    {
        public const int SqlServer = 1;

        public const int LocallWindown = 0;
    }

    public class Constraint
    {
        public const string fileConnection = "ConnectionFile";
        public static string AppDirectoryFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TmTech";
    }

}
