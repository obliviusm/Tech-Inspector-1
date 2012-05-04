using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Drawing;

namespace lol2
{
    public static class GeneralContentManager
    {
        public static Dictionary<string, string> GlobalSettings = new Dictionary<string, string>();
        public static Icon defaultIcon;

        public static System.Data.DataRow user;
        public static System.Data.DataRow get()
        {
            return user;
        }
        public static void set(System.Data.DataRow userDataRow)
        {
            user = userDataRow;
        }
        public static string getUserId()
        {
            return user["user_id"].ToString();
        }
        public static string getUserName()
        {
            return user["user_name"].ToString();
        }
        public static int getRoleId()
        {
            return int.Parse( user["role_id"].ToString() );
        }
        public static string getPass()
        {
            return user["password"].ToString();
        }
        public static string getRoleName()
        { 
            int role_id = getRoleId();
            if (role_id == 1) return "Системний адміністратор";
            else if (role_id == 2) return "Оператор";
            else return "Користувач";
        }
        public static string EncodePass(string passwd)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(passwd);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = string.Empty;
            foreach (byte b in byteHash)
            {
                hash += string.Format("{0:x2}", b);
            }
            return hash;
        }

        public static void LoadGlobalSettings()
        {
            try
            {
                defaultIcon = new Icon(Path.GetFullPath(Properties.Settings.Default.DataFolder + "\\favicon.ico"));
            }
            catch (Exception e)
            { }
            try
            {
                TextReader reader = new StreamReader(Path.GetFullPath(Properties.Settings.Default.DataFolder + "/settings.ini"), Encoding.UTF8);
                string currentSetting = reader.ReadLine();
                while (currentSetting != null)
                {
                    try
                    {
                        string[] keyVal;
                        keyVal = currentSetting.Split('=');
                        GlobalSettings.Add(keyVal[0], keyVal[1]);
                        currentSetting = reader.ReadLine();
                    }
                    catch (Exception e)
                    {
                        currentSetting = reader.ReadLine();
                    }
                }
                reader.Close();
            }
            catch (Exception e)
            { }
        }

        public static void SaveGlobalSettings()
        {
            try
            {
                TextWriter writer = new StreamWriter(Path.GetFullPath(Properties.Settings.Default.DataFolder + "/settings.ini"), false, Encoding.UTF8);
                foreach (string key in GlobalSettings.Keys)
                    writer.WriteLine(key + "=" + GlobalSettings[key]);
                writer.Close();
            }
            catch (Exception e)
            { }
        }

        public static void ClearTempFolder()
        {
            try
            {
                foreach (string filePath in Directory.GetFiles(Path.GetFullPath(Properties.Settings.Default.TempFolder) + "/"))
                    File.Delete(filePath);
            }
            catch (Exception e)
            { }
        }
    }
}
