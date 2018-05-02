using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace SegundaVista.clases
{
    public class DatosMedidor
    {
        public ObjectId ObjectId_Medidor { get; set; }
        public string Nis { get; set; }
        public string Numero_Medidor { get; set; }
        public string Nombre_Medidor { get; set; }
        public string Modo_Uso { get; set; }
        public string Grupo { get; set; }
        public string Area { get; set; }
        public string Nombre_Propietario { get; set; }
        public string Ubicacion { get; set; }
        public float KWH_Punto_dia { get; set; }
        public float Potencia_Punto_dia { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public int clase { get; set; }
        public float Presicion { get; set; }
        public string Codigo_fabricante { get; set; }
        public float TC_Primario { get; set; }
        public float TC_secundario { get; set; }
        public float Relacion_TC { get; set; }
        public float TP_Primario { get; set; }
        public float TP_secundario { get; set; }
        public float Relacion_TP { get; set; }
        public string Numero_Cerie { get; set; }
        public float Ia_punto { get; set; }
        public float Ib_punto { get; set; }
        public float Ic_punto { get; set; }
        public float Va_punto { get; set; }
        public float Vb_punto { get; set; }
        public float Vc_punto { get; set; }

        ///Datos de comunicacion

        public BsonBoolean Eternet { get; set; }
        public BsonBoolean Eternet_Operativo { get; set; }
        public string Eternet_NumeroIp { get; set; }

        public BsonBoolean Modem { get; set; }
        public BsonBoolean Modem_Operativo { get; set; }
        public string Modem_Telefono { get; set; }

        public BsonBoolean RS232 { get; set; }
        public BsonBoolean RS232_Operativo { get; set; }
        public string RS232_Id { get; set; }

        public BsonBoolean RS485 { get; set; }
        public BsonBoolean RS485_Operativo { get; set; }
        public string RS485_Numero_Id { get; set; }

        public BsonBoolean PuertoOptico { get; set; }
        public BsonBoolean PuertoOptico_Operativo { get; set; }

        public BsonBoolean infrarrojo { get; set; }
        public BsonBoolean infrarrojo_Operativo { get; set; }


        public BsonBoolean RadioFrecuencia { get; set; }
        public BsonBoolean RadioFrecuencia_Operativo { get; set; }

    }
}
