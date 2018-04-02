using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaVista.clases
{
    class Clientee
    {
        public int IdCliente_MongoDB { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nombre_Empresa { get; set; }
        public string RazonSocial { get; set; }
        public string Ruc { get; set; }
        public string Responsable_Medicion { get; set; }
        public string DirigirReporte_A { get; set; }
        public string NisCliente { get; set;  }
    }
}
