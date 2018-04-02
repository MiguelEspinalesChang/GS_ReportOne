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
    public partial class Cliente : Form
    {
        

        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            pnlAlerta.Visible = false;
            pnlAlertaVerde.Visible = false;
            pnlAlertaRojo.Visible = false;
        }

        private void pnlContenedorHijo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlAlerta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlContenedorHijo_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrarAlertaV_Click(object sender, EventArgs e)
        {
            pnlAlertaVerde.Visible = false;
            //pnlAlertaRojo.Visible = false;
        }

        private void btnCerrarAlertaR_Click(object sender, EventArgs e)
        {
           // pnlAlertaVerde.Visible = false;
            pnlAlertaRojo.Visible = false;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Form abrir = new AgregarCliente();
            abrir.ShowDialog();
        }
    }
}
