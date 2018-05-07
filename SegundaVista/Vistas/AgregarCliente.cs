using SegundaVista.Mongo_Data.Clases;
using SegundaVista.clases;
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
    public partial class AgregarCliente : Form
    {
        Cliente padre = new Cliente();
        private bool seAgregoUno = false;

        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            pnlAlerta.Visible = true;
            pnlAlertaVerde.Visible = false;
            pnlAlertaRojo.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (seAgregoUno)
                padre.RefrescarCocaCola();
            

            this.Close();
        }

        private void btnGuardarMedidor_Click(object sender, EventArgs e)
        {
            Conector_DataBase conector = new Conector_DataBase();

            Clientee cliente = new Clientee();
            cliente.Nombre = txt_m_Nombre.Text;
            cliente.Apellido = txt_m_Apellido.Text;
            cliente.Nombre_Empresa = txt_m_NomEmpresa.Text;
            cliente.Responsable_Medicion = txt_m_ResMedicion.Text;
            cliente.DirigirReporte_A = txt_m_DirigirReporte.Text;
            cliente.RazonSocial = txt_m_RazonSocial.Text;
            cliente.Ruc = txt_m_Ruc.Text;
            cliente.NisCliente = txt_m_NisCliente.Text;

           // Mandar los datos del usuario ala base de datos en mongo
            conector.insertar_Cliete(cliente.Nombre,cliente.Apellido,cliente.Nombre_Empresa,cliente.Responsable_Medicion,cliente.DirigirReporte_A,cliente.RazonSocial,cliente.Ruc,cliente.NisCliente);
            pnlAlertaVerde.Visible = true;
            lbl_verde.Text = "Usuario Agregado";
            txt_m_Nombre.Text = "";
            txt_m_Apellido.Text = "";
            txt_m_NomEmpresa.Text = "";
            txt_m_ResMedicion.Text = "";
            txt_m_DirigirReporte.Text = "";
            txt_m_RazonSocial.Text = "";
            txt_m_Ruc.Text = "";
            txt_m_NisCliente.Text = "";

            seAgregoUno = true;
        }

        private void txt_m_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarAlertaV_Click(object sender, EventArgs e)
        {
            pnlAlertaVerde.Visible = false;
        }

        private void btnCerrarAlertaR_Click(object sender, EventArgs e)
        {
            pnlAlertaRojo.Visible = false;
        }
    }
}
