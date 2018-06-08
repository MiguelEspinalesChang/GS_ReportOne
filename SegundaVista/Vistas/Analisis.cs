using SegundaVista.Mongo_Data.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using SegundaVista.clases.Medidores;
using SegundaVista.Mongo_Data;
using MongoDB;
using MongoDB.Driver.Linq;
using MongoDB.Driver;

namespace SegundaVista.Vistas
{
    public partial class Analisis : Form
    {
        public Analisis()
        {
            InitializeComponent();
        }


        private Conexion MongoConexion = new Conexion();
        private void Analisis_Load(object sender, EventArgs e)
        {
            pnlAlerta.Visible = true;
            pnlAlertaVerde.Visible = false;
            pnlAlertaRojo.Visible = false;
            CbHoraInicialRegistro.SelectedIndex = 0;
            CbMinutoInicialRegistro.SelectedIndex = 1;
            CbHoraFinalRegistro.SelectedIndex = 0;
            CbMinutoFinalRegistro.SelectedIndex = 1;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarAlertaR_Click(object sender, EventArgs e)
        {
            pnlAlertaVerde.Visible = false;
        }

        private void btnCerrarAlertaV_Click(object sender, EventArgs e)
        {
            pnlAlertaVerde.Visible = false;
        }

        public int CantidadDias;


        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDatosRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabDatosNeto_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        public DateTime L1MAxdate;
        private void btnAnlizarRangoFecha_Click(object sender, EventArgs e)
        {
            //Valores de Fecha para la consulta
            //Fecha Inicial
            DateTime fechaInicial = dtFechaInicalRegistro.Value.Date;
            DateTime horaInicial = Convert.ToDateTime(CbHoraInicialRegistro.Text + ":" + CbMinutoInicialRegistro.Text + ":" + "00");
            DateTime FechaInicialRegistro = fechaInicial.AddHours(horaInicial.Hour).AddMinutes(horaInicial.Minute).AddSeconds(horaInicial.Second);
            //Fecha Final
            DateTime fechaFinal = dtFechaFinalRegistro.Value.Date;
            DateTime horaFinal = Convert.ToDateTime(CbHoraFinalRegistro.Text + ":" + CbMinutoFinalRegistro.Text + ":" + "00");
            DateTime FechaFinalRegistro = fechaFinal.AddHours(horaFinal.Hour).AddMinutes(horaFinal.Minute).AddSeconds(horaFinal.Second);

            CantidadDias = 0;
            for (DateTime i = FechaInicialRegistro; i <= FechaFinalRegistro; i = i.AddDays(1))
            {
                CantidadDias++;
            }
            txtCantidadDias.Text = "" + CantidadDias;
            // PilotDB pilot = new PilotDB();
            dbDatosPilot dpilot = new dbDatosPilot();
            dbDatosPilot dpilotValle = new dbDatosPilot();
            dbDatosPilot dpilotPunta = new dbDatosPilot();
            Conector_DataBase conector = new Conector_DataBase();

            var DocumentoRegistro = MongoConexion.DataBase.GetCollection<PilotDB>("Datos");


            //Linq
            //version Pro
            //var resutado = from d in DocumentoRegistro.FindAll()
            //               where d.NumeroMedidor == txtNumeroMedidor.Text
            //               /*&& d.Regitros["Time"] == */
            //               select d.Regitros.Select(x=>x)
            //               .Where(x=>x.Time >= FechaInicialRegistro 
            //               && x.Time <= FechaFinalRegistro).OrderByDescending(x=>x.Time).ToList();

            var resutado = from d in DocumentoRegistro.FindAll()
                           where d.NumeroMedidor == txtNumeroMedidor.Text
                           select (
                                from otraVariableInventada in d.Regitros
                                where otraVariableInventada.Time >= FechaInicialRegistro
                                && otraVariableInventada.Time <= FechaFinalRegistro
                                orderby otraVariableInventada.Time descending
                                select otraVariableInventada
                                ).ToList();//.FirstOrDefault();

            if (resutado == null || resutado.Count() < 1)
            {
                //HACER ALGO POR QUE NO HAY DATA
            }
            else
            {
                //FUMADAS CON DATA



            }

            decimal L1Max = 0;
            foreach (var Datos in resutado.Select(x => x).FirstOrDefault())
            {
                //Llano
                dpilot.TotalkWh_del_Rec = dpilot.TotalkWh_del_Rec + Datos.TotalkWh_del_Rec;
                dpilot.TotalkVARh = dpilot.TotalkVARh + Datos.TotalkVARh;
                dpilot.TotalkW = dpilot.TotalkW + Datos.TotalkW;
                dpilot.Pftot = dpilot.Pftot + Datos.Pftot;
                if (Datos.Time.Hour > 18 && Datos.Time.Hour < 20)
                {
                    //punta
                    dpilotPunta.TotalkWh_del_Rec = dpilotPunta.TotalkWh_del_Rec + Datos.TotalkWh_del_Rec;
                    dpilotPunta.TotalkVARh = dpilotPunta.TotalkVARh + Datos.TotalkVARh;
                    dpilotPunta.TotalkW = dpilotPunta.TotalkW + Datos.TotalkW;
                    dpilotPunta.Pftot = dpilotPunta.Pftot + Datos.TotalkW;
                }
                else
                {
                    //Valle
                    dpilotValle.TotalkWh_del_Rec = dpilotValle.TotalkWh_del_Rec + Datos.TotalkWh_del_Rec;
                    dpilotValle.TotalkVARh = dpilotValle.TotalkVARh + Datos.TotalkVARh;
                    dpilotValle.TotalkW = dpilotValle.TotalkW + Datos.TotalkW;
                    dpilotValle.Pftot = dpilotValle.Pftot + Datos.Pftot;

                }
                if (L1Max < Datos.Ia)
                {
                    L1Max = Datos.Ia;
                    L1MAxdate = Datos.Time;
                }


            }
            //Llano
            txtKwhLlano.Text = dpilot.TotalkWh_del_Rec + "";
            txtKvahrLlano.Text = dpilot.TotalkVARh + "";
            txtKwdLlano.Text = dpilot.TotalkW + "";
            txtFactorPotenciaLlano.Text = dpilot.Pftot + "";
            //punta
            txtKwhPunta.Text = dpilotPunta.TotalkWh_del_Rec + "";
            txtKvahrPunta.Text = dpilotPunta.TotalkVARh + "";
            txtKwdPunta.Text = dpilotPunta.TotalkW + "";
            txtFactorPotenciaPunta.Text = dpilotPunta.Pftot + "";
            //valle
            txtKwhValle.Text = dpilotValle.TotalkWh_del_Rec + "";
            txtKvahrValle.Text = dpilotValle.TotalkVARh + "";
            txtKwdValle.Text = dpilotValle.TotalkW + "";
            txtFactorPotenciaValle.Text = dpilotValle.Pftot + "";
            //Voltaje
            txtMaxL1.Text = L1Max + "";
            txtFechaMaxL1.Text = L1MAxdate  + "";
        }
    }
}
