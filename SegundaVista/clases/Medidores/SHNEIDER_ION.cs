using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaVista.clases.Medidores
{
    class SHNEIDER_ION
    {
        public int IdRegistro { get; set; }          //id del registro
        public DateTime Time { get; set; }           //fecha 
        public string Modelo { get; set; }

        public decimal TotalkWh { get; set; }        //total kiloWatsHora     ( Del - Rec)                            [kWh del-rec]
        public decimal KwhRec { get; set; }          //kiloWatsHora recividos (rec - positivo)                        [kWh rec int]
        public decimal KwhDel { get; set; }          //kiloWatsHora enviados  (del - Negativo)                        [kWh del int]
        public decimal KwhRec_Rol { get; set; }      //kiloWatsHora recividos que muestra en pantalla el medidor      [kWh rec]
        public decimal KwhDel_Rol { get; set; }      //kiloWatsHora enviados que muestra en pantalla el medidor       [kWh del]

        public decimal TotalkVARh { get; set; }      //total kiloVarHora                                              [kVARh del-rec]   
        public decimal kVARhRec { get; set; }        //kiloVarHora  recividos (rec - positivo)                        [kVARh rec int]
        public decimal kVARhDel { get; set; }        //kiloVarHora  enviados  (del - Negativo)                        [kVARh del int]
        public decimal kVARhRec_Rol { get; set; }    //recivido kiloVarHora   (rec - positivo) mostrados en pantalla  [kVARh rec]
        public decimal kVARhDel_Rol { get; set; }    //recivido kiloVarHora   (del - Negativo) mostrados en pantalla  [kVARh del]

        public decimal TotalkW { get; set; }         //total Kilowhats                                                [kW del-rec]
    }
}
