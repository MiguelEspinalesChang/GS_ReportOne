using SegundaVista.Mongo_Data.Clases;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SegundaVista.clases.Medidores;
using SegundaVista.Mongo_Data;
using MongoDB.Driver.Linq;
using MongoDB.Driver;
using SegundaVista.clases;
using PagedList;

namespace SegundaVista.Vistas
{
    public partial class Analisis : Form
    {
        public Analisis()
        {
            InitializeComponent();
        }
        ///agregar paginacion
        ///https://www.youtube.com/watch?v=L1wpQ_fKjVw
        public int numeroPagina = 1;

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
            pnlAlertaRojo.Visible = false;
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

        public void btnAnlizarRangoFecha_Click(object sender, EventArgs e)
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


            Conector_DataBase conector = new Conector_DataBase();

            var DocumentoRegistro = MongoConexion.DataBase.GetCollection<DatosPilot>("pilot");


            ////Linq
            var resutado = (from d in DocumentoRegistro.FindAll()
                            where (d.NumeroMedidor == txtNumeroMedidor.Text) &&
                            (d.Time >= FechaInicialRegistro && d.Time <= FechaFinalRegistro)
                            orderby d.Time ascending
                            select d).ToList();

            //var PRUEBA = (from d in DocumentoRegistro.FindAll()
            //                  where (d.NumeroMedidor == txtNumeroMedidor.Text)
            //                orderby d.Time ascending
            //                select d).ToList();



            // PilotDB pilot = new PilotDB();
            DatosPilot dpilot = new DatosPilot();
            DatosPilot dpilotValle = new DatosPilot();
            DatosPilot dpilotPunta = new DatosPilot();
            //deliveri
            DatosPilot dpilotDelivey = new DatosPilot();
            DatosPilot dpilotValleDelivey = new DatosPilot();
            DatosPilot dpilotPuntaDelivey = new DatosPilot();
            //recibido
            DatosPilot dpilotRecibido = new DatosPilot();
            DatosPilot dpilotValleRecibido = new DatosPilot();

            DatosRegistro DatosNeto = new DatosRegistro();
            DatosRegistro DatosValle = new DatosRegistro();
            DatosRegistro DatosPunta = new DatosRegistro();

            if (resutado == null || resutado.Count() < 1)
            {
                //HACER ALGO POR QUE NO HAY DATA
                pnlAlertaRojo.Visible = true;
                lblR.Text = "Rango de fecha invalido";
            }
            else
            {
                //FUMADAS CON DATA
                foreach (var Datos in resutado)
                {
                    //neto => Total de la sumatoria en valle y punta de los registros
                    DatosNeto.Kwh = DatosNeto.Kwh + Datos.Blo_TotalkWh_del_Rec;
                    DatosNeto.Kvarh = DatosNeto.Kvarh + Datos.Blo_TotalkVARh;
                    DatosNeto.Kwd = DatosNeto.Kwd + Datos.TotalkW;
                    // Total de los delivery
                    DatosNeto.D_Kwh = DatosNeto.D_Kwh + Datos.Blo_kVARhDel;
                    DatosNeto.D_Kvarh = DatosNeto.D_Kvarh + Datos.Blo_kVARhDel;
                    // total de los dados recibidos
                    DatosNeto.R_Kwh = DatosNeto.R_Kwh + Datos.Blo_KwhRec;
                    DatosNeto.R_Kvarh = DatosNeto.R_Kvarh + Datos.Blo_kVARhRec;

                    if (Datos.Time.Hour > 18 && Datos.Time.Hour < 20)
                    {
                        //punta
                        //neto
                        dpilotPunta.TotalkWh_del_Rec = dpilotPunta.TotalkWh_del_Rec + Datos.TotalkWh_del_Rec;
                        dpilotPunta.TotalkVARh = dpilotPunta.TotalkVARh + Datos.TotalkVARh;
                        dpilotPunta.TotalkW = dpilotPunta.TotalkW + Datos.TotalkW;


                        //delivey
                        dpilotPuntaDelivey.KwhDel = dpilotPuntaDelivey.KwhDel + Datos.KwhDel;
                        dpilotPuntaDelivey.kVARhDel = dpilotPuntaDelivey.kVARhDel + Datos.kVARhDel;
                        dpilotPuntaDelivey.Del_kW = dpilotPuntaDelivey.Del_kW + Datos.Del_kW;

                        //Resibido

                    }
                    else
                    {
                        //Valle
                        //Neto
                        dpilotValle.TotalkWh_del_Rec = dpilotValle.TotalkWh_del_Rec + Datos.TotalkWh_del_Rec;
                        dpilotValle.TotalkVARh = dpilotValle.TotalkVARh + Datos.TotalkVARh;
                        dpilotValle.TotalkW = dpilotValle.TotalkW + Datos.TotalkW;
                        //delivey
                        dpilotValleDelivey.KwhDel = dpilotValleDelivey.KwhDel + Datos.KwhDel;
                        dpilotValleDelivey.kVARhDel = dpilotValleDelivey.kVARhDel + Datos.kVARhDel;
                        dpilotValleDelivey.Del_kW = dpilotValleDelivey.Del_kW + Datos.Del_kW;
                        //Recibido
                        dpilotValleRecibido.KwhRec = dpilotValleRecibido.KwhRec + Datos.KwhRec;
                        dpilotValleRecibido.kVARhRec = dpilotValleRecibido.kVARhRec + Datos.kVARhRec;
                        dpilotValleRecibido.kVARhRec = dpilotValleRecibido.kVARhRec + Datos.kVARhRec;

                    }
                    //Enviado
                    //dpilot.

                    if (DatosNeto.L1Max < Convert.ToSingle(Datos.Va))
                    {
                        DatosNeto.L1Max = Convert.ToSingle(Datos.Va);
                        DatosNeto.L1MAxdate = Datos.Time;
                    }
                    if (DatosNeto.L2Max < Convert.ToSingle(Datos.Vb))
                    {
                        DatosNeto.L2Max = Convert.ToSingle(Datos.Vb);
                        DatosNeto.L2Maxdate = Datos.Time;
                    }
                    if (DatosNeto.L3Max < Convert.ToSingle(Datos.Vc))
                    {
                        DatosNeto.L3Max = Convert.ToSingle(Datos.Vc);
                        DatosNeto.L3Maxdate = Datos.Time;
                    }
                }
                DatosNeto.PF = (DatosNeto.Kwh == 0) ? 0 : Convert.ToDecimal(Math.Cos(Math.Atan(Convert.ToSingle(DatosNeto.Kvarh / DatosNeto.Kwh))));


                //Agregar los datos de la consulta a una tabla

                var bindingList = new BindingList<DatosPilot>(resutado);
                var source = new BindingSource(bindingList, null);
                gridDatosConsulta.Rows.Clear();
                gridDatosConsulta.DataSource = source;
                gridDatosConsulta.Refresh();

                ////Llano////////////////////////

                //dpilot.Pftot = 
                //txtKwhLlano.Text = dpilot.TotalkWh_del_Rec.ToString();
                //txtKvahrLlano.Text = dpilot.TotalkVARh.ToString();
                //txtKwdLlano.Text = dpilot.TotalkW.ToString();
                //txtFactorPotenciaLlano.Text = dpilot.Pftot.ToString();
                ////Lano delivery
                //dpilotDelivey.Pftot = (dpilotDelivey.KwhDel == 0) ? 0 : Convert.ToDecimal(Math.Cos(Math.Atan(Convert.ToSingle(dpilotDelivey.kVARhDel / dpilotDelivey.KwhDel))));
                //txtKwhLlanoD.Text = dpilotDelivey.KwhDel.ToString();
                //txtKvarhLlanoD.Text = dpilotDelivey.kVARhDel.ToString();
                //txtKwdLlanoD.Text = dpilotDelivey.Del_kW.ToString();
                //txtPfLlanoD.Text = dpilotDelivey.Pftot.ToString();
                ////Llano Recibido
                //dpilotRecibido.Pftot = (dpilotRecibido.KwhRec == 0) ? 0 : Convert.ToDecimal(Math.Cos(Math.Atan(Convert.ToSingle(dpilotRecibido.kVARhRec / dpilotRecibido.KwhRec))));
                //txtKwhLlanoR.Text = dpilotRecibido.KwhRec.ToString();
                //txtKvarhLlanoR.Text = dpilotRecibido.kVARhRec.ToString();
                //txtKwdLlanoR.Text = dpilotRecibido.Rec_kW.ToString();
                //txtPfLlanoR.Text = dpilotRecibido.Pftot.ToString();

                ////punta/////////////////


                //dpilotPunta.Pftot = (dpilotPunta.TotalkWh_del_Rec == 0) ? 0 : Convert.ToDecimal(Math.Cos(Math.Atan(Convert.ToSingle(dpilotPunta.TotalkVARh / dpilotPunta.TotalkWh_del_Rec))));
                //txtKwhPunta.Text = dpilotPunta.TotalkWh_del_Rec.ToString();
                //txtKvahrPunta.Text = dpilotPunta.TotalkVARh.ToString();
                //txtKwdPunta.Text = dpilotPunta.TotalkW.ToString();
                //txtFactorPotenciaPunta.Text = dpilotPunta.Pftot.ToString();
                ////Delivery
                //dpilotPuntaDelivey.Pftot = (dpilotPuntaDelivey.KwhDel == 0) ? 0 : Convert.ToDecimal(Math.Cos(Math.Atan(Convert.ToSingle(dpilotPuntaDelivey.kVARhDel / dpilotPuntaDelivey.KwhDel))));
                //txtKwhPuntaD.Text = dpilotPuntaDelivey.KwhDel.ToString();
                //txtKvarhPuntaD.Text = dpilotPuntaDelivey.kVARhDel.ToString();
                //txtKwdPuntaD.Text = dpilotPuntaDelivey.Del_kW.ToString();
                //txtPfPuntaD.Text = dpilotPuntaDelivey.Pftot.ToString();

                ////valle////////////

                ////netos///////
                //dpilotValle.Pftot = (dpilotValle.TotalkWh_del_Rec == 0) ? 0 : Convert.ToDecimal(Math.Cos(Math.Atan(Convert.ToSingle(dpilotValle.TotalkVARh / dpilotValle.TotalkWh_del_Rec))));
                //txtKwhValle.Text = dpilotValle.TotalkWh_del_Rec.ToString();
                //txtKvahrValle.Text = dpilotValle.TotalkVARh.ToString();
                //txtKwdValle.Text = dpilotValle.TotalkW.ToString();
                //txtFactorPotenciaValle.Text = dpilotValle.Pftot.ToString();
                ////Delivery
                //dpilotValleDelivey.Pftot = (dpilotValleDelivey.KwhDel == 0) ? 0 : Convert.ToDecimal(Math.Cos(Math.Atan(Convert.ToSingle(dpilotValleDelivey.kVARhDel / dpilotValleDelivey.KwhDel))));
                //txtKwhValleD.Text = dpilotValleDelivey.KwhDel.ToString();
                //txtKvarhValleD.Text = dpilotValleDelivey.kVARhDel.ToString();
                //txtKwdValleD.Text = dpilotValleDelivey.Del_kW.ToString();
                //txtPfValleD.Text = dpilotValleDelivey.Pftot.ToString();
                ////Recibido
                //txtKwhValleR.Text = dpilotValleRecibido.KwhRec.ToString();

                ////Voltaje
                //txtMaxL1.Text = L1Max.ToString();
                //txtFechaMaxL1.Text = L1MAxdate.ToString();
                //txtMaxL2.Text = L2Max.ToString();
                //txtFechaMaxL2.Text = L2Maxdate.ToString();
                //txtMaxL3.Text = L3Max.ToString();
                //txtFechaMaxL3.Text = L3Maxdate.ToString();
            }
        }

        private void tabDelivery_Click(object sender, EventArgs e)
        {

        }

        private void btnExportarExel_Click(object sender, EventArgs e)
        {
            Exportar_a export = new Exportar_a();
            try
            {
                if (gridDatosConsulta.Rows.Count > 0)
                {
                    //export.Exel(gridDatosConsulta, txtNombreMedidor.Text);
                    export.excelPro(gridDatosConsulta, txtNombreMedidor.Text);
                    pnlAlertaVerde.Visible = true;
                    lblverde.Text = "datos exportados";
                }
                else
                {
                    lblR.Text = "Tabla vacio ";
                }
            }
            catch (Exception erro)
            {
                pnlAlertaRojo.Visible = true;
                lblR.Text = "Error al exportar " + erro;
            }



        }

        private void txtNombreMedidor_Click(object sender, EventArgs e)
        {

        }

        private void lblPageNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnPageFinal_Click(object sender, EventArgs e)
        {

        }

        private void btnPageSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void btnPageInicial_Click(object sender, EventArgs e)
        {

        }

        private void btnPageAnterior_Click(object sender, EventArgs e)
        {

        }
    }
}
