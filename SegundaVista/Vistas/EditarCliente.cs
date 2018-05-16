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
using SegundaVista.Mongo_Data;
using SegundaVista.Mongo_Data.Clases;
using MongoDB.Driver.Builders;

namespace SegundaVista.Vistas
{
    public partial class EditarCliente : Form
    {
        private Conexion MongoConexion = new Conexion();
        public EditarCliente()
        {
            InitializeComponent();
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            pnlAlerta.Visible = true;
            pnlAlertaVerde.Visible = false;
            pnlAlertaRojo.Visible = false;

            lblNombreCliente.Text = txt_E_Nombre.Text;
            lblNisCliente.Text = txt_E_NisCliente.Text;


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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

        private void btnGuardarMedidor_Click(object sender, EventArgs e)
        {
            try
            {
                Conector_DataBase conector = new Conector_DataBase();
                DatosCliente cliente_Editado = new DatosCliente();
                var Cliente = MongoConexion.DataBase.GetCollection<DatosCliente>("Clientes");
     
                cliente_Editado.Nombre = txt_E_Nombre.Text;
                cliente_Editado.Apellido = txt_E_Apellido.Text;
                cliente_Editado.Nombre_Empresa = txt_E_NombreEmpresa.Text;
                cliente_Editado.Responsable_Medicion = txt_E_ResponsableMedidcion.Text;
                cliente_Editado.DirigirReporte_A = txt_E_DirigirReporte.Text;
                cliente_Editado.RazonSocial = txt_E_RazonSocial.Text;
                cliente_Editado.Ruc = txt_E_Ruc.Text;
                cliente_Editado.NisCliente = txt_E_NisCliente.Text;

                var query = Query.EQ("id_cliente", txt_IdCliente.Text);
                var entity = Cliente.FindOne(query);
                entity.Nombre = cliente_Editado.Nombre;
                entity.Apellido = cliente_Editado.Apellido;
                entity.Nombre_Empresa = cliente_Editado.Nombre_Empresa;
                entity.Responsable_Medicion = cliente_Editado.Responsable_Medicion;
                entity.DirigirReporte_A = cliente_Editado.DirigirReporte_A;
                entity.RazonSocial = cliente_Editado.RazonSocial;
                entity.Ruc = cliente_Editado.Ruc;
                entity.NisCliente = cliente_Editado.NisCliente;
                Cliente.Save(entity);
                if (lblNombreCliente.Text != cliente_Editado.Nombre || lblNisCliente.Text != cliente_Editado.NisCliente)
                {
                    var Medidor = MongoConexion.DataBase.GetCollection<MedidorDatos>("Medidor");
                    var consulta = Query.EQ("NisCliente", lblNisCliente.Text);
                    var entidad = Medidor.FindOne(consulta);
                    entidad.Nombre_Del_Propietario = cliente_Editado.Nombre;
                    entidad.NisCliente = cliente_Editado.NisCliente;
                    Medidor.Save(entidad);
                }

                pnlAlertaVerde.Visible = true;
                lbl_verde.Text = "Cliente Editado";

            }
            catch (Exception ex)
            {
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "Erro Al Editar Cliente : " + ex;
            }




        }

        private void PnlFormCliente_Paint(object sender, PaintEventArgs e)
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
    }
}
