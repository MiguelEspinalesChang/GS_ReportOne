using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaVista.clases.Medidores
{
    class NEXUS_orig
    {
        public int IdRegistro { get; set; }              //id del registro
        public DateTime Time { get; set; }               //fecha 
        public string Modelo { get; set; }

        public decimal KwhRec_Rol { get; set; }          //kiloWatsHora recividos (rec - positivo)                           [0_3_22412 / Energy +Wh (Q1 & Q4)]
        public decimal KwhDel_Rol { get; set; }          //kiloWatsHora enviados  (del - Negativo)                           [0_3_22417 / Energy -Wh (Q2 & Q3)]

        public decimal TotalkVARh { get; set; }          //                                                                  [0_3_21204 / Rolling Avg. VAR]

        public decimal kVARhRec_Rol { get; set; }       //recivido kiloVarHora   (rec - positivo) mostrados en pantalla      [0_3_22465 / Energy +VARh (Q1+Q2,Prim,Bin)]
        public decimal kVARhDel_Rol { get; set; }       //recivido kiloVarHora   (del - Negativo) mostrados en pantalla      [0_3_22466 / Energy -VARh (Q3+Q4,Prim,Bin)]

        public decimal TotalkW { get; set; }            //total Kilowhats                                                    [0_3_21205 / Rolling Avg. W]

        public decimal kVAh { get; set; }               //kva por hora                                                       [0_3_22464 / Energy Total Vah (Prim,Bin)]

        public decimal Va { get; set; }                //voltaje en a                                                        [0_3_20402 / High Speed Van]
        public decimal Vb { get; set; }                //voltaje en b                                                        [0_3_20403 / High Speed Vbn]
        public decimal Vc { get; set; }                //voltaje en c                                                        [0_3_20404 / High Speed Vcn]

        public decimal Pfavanz { get; set; }
        public decimal Pfretras { get; set; }

    }
}
