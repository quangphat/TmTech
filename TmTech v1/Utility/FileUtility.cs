using System.IO;
using System.Windows.Forms;
using TmTech_v1.CustomModel;

namespace TmTech_v1.Utility
{
    public static class FileUtility
    {
        public static string Filefilter = "Document (*.doc,*.docx,*.pdf,*.xls,*.xlsx,*.txt)|*.doc;*.docx;*.pdf;*.xls;*.xlsx;*.txt";
        private static string ServerIP = DbTmTech._dbInfo.Server;
        private static string serverPath = "\\\\" +ServerIP + "\\Development\\Document";

        public static bool PathIsImage(string filename)
        {
            if (filename.Contains(".png") || filename.Contains(".jpg") || filename.Contains(".jpeg"))
                return true;
            return false;
        }
        public static FileInformation OpenFile()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = Filefilter;
            op.ShowDialog();
            FileInformation info = new FileInformation();
            if (ValidationUtility.StringIsNull(op.FileName)) return info;
            FileInfo finfo = new FileInfo(op.FileName);
            info.FileName = finfo.Name;
            info.FilePath = op.FileName;
            return info;
        }
        public static string GetFileLocation(string filename)
        {
            if (!string.IsNullOrWhiteSpace(filename))
            {
                return Path.Combine(serverPath, filename);
            }
            return "";
        }
        public static bool OpenToView(string fileName)
        {
            try
            {
                System.Diagnostics.Process.Start(GetFileLocation(fileName));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void SaveToServer(FileInformation info)
        {
            string pathToSave = serverPath + "\\" + info.FileName;
            FileInfo finfo = new FileInfo(pathToSave);
            if (File.Exists(pathToSave))
            {
                return;
            }
            else
            {
                byte[] buf = File.ReadAllBytes(info.FilePath);
                FileStream stream = new FileStream(pathToSave, FileMode.Create, FileAccess.Write);
                stream.Write(buf, 0, buf.Length);
                stream.Close();
                stream.Dispose();
            }
        }
        public static void SaveToServer(string fileName,string filePath)
        {
            string pathToSave = serverPath + "\\" + fileName;
            FileInfo finfo = new FileInfo(pathToSave);
            if (File.Exists(pathToSave))
            {
                return;
            }
            else
            {
                byte[] buf = File.ReadAllBytes(filePath);
                FileStream stream = new FileStream(pathToSave, FileMode.Create, FileAccess.Write);
                stream.Write(buf, 0, buf.Length);
                stream.Close();
                stream.Dispose();
            }
        }
    }
}
