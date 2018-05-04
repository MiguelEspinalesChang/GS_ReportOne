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

        // funcion para agregar Usuarios
        public void insertar_Cliete(string Nombre, string Apellido, string Nombre_Empresa, string Responsable_Medicion, string DirigirReporte_A, string RazonSocial, string Ruc, string NisCliente)
        {
            //string id = ObjectId.GenerateNewId().ToString();
            var documento = new BsonDocument
            {
                /*{"_id",id},*/
                {"date_Loader",DateTime.Now},
                {"Nombre",Nombre},
                {"Apellido",Apellido},
                {"Nombre_Empresa",Nombre_Empresa},
                {"Responsable_Medicion",Responsable_Medicion},
                {"DirigirReporte_A",DirigirReporte_A},
                {"RazonSocial",RazonSocial},
                {"Ruc",Ruc},
                {"NisCliente",NisCliente}
            };
            var collection_ = dataLocal.GetCollection<BsonDocument>("Clientes");
            collection_.InsertOneAsync(documento);
        }
        // funcion para agregar Medidores
        public void insertar_Medidor(DatosMedidor datosTxt)
        {
            var documento = new BsonDocument
           {
                {"date_Loader",DateTime.Now},
                {"NisCliente",datosTxt.Nis},
                {"Numero Medidor",datosTxt.Numero_Medidor},
                {"Nombre Medidor",datosTxt.Nombre_Medidor},
                {"Area",datosTxt.Area},
                {"DModo De Uso",datosTxt.Modo_Uso},
                {"Nombre Del Propietario",datosTxt.Nombre_Propietario},
                {"Ubicacion Del Medidor",datosTxt.Ubicacion},
                {"KWH punto Dia",datosTxt.KWH_Punto_dia},
                {"N° Grupo",datosTxt.Grupo},
                {"Pototencia punto Dia",datosTxt.Potencia_Punto_dia},
                {"Marca",datosTxt.Marca},
                {"Modelo",datosTxt.Modelo},
                {"Tipo",datosTxt.Tipo},
                {"Clase",datosTxt.clase},
                {"Presicion",datosTxt.Presicion},
                {"Codigo Del Fabricante",datosTxt.Codigo_fabricante},
                {"TC Primario",datosTxt.TC_Primario},
                {"TC Secundario",datosTxt.TC_secundario},
                {"Relacion TC",datosTxt.Relacion_TC},
                {"Tp Primario",datosTxt.TP_Primario},
                {"Tp Secundario",datosTxt.TP_secundario},
                {"Relacion Tp",datosTxt.Relacion_TP},
                {"N° Serie",datosTxt.Numero_Cerie},
                {"Ia punto",datosTxt.Ia_punto},
                {"Ib punto",datosTxt.Ib_punto},
                {"Ic punto",datosTxt.Ic_punto},
                {"Va punto",datosTxt.Va_punto},
                {"Vb punto",datosTxt.Vb_punto},
                {"Vc punto",datosTxt.Vc_punto},
                //comunicacion
                {"Eternet",datosTxt.Eternet},
                {"Eternet Operativo",datosTxt.Eternet_Operativo},
                {"Eternet NumeroIp",datosTxt.Eternet_NumeroIp},
                {"Modem",datosTxt.Modem},
                {"Modem Operativo",datosTxt.Modem_Operativo},
                {"Modem Telefono",datosTxt.Modem_Telefono},
                {"RS232",datosTxt.RS232},
                {"RS232 Operativo",datosTxt.RS232_Operativo},
                {"RS232 Id",datosTxt.RS232_Id},
                {"RS485",datosTxt.RS485},
                {"RS485 Operativo",datosTxt.RS485_Operativo},
                {"RS485 Id",datosTxt.RS485_Numero_Id},
                {"PuertoOptico",datosTxt.PuertoOptico},
                {"PuertoOptico Operativo",datosTxt.PuertoOptico_Operativo},
                {"infrarrojo",datosTxt.infrarrojo},
                {"infrarrojo Operativo",datosTxt.infrarrojo_Operativo},
                {"RadioFrecuencia",datosTxt.RadioFrecuencia},
                {"RadioFrecuencia Operativo",datosTxt.RadioFrecuencia_Operativo}
           };
            var collection_ = dataLocal.GetCollection<BsonDocument>("Medidor");
            collection_.InsertOneAsync(documento);
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



