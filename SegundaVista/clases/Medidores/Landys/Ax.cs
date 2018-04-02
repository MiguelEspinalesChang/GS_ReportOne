using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaVista.clases.Medidores.Landys
{
    class Ax
    {
        public int IdRegistro { get; set; }          //id del registro
        public DateTime Time { get; set; }           //fecha 
        public string Status { get; set; }           //status
        public string Modelo { get; set; }

        public decimal KwhRec { get; set; }          //kiloWatsHora recividos (rec - positivo)  [Negative kWh]
        public decimal KwhDel { get; set; }          //kiloWatsHora enviados  (del - Negativo)  [kWh]

        public decimal Va { get; set; }              //voltaje en a                             [Va]
        public decimal Vb { get; set; }              //voltaje en b                             [Vb]
        public decimal Vc { get; set; }              //voltaje en c                             [Vc]

        public decimal Ia { get; set; }              //intencidad en a                          [Ia]
        public decimal Ib { get; set; }              //intencidad en b                          [Ib]
        public decimal Ic { get; set; }              //intencidad en c                          [Ic]
    }
}
