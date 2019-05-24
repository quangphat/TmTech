using System.Text.RegularExpressions;

namespace TmTech_v1.Utility
{
    public  static class Common
    {
        
        public static int ToInt( this string convert)
        {
            var regex = new Regex(@"^\d$");
            return regex.Match(convert).Success ? int.Parse(convert) : 0;
        }
    }
}
