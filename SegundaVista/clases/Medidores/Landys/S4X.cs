using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaVista.clases.Medidores.Landys
{
    class S4X
    {
        public int IdRegistro { get; set; }          //id del registro
        public DateTime Time { get; set; }           //fecha 
        public string Status { get; set; }           //status
        public string Modelo { get; set; }

        public decimal TotalkWh { get; set; }        //total kiloWatsHora     ( Del - Rec)           [Total kWh]
        public decimal KwhRec { get; set; }          //kiloWatsHora recividos (rec - positivo)       [Rec.kWh]
        public decimal KwhDel { get; set; }          //kiloWatsHora enviados  (del - Negativo)       [Del. kWh]

        public decimal TotalkVARh { get; set; }      //total kiloVarHora                             [Total kVARh]
        public decimal kVARhRec { get; set; }        //kiloVarHora  recividos (rec - positivo)       [Rec. kVARh]
        public decimal kVARhDel { get; set; }        //kiloVarHora  enviados  (del - Negativo)       [Del. kVARh]

        public decimal TotalkW { get; set; }         //total Kilowhats                               [Total kW]
        public decimal kWRec { get; set; }           //kilowhats recividos    (rec - positivo)       [ Rec. kW ]
        public decimal kWDel { get; set; }           //kilowhts enviados      (del - Negativo)       [ Del. kW]

        public decimal kVAhrms { get; set; }         //                                              [kVAh rms]
        public decimal kVAhREc { get; set; }         //kva          recividos (rec - positivo)       [Rec. kVAh]
        public decimal kVAhDel { get; set; }         //kva          enviados  (del - Negativo)       [Del. kVAh]

        public decimal Va { get; set; }              //voltaje en a                                  [Va]
        public decimal Vb { get; set; }              //voltaje en b                                  [Vb]
        public decimal Vc { get; set; }              //voltaje en c                                  [Vc]

        public decimal Ia { get; set; }              //intencidad en a                               [Ia]
        public decimal Ib { get; set; }              //intencidad en b                               [Ib]
        public decimal Ic { get; set; }              //intencidad en c                               [Ic]

        public decimal Pa { get; set; }              //potencia en a                                 [Pa]
        public decimal Pb { get; set; }              //potencia en b                                 [Pb]
        public decimal Pc { get; set; }              //potencia en c                                 [Pc]

        public decimal Frequency { get; set; }       //frecuencia                                    [Frequency]
        public decimal Pftot { get; set; }           //factor                                        [Pftot]
    }
}
