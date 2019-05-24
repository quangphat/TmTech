using System.Collections.Generic;

namespace TmTech_v1
{
    public class UserTheme
    {
        public string[] Colors = new string[] { "Default", "LightGreen", "Grey", "Green" };
        public string Name { get; set; }
        public string PrimaryColor { get; set; }
        public string LightPrimary { get; set; }
        public string TextColor { get; set; }
        public string TitleBarColor { get; set; }
        public string Accent { get; set; }
        public UserTheme()
        {
            Name = "Default";
            PrimaryColor = "#F2F4F8";
            LightPrimary = "#A5D6A7";
            TextColor = "#212121";
            TitleBarColor = "#3C5488";
            Accent = "#3498DB";
        }
        public static List<UserTheme> generateTheme()
        {
            List<UserTheme> lstTheme = new List<UserTheme>();
            lstTheme.Add(new UserTheme { Name = "Default", PrimaryColor = "#F2F4F8", TitleBarColor = "#3C5488", LightPrimary = "#A5D6A7", TextColor = "#212121",Accent="#3C5488" });
            lstTheme.Add(new UserTheme { Name = "Grey", PrimaryColor = "#37474F", TitleBarColor = "#263238", LightPrimary = "#607D8B", TextColor = "#FFFFFF", Accent = "#263238" });
            lstTheme.Add(new UserTheme { Name = "Green", PrimaryColor = "#43A047", TitleBarColor = "#388E3C", LightPrimary = "#A5D6A7", TextColor = "#ffffff", Accent = "#388E3C" });
            lstTheme.Add(new UserTheme { Name = "Blue", PrimaryColor = "#3498DB", TitleBarColor = "#2980b9", LightPrimary = "#ff4950", TextColor = "#ffffff", Accent = "#2980b9" });
            lstTheme.Add(new UserTheme { Name = "Pink", PrimaryColor = "#E74c3c", TitleBarColor = "#c0392b", LightPrimary = "#FF4821", TextColor = "#ffffff", Accent = "#c0392b" });
            lstTheme.Add(new UserTheme { Name = "Concrete", PrimaryColor = "#95a5a6", TitleBarColor = "#7f8c8d", LightPrimary = "#2e7d32", TextColor = "#ffffff", Accent = "#7f8c8d" });
            lstTheme.Add(new UserTheme { Name = "Cyan", PrimaryColor = "#00BCD4", TitleBarColor = "#0097A7", LightPrimary = "#B2EBF2", TextColor = "#ffffff", Accent = "#0097A7" });
            lstTheme.Add(new UserTheme { Name = "Orrange", PrimaryColor = "#FF5722", TitleBarColor = "#E64A19", LightPrimary = "#FFCCBC", TextColor = "#ffffff", Accent="#E64A19" });
            lstTheme.Add(new UserTheme { Name = "Green2", PrimaryColor = "#33691E", TitleBarColor = "#1B5E20", LightPrimary = "#9CCC65", TextColor = "#ffffff", Accent = "#1B5E20" });
            lstTheme.Add(new UserTheme { Name = "SoftPink", PrimaryColor = "#F48FB1", TitleBarColor = "#ef9a9a", LightPrimary = "#9CCC65", TextColor = "#ffffff",Accent= "#ef9a9a" });
            lstTheme.Add(new UserTheme { Name = "Teal", PrimaryColor = "#9CCC65", TitleBarColor = "#66BB6A", LightPrimary = "#A5D6A7", TextColor = "#ffffff",Accent= "#66BB6A" });
            return lstTheme;
        }
    }
}
