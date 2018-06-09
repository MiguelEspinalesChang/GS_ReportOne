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
        public DateTime L1MAxdate, L2Maxdate, L3Maxdate;
        private void btnAnlizarRangoFecha_Click(object sender, EventArgs e)
        {
            //Llano
            txtKwhLlano.Text = "";
            txtKvahrLlano.Text = "";
            txtKwdLlano.Text = "";
            txtFactorPotenciaLlano.Text = "";
            //punta
            txtKwhPunta.Text = "";
            txtKvahrPunta.Text = "";
            txtKwdPunta.Text = "";
            txtFactorPotenciaPunta.Text = "";
            //valle
            txtKwhValle.Text = "";
            txtKvahrValle.Text = "";
            txtKwdValle.Text = "";
            txtFactorPotenciaValle.Text = "";
            //Voltaje
            txtMaxL1.Text = "";
            txtFechaMaxL1.Text = "";

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
            //deliveri
            dbDatosPilot dpilotDelivey = new dbDatosPilot();

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

            decimal L1Max = 0, L2Max = 0, L3Max = 0;

            if (resutado == null || resutado.Count() < 1)
            {
                //HACER ALGO POR QUE NO HAY DATA
                pnlAlertaRojo.Visible = true;
                lblR.Text = "Error al Traer los datos";
            }
            else
            {
                //FUMADAS CON DATA
                foreach (var Datos in resutado.Select(x => x).FirstOrDefault())
                {
                    //Llano
                    dpilot.TotalkWh_del_Rec = dpilot.TotalkWh_del_Rec + Datos.TotalkWh_del_Rec;
                    dpilot.TotalkVARh = dpilot.TotalkVARh + Datos.TotalkVARh;
                    dpilot.TotalkW = dpilot.TotalkW + Datos.TotalkW;
                    //Llano Delivery
                    dpilotDelivey.KwhDel = dpilotDelivey.KwhDel + Datos.KwhDel;
                    dpilotDelivey.kVARhDel = dpilotDelivey.kVARhDel + Datos.kVARhDel;
                    dpilotDelivey.Del_kW = dpilotDelivey.Del_kW + Datos.Del_kW;

                    if (Datos.Time.Hour > 18 && Datos.Time.Hour < 20)
                    {
                        //punta
                        dpilotPunta.TotalkWh_del_Rec = dpilotPunta.TotalkWh_del_Rec + Datos.TotalkWh_del_Rec;
                        dpilotPunta.TotalkVARh = dpilotPunta.TotalkVARh + Datos.TotalkVARh;
                        dpilotPunta.TotalkW = dpilotPunta.TotalkW + Datos.TotalkW;

                    }
                    else
                    {
                        //Valle
                        dpilotValle.TotalkWh_del_Rec = dpilotValle.TotalkWh_del_Rec + Datos.TotalkWh_del_Rec;
                        dpilotValle.TotalkVARh = dpilotValle.TotalkVARh + Datos.TotalkVARh;
                        dpilotValle.TotalkW = dpilotValle.TotalkW + Datos.TotalkW;


                    }
                    //Enviado
                    //dpilot.

                    if (L1Max < Datos.Va)
                    {
                        L1Max = Datos.Va;
                        L1MAxdate = Datos.Time;
                    }
                    if (L2Max < Datos.Vb)
                    {
                        L2Max = Datos.Vb;
                        L2Maxdate = Datos.Time;
                    }
                    if (L3Max < Datos.Vc)
                    {

                        L3Max = Datos.Vc;
                        L3Maxdate = Datos.Time;
                    }

                }
                //Llano
                dpilot.Pftot = (dpilot.TotalkVARh == 0) ? 0 : Convert.ToDecimal(Math.Cos(Math.Atan(Convert.ToSingle(dpilot.TotalkVARh / dpilot.TotalkWh_del_Rec))));
                txtKwhLlano.Text = dpilot.TotalkWh_del_Rec + "";
                txtKvahrLlano.Text = dpilot.TotalkVARh + "";
                txtKwdLlano.Text = dpilot.TotalkW + "";
                txtFactorPotenciaLlano.Text = dpilot.Pftot + "";
                //Lano delivery
                dpilotDelivey.Pftot = (dpilotDelivey.KwhDel == 0) ? 0 : Convert.ToDecimal(Math.Cos(Math.Atan(Convert.ToSingle(dpilotDelivey.kVARhDel / dpilotDelivey.KwhDel))));
                txtKwhLlanoD.Text = dpilotDelivey.KwhDel + "";
                txtKvarhLlanoD.Text = dpilotDelivey.kVARhDel + "";
                txtKwdLlanoD.Text = dpilotDelivey.Del_kW + "";
                txtPfLlanoD.Text = dpilotDelivey.Pftot + "";
                //punta
                dpilotPunta.Pftot = (dpilotPunta.TotalkVARh == 0) ? 0 : Convert.ToDecimal(Math.Cos(Math.Atan(Convert.ToSingle(dpilotPunta.TotalkVARh / dpilotPunta.TotalkWh_del_Rec))));
                txtKwhPunta.Text = dpilotPunta.TotalkWh_del_Rec + "";
                txtKvahrPunta.Text = dpilotPunta.TotalkVARh + "";
                txtKwdPunta.Text = dpilotPunta.TotalkW + "";
                txtFactorPotenciaPunta.Text = dpilotPunta.Pftot + "";
                //valle
                dpilotValle.Pftot = (dpilotValle.TotalkVARh == 0) ? 0 : Convert.ToDecimal(Math.Cos(Math.Atan(Convert.ToSingle(dpilotValle.TotalkVARh / dpilotValle.TotalkWh_del_Rec))));
                txtKwhValle.Text = dpilotValle.TotalkWh_del_Rec + "";
                txtKvahrValle.Text = dpilotValle.TotalkVARh + "";
                txtKwdValle.Text = dpilotValle.TotalkW + "";
                txtFactorPotenciaValle.Text = dpilotValle.Pftot + "";
                //Voltaje
                txtMaxL1.Text = L1Max + "";
                txtFechaMaxL1.Text = L1MAxdate + "";
                txtMaxL2.Text = L2Max + "";
                txtFechaMaxL2.Text = L2Maxdate + "";
                txtMaxL3.Text = L3Max + "";
                txtFechaMaxL3.Text = L3Maxdate + "";
            }
        }

        private void tabDelivery_Click(object sender, EventArgs e)
        {

        }
    }
}
