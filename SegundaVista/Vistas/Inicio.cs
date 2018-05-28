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
            [Browsable(false)]
            public string Numero_Medidor { get; set; }
            //System.ComponentModel
            [Browsable(false)]
            public ObjectId _id { get; set; }
            [Browsable(false)]
            public string id_Medidor { get; set; }
            [Browsable(false)]
            public DateTime date_Loader { get; set; }
            [DisplayName("Nombre Medidor")]
            public string Nombre_Medidor { get; set; }
            [DisplayName("Inicio Data Base")]
            public string DB_Inicio { get; set; }
            [DisplayName("Fin Data Base")]
            public string DB_Final { get; set; }
            [Browsable(false)]
            public string NisCliente { get; set; }
            [Browsable(false)]
            public string Area { get; set; }
            [Browsable(false)]
            public string Modo_De_Uso { get; set; }
            [Browsable(false)]
            public string Nombre_Del_Propietario { get; set; }
            [Browsable(false)]
            public string Ubicacion_Del_Medidor { get; set; }
            [Browsable(false)]
            public float KWH_punto_Dia { get; set; }
            [Browsable(false)]
            public string Grupo { get; set; }
            [Browsable(false)]
            public float Pototencia_punto_Dia { get; set; }
            [Browsable(false)]
            public string Marca { get; set; }
            [Browsable(false)]
            public string Modelo { get; set; }
            [Browsable(false)]
            public string Tipo { get; set; }
            [Browsable(false)]
            public int Clase { get; set; }
            [Browsable(false)]
            public float Presicion { get; set; }
            [Browsable(false)]
            public string Codigo_Del_Fabricante { get; set; }
            [Browsable(false)]
            public float TC_Primario { get; set; }
            [Browsable(false)]
            public float TC_Secundario { get; set; }
            [Browsable(false)]
            public float Relacion_TC { get; set; }
            [Browsable(false)]
            public float Tp_Primario { get; set; }
            [Browsable(false)]
            public float Tp_Secundario { get; set; }
            [Browsable(false)]
            public float Relacion_Tp { get; set; }
            [Browsable(false)]
            public string Numero_Serie { get; set; }
            [Browsable(false)]
            public float Ia_punto { get; set; }
            [Browsable(false)]
            public float Ib_punto { get; set; }
            [Browsable(false)]
            public float Ic_punto { get; set; }
            [Browsable(false)]
            public float Va_punto { get; set; }
            [Browsable(false)]
            public float Vb_punto { get; set; }
            [Browsable(false)]
            public float Vc_punto { get; set; }
            ///Datos de comunicacion
            [Browsable(false)]
            public BsonBoolean Eternet { get; set; }
            [Browsable(false)]
            public BsonBoolean Eternet_Operativo { get; set; }
            [Browsable(false)]
            public string Eternet_NumeroIp { get; set; }
            [Browsable(false)]
            public BsonBoolean Modem { get; set; }
            [Browsable(false)]
            public BsonBoolean Modem_Operativo { get; set; }
            [Browsable(false)]
            public string Modem_Telefono { get; set; }
            [Browsable(false)]
            public BsonBoolean RS232 { get; set; }
            [Browsable(false)]
            public BsonBoolean RS232_Operativo { get; set; }
            [Browsable(false)]
            public string RS232_Id { get; set; }
            [Browsable(false)]
            public BsonBoolean RS485 { get; set; }
            [Browsable(false)]
            public BsonBoolean RS485_Operativo { get; set; }
            [Browsable(false)]
            public string RS485_Id { get; set; }
            [Browsable(false)]
            public BsonBoolean PuertoOptico { get; set; }
            [Browsable(false)]
            public BsonBoolean PuertoOptico_Operativo { get; set; }
            [Browsable(false)]
            public BsonBoolean infrarrojo { get; set; }
            [Browsable(false)]
            public BsonBoolean infrarrojo_Operativo { get; set; }
            [Browsable(false)]
            public BsonBoolean RadioFrecuencia { get; set; }
            [Browsable(false)]
            public BsonBoolean RadioFrecuencia_Operativo { get; set; }
        }

        //public List<MedidorDatos> ListaDatosMedidor = new List<MedidorDatos>();

        public Inicio()
        {
            InitializeComponent();
        }
        private Conexion MongoConexion = new Conexion();

        private void fechasDB()
        {
            var Documento = MongoConexion.DataBase.GetCollection<MedidorDatos>("Medidor");
            var result = Documento.FindAll();
            List<MedidorDatos> ListaFecha = new List<MedidorDatos>();
            ListaFecha = result.ToList();
            gridFechaDb.DataSource = ListaFecha;
            gridFechaDb.Refresh();

        }

        private void ListaMedidor()
        {
            //BindingList<DatosCliente> listaCliente = new BindingList<DatosCliente>();

            //  List<string> listaCliente = new List<string>();
            var Documento = MongoConexion.DataBase.GetCollection<MedidorDatos>("Medidor");

            foreach (var valor in Documento.FindAll())
            {
                // ListaDatosMedidor.Add(valor);
                ComboMedidores.Items.Add(valor.Nombre_Medidor);
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            pnlAlerta.Visible = true;
            pnlAlertaVerde.Visible = false;
            pnlAlertaRojo.Visible = false;
            ListaMedidor();
            fechasDB();
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
        public string idMedidor, nombrePropietario;

        private void btnDataBaseOnline_Click(object sender, EventArgs e)
        {

        }

        private void gridFechaDb_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
            if (this.gridFechaDb.Columns[e.ColumnIndex].Name == "DB_Inicio")
            {
                if (e.Value.ToString() == "" )
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.BackColor = Color.OrangeRed;
                }
            }
            if (this.gridFechaDb.Columns[e.ColumnIndex].Name == "DB_Final")
            {
                if (e.Value.ToString() == "")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.BackColor = Color.OrangeRed;
                }
            }
        }

        private void ComboMedidores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Medidor = ComboMedidores.SelectedItem.ToString();

            //consulta Medidior
            var DocumentoMedidor = MongoConexion.DataBase.GetCollection<MedidorDatos>("Medidor");
            //var consultaMedidor = Query.EQ("NisCliente", txtNissCliente.Text);
            //var Dato = DocumentoMedidor.FindOne(consultaMedidor);
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
                    idMedidor = valor.id_Medidor;
                    nombrePropietario = valor.Nombre_Del_Propietario;
                }

            }
            ///consulta Cliente
            var DocumentoCliente = MongoConexion.DataBase.GetCollection<DatosCliente>("Clientes");
            // var consultaCliente = Query.EQ("Nombre", Cliente);
            foreach (var valor in DocumentoCliente.FindAll())
            {
                if (valor.Nombre == nombrePropietario)
                {
                    txtNombreCliente.Text = valor.Nombre;
                    txtNissCliente.Text = valor.NisCliente;
                    txtRucCliente.Text = valor.Ruc;
                    txtRazonSocial.Text = valor.RazonSocial;
                    txtNombreEmpresaCliente.Text = valor.Nombre_Empresa;
                }

            }



        }
    }
}
