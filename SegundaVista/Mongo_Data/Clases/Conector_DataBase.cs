using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace SegundaVista.Mongo_Data.Clases
{
    class Conector_DataBase
    {
        private static IMongoClient clienteLocal = new MongoClient();
        private static IMongoDatabase dataLocal = clienteLocal.GetDatabase("mitienda");

        public void insertar(string Nombre, string Edad)
        {
            string id = ObjectId.GenerateNewId().ToString();
            var documento = new BsonDocument
            {
                 {"_id",id},{"Nombre",Nombre},{"date", DateTime.Now},
                 { "Edad",  Edad}
            };
            var collection_ = dataLocal.GetCollection<BsonDocument>("Usuario");
            collection_.InsertOneAsync(documento);
        }

    }
}



