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
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using MongoDB;

namespace SegundaVista.Vistas
{
    public partial class Cliente : Form
    {

        private Conexion MongoConexion = new Conexion();


        public Cliente()
        {
            InitializeComponent();
        }

        public void RefrescarCocaCola()
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

        private void Cliente_Load(object sender, EventArgs e)
        {

            RefrescarCocaCola();
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
            RefrescarCocaCola();
        }

        public class Client
        {
            [DisplayName("Nombre Empresa")]
            public string Nombre_Empresa { get; set; }
            public string NisCliente { get; set; }
            public string RazonSocial { get; set; }
            public string Ruc { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            [DisplayName("Responsable Medicion")]
            public string Responsable_Medicion { get; set; }
            [DisplayName("DirigirReporte A")]
            public string DirigirReporte_A { get; set; }
            [Browsable(false)]
            public ObjectId Id { get; set; }
            [DisplayName("Id Cliente")]
            public string id_cliente { get; set; }
            [Browsable(false)]
            public DateTime date_Loader { get; set; }

        }

        public class MedidorDatos
        {
            [DisplayName("Numero Medidor")]
            public string Numero_Medidor { get; set; }
            //System.ComponentModel.
            [Browsable(false)]
            public ObjectId _id { get; set; }
            [Browsable(false)]
            public DateTime date_Loader { get; set; }
            [DisplayName("DataBase Inicio")]
            public string DB_Inicio { get; set; }
            [DisplayName("DataBase Final")]
            public string DB_Final { get; set; }
            [DisplayName("Nis Cliente")]
            public string NisCliente { get; set; }
            [DisplayName("Nombre Medido")]
            public string Nombre_Medidor { get; set; }
            public string Area { get; set; }
            [DisplayName("Modo De Uso")]
            public string Modo_De_Uso { get; set; }
            [DisplayName("Nombre Del Propietario")]
            public string Nombre_Del_Propietario { get; set; }
            [DisplayName("Ubicacion Del Medidor")]
            public string Ubicacion_Del_Medidor { get; set; }
            [DisplayName("KWH punto Dia")]
            public float KWH_punto_Dia { get; set; }
            public string Grupo { get; set; }
            [DisplayName("Pototencia punto Dia")]
            public float Pototencia_punto_Dia { get; set; }
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public string Tipo { get; set; }
            public int Clase { get; set; }
            public float Presicion { get; set; }
            [DisplayName("Codigo Del Fabricante")]
            public string Codigo_Del_Fabricante { get; set; }
            [DisplayName("TC Primario")]
            public float TC_Primario { get; set; }
            [DisplayName("TC Secundario")]
            public float TC_Secundario { get; set; }
            [DisplayName("TRelacion TC")]
            public float Relacion_TC { get; set; }
            [DisplayName("Tp_Primari")]
            public float Tp_Primario { get; set; }
            [DisplayName("Tp Secundario")]
            public float Tp_Secundario { get; set; }
            [DisplayName("Relacion Tp")]
            public float Relacion_Tp { get; set; }
            [DisplayName("Numero Serie")]
            public string Numero_Serie { get; set; }
            [DisplayName("Ia punto")]
            public float Ia_punto { get; set; }
            [DisplayName("Ib punto")]
            public float Ib_punto { get; set; }
            [DisplayName("Ic punto")]
            public float Ic_punto { get; set; }
            [DisplayName("Va punto")]
            public float Va_punto { get; set; }
            [DisplayName("Vb punto")]
            public float Vb_punto { get; set; }
            [DisplayName("Vc punto")]
            public float Vc_punto { get; set; }
            ///Datos de comunicacion
            public BsonBoolean Eternet { get; set; }
            [DisplayName("Eternet Operativo")]
            public BsonBoolean Eternet_Operativo { get; set; }
            [DisplayName("Eternet NumeroIp")]
            public string Eternet_NumeroIp { get; set; }
            public BsonBoolean Modem { get; set; }
            [DisplayName("Modem Operativo")]
            public BsonBoolean Modem_Operativo { get; set; }
            [DisplayName("Modem Telefono")]
            public string Modem_Telefono { get; set; }
            public BsonBoolean RS232 { get; set; }
            [DisplayName("RS232 Operativo")]
            public BsonBoolean RS232_Operativo { get; set; }
            [DisplayName("RS232 Id")]
            public string RS232_Id { get; set; }
            public BsonBoolean RS485 { get; set; }
            [DisplayName("RS485 Operativo")]
            public BsonBoolean RS485_Operativo { get; set; }
            public string RS485_Id { get; set; }
            public BsonBoolean PuertoOptico { get; set; }
            [DisplayName("PuertoOptico Operativo")]
            public BsonBoolean PuertoOptico_Operativo { get; set; }
            public BsonBoolean infrarrojo { get; set; }
            [DisplayName("infrarrojo Operativo")]
            public BsonBoolean infrarrojo_Operativo { get; set; }
            public BsonBoolean RadioFrecuencia { get; set; }
            [DisplayName("RadioFrecuencia Operativo")]
            public BsonBoolean RadioFrecuencia_Operativo { get; set; }
            [DisplayName("Id Medidor")]
            public string id_Medidor { get; set; }

        }

        private void Usuarios()
        {

            var Documento = MongoConexion.DataBase.GetCollection<Client>("Clientes");

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
            gridClientes.Rows.Clear();
            gridClientes.DataSource = source;
            gridClientes.Refresh();

        }
        private void Medidor()
        {

            var collection = MongoConexion.DataBase.GetCollection<MedidorDatos>("Medidor");
            var result = collection.FindAll();

            List<MedidorDatos> parts = new List<MedidorDatos>();
            parts = result.ToList();
            gridMedidor.DataSource = parts;
            gridMedidor.Refresh();

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
                    RefrescarCocaCola();
                    var cdeldas = clienteSelect.Cells;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Form abrir = new EditarCliente();
            //abrir.ShowDialog();
            var contador = gridClientes.SelectedRows.Count;
            if (contador > 0)
            {
                var clienteSelect = gridClientes.SelectedRows[0];
                var celdas = clienteSelect.Cells;

                string NomEmpresa = Convert.ToString(celdas["Nombre_Empresa"].Value);
                string NisCliente = Convert.ToString(celdas["NisCliente"].Value);
                string RazonSocial = Convert.ToString(celdas["RazonSocial"].Value);
                string Ruc = Convert.ToString(celdas["Ruc"].Value);
                string clienteNombre = Convert.ToString(celdas["Nombre"].Value);
                string clienteApellido = Convert.ToString(celdas["Apellido"].Value);
                string Res_Medidor = Convert.ToString(celdas["Responsable_Medicion"].Value);
                string DirigirReporte = Convert.ToString(celdas["DirigirReporte_A"].Value);
                //string IdCliente = Convert.ToString(celdas["Id"].Value);
                string idPropia = Convert.ToString(celdas["id_cliente"].Value);

                EditarCliente cliente_Edit = new EditarCliente();
                cliente_Edit.txt_IdCliente.Text = idPropia;
                cliente_Edit.txt_E_Nombre.Text = clienteNombre;
                cliente_Edit.txt_E_RazonSocial.Text = RazonSocial;
                cliente_Edit.txt_E_Apellido.Text = clienteApellido;
                cliente_Edit.txt_E_Ruc.Text = Ruc;
                cliente_Edit.txt_E_NombreEmpresa.Text = NomEmpresa;
                cliente_Edit.txt_E_NisCliente.Text = NisCliente;
                cliente_Edit.txt_E_ResponsableMedidcion.Text = Res_Medidor;
                cliente_Edit.txt_E_DirigirReporte.Text = DirigirReporte;
                // cliente_Edit.lblId.Text = idPropia;
                pnlAlertaRojo.Visible = false;
                cliente_Edit.ShowDialog();
                RefrescarCocaCola();
            }
            else
            {
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "Seleccione Una Celda De Cliente";

            }
        }

        private void ntnEliminar_Click(object sender, EventArgs e)
        {
            //if ( MetroFramework.MetroMessageBox.Show(this,"Yes/No","Mensaje",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            //{
            //    pnlAlertaRojo.Visible = true;
            //    lblRojo.Text = "si";
            //}

            var contador = gridClientes.SelectedRows.Count;
            if (contador > 0)
            {
                var Documento = MongoConexion.DataBase.GetCollection<Client>("Clientes");
                var clienteSelect = gridClientes.SelectedRows[0];
                var celdas = clienteSelect.Cells;
                string idPropia = Convert.ToString(celdas["id_cliente"].Value);



                DialogResult dialogResult = MessageBox.Show("Desea Eliminar El Cliente", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var consulta = Query.EQ("id_cliente", idPropia);
                    Documento.Remove(consulta);

                    RefrescarCocaCola();
                    pnlAlertaVerde.Visible = true;
                    lblverde.Text = "Cliente Eliminado";
                }


            }
            else
            {
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "Seleccione Una Celda De clientes";

            }
        }

        private void pnlContenedorHijo_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void btnEliminarMedidor_Click(object sender, EventArgs e)
        {
            var contador = gridMedidor.SelectedRows.Count;
            if (contador > 0)
            {
                var Documento = MongoConexion.DataBase.GetCollection<MedidorDatos>("Medidor");
                var clienteSelect = gridMedidor.SelectedRows[0];
                var celdas = clienteSelect.Cells;
                string idPropia = Convert.ToString(celdas["id_Medidor"].Value);


                DialogResult dialogResult = MessageBox.Show("Desea Eliminar El Medidor", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var consulta = Query.EQ("id_Medidor", idPropia);
                    Documento.Remove(consulta);

                    RefrescarCocaCola();
                    pnlAlertaVerde.Visible = true;
                    lblverde.Text = "Medidor Eliminado";
                }
            }
            else
            {
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "Seleccione Una Celda De Medidore";

            }
        }

        private void btnEditarMedidor_Click(object sender, EventArgs e)
        {
            var contador = gridMedidor.SelectedRows.Count;
            if (contador > 0)
            {
                var MedidorSelect = gridMedidor.SelectedRows[0];
                var celdas = MedidorSelect.Cells;

                EditarMedidor Medidor_Edit = new EditarMedidor();

                Medidor_Edit.txtNumero_Medidor.Text = Convert.ToString(celdas["Numero_Medidor"].Value);
                Medidor_Edit.txtNIS.Text = Convert.ToString(celdas["NisCliente"].Value);
                Medidor_Edit.txtNombreMedidor.Text = Convert.ToString(celdas["Nombre_Medidor"].Value);
                Medidor_Edit.txtArea.Text = Convert.ToString(celdas["Area"].Value);
                Medidor_Edit.txtModo_Uso.Text = Convert.ToString(celdas["Modo_De_Uso"].Value);
                Medidor_Edit.txtNom_Propietario.Text = Convert.ToString(celdas["Nombre_Del_Propietario"].Value);
                Medidor_Edit.txtUbicacionMedidor.Text = Convert.ToString(celdas["Ubicacion_Del_Medidor"].Value);
                Medidor_Edit.txtKWH_punto_dia.Text = Convert.ToString(celdas["KWH_punto_Dia"].Value);
                Medidor_Edit.txtNumero_Grupo.Text = Convert.ToString(celdas["Grupo"].Value);
                Medidor_Edit.txtPotencia_Punto_dia.Text = Convert.ToString(celdas["Pototencia_punto_Dia"].Value);
                Medidor_Edit.txtMarca.Text = Convert.ToString(celdas["Marca"].Value);
                Medidor_Edit.txtModelo.Text = Convert.ToString(celdas["Modelo"].Value);
                Medidor_Edit.txtTipo.Text = Convert.ToString(celdas["Tipo"].Value);
                Medidor_Edit.txtClase.Text = Convert.ToString(celdas["Clase"].Value);
                Medidor_Edit.txtPresicion.Text = Convert.ToString(celdas["Presicion"].Value);
                Medidor_Edit.txtCodigo_Fabricante.Text = Convert.ToString(celdas["Codigo_Del_Fabricante"].Value);
                Medidor_Edit.txtTc_primaria.Text = Convert.ToString(celdas["TC_Primario"].Value);
                Medidor_Edit.txtTc_secundaria.Text = Convert.ToString(celdas["TC_Secundario"].Value);
                Medidor_Edit.txtRelacion_TC.Text = Convert.ToString(celdas["Relacion_TC"].Value);
                Medidor_Edit.txtTP_primaria.Text = Convert.ToString(celdas["Tp_Primario"].Value);
                Medidor_Edit.txtTP_secundario.Text = Convert.ToString(celdas["Tp_Secundario"].Value);
                Medidor_Edit.txtRelacion_TP.Text = Convert.ToString(celdas["Tp_Secundario"].Value);
                Medidor_Edit.txtNumero_Serie.Text = Convert.ToString(celdas["Numero_Serie"].Value);
                Medidor_Edit.txt_Ia_punto.Text = Convert.ToString(celdas["Ia_punto"].Value);
            }
            else
            {
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "Seleccione Una Celda De Cliente";

            }
        }
    }
}
