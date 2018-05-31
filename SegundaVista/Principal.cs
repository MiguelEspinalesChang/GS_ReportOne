using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SegundaVista.Vistas;

namespace SegundaVista
{
    public partial class Principal : MetroFramework.Forms.MetroForm
    {
        public Principal()
        {
            InitializeComponent();
        }
      

        private void Principal_Load(object sender, EventArgs e)
        {
            btnRestaurar.Visible = false;
            AbrirFormHijo(new Inicio());
           
        }

        private void PnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            
        }

     

        private void AbrirFormHijo (object formHijo)
        {
            if (this.PnlContenedor.Controls.Count >0)
                this.PnlContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PnlContenedor.Controls.Add(fh);
            this.PnlContenedor.Tag = fh;
            fh.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Inicio());
        }

        private void PnlMenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Cliente());
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Usuario());
        }

        private void btnMedidor_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Medidor());
        }

        private void btnAnalis_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new DatosOrige());
        }

        private void PnlContenedor_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Herramientas());
        }
    }
}
