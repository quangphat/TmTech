using System.Globalization;
using System.Text.RegularExpressions;

namespace TmTech_v1.Utility
{
    public static class CurrencyUtility
    {
        private static CultureInfo UsCul = CultureInfo.GetCultureInfo("en-US");
        private static CultureInfo VnCul = CultureInfo.GetCultureInfo("vi-VN");
        private static string CurrencyFormat = "#,###";
        private static string GetAllText(string input)
        {
            return Regex.Replace(input, "[^0-9]", "");
        }
        public static decimal ToDecimal(string input)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                return 0;
            return decimal.Parse(GetAllText(input));
        }
        public static string DecimalToString(decimal money)
        {
            string str = money.ToString(CurrencyFormat, UsCul);
            if (str == string.Empty)
                str = "0";
            return str;
        }
        public static decimal PercentToMoney(double percent, decimal money)
        {
            return (decimal)percent * money;
        }
        public static decimal PercentToMoney(double percent, string money)
        {
            decimal temp = CurrencyUtility.ToDecimal(money);
            return (decimal)percent * temp;
        }
    }
}
