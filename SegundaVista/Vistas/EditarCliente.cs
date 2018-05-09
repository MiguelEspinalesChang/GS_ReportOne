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

            lblId.Text = txt_E_Nombre.Text;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public class DatosCliente
        {
            public ObjectId _id { get; set; }
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


        private void btnGuardarMedidor_Click(object sender, EventArgs e)
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


            //var query = from c in Cliente.AsQueryable<DatosCliente>()
            //            where c.Nombre == lblId.Text
            //            select c;
            var query = Query.EQ("Nombre", lblId.Text);
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
            //var u = Update.Set("Name", "Harry");
            //Cliente.Update.(query, u);

        }
    }
}
