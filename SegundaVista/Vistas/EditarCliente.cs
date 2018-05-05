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
using MongoDB.Bson;
using MongoDB.Driver;

namespace SegundaVista.Vistas
{
    public partial class EditarCliente : Form
    {
        public EditarCliente()
        {
            InitializeComponent();
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            pnlAlerta.Visible = true;
            pnlAlertaVerde.Visible = false;
            pnlAlertaRojo.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public class DatosCliente
        {
            DatosCliente()
            {

            }
        }

        private void btnGuardarMedidor_Click(object sender, EventArgs e)
        {

            Clientee dato = new Clientee();
            var connectionString = "mongodb://localhost";
            MongoClient client = new MongoClient(connectionString);
            MongoServer server = client.GetServer();
            var database = server.GetDatabase("GS_Report_one_DataBaseMongo");
          //  MongoCollection Client 
        }
    }
}
