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
using SegundaVista.clases.Medidores;

namespace SegundaVista.Mongo_Data.Clases
{
    class Conector_DataBase
    {
        private static IMongoClient clienteLocal = new MongoClient(); //iniciar una instancia de un cliente con la libreria de mongo
        private static IMongoDatabase dataLocal = clienteLocal.GetDatabase("GS_Report_one_DataBaseMongo"); // conectar ala base de datos echa en monmgo 

        // funcion para agregar Usuarios
        public void insertar_Cliete(string Nombre, string Apellido, string Nombre_Empresa, string Responsable_Medicion, string DirigirReporte_A, string RazonSocial, string Ruc, string NisCliente)
        {
            string id = ObjectId.GenerateNewId().ToString();
            var documento = new BsonDocument
            {
                {"id_cliente",id},
                {"date_Loader",DateTime.Now},
                {"Nombre",Nombre},
                {"Apellido",Apellido},
                {"Nombre_Empresa",Nombre_Empresa},
                {"Responsable_Medicion",Responsable_Medicion},
                {"DirigirReporte_A",DirigirReporte_A},
                {"RazonSocial",RazonSocial},
                {"Ruc",Ruc},
                {"NisCliente",NisCliente},

            };
            var collection_ = dataLocal.GetCollection<BsonDocument>("Clientes");
            collection_.InsertOneAsync(documento);
        }
        // funcion para agregar Medidores
        public void insertar_Medidor(DatosMedidor datosTxt)
        {
            string DB_Inicio = "", DB_Final = "";
            string id = ObjectId.GenerateNewId().ToString();
            var documento = new BsonDocument
           {
                {"id_Medidor",id },
                {"date_Loader",DateTime.Now},
                {"DB_Inicio",DB_Inicio },
                {"DB_Final",DB_Final},
                {"NisCliente",datosTxt.Nis},
                {"Numero_Medidor",datosTxt.Numero_Medidor},
                {"Nombre_Medidor",datosTxt.Nombre_Medidor},
                {"Area",datosTxt.Area},
                {"Modo_De_Uso",datosTxt.Modo_Uso},
                {"Nombre_Del_Propietario",datosTxt.Nombre_Propietario},
                {"Ubicacion_Del_Medidor",datosTxt.Ubicacion},
                {"KWH_punto_Dia",datosTxt.KWH_Punto_dia},
                {"Grupo",datosTxt.Grupo},
                {"Pototencia_punto_Dia",datosTxt.Potencia_Punto_dia},
                {"Marca",datosTxt.Marca},
                {"Modelo",datosTxt.Modelo},
                {"Tipo",datosTxt.Tipo},
                {"Clase",datosTxt.clase},
                {"Presicion",datosTxt.Presicion},
                {"Codigo_Del_Fabricante",datosTxt.Codigo_fabricante},
                {"TC_Primario",datosTxt.TC_Primario},
                {"TC_Secundario",datosTxt.TC_secundario},
                {"Relacion_TC",datosTxt.Relacion_TC},
                {"Tp_Primario",datosTxt.TP_Primario},
                {"Tp_Secundario",datosTxt.TP_secundario},
                {"Relacion_Tp",datosTxt.Relacion_TP},
                {"Numero_Serie",datosTxt.Numero_Cerie},
                {"Ia_punto",datosTxt.Ia_punto},
                {"Ib_punto",datosTxt.Ib_punto},
                {"Ic_punto",datosTxt.Ic_punto},
                {"Va_punto",datosTxt.Va_punto},
                {"Vb_punto",datosTxt.Vb_punto},
                {"Vc_punto",datosTxt.Vc_punto},
                //comunicacion
                {"Eternet",datosTxt.Eternet},
                {"Eternet_Operativo",datosTxt.Eternet_Operativo},
                {"Eternet_NumeroIp",datosTxt.Eternet_NumeroIp},
                {"Modem",datosTxt.Modem},
                {"Modem_Operativo",datosTxt.Modem_Operativo},
                {"Modem_Telefono",datosTxt.Modem_Telefono},
                {"RS232",datosTxt.RS232},
                {"RS232_Operativo",datosTxt.RS232_Operativo},
                {"RS232_Id",datosTxt.RS232_Id},
                {"RS485",datosTxt.RS485},
                {"RS485_Operativo",datosTxt.RS485_Operativo},
                {"RS485_Id",datosTxt.RS485_Numero_Id},
                {"PuertoOptico",datosTxt.PuertoOptico},
                {"PuertoOptico_Operativo",datosTxt.PuertoOptico_Operativo},
                {"infrarrojo",datosTxt.infrarrojo},
                {"infrarrojo_Operativo",datosTxt.infrarrojo_Operativo},
                {"RadioFrecuencia",datosTxt.RadioFrecuencia},
                {"RadioFrecuencia_Operativo",datosTxt.RadioFrecuencia_Operativo}
           };
            var collection_ = dataLocal.GetCollection<BsonDocument>("Medidor");
            collection_.InsertOneAsync(documento);
        }
        public void insertarDatosPilot(PilotDB filaData)
        {
            string id = ObjectId.GenerateNewId().ToString();
            var documento = new BsonDocument
            {
                {"id_pilot",id},
                {"Marca",filaData.Marca},
                {"Nombre",filaData.Nombre},
                {"NumeroMedidor",filaData.NumeroMedidor},
                {"NombrePropietadio",filaData.NombrePropietadio},
                {"date_Loader",DateTime.Now}
            };
            var arreglo = new BsonArray();
            //Agregar Datos al Areglo de Registro de mongo

            foreach (var valor in filaData.Regitros)
            {
                var Registro = new BsonDocument
            {
                {"Time",valor.Time},
                {"Va", valor.Va},
                {"Vb", valor.Vb},
                {"Vc",valor.Vc},
                {"Ia",valor.Ia},
                {"Ib",valor.Ib},
                {"Ic",valor.Ic},
                {"Frequency",valor.Frequency},
                {"Pa",valor.Pa},
                {"Pb",valor.Pb},
                {"Pc",valor.Pc},
                {"TotalkW",valor.TotalkW},
                {"Pftot",valor.Pftot},
                {"KwhRec",valor.KwhRec},
                {"KwhDel",valor.KwhDel},
                {"kVARhDel",valor.kVARhDel},
                {"kVARhRec",valor.kVARhRec},
                {"TotalkWh_del_Rec",valor.TotalkWh_del_Rec},
                {"TotalkVARh",valor.TotalkVARh},
                {"Rec_kW",valor.Rec_kW},
                {"Del_kW",valor.Del_kW},
                {"kVAh_rms",valor.kVAh_rms},
                {"Rec_kVAh",valor.Rec_kVAh},
                {"Del_kVAh",valor.Del_kVAh}
            };
                arreglo.Add(Registro);
            }
            documento.Add("Regitros", arreglo);
            var collection_ = dataLocal.GetCollection<BsonDocument>("Datos");
            collection_.InsertOneAsync(documento);
        }



    }
}



