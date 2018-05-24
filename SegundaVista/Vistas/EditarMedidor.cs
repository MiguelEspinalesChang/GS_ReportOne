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
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using SegundaVista.Mongo_Data;

namespace SegundaVista.Vistas
{
    public partial class EditarMedidor : Form
    {
        private Conexion MongoConexion = new Conexion();
        public EditarMedidor()
        {
            InitializeComponent();
            ListaClientes();
        }
        private void ListaClientes()
        {
            //BindingList<DatosCliente> listaCliente = new BindingList<DatosCliente>();

            //  List<string> listaCliente = new List<string>();
            var Documento = MongoConexion.DataBase.GetCollection<DatosCliente>("Clientes");
            foreach (var valor in Documento.FindAll())
            {
                //listaCliente.Add(valor.Nombre);
                txtNom_Propietario.Items.Add(valor.Nombre);
            }



        }

        private void EditarMedidor_Load(object sender, EventArgs e)
        {
            pnlAlerta.Visible = true;
            pnlAlertaVerde.Visible = false;
            pnlAlertaRojo.Visible = false;
            lblNombreOrigen.Text = txtNom_Propietario.Text;
            //consulat de clientes
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

        private void btnGuardarMedidor_Click(object sender, EventArgs e)
        {
            try
            {
                MedidorDatos Medidor_Edit = new MedidorDatos();
                var Medidor = MongoConexion.DataBase.GetCollection<MedidorDatos>("Medidor");
                Medidor_Edit.Numero_Medidor = txtNumero_Medidor.Text;
                Medidor_Edit.NisCliente = txtNIS.Text;
                Medidor_Edit.Nombre_Medidor = txtNombreMedidor.Text;
                Medidor_Edit.Area = txtArea.Text;
                Medidor_Edit.Modo_De_Uso = txtModo_Uso.Text;
                Medidor_Edit.Nombre_Del_Propietario = txtNom_Propietario.Text;
                Medidor_Edit.Ubicacion_Del_Medidor = txtUbicacionMedidor.Text;
                Medidor_Edit.KWH_punto_Dia = Convert.ToSingle(txtKWH_punto_dia.Text);
                Medidor_Edit.Grupo = txtNumero_Grupo.Text;
                Medidor_Edit.Pototencia_punto_Dia = Convert.ToSingle(txtPotencia_Punto_dia.Text);
                Medidor_Edit.Marca = txtMarca.Text;
                Medidor_Edit.Modelo = txtModelo.Text;
                Medidor_Edit.Tipo = txtTipo.Text;
                Medidor_Edit.Clase = Convert.ToUInt16(txtClase.Text);
                Medidor_Edit.Presicion = Convert.ToSingle(txtPresicion.Text);
                Medidor_Edit.Codigo_Del_Fabricante = txtCodigo_Fabricante.Text;
                Medidor_Edit.TC_Primario = Convert.ToSingle(txtTc_primaria.Text);
                Medidor_Edit.TC_Secundario = Convert.ToSingle(txtTc_secundaria.Text);
                Medidor_Edit.Relacion_TC = Convert.ToSingle(txtRelacion_TC.Text);
                Medidor_Edit.Tp_Primario = Convert.ToSingle(txtTP_primaria.Text);
                Medidor_Edit.Tp_Secundario = Convert.ToSingle(txtTP_secundario.Text);
                Medidor_Edit.Relacion_Tp = Convert.ToSingle(txtRelacion_TP.Text);
                Medidor_Edit.Numero_Serie = txtNumero_Serie.Text;
                Medidor_Edit.Ia_punto = Convert.ToSingle(txt_Ia_punto.Text);
                Medidor_Edit.Ib_punto = Convert.ToSingle(txt_Ib_punto.Text);
                Medidor_Edit.Ic_punto = Convert.ToSingle(txt_Ic_punto.Text);
                Medidor_Edit.Va_punto = Convert.ToSingle(txt_Va_punto.Text);
                Medidor_Edit.Vb_punto = Convert.ToSingle(txt_Vb_punto.Text);
                Medidor_Edit.Vc_punto = Convert.ToSingle(txt_Vc_punto.Text);
                //comunicacion
                Medidor_Edit.Eternet = check_Eternet.Checked;
                Medidor_Edit.Eternet_Operativo = radio_Eternet_si.Checked;
                Medidor_Edit.Eternet_NumeroIp = txtNumeroIp_Eternet.Text;
                Medidor_Edit.Modem = check_Modem.Checked;
                Medidor_Edit.Modem_Operativo = radio_Modem_si.Checked;
                Medidor_Edit.Modem_Telefono = txtNumTelefono_modem.Text;
                Medidor_Edit.RS232 = checkRS_232.Checked;
                Medidor_Edit.RS232_Operativo = radio_RS232_si.Checked;
                Medidor_Edit.RS232_Id = txtId_RS232.Text;
                Medidor_Edit.RS485 = check_RS_485.Checked;
                Medidor_Edit.RS485_Operativo = radio_RS485_si.Checked;
                Medidor_Edit.RS485_Id = txtRS485_Id.Text;
                Medidor_Edit.PuertoOptico = checkPuerto_optico.Checked;
                Medidor_Edit.PuertoOptico_Operativo = radio_PuertoOptico_si.Checked;
                Medidor_Edit.infrarrojo = check_infrarrojo.Checked;
                Medidor_Edit.infrarrojo_Operativo = radio_Infrarrojo_si.Checked;
                Medidor_Edit.RadioFrecuencia = check_radio_frecuencia.Checked;
                Medidor_Edit.RadioFrecuencia_Operativo = radio_RadiFrecuencia_si.Checked;
               // Medidor_Edit.id_Medidor = lbl_IdMedidor.Text;

                var consulta = Query.EQ("id_Medidor", lbl_IdMedidor.Text);
                var entidad = Medidor.FindOne(consulta);
                entidad.Numero_Medidor = Medidor_Edit.Numero_Medidor;
                entidad.NisCliente = Medidor_Edit.NisCliente;
                entidad.Nombre_Medidor = Medidor_Edit.Nombre_Medidor;
                entidad.Area = Medidor_Edit.Area;
                entidad.Modo_De_Uso = Medidor_Edit.Modo_De_Uso;
                entidad.Nombre_Del_Propietario = Medidor_Edit.Nombre_Del_Propietario;
                entidad.Ubicacion_Del_Medidor = Medidor_Edit.Ubicacion_Del_Medidor;
                entidad.KWH_punto_Dia = Medidor_Edit.KWH_punto_Dia;
                entidad.Grupo = Medidor_Edit.Grupo;
                entidad.Pototencia_punto_Dia = Medidor_Edit.Pototencia_punto_Dia;
                entidad.Marca = Medidor_Edit.Marca;
                entidad.Modelo = Medidor_Edit.Modelo;
                entidad.Tipo = Medidor_Edit.Tipo;
                entidad.Clase = Medidor_Edit.Clase;
                entidad.Presicion = Medidor_Edit.Presicion;
                entidad.Codigo_Del_Fabricante = Medidor_Edit.Codigo_Del_Fabricante;
                entidad.TC_Primario = Medidor_Edit.TC_Primario;
                entidad.TC_Secundario = Medidor_Edit.TC_Secundario;
                entidad.Relacion_TC = Medidor_Edit.Relacion_TC;
                entidad.Tp_Primario = Medidor_Edit.Tp_Primario;
                entidad.Tp_Secundario = Medidor_Edit.Tp_Secundario;
                entidad.Relacion_Tp = Medidor_Edit.Relacion_Tp;
                entidad.Numero_Serie = Medidor_Edit.Numero_Serie;
                entidad.Ia_punto = Medidor_Edit.Ia_punto;
                entidad.Ib_punto = Medidor_Edit.Ib_punto;
                entidad.Ic_punto = Medidor_Edit.Ic_punto;
                entidad.Va_punto = Medidor_Edit.Va_punto;
                entidad.Vb_punto = Medidor_Edit.Vb_punto;
                entidad.Vc_punto = Medidor_Edit.Vc_punto;
                entidad.Eternet = Medidor_Edit.Eternet;
                entidad.Eternet_Operativo = Medidor_Edit.Eternet_Operativo;
                entidad.Eternet_NumeroIp = Medidor_Edit.Eternet_NumeroIp;
                entidad.Modem = Medidor_Edit.Modem;
                entidad.Modem_Operativo = Medidor_Edit.Modem_Operativo;
                entidad.Modem_Telefono = Medidor_Edit.Modem_Telefono;
                entidad.RS232 = Medidor_Edit.RS232;
                entidad.RS232_Operativo = Medidor_Edit.RS232_Operativo;
                entidad.RS232_Id = Medidor_Edit.RS232_Id;
                entidad.RS485 = Medidor_Edit.RS485;
                entidad.RS485_Operativo = Medidor_Edit.RS485_Operativo;
                entidad.RS485_Id = Medidor_Edit.RS485_Id;
                entidad.PuertoOptico = Medidor_Edit.PuertoOptico;
                entidad.PuertoOptico_Operativo = Medidor_Edit.PuertoOptico_Operativo;
                entidad.infrarrojo = Medidor_Edit.infrarrojo;
                entidad.infrarrojo_Operativo = Medidor_Edit.infrarrojo_Operativo;
                entidad.RadioFrecuencia = Medidor_Edit.RadioFrecuencia;
                entidad.RadioFrecuencia_Operativo = Medidor_Edit.RadioFrecuencia_Operativo;

                //if (lblNombreOrigen.Text != Medidor_Edit.Nombre_Del_Propietario)
                //{
                //    DatosCliente cliente_Editado = new DatosCliente();
                //    var Cliente = MongoConexion.DataBase.GetCollection<DatosCliente>("Clientes");
                //    var consultaCliente = Query.EQ("Nombre_Del_Propietario", lblNombreOrigen.Text);
                //    var consulaCliente_Editado = Query.EQ("Nombre_Del_Propietario", txtNom_Propietario.Text);
                //    var dato = Cliente.FindOne(consultaCliente);
                //    var dato2 = Cliente.FindOne(consulaCliente_Editado);
                //    dato.NisCliente = dato2.NisCliente;
                //    Cliente.Save(dato);
                //}

                Medidor.Save(entidad);

                pnlAlertaVerde.Visible = true;
                lbl_verde.Text = "Medidor Editado";
            }
            catch (Exception ex)
            {
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "Erro Al Editar Medidor : " + ex;
            }
        }
    }
}
