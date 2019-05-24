
using System.Globalization;

namespace TmTech.Resource
{
  
    public class ManagementResource : ILocale
    {

        string[] cultures = { "", "en-US" };
        public void SwichLanguage(CultureLanguage cultureLanguage = CultureLanguage.en_US)
        {
            CultureInfo currentCulture = null;
            switch (cultureLanguage)
            {
                case CultureLanguage.vn_VN:
                    currentCulture = new CultureInfo(string.Empty);
                    break;
                case CultureLanguage.en_US:
                    currentCulture = new CultureInfo(cultures[1]);
                    break;
                default:
                    currentCulture = new CultureInfo(cultures[1]);
                    break;
            }
            UI.Culture = currentCulture;
            Permission.Culture = currentCulture;
            Validation.Culture = currentCulture;
        }
    }
}
