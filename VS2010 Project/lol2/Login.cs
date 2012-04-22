using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lol2
{
    class Login
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
        public static string getRoleId()
        {
            return user["role_id"].ToString();
        }
        public static string getPass()
        {
            return user["password"].ToString();
        }
        public static string getRoleName()
        { 
            string role_id = getRoleId();
            if (role_id == "1") return "Системний адміністратор";
            else if (role_id == "2") return "Оператор";
            else return "Користувач";
        }
    }
}
