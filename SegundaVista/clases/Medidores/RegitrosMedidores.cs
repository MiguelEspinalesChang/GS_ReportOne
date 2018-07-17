using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaVista.clases.Medidores
{
    public class RegitrosMedidores
    {
        //Datos del Medidor
        public ObjectId _id { get; set; }
        public String IdMedidor { get; set; }
        public string Nombre { get; set; }
        public string NumeroMedidor { get; set; }
        public DateTime date_Loader { get; set; }
        public DateTime Time { get; set; }    
        public string Status { get; set; }  
        //Datos de lo Registros del Csv

        //Neto
        public decimal TotalKwh { get; set; }
        public decimal Blo_TotalkWh{ get; set; }
        public decimal KwhRec { get; set; }        
        public decimal KwhDel { get; set; }
        public decimal Blo_KwhRec { get; set; }        
        public decimal Blo_KwhDel { get; set; }
        public decimal Total_kVARh { get; set; }
        public decimal kVARhRec { get; set; }
        public decimal kVARhDel { get; set; }
        public decimal Blo_kVARhRec { get; set; }
        public decimal Blo_kVARhDel { get; set; }
        public decimal Blo_Total_kVARh { get; set; }
        public decimal TotalkW { get; set; }
        public decimal Rec_kW { get; set; }
        public decimal Del_kW { get; set; }
        public decimal kVAhrms { get; set; }
        public decimal Rec_kVAh { get; set; }
        public decimal Del_kVAh { get; set; }
        public decimal kVAh { get; set; }
        public decimal Va { get; set; }
        public decimal Vb { get; set; }
        public decimal Vc { get; set; }
        public decimal Ia { get; set; }
        public decimal Ib { get; set; }
        public decimal Ic { get; set; }
        public decimal Pa { get; set; }
        public decimal Pb { get; set; }
        public decimal Pc { get; set; }
        public decimal Frequency { get; set; }
        public decimal Pftot { get; set; }
        public decimal Pfavanz { get; set; }
        public decimal Pfretras { get; set; }

        ////////////////////////////////////////////////////////

        public float L1Max { get; set; }
        public DateTime L1MAxdate { get; set; }
        public float L2Max { get; set; }
        public DateTime L2Maxdate { get; set; }
        public float L3Max { get; set; }
        public DateTime L3Maxdate { get; set; }

        ////////////////////////////////////////////////////////

        //Valle
        public decimal V_TotalKwh { get; set; }
        public decimal V_Blo_TotalkWh { get; set; }
        public decimal V_KwhRec { get; set; }
        public decimal V_KwhDel { get; set; }
        public decimal V_Blo_KwhRec { get; set; }
        public decimal V_Blo_KwhDel { get; set; }
        public decimal V_Total_kVARh { get; set; }
        public decimal V_kVARhRec { get; set; }
        public decimal V_kVARhDel { get; set; }
        public decimal V_Blo_kVARhRec { get; set; }
        public decimal V_Blo_kVARhDel { get; set; }
        public decimal V_Blo_Total_kVARh { get; set; }
        public decimal V_TotalkW { get; set; }
        public decimal V_Rec_kW { get; set; }
        public decimal V_Del_kW { get; set; }
        public decimal V_kVAhrms { get; set; }
        public decimal V_Rec_kVAh { get; set; }
        public decimal V_Del_kVAh { get; set; }
        public decimal V_kVAh { get; set; }
        public decimal V_Va { get; set; }
        public decimal V_Vb { get; set; }
        public decimal V_Vc { get; set; }
        public decimal V_Ia { get; set; }
        public decimal V_Ib { get; set; }
        public decimal V_Ic { get; set; }
        public decimal V_Pa { get; set; }
        public decimal V_Pb { get; set; }
        public decimal V_Pc { get; set; }
        public decimal V_Frequency { get; set; }
        public decimal V_Pftot { get; set; }

        //Punta
        public decimal P_TotalKwh { get; set; }
        public decimal P_Blo_TotalkWh { get; set; }
        public decimal P_KwhRec { get; set; }
        public decimal P_KwhDel { get; set; }
        public decimal P_Blo_KwhRec { get; set; }
        public decimal P_Blo_KwhDel { get; set; }
        public decimal P_Total_kVARh { get; set; }
        public decimal P_kVARhRec { get; set; }
        public decimal P_kVARhDel { get; set; }
        public decimal P_Blo_kVARhRec { get; set; }
        public decimal P_Blo_kVARhDel { get; set; }
        public decimal P_Blo_Total_kVARh { get; set; }
        public decimal P_TotalkW { get; set; }
        public decimal P_Rec_kW { get; set; }
        public decimal P_Del_kW { get; set; }
        public decimal P_kVAhrms { get; set; }
        public decimal P_Rec_kVAh { get; set; }
        public decimal P_Del_kVAh { get; set; }
        public decimal P_kVAh { get; set; }
        public decimal P_Va { get; set; }
        public decimal P_Vb { get; set; }
        public decimal P_Vc { get; set; }
        public decimal P_Ia { get; set; }
        public decimal P_Ib { get; set; }
        public decimal P_Ic { get; set; }
        public decimal P_Pa { get; set; }
        public decimal P_Pb { get; set; }
        public decimal P_Pc { get; set; }
        public decimal P_Frequency { get; set; }
        public decimal P_Pftot { get; set; }
    }
    public class DatosRegistro
    {
        //Voltaje Maximo
        public float L1Max { get; set; }
        public DateTime L1MAxdate { get; set; }
        public float L2Max { get; set; }
        public DateTime L2Maxdate { get; set; }
        public float L3Max { get; set; }
        public DateTime L3Maxdate { get; set; }
        //Neto
        public decimal Kwh { get; set; }
        public decimal Kvarh { get; set; }
        public decimal Kwd { get; set; }
        public decimal PF { get; set; }
        //Delevery 
        public decimal D_Kwh { get; set; }
        public decimal D_Kvarh { get; set; }
        public decimal D_Kwd { get; set; }
        public decimal D_PF { get; set; }
        //Recibido
        public decimal R_Kwh { get; set; }
        public decimal R_Kvarh { get; set; }
        public decimal R_Kwd { get; set; }
        public decimal R_PF { get; set; }
    }
}
