using SegundaVista.clases;
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
using MongoDB.Driver;
using SegundaVista.Mongo_Data;

namespace SegundaVista.Vistas
{
    public partial class Cliente : Form
    {

        private Conexion MongoConexion = new Conexion();

        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            pnlAlerta.Visible = false;
            pnlAlertaVerde.Visible = false;
            pnlAlertaRojo.Visible = false;
            Usuarios();
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

        public class Client
        {
            public string Nombre_Empresa { get; set; }
            public string NisCliente { get; set; }
            public string RazonSocial { get; set; }
            public string Ruc { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Responsable_Medicion { get; set; }
            public string DirigirReporte_A { get; set; }
            public ObjectId Id { get; set; }
            public DateTime date_Loader { get; set; }

        }

        public void Usuarios()
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var database = server.GetDatabase("GS_Report_one_DataBaseMongo");
            var Documento = MongoConexion.DataBase.GetCollection<Client>("Usuarios");
            //MongoCollection<Client> Documento = database.GetCollection<Client>("Usuarios");
            BindingList<Client> doclist = new BindingList<Client>();
            Clientee Cli = new Clientee();
            foreach (var deger in Documento.FindAll())
            {
                Cli.Nombre = deger.Nombre.ToString();
                Cli.Apellido = deger.Apellido.ToString();
                Cli.Nombre_Empresa = deger.Nombre_Empresa.ToString();
                Cli.Responsable_Medicion = deger.Responsable_Medicion.ToString();
                Cli.DirigirReporte_A = deger.DirigirReporte_A.ToString();
                Cli.RazonSocial = deger.RazonSocial.ToString();
                Cli.Ruc = deger.Ruc.ToString();
                Cli.NisCliente = deger.NisCliente.ToString();
                Cli.ObjectId_Cliente = deger.Id;
                doclist.Add(deger);
                
            }

            var bindingList = new BindingList<Client>(doclist);
            var source = new BindingSource(bindingList, null);
            gridClientes.DataSource = source;

        }

        private void btnAgregarMedidor_Click(object sender, EventArgs e)
        {
            try
            {
                Form abrir = new AgregarMedidor();
                var contador = gridClientes.SelectedRows.Count;
                if (contador>0)
                {     
                    //IF DE CONTADOR MAYOR QUE CERO LANZAR VENTANA PASANDO DATOS
                    //ELSE LANZAR ALERTA
                    var clienteSelect = gridClientes.SelectedRows[0];
                    var celdas = clienteSelect.Cells;
                    var clienteNombre = celdas["Nombre"].Value;
                    var NisCliente = celdas["NisCliente"].Value;
                    abrir.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seleccione Una Celda");
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : "+ ex);
            }

        
        
        }

        private void gridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //string Dato_NIS, Dato_NOMBRE;
           // Dato_NIS = gridClientes.row[1];

        }
    }
}
