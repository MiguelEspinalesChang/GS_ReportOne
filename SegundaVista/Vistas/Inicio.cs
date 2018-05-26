using SegundaVista.clases;
using SegundaVista.clases.Medidores;
using SegundaVista.Mongo_Data;
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
using MongoDB.Driver.Builders;

namespace SegundaVista.Vistas
{
    public partial class Inicio : Form
    {
        public class DatosCliente
        {
            public ObjectId _id { get; set; }
            public string id_cliente { get; set; }
            public DateTime date_Loader { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Nombre_Empresa { get; set; }
            public string Responsable_Medicion { get; set; }
            public string DirigirReporte_A { get; set; }
            public string RazonSocial { get; set; }
            public string Ruc { get; set; }
            public string NisCliente { get; set; }
        }

        public class MedidorDatos
        {
            public string Numero_Medidor { get; set; }
            //System.ComponentModel.
            public ObjectId _id { get; set; }
            public string id_Medidor { get; set; }
            public DateTime date_Loader { get; set; }
            public string DB_Inicio { get; set; }
            public string DB_Final { get; set; }
            public string NisCliente { get; set; }
            public string Nombre_Medidor { get; set; }
            public string Area { get; set; }
            public string Modo_De_Uso { get; set; }
            public string Nombre_Del_Propietario { get; set; }
            public string Ubicacion_Del_Medidor { get; set; }
            public float KWH_punto_Dia { get; set; }
            public string Grupo { get; set; }
            public float Pototencia_punto_Dia { get; set; }
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public string Tipo { get; set; }
            public int Clase { get; set; }
            public float Presicion { get; set; }
            public string Codigo_Del_Fabricante { get; set; }
            public float TC_Primario { get; set; }
            public float TC_Secundario { get; set; }
            public float Relacion_TC { get; set; }
            public float Tp_Primario { get; set; }
            public float Tp_Secundario { get; set; }
            public float Relacion_Tp { get; set; }
            public string Numero_Serie { get; set; }
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
            public string RS485_Id { get; set; }
            public BsonBoolean PuertoOptico { get; set; }
            public BsonBoolean PuertoOptico_Operativo { get; set; }
            public BsonBoolean infrarrojo { get; set; }
            public BsonBoolean infrarrojo_Operativo { get; set; }
            public BsonBoolean RadioFrecuencia { get; set; }
            public BsonBoolean RadioFrecuencia_Operativo { get; set; }
        }



        public Inicio()
        {
            InitializeComponent();
        }
        private Conexion MongoConexion = new Conexion();
        private void ListaMedidor()
        {
            //BindingList<DatosCliente> listaCliente = new BindingList<DatosCliente>();

            //  List<string> listaCliente = new List<string>();
            var Documento = MongoConexion.DataBase.GetCollection<MedidorDatos>("Medidor");
            foreach (var valor in Documento.FindAll())
            {
                //listaCliente.Add(valor.Nombre);
                ComboMedidores.Items.Add(valor.Nombre_Medidor);
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            pnlAlerta.Visible = true;
            pnlAlertaVerde.Visible = false;
            pnlAlertaRojo.Visible = false;
            ListaMedidor();
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

        private void ComboMedidores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Medidor = ComboMedidores.SelectedItem.ToString();
            //consulta Medidior
            var DocumentoMedidor = MongoConexion.DataBase.GetCollection<MedidorDatos>("Medidor");
            //var consultaMedidor = Query.EQ("NisCliente", txtNissCliente.Text);
            foreach (var valor in DocumentoMedidor.FindAll())
            {
                if (valor.Nombre_Medidor == Medidor)
                {
                    txtNombreMedidor.Text = valor.Nombre_Medidor;
                    txtIdMedidor.Text = valor.id_Medidor;
                    txtModoHusoMedidor.Text = valor.Modo_De_Uso;
                    txtKwhDia.Text = valor.KWH_punto_Dia.ToString();
                    txtPotenciaDia.Text = valor.Pototencia_punto_Dia.ToString();
                    txtModeloMedidor.Text = valor.Modelo;
                    txtMarcaMedidor.Text = valor.Marca;
                    txtRelacionTC.Text = valor.Relacion_TC.ToString();
                    txtRelacionTP.Text = valor.Relacion_Tp.ToString();
                    txtInicioDB.Text = valor.DB_Inicio;
                    txtFinDB.Text = valor.DB_Final;
                }

            }
            ///consulta Cliente
          
            var DocumentoCliente = MongoConexion.DataBase.GetCollection<DatosCliente>("Clientes");
            // var consultaCliente = Query.EQ("Nombre", Cliente);


        }
    }
}
