using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaVista.clases
{
    class Clientee
    {
        public ObjectId ObjectId_Cliente { get; set; }
        //public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime date_Loader { get; set; }
        public string Apellido { get; set; }
        public string Nombre_Empresa { get; set; }
        public string RazonSocial { get; set; }
        public string Ruc { get; set; }
        public string Responsable_Medicion { get; set; }
        public string DirigirReporte_A { get; set; }
        public string NisCliente { get; set;  }
    }

}
