using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaVista.clases.Medidores
{
    public class PILOT
    {
     
        public DateTime Time { get; set; }           //fecha 
        //  public string Modelo { get; set; }
        public decimal Va { get; set; }              //voltaje en a                            [Ua/Uab(V)]
        public decimal Vb { get; set; }              //voltaje en b                            [Ub/Ubc(V)]
        public decimal Vc { get; set; }              //voltaje en c                            [Uc/Uca(V)]
        public decimal Ia { get; set; }              //intencidad en a                         [Ia(A)]
        public decimal Ib { get; set; }              //intencidad en b                         [Ib(A)]
        public decimal Ic { get; set; }              //intencidad en c                         [Ic(A)]
        public decimal Frequency { get; set; }       //frecuencia                              [F(Hz)]
        public decimal Pa { get; set; }              //potencia en a                           [Pa(kW)]
        public decimal Pb { get; set; }              //potencia en b                           [Pb(kW)]
        public decimal Pc { get; set; }              //potencia en c                           [Pc(kW)]
        public decimal TotalkW { get; set; }         //total Kilowhats                         [Ptot(kW)]
        public decimal Pftot { get; set; }           //factor                                  [PFtot]
        public decimal KwhRec { get; set; }          //kiloWatsHora recividos (rec - positivo) [KwhImp(kWh)]
        public decimal KwhDel { get; set; }          //kiloWatsHora enviados  (del - Negativo) [KwhExp(kWh)]
        public decimal kVARhDel { get; set; }        //kiloVarHora  enviados  (del - Negativo) [KvarhImp(kvarh)]
        public decimal kVARhRec { get; set; }        //kiloVarHora  recividos (rec - positivo) [KvarhExp(kvarh)]

        //Datos creados

        public decimal TotalkWh_del_Rec { get; set; }//  Kwh Del Int - Kwh Rec Int
        public decimal TotalkVARh { get; set; }      //  Del. kVARh Int - Rec. kVARh Int
        public decimal Rec_kW { get; set; }          // Kwh Rec Int * 4
        public decimal Del_kW { get; set; }          // Del. kW
        public decimal kVAh_rms { get; set; }        // Total kWh (del-Rec) * 0.8
        public decimal Rec_kVAh { get; set; }        // Kwh Rec Int * 0.8
        public decimal Del_kVAh { get; set; }        // Kwh Del Int * 0.8

    }

    public class PilotDB
    {
       public ObjectId _id { get; set; }            //
        public string id_pilot { get; set; }         //id del registro
        public string Nombre { get; set; }
       public string NumeroMedidor { get; set; }
       public string NombrePropietadio { get; set; }
       public string Marca { get; set; }
       public DateTime date_Loader { get; set; }    //Fecha de creacion del Registro
       //public List<dbDatosPilot> Regitros = new List<dbDatosPilot>();
       
    }
    //public class dbDatosPilot
    //{
    //    public DateTime Time { get; set; }           //fecha 
    //    //  public string Modelo { get; set; }
    //    public decimal Va { get; set; }              //voltaje en a                            [Ua/Uab(V)]
    //    public decimal Vb { get; set; }              //voltaje en b                            [Ub/Ubc(V)]
    //    public decimal Vc { get; set; }              //voltaje en c                            [Uc/Uca(V)]
    //    public decimal Ia { get; set; }              //intencidad en a                         [Ia(A)]
    //    public decimal Ib { get; set; }              //intencidad en b                         [Ib(A)]
    //    public decimal Ic { get; set; }              //intencidad en c                         [Ic(A)]
    //    public decimal Frequency { get; set; }       //frecuencia                              [F(Hz)]
    //    public decimal Pa { get; set; }              //potencia en a                           [Pa(kW)]
    //    public decimal Pb { get; set; }              //potencia en b                           [Pb(kW)]
    //    public decimal Pc { get; set; }              //potencia en c                           [Pc(kW)]
    //    public decimal TotalkW { get; set; }         //total Kilowhats                         [Ptot(kW)]
    //    public decimal Pftot { get; set; }           //factor                                  [PFtot]
    //    public decimal KwhRec { get; set; }          //kiloWatsHora recividos (rec - positivo) [KwhImp(kWh)]
    //    public decimal KwhDel { get; set; }          //kiloWatsHora enviados  (del - Negativo) [KwhExp(kWh)]
    //    public decimal kVARhDel { get; set; }        //kiloVarHora  enviados  (del - Negativo) [KvarhImp(kvarh)]
    //    public decimal kVARhRec { get; set; }        //kiloVarHora  recividos (rec - positivo) [KvarhExp(kvarh)]
    //    //Datos creados
    //    public decimal TotalkWh_del_Rec { get; set; }//  Kwh Del Int - Kwh Rec Int
    //    public decimal TotalkVARh { get; set; }      //  Del. kVARh Int - Rec. kVARh Int
    //    public decimal Rec_kW { get; set; }          // Kwh Rec Int * 4
    //    public decimal Del_kW { get; set; }          // Del. kW
    //    public decimal kVAh_rms { get; set; }        // Total kWh (del-Rec) * 0.8
    //    public decimal Rec_kVAh { get; set; }        // Kwh Rec Int * 0.8
    //    public decimal Del_kVAh { get; set; }        // Kwh Del Int * 0.8
    //}
    public class DatosPilot
    {
        public ObjectId _id { get; set; }            //
        public string id_pilot { get; set; }
        public string Nombre { get; set; }
        public DateTime date_Loader { get; set; }
        public DateTime Time { get; set; }           //fecha 
        //  public string Modelo { get; set; }
        public decimal Va { get; set; }              //voltaje en a                            [Ua/Uab(V)]
        public decimal Vb { get; set; }              //voltaje en b                            [Ub/Ubc(V)]
        public decimal Vc { get; set; }              //voltaje en c                            [Uc/Uca(V)]
        public decimal Ia { get; set; }              //intencidad en a                         [Ia(A)]
        public decimal Ib { get; set; }              //intencidad en b                         [Ib(A)]
        public decimal Ic { get; set; }              //intencidad en c                         [Ic(A)]
        public decimal Frequency { get; set; }       //frecuencia                              [F(Hz)]
        public decimal Pa { get; set; }              //potencia en a                           [Pa(kW)]
        public decimal Pb { get; set; }              //potencia en b                           [Pb(kW)]
        public decimal Pc { get; set; }              //potencia en c                           [Pc(kW)]
        public decimal TotalkW { get; set; }         //total Kilowhats                         [Ptot(kW)]
        public decimal Pftot { get; set; }           //factor                                  [PFtot]
        public decimal KwhRec { get; set; }          //kiloWatsHora recividos (rec - positivo) [KwhImp(kWh)]
        public decimal KwhDel { get; set; }          //kiloWatsHora enviados  (del - Negativo) [KwhExp(kWh)]
        public decimal kVARhDel { get; set; }        //kiloVarHora  enviados  (del - Negativo) [KvarhImp(kvarh)]
        public decimal kVARhRec { get; set; }        //kiloVarHora  recividos (rec - positivo) [KvarhExp(kvarh)]
        //Datos creados
        public decimal TotalkWh_del_Rec { get; set; }//  Kwh Del Int - Kwh Rec Int
        public decimal TotalkVARh { get; set; }      //  Del. kVARh Int - Rec. kVARh Int
        public decimal Rec_kW { get; set; }          // Kwh Rec Int * 4
        public decimal Del_kW { get; set; }          // Del. kW
        public decimal kVAh_rms { get; set; }        // Total kWh (del-Rec) * 0.8
        public decimal Rec_kVAh { get; set; }        // Kwh Rec Int * 0.8
        public decimal Del_kVAh { get; set; }        // Kwh Del Int * 0.8
    }
}
