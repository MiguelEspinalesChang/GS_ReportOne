using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SegundaVista.Vistas.Cliente;

namespace SegundaVista.Mongo_Data
{
    public class Conexion
    {

        public MongoClient Client  {
            get; set;
            }

        public MongoDatabase DataBase
        {
            get; set;
        }

        public MongoServer Server
        {
            get; set;
        }

        public Conexion()
        {
            string connectionString = "mongodb://localhost";
            MongoClient cliente_constructor = new MongoClient(connectionString);
            MongoServer server_constructor = cliente_constructor.GetServer();
            MongoDatabase database_contructor = server_constructor.GetDatabase("GS_Report_one_DataBaseMongo");
            Client = cliente_constructor;
            DataBase = database_contructor;
            Server = server_constructor;
        }

        public MongoCollection ObtenerDocumento(string nombre)
        {




            return null;
        }

        

    }
}
