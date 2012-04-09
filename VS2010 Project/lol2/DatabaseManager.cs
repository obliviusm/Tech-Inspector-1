using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace lol2
{
    public static class DatabaseManager
    {
        #region Declarations

        static MySqlConnection Connection;

        #endregion

        #region Public Methods
        
        public static void Initialize(string db_name)
        {
            string connStr = "server=localhost;user=root;database="+db_name+";port=3306;password=1111;";
            Connection = new MySqlConnection(connStr);
            Connection.Open();
        }

        #endregion
    }
}
