using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundaVista.Vistas
{
    public partial class Analisis : Form
    {
        public Analisis()
        {
            InitializeComponent();
        }

        private void Analisis_Load(object sender, EventArgs e)
        {
            pnlAlerta.Visible = true;
            pnlAlertaVerde.Visible = false;
            pnlAlertaRojo.Visible = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            //Valores de Fecha para la consulta
            DateTime fechaInicial = dtFechaFinalRegistro.Value.Date;
            DateTime horaInicial = Convert.ToDateTime(CbHoraInicialRegistro.Text +":" +CbMinutoInicialRegistro.Text +":" +"00");
            DateTime FechaInicialRegistro = fechaInicial.AddHours(horaInicial.Hour).AddMinutes(horaInicial.Minute).AddSeconds(horaInicial.Second);
     

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
