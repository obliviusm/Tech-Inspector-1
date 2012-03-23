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
        static MongoServer server;
        static MongoDatabase database;
        public static MongoCollection EquipmentTypes { get; private set; }
        public static void Initialize(string db_name)
        {
            server = MongoServer.Create(); // connect to localhost
            database = server[db_name];
            EquipmentTypes = DatabaseManager.GetDataCollection("equipment_types");
        }
        public static MongoCollection<BsonDocument> GetDataCollection(string colection_name)
        {
            return database.GetCollection<BsonDocument>(colection_name);
        }
    }
}
