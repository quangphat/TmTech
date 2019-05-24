
using TmTech.Core;

namespace TmTech.HanldlerFile
{
   public interface IFile
    {
        string ReadFile(string filename);
        bool WrieFile(FileContentWrite fileContentWrite);
    }
}
