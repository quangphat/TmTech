namespace Tmtech.Common
{
    public class Common
    {
        public static bool Tmtech_CheckNullString(string strCheck)
        {
            if (string.IsNullOrWhiteSpace(strCheck) || string.IsNullOrEmpty(strCheck))
            {
                return true;
            }
            return false;
        }

    }
}
