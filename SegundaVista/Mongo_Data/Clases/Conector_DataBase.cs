using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
//filtrar los ducumetos
using System.ComponentModel;
using MongoDB.Driver.Linq;
using SegundaVista.Vistas;
using SegundaVista.clases;

namespace SegundaVista.Mongo_Data.Clases
{
    class Conector_DataBase
    {
        private static IMongoClient clienteLocal = new MongoClient(); //iniciar una instancia de un cliente con la libreria de mongo
        private static IMongoDatabase dataLocal = clienteLocal.GetDatabase("GS_Report_one_DataBaseMongo"); // conectar ala base de datos echa en monmgo 
       

        public void insertar_Cliete(string Nombre, string Apellido , string Nombre_Empresa, string Responsable_Medicion, string DirigirReporte_A ,string RazonSocial ,string Ruc, string NisCliente)
            // funcion para agregar Usuarios
        {
            //string id = ObjectId.GenerateNewId().ToString();
            var documento = new BsonDocument
            {
                /*{"_id",id},*/
                {"date_Loader",DateTime.Now},
                { "Nombre",Nombre},
                {"Apellido",Apellido},
                {"Nombre_Empresa",Nombre_Empresa},
                {"Responsable_Medicion",Responsable_Medicion},
                {"DirigirReporte_A",DirigirReporte_A},
                {"RazonSocial",RazonSocial},
                {"Ruc",Ruc},
                {"NisCliente",NisCliente}
            };
            var collection_ = dataLocal.GetCollection<BsonDocument>("Usuarios");
            collection_.InsertOneAsync(documento);
        }
        public void insertar_Medidor()
        {


        }



        public void Buscar_Cliente(string id)
        {
            var collection_ = dataLocal.GetCollection<BsonDocument>("Usuarios");
            var filtro = Builders<BsonDocument>.Filter.Eq("_id", id);
            var datos = collection_.Find<BsonDocument>(filtro).FirstOrDefault();
            string nombre = datos["status"].ToString();

        }

       
       
    }
}



