using System;

namespace TmTech_v1.Helper
{
  public  class Folder
    {

        public static string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string GetPathFolder( string nameFolder)
        {
            var pathfolder = "../../";
            pathfolder = System.IO.Path.Combine(pathfolder, nameFolder);
            return pathfolder;
        }
    }
}
