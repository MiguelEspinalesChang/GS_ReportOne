using SegundaVista.clases;
using SegundaVista.clases.Medidores;
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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            pnlAlerta.Visible = true;
            pnlAlertaVerde.Visible = false;
            pnlAlertaRojo.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pnlContenedorHijo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMarcaMedidor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarAlertaR_Click(object sender, EventArgs e)
        {
            pnlAlertaRojo.Visible = false;
        }

        private void btnCerrarAlertaV_Click(object sender, EventArgs e)
        {
            pnlAlertaVerde.Visible = false;
        }
    }
}
