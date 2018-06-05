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
        private void button2_Click(object sender, EventArgs e)
        {
           
        }

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
            PilotDB pilot = new PilotDB();
            Conector_DataBase conector = new Conector_DataBase();

            var DocumentoRegistro = MongoConexion.DataBase.GetCollection<PilotDB>("Datos");
            //Expresion lamda
            //var filtro = Query<PilotDB>.EQ(pil => pil.NumeroMedidor, txtNumeroMedidor.Text );
            //var Reg = DocumentoRegistro.FindAs<PilotDB>(filtro);
            //foreach (var valor in Reg)
            //{
            //    pilot.Nombre = valor.Nombre;
            //    pilot.Regitros = valor.Regitros;
            //}
            //Linq
            var resutado = from d in DocumentoRegistro.FindAll()
                           where d.NumeroMedidor == txtNumeroMedidor.Text // && ((d.Regitros[].Time)&&())
                           select d;
            //Recorro y guardo los valores de la consulta
            foreach (var valor in resutado)
            {
                pilot._id = valor._id;
                pilot.id_pilot = valor.id_pilot;
                pilot.Nombre = valor.Nombre;
                pilot.NumeroMedidor = valor.NumeroMedidor;
                pilot.NombrePropietadio = valor.NombrePropietadio;
                pilot.Marca = valor.Marca;
                pilot.date_Loader = valor.date_Loader;
                pilot.Regitros = valor.Regitros;
            }
            foreach (var Datos in pilot.Regitros)
            {

            }

        }
    }
}
