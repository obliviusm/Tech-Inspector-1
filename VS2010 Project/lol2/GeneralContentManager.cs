using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace lol2
{
    class GeneralContentManager
    {
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
    }
}
