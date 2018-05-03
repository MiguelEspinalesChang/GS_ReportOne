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
            pnlAlerta.Visible = true;
            pnlAlertaVerde.Visible = false;
            pnlAlertaRojo.Visible = false;
            try
            {
                Usuarios();
                Medidor();
            }
            catch (Exception ex)
            {
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "Error Al Conectar al Servidor : " + ex;
            }

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
        public class MedidorDatos
        {
            public ObjectId Id { get; set; }
            public DateTime date_Loader { get; set; }
            public string Nis { get; set; }
            public string Numero_Medidor { get; set; }
            public string Nombre_Medidor { get; set; }
            public string Modo_Uso { get; set; }
            public string Grupo { get; set; }
            public string Area { get; set; }
            public string Nombre_Propietario { get; set; }
            public string Ubicacion { get; set; }
            public float KWH_Punto_dia { get; set; }
            public float Potencia_Punto_dia { get; set; }
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public string Tipo { get; set; }
            public int clase { get; set; }
            public float Presicion { get; set; }
            public string Codigo_fabricante { get; set; }
            public float TC_Primario { get; set; }
            public float TC_secundario { get; set; }
            public float Relacion_TC { get; set; }
            public float TP_Primario { get; set; }
            public float TP_secundario { get; set; }
            public float Relacion_TP { get; set; }
            public string Numero_Cerie { get; set; }
            public float Ia_punto { get; set; }
            public float Ib_punto { get; set; }
            public float Ic_punto { get; set; }
            public float Va_punto { get; set; }
            public float Vb_punto { get; set; }
            public float Vc_punto { get; set; }
            ///Datos de comunicacion
            public BsonBoolean Eternet { get; set; }
            public BsonBoolean Eternet_Operativo { get; set; }
            public string Eternet_NumeroIp { get; set; }
            public BsonBoolean Modem { get; set; }
            public BsonBoolean Modem_Operativo { get; set; }
            public string Modem_Telefono { get; set; }
            public BsonBoolean RS232 { get; set; }
            public BsonBoolean RS232_Operativo { get; set; }
            public string RS232_Id { get; set; }
            public BsonBoolean RS485 { get; set; }
            public BsonBoolean RS485_Operativo { get; set; }
            public string RS485_Numero_Id { get; set; }
            public BsonBoolean PuertoOptico { get; set; }
            public BsonBoolean PuertoOptico_Operativo { get; set; }
            public BsonBoolean infrarrojo { get; set; }
            public BsonBoolean infrarrojo_Operativo { get; set; }
            public BsonBoolean RadioFrecuencia { get; set; }
            public BsonBoolean RadioFrecuencia_Operativo { get; set; }
        }

        public void Usuarios()
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var database = server.GetDatabase("GS_Report_one_DataBaseMongo");
            var Documento = MongoConexion.DataBase.GetCollection<Client>("Usuarios");

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
                Cli.date_Loader = deger.date_Loader.Date;
                doclist.Add(deger);

            }

            var bindingList = new BindingList<Client>(doclist);
            var source = new BindingSource(bindingList, null);
            gridClientes.DataSource = source;

        }
        public void Medidor()
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var database = server.GetDatabase("GS_Report_one_DataBaseMongo");
            var Documento = MongoConexion.DataBase.GetCollection<MedidorDatos>("Medidor");
            BindingList<MedidorDatos> doclist = new BindingList<MedidorDatos>();
            MedidorDatos _Medidor = new MedidorDatos();
            foreach (var deger in Documento.FindAll())
            {
                _Medidor.Id = deger.Id;
                _Medidor.date_Loader = deger.date_Loader.Date;
                _Medidor.Nis = deger.Nis;
                _Medidor.Numero_Medidor = deger.Numero_Medidor;
                _Medidor.Nombre_Medidor = deger.Nombre_Medidor;
                _Medidor.Modo_Uso = deger.Modo_Uso;
            }
            var bindingList = new BindingList<MedidorDatos>(doclist);
            var source = new BindingSource(bindingList, null);
            gridMedidor.DataSource = source;
        }

        private void btnAgregarMedidor_Click(object sender, EventArgs e)
        {
            try
            {
                var contador = gridClientes.SelectedRows.Count;
                if (contador > 0)
                {
                    var clienteSelect = gridClientes.SelectedRows[0];
                    var celdas = clienteSelect.Cells;
                    string clienteNombre = Convert.ToString(celdas["Nombre"].Value);
                    string NisCliente = Convert.ToString(celdas["NisCliente"].Value);
                    AgregarMedidor Medi = new AgregarMedidor();
                    Medi.txtNIS.Text = NisCliente;
                    Medi.txtNom_Propietario.Text = clienteNombre;
                    pnlAlertaRojo.Visible = false;
                    Medi.ShowDialog();
                }
                else
                {
                    pnlAlertaRojo.Visible = true;
                    lblRojo.Text = "Seleccione Una Celda";

                }


            }
            catch (Exception ex)
            {
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "Error : " + ex;
            }



        }

        private void gridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
