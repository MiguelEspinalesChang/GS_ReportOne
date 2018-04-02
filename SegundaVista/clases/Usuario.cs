using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaVista.clases
{
    class Usuario
    {
        public int IdUsuario_MongoDB { get; set; }
        public int Id { get; set; }
        public int Pass { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Cargo { get; set; }
    }
}
