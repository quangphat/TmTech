using System;
using System.IO;
using TmTech.Core;

namespace TmTech.HanldlerFile
{
    public class FileHandler : IFile
    {
        public string ReadFile(string filename)
        {
            var path = Path.Combine(Constraint.AppDataDir, filename);
            if (!File.Exists(path))
                return string.Empty;
            var resulfString = string.Empty;
            using (StreamReader streamReader = new StreamReader(path))
            {
                resulfString = streamReader.ReadToEnd();
            }
            return resulfString;
        }

        public bool WrieFile(FileContentWrite fileContentWrite)
        {
            var fileName = fileContentWrite.FileName;
            string path = Path.Combine(Constraint.AppDataDir, fileName);
            if (!Directory.Exists(Constraint.AppDataDir))
            {
                Directory.CreateDirectory(Constraint.AppDataDir);
            }
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
            }
            using (StreamWriter streamWriter = new StreamWriter(path, false))
            {
                streamWriter.Write(fileContentWrite.ContentFile);
            }
            return true;
        }
    }


}
