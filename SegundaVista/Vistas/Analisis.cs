using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SegundaVista.Vistas;

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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMS4X_Click(object sender, EventArgs e)
        {
            Form abrir = new S4X();
            abrir.ShowDialog();
        }

        private void btnMpilot_Click(object sender, EventArgs e)
        {
            Form abrir = new Pilot();
            abrir.ShowDialog();

        }
    }
}
