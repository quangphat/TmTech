using Newtonsoft.Json;
using TmTech.Core;
using TmTech.HanldlerFile;

namespace TmTech.SDK.Connection1
{
    public class UtilityFunction : IUtilityFunction
    {
        public DatabaseInfo ReadDbInfo()
        {
            IFile ifile = new FileHandler();
            string directory = Constraint.AppDirectoryFolder;
            string fileName = Configuration.FileNameConnection;
            string path = System.IO.Path.Combine(directory, fileName);
            string info = ifile.ReadFile(path);
            if (string.IsNullOrEmpty(info))
                return null;
            try
            {
                DatabaseInfo dbinfo = JsonConvert.DeserializeObject<DatabaseInfo>(info);
                return dbinfo;
            }
            catch
            {
                return null;
            }
        }
        public bool WriteDbInfo(DatabaseInfo dbInfo)
        {
            if (dbInfo == null) return false;
            string info = ConvertDbInfoToJson(dbInfo);
            string directory = Constraint.AppDirectoryFolder;
            string path = Constraint.fileConnection;
            string fileName = System.IO.Path.Combine(directory, path);
            IFile ifile = new FileHandler();
            FileContentWrite fileContentWrite = new FileContentWrite
            {
                ContentFile = info,
                FileName = fileName
            };
            ifile.WrieFile(fileContentWrite);
            return true;
        }
        public string ConvertDbInfoToJson<T>(T t)
        {
            return JsonConvert.SerializeObject(t, Formatting.None);
        }
    }

    public interface IUtilityFunction
    {
        bool WriteDbInfo(DatabaseInfo dbInfo);
        DatabaseInfo ReadDbInfo();

    }


}
