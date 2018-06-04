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
using System.IO;
using SegundaVista.Mongo_Data.Clases;


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
            pnlAlertaRojo.Visible = false;
            pnlAlertaVerde.Visible = false;
            if (ComboMedidores.Text != "")
            {
               
                Analisis vistaAnalisis = new Analisis();

                vistaAnalisis.ShowDialog();
                
            }
            else
            {
                pnlAlertaRojo.Visible = true;
                lblR.Text = "Seleccione Un Medidor";
            }
           
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
                if (e.Value.ToString() == "")
                {
                    e.Value = "Sin Registro";
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.OrangeRed;
                }
            }
            if (this.gridFechaDb.Columns[e.ColumnIndex].Name == "DB_Final")
            {
                if (e.Value.ToString() == "")
                {
                    e.Value = "Sin Registro";
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.OrangeRed;
                }
            }
        }
        public string SacarTexto(string linea, int ubicacion)
        {
            linea = linea.TrimEnd(',');
            string[] arregloLinea = linea.Split(',');
            return (arregloLinea.Length >= ubicacion) ? arregloLinea[ubicacion - 1] : "";
        }

        private void btnAbrirDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboMedidores.Text != "")
                {
                    pnlAlertaVerde.Visible = false;
                    pnlAlertaRojo.Visible = false;
                    Conector_DataBase conector = new Conector_DataBase();
                    //OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    //openFileDialog1.RestoreDirectory = true;
                    //openFileDialog1.CheckFileExists = true;
                    //openFileDialog1.CheckPathExists = true;
                    //openFileDialog1.Title = "Buscar medición en formato csv";
                    //openFileDialog1.DefaultExt = ".csv";
                    //openFileDialog1.Filter = "archivos csv (*.csv)|*.csv";

                    string ScvMedidor = txtNumeroMedidor.Text + ".csv";
                    string url = "C:\\Data Origen Report One\\DBPILOT\\"+ ScvMedidor;

                    if (File.Exists(url).ToString() != "")
                    {
                        if (File.Exists(url))
                        {
                            string line;
                            string linea;
                            int counter = 0;
                            // Read the file and display it line by line.  
                            System.IO.StreamReader file = new System.IO.StreamReader(@"" + url);
                            //se crear un clon de la lectura del archivon para saber la cantidad de lineas
                            System.IO.StreamReader fileCantidad = new System.IO.StreamReader(@"" + url);
                            PilotDB filaData = new PilotDB();
                            filaData.Nombre = txtNombreMedidor.Text;
                            filaData.NombrePropietadio = txtNombreCliente.Text;
                            filaData.Marca = txtMarcaMedidor.Text;
                            filaData.NumeroMedidor = txtNumeroMedidor.Text;
                            //sacar la cantidad de lineas
                            int cantidadLineas = 0;
                            while ((linea = fileCantidad.ReadLine()) != null)
                            {
                                cantidadLineas++;
                            }


                            while ((line = file.ReadLine()) != null)
                            {
                                counter++;
                                int cantidadColumnas = line.Split(',').Count();
                                string[] columnasCsv = new string[cantidadColumnas];
                                int[] columnasUsar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 15, 17, 18, 19, 20, 21 };
                                columnasCsv = line.Split(',');
                                dbDatosPilot Dato = new dbDatosPilot();
                                if (counter > 1 && counter <= cantidadLineas+1)
                                {
                                    // this.gridDatos.Rows.Add(1);
                                    Random rnd = new Random();
                                    for (var i = 0; i < cantidadColumnas; i++)
                                    {
                                        var texto = SacarTexto(line, i + 1);
                                        switch (i)
                                        {
                                            case 1:
                                                Dato.Time = Convert.ToDateTime(texto);
                                                break;
                                            case 2:
                                                Dato.Va = Convert.ToDecimal(texto);
                                                break;
                                            case 3:
                                                Dato.Vb = Convert.ToDecimal(texto);
                                                break;
                                            case 4:
                                                Dato.Vc = Convert.ToDecimal(texto);
                                                break;
                                            case 5:
                                                Dato.Ia = Convert.ToDecimal(texto);
                                                break;
                                            case 6:
                                                Dato.Ib = Convert.ToDecimal(texto);
                                                break;
                                            case 7:
                                                Dato.Ic = Convert.ToDecimal(texto);
                                                break;
                                            case 8:
                                                Dato.Frequency = Convert.ToDecimal(texto);
                                                break;
                                            case 9:
                                                Dato.Pa = Convert.ToDecimal(texto);
                                                break;
                                            case 10:
                                                Dato.Pb = Convert.ToDecimal(texto);
                                                break;
                                            case 11:
                                                Dato.Pc = Convert.ToDecimal(texto);
                                                break;
                                            case 15:
                                                Dato.TotalkW = Convert.ToDecimal(texto);
                                                break;
                                            case 18:
                                                Dato.Pftot = Convert.ToDecimal(texto);
                                                break;
                                            case 19:
                                                Dato.KwhRec = Convert.ToDecimal(texto);
                                                break;
                                            case 20:
                                                Dato.KwhDel = Convert.ToDecimal(texto);
                                                break;
                                            case 21:
                                                Dato.kVARhDel = Convert.ToDecimal(texto);
                                                break;
                                            case 22:
                                                Dato.kVARhRec = Convert.ToDecimal(texto);
                                                break;
                                            case 23:
                                                Dato.TotalkWh_del_Rec = (Dato.KwhRec - Dato.KwhDel);
                                                Dato.TotalkVARh = (Dato.kVARhDel - Dato.kVARhRec);
                                                ////datos Calculado a partir de lo registros
                                                Dato.Rec_kW = (Dato.KwhRec * 4);
                                                Dato.Del_kW = (Dato.KwhDel * 4);
                                                double a = Convert.ToDouble(Dato.TotalkVARh);
                                                Dato.kVAh_rms = Convert.ToDecimal(a * 0.8);
                                                double b = Convert.ToDouble(Dato.KwhRec);
                                                Dato.Rec_kVAh = Convert.ToDecimal(b * 0.8);
                                                double c = Convert.ToDouble(Dato.KwhDel);
                                                Dato.Rec_kVAh = Convert.ToDecimal(c * 0.8);
                                                break;
                                        }
                                    }
                                    filaData.Regitros.Add(Dato);
                                }
                            }
                            //Pasar Los Datos Leidos Ala Base de datos
                            conector.insertarDatosPilot(filaData);
                            pnlAlertaVerde.Visible = true;
                            lblverde.Text = "Registros Agregados";
                        }
                        else
                        {
                            pnlAlertaRojo.Visible = true;
                            lblR.Text = "El archivo scv  no se encuentra";
                        }
                    }
                    else
                    {
                        pnlAlertaRojo.Visible = true;
                        lblR.Text = "El archivo scv esta Vacio ";
                    }
                }
                else
                {
                 pnlAlertaRojo.Visible = true;
                 lblR.Text = "Seleccione Un Medidor";
                }

            }
            catch (Exception ex)
            {
                pnlAlertaRojo.Visible = true;
                lblR.Text = "Erro AL Guardar Los Registro : "+ex.ToString();
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
                    txtNumeroMedidor.Text = valor.Numero_Medidor;
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
