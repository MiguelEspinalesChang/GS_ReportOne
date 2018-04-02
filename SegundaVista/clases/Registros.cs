using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaVista.clases
{
    class Registros
    {
        public int IdRegistro { get; set; }          //id del registro
        public DateTime Time { get; set; }           //fecha 
        public string Status { get; set; }           //status
        public string Modelo { get; set; }

        public decimal TotalkWh { get; set; }        //total kiloWatsHora     ( Del - Rec)
        public decimal KwhRec { get; set; }          //kiloWatsHora recividos (rec - positivo)
        public decimal KwhDel { get; set; }          //kiloWatsHora enviados  (del - Negativo)
        public decimal KwhRec_Rol { get; set; }      //kiloWatsHora recividos que muestra en pantalla el medidor 
        public decimal KwhDel_Rol { get; set; }      //kiloWatsHora enviados que muestra en pantalla el medidor 
        public decimal TotalKwh_Rol { get; set; }    //total kiloWatsHora enviados que muestra en pantalla el medidor / Demanda

        public decimal TotalkVARh { get; set; }      //total kiloVarHora
        public decimal kVARhRec { get; set; }        //kiloVarHora  recividos (rec - positivo)
        public decimal kVARhDel { get; set; }        //kiloVarHora  enviados  (del - Negativo)
        public decimal kVARhRec_Rol { get; set; }    //recivido kiloVarHora   (rec - positivo) mostrados en pantalla
        public decimal kVARhDel_Rol { get; set; }    //recivido kiloVarHora   (del - Negativo) mostrados en pantalla

        // los Kva son el 0.8% mas que los kwh
        public decimal kVAhrms { get; set; }         //
        public decimal kVAhREc { get; set; }         //kva          recividos (rec - positivo)
        public decimal kVAhDel { get; set; }         //kva          enviados  (del - Negativo)
        public decimal kVAh { get; set; }            //kva por hora

        public decimal TotalkW { get; set; }         //total Kilowhats
        public decimal kWRec { get; set; }           //kilowhats recividos    (rec - positivo)
        public decimal kWDel { get; set; }           //kilowhts enviados      (del - Negativo)

        //el voltaje puede venir en tres Fases
        public decimal Va { get; set; }              //voltaje en a
        public decimal Vb { get; set; }              //voltaje en b
        public decimal Vc { get; set; }              //voltaje en c

        public decimal Ia { get; set; }              //intencidad en a
        public decimal Ib { get; set; }              //intencidad en b
        public decimal Ic { get; set; }              //intencidad en c

        public decimal Pa { get; set; }              //potencia en a
        public decimal Pb { get; set; }              //potencia en b
        public decimal Pc { get; set; }              //potencia en c 

        public decimal Pfavanz { get; set; }        
        public decimal Pfretras { get; set; }

        public decimal Frequency { get; set; }       //frecuencia
        public decimal Pftot { get; set; }           //factor

        //datos calculados

        public decimal TotalkWh_A { get; set; }        //total kiloWatsHora   A  ( Del - Rec)
        public decimal KwhRec_A { get; set; }
        public decimal KwhDel_A { get; set; }
        public decimal KwhRec_Rol_A { get; set; }
        public decimal KwhDel_Rol_A { get; set; }

        public decimal TotalkVAh_A { get; set; }
        public decimal kVARhRec_A { get; set; }
        public decimal kVARhDel_A { get; set; }
        public decimal kVARhRec_Rol_A { get; set; }
        public decimal kVARhDel_Rol_A { get; set; }

        // A Balle

        public decimal TotalkW_A { get; set; }
        public decimal kWRec_A { get; set; }           //kilowhats recividos  A  (rec - positivo) 
        public decimal kWDel_A { get; set; }           //b es punta y la suma es llano

        public decimal Va_A { get; set; }              //voltaje en a 
        public decimal Vb_A { get; set; }              //voltaje en b
        public decimal Vc_A { get; set; }              //voltaje en c

        public decimal Ia_A { get; set; }              //intencidad en a
        public decimal Ib_A { get; set; }              //intencidad en b
        public decimal Ic_a{ get; set; }               //intencidad en c

        public decimal Pa_A { get; set; }              //potencia en a
        public decimal Pb_A { get; set; }              //potencia en b
        public decimal Pc_A { get; set; }

        public decimal Frequency_A { get; set; }
        public decimal Pftot_A { get; set; }

        // B Punta 

        public decimal TotalkW_B { get; set; }
        public decimal kWRec_B { get; set; }           //kilowhats recividos  B  (rec - positivo) 
        public decimal kWDel_B { get; set; }           //la suma es llano

        public decimal Va_B { get; set; }              //voltaje en a 
        public decimal Vb_B { get; set; }              //voltaje en b
        public decimal Vc_B { get; set; }              //voltaje en c

        public decimal Ia_B { get; set; }              //intencidad en a
        public decimal Ib_B { get; set; }              //intencidad en b
        public decimal Ic_B { get; set; }               //intencidad en c

        public decimal Pa_B { get; set; }              //potencia en a
        public decimal Pb_B { get; set; }              //potencia en b
        public decimal Pc_B { get; set; }

        public decimal Frequency_B { get; set; }
        public decimal Pftot_B { get; set; }
    }
}
