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

namespace SegundaVista.Vistas
{
    public partial class EditarMedidor : Form
    {
        public EditarMedidor()
        {
            InitializeComponent();
        }

        private void EditarMedidor_Load(object sender, EventArgs e)
        {
            pnlAlerta.Visible = true;
            pnlAlertaVerde.Visible = false;
            pnlAlertaRojo.Visible = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void check_Eternet_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Eternet.Checked == true)
            {
                gro_B_Eternet.Visible = true;
            }
            else
            {
                gro_B_Eternet.Visible = false;
            }
        }

        private void check_Modem_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Modem.Checked == true)
            {
                gro_B_Modem.Visible = true;
            }
            else
            {
                gro_B_Modem.Visible = false;
            }
        }

        private void checkRS_232_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRS_232.Checked == true)
            {
                gro_B_RS_232.Visible = true;
            }
            else
            {
                gro_B_RS_232.Visible = false;
            }
        }

        private void check_RS_485_CheckedChanged(object sender, EventArgs e)
        {
            if (check_RS_485.Checked == true)
            {
                gro_B_RS_485.Visible = true;
            }
            else
            {
                gro_B_RS_485.Visible = false;
            }
        }

        private void checkPuerto_optico_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPuerto_optico.Checked == true)
            {
                gro_B_PuertoOptico.Visible = true;
            }
            else
            {
                gro_B_PuertoOptico.Visible = false;
            }
        }

        private void check_infrarrojo_CheckedChanged(object sender, EventArgs e)
        {
            if (check_infrarrojo.Checked == true)
            {
                gro_B_Infrarrojo.Visible = true;
            }
            else
            {
                gro_B_Infrarrojo.Visible = false;
            }
        }

        private void check_radio_frecuencia_CheckedChanged(object sender, EventArgs e)
        {
            if (check_radio_frecuencia.Checked == true)
            {
                gro_B_RadioFrecuencia.Visible = true;
            }
            else
            {
                gro_B_RadioFrecuencia.Visible = false;
            }
        }
    }
}
