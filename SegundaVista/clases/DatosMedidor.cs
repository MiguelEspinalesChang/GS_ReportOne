using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaVista.clases
{
    class DatosMedidor
    {
        public int IdMedidor { get; set; }   // idMedidor
        public string DeviceID { get; set; } // nombre que del medidor
        public int SerialNumberm { get; set; } //numero de cerial del medidor
        public string UbicacionMedidor { get; set; }
        public float Kh { get; set; }             //Kilo What que marco el medidor
        public int IntervalLength { get; set; } 
        public int TransformerFactor { get; set; }
        public Boolean TransformerFactorApplied { get; set; }
        public int MeterMultiplier { get; set; }
        public Boolean MeterMultiplierApplied { get; set; }
        public int Ct { get; set; }
        public Boolean CTApplied { get; set; }
        public int Pt { get; set; }
        public Boolean PtApplied { get; set; }
        public int SagThreshold { get; set; }
        public int SwellTheshold { get; set; }
        public Boolean DayLightTime { get; set; }
        public Boolean PulseValues { get; set; }

    }
}
