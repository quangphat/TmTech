using System;
using System.Windows.Forms;
using TmTech_v1.Utility;
using TmTech_v1.Model;
using ModernUI.Controls;
using System.IO;
using Newtonsoft.Json;
using System.Globalization;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;
using System.Reflection;
using System.Collections.Generic;
using TmTech_v1.Interface;

namespace TmTech_v1
{
    public static class UtilityFunction
    {
        public static DateTime minDate = new DateTime(1987, 12, 02);
        public static CultureInfo UsCul = CultureInfo.GetCultureInfo("en-US");
        public static CultureInfo VnCul = CultureInfo.GetCultureInfo("vi-VN");
        public static string CurrencyFormat = "#,###";
        public static string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TmTech";
        private static string connectionfile41 = "connectioninfo.1.41";
        private static string themefile = "theme";
        private static string columntoShowFile = "columntoshow";
        public static bool IsWorkDatabase = true;
       

        #region Format
        public static bool WriteDbInfo(DatabaseInfo dbInfo)
        {
            if (dbInfo == null) return false;
            string info = ConvertDbInfoToJson(dbInfo);
            WriteToFile(connectionfile41, info);
            return true;
        }
        public static DatabaseInfo ReadDbInfo()
        {
           // string info = ReadFile(connectionfile);
            string info = ReadFile(connectionfile41);
            if (string.IsNullOrEmpty(info))
            {
                return null;
            }
            try
            {
                var dbinfo = JsonConvert.DeserializeObject<DatabaseInfo>(info);
                return dbinfo;
            }
            catch
            {
                return null;
            }
        }
        public static void AddTab(MaterialTabControl mainTab,Control ctrl)
        {
            TabPage tab = new TabPage();
            tab.Controls.Add(ctrl);
            mainTab.TabPages.Add(tab);
            mainTab.SelectedTab = tab;
        }
        public static int? getNumberIString(string strNumber)
        {
            if (ValidationUtility.StringIsNull(strNumber))
                return 0;
            else
                return Convert.ToInt32(strNumber);
        }
        public static double getNumberDString(string strNumber)
        {
            return !ValidationUtility.StringIsNull(strNumber) ? Convert.ToDouble(strNumber) : 0;
        }

        #endregion
        #region check input
        public static Boolean CheckInput(Control ctrl)  // check input
        {
            foreach (Control Ctr in ctrl.Controls)
            {

                if (ctrl.Name.Contains("code") || ctrl.Name.Contains("name"))
                {
                    if (ctrl is TextBox)
                    {
                        TextBox txtObjCheck = (TextBox)ctrl;
                        if (string.IsNullOrWhiteSpace(txtObjCheck.Text))
                        {
                            FlatMessageBox.FlatMsgBox.Show(NotificationMessage.MsgMissingData, "", FlatMessageBox.FlatMsgBox.Buttons.OK, FlatMessageBox.FlatMsgBox.Icon.Info);
                            ctrl.Focus();
                            return false;
                        }
                    }


                }


                if (Ctr.Controls.Count > 0)
                {
                    CheckInput(ctrl);
                }
            }
            return true;
        }

        #endregion
        public static DateTime GetDatetime(DateEdit dtp)
        {
            if (DateTime.Compare(dtp.DateTime, minDate) < 0)
                return minDate;
            else
                return dtp.DateTime;
        }
        public static string DateTimeToString(DateTime date)
        {
            return date.ToString("dd/MM/yyyy");
        }
        
        public static void ConvertTreeListNodeToObj<T>(DevExpress.XtraTreeList.TreeList treeList,TreeListNode node,T obj)
        {
            object arr = treeList.GetDataRecordByNode(node);
            foreach (TreeListColumn col in treeList.Columns)
            {
                string[] props = col.FieldName.Split('.');
                if (props != null)
                {
                    for (int i = 0; i < props.Length; i++)
                    {
                        object val = node.GetDisplayText(props[i]);
                        if (val != null && !string.IsNullOrWhiteSpace(val.ToString()))
                        {
                            foreach (PropertyInfo p in obj.GetType().GetProperties())
                            {
                                if (p.Name == props[i])
                                {
                                    Type u = Nullable.GetUnderlyingType(p.PropertyType);
                                    if (u != null)
                                    {
                                        var temp = ChangeType(val, u);
                                        if (temp != null)
                                            p.SetValue(obj, temp, null);
                                    }
                                    else
                                    {
                                        var temp = ChangeType(val, p.PropertyType);
                                        if (val != null)
                                            p.SetValue(obj, temp, null);
                                    }

                                    //if (p.PropertyType.Name == "DateTime")
                                    //{
                                    //    var temp =  Convert.ChangeType(val, p.PropertyType,VnCul);
                                    //    p.SetValue(obj, temp, null);
                                    //}
                                    //else
                                    //{
                                    //    var temp = (val == null) ? null : Convert.ChangeType(val, p.PropertyType);
                                    //    p.SetValue(obj, temp, null);
                                    //}
                                }
                            }
                        }
                    }
                }
            }
        }
        private static object ChangeType(object obj, Type t)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(obj.ToString()))
                {
                    if (t == typeof(int))
                    {
                        return (int)(0);
                    }
                    if (t == typeof(double))
                    {
                        return (double)(0);
                    }
                    if (t == typeof(decimal))
                    {
                        return (decimal)(0);
                    }
                    if (t == typeof(float))
                    {
                        return (float)(0);
                    }
                }
                if ((t == typeof(decimal) || t == typeof(Decimal)))
                {
                    return CurrencyUtility.ToDecimal(obj.ToString());
                }
                return Convert.ChangeType(obj, t);
            }
            catch
            {
                obj = "";
                return ChangeType(obj, t);
            }
        }
        public static Users GetUser(Deputy deputy)
        {
            Users user;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                user = uow.UsersRepository.Find(deputy.UserId);
                uow.Commit();
            }
            return user;
        }
        public static Users GetUser(SubSupplier subsupplier)
        {
            Users user;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                user = uow.UsersRepository.Find(subsupplier.UserId);
                uow.Commit();
            }
            return user;
        }
        public static T ConvertToType<T>(object obj)
        {
            //If you definitely know the type you want to return.
            return (T)Convert.ChangeType(obj, typeof(T));
        }
        /// <summary>
        /// range input
        /// </summary>
        /// <param name="ctrl"></param>










        //static 
        public static string GetSHA256Hash(string input)
        {
            if (String.IsNullOrEmpty(input))
                return String.Empty;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(input);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }



        //public static List<UserType> GetUserType()
        //{
        //    IDbConnection db = DbTmTech.DbCon;
        //    return db.Query<UserType>("Select * from UserType").ToList();
        //}



        public static bool WriteTheme(UserSetting setting)
        {
            string value = ConvertUserThemeToJson(setting);
            try
            {
                WriteToFile(themefile, value);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static string ConvertUserThemeToJson(UserSetting userTheme)
        {
            return JsonConvert.SerializeObject(userTheme, Formatting.None);
        }
        public static UserSetting DeserializeTheme()
        {
            string theme = ReadTheme();
            if (string.IsNullOrEmpty(theme)) return null;
            try
            {
                UserSetting stting = JsonConvert.DeserializeObject<UserSetting>(theme);
                return stting;
            }
            catch
            {
                return null;
            }
        }
        public static string ReadTheme()
        {
            return ReadFile(themefile);
        }
        public static string ConvertDbInfoToJson(DatabaseInfo dbInfo)
        {
            return JsonConvert.SerializeObject(dbInfo, Formatting.None);
        }
        
        public static bool WriteToFile(string fileName, string value)
        {
            string path = appDataDir + "\\" + fileName;
            if (!Directory.Exists(appDataDir))
            {
                Directory.CreateDirectory(appDataDir);
            }
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.Write(value);
            }
            return true;
        }
        public static string ReadFile(string fileName)
        {
            string path = appDataDir + "\\" + fileName;
            if (!File.Exists(path))
                return string.Empty;
            string s = string.Empty;
            using (StreamReader sr = new StreamReader(path))
            {
                s = sr.ReadToEnd();
            }
            return s;
        }
        public static bool WriteColumnToshow(List<string> lstValue)
        {
            string path = appDataDir + "\\" + columntoShowFile;
            if (!Directory.Exists(appDataDir))
            {
                Directory.CreateDirectory(appDataDir);
            }
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                foreach (string s in lstValue)
                {
                    sw.WriteLine(s);
                }
            }
            return true;
        }
        public static string[] ReadColumnToShow()
        {
            string path = appDataDir + "\\" + columntoShowFile;
            if (!File.Exists(path))
                return null;
            string[] readText = File.ReadAllLines(path);
            return readText;
        }
        public static bool IsValidEmailAddress(string s)
        {
            var regex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            return regex.IsMatch(s);
        }

        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
    }
}
