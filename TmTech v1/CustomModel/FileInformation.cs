namespace TmTech_v1.CustomModel
{
    public class FileInformation
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public FileInformation()
        {
            FileName = FilePath = string.Empty;
        }
    }
}
