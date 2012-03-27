using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace lol2
{
    public static class DatabaseManager
    {
        #region Declarations
        
        static MongoServer server;
        static MongoDatabase database;

        #endregion
        #region Public Methods
        
        public static void Initialize(string db_name)
        {
            server = MongoServer.Create(); // connect to localhost
            database = server[db_name];
        }
        public static MongoCollection<BsonDocument> GetDataCollection(string colection_name)
        {
            return database.GetCollection<BsonDocument>(colection_name);
        }

        #endregion
    }
}
