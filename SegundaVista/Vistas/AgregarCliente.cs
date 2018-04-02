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
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {

            Conector_DataBase conect = new Conector_DataBase();
           

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarMedidor_Click(object sender, EventArgs e)
        {
            Clientee cliente = new Clientee();
            cliente.Nombre = txt_m_Nombre.Text;
            cliente.Apellido = txt_m_Apellido.Text;
            cliente.Nombre_Empresa = txt_m_NomEmpresa.Text;
            cliente.Responsable_Medicion = txt_m_ResMedicion.Text;
            cliente.DirigirReporte_A = txt_m_DirigirReporte.Text;
            cliente.RazonSocial = txt_m_RazonSocial.Text;
            cliente.Ruc = txt_m_Ruc.Text;
            cliente.NisCliente = txt_m_NisCliente.Text;
        }

        private void txt_m_Nombre_Click(object sender, EventArgs e)
        {

        }
    }
}
