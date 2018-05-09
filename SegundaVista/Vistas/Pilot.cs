using SegundaVista.clases.Medidores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SegundaVista.Vistas
{
    public partial class Pilot : Form
    {
        

        public class columnas
        {
            public string Nombre { get; set; }
            public string llave { get; set; }
            public bool usar { get; set; }
        }
        private List<columnas> objetoColumnas = new List<columnas>();
        public Pilot()
        {
            InitializeComponent();
        }
        private void Pilot_Load(object sender, EventArgs e)
        {
            btnRestaurar.Visible = false;
           
        }
        private void gridDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Title = "Buscar medición en formato csv";
            openFileDialog1.DefaultExt = ".csv";
            openFileDialog1.Filter = "archivos csv (*.csv)|*.csv";
            //openFileDialog1.ShowDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.ToString() != "")
            {
                if (File.Exists("" + openFileDialog1.FileName))
                {
                    string line;
                    int counter = 0;

                    // Read the file and display it line by line.  
                    System.IO.StreamReader file =
                        new System.IO.StreamReader(@"" + openFileDialog1.FileName);

                    List<PILOT> listaData = new List<PILOT>();


                    while ((line = file.ReadLine()) != null)
                    {

                        counter++;
                        int cantidadColumnas = line.Split(',').Count();
                        string[] columnasCsv = new string[cantidadColumnas];
                        int[] columnasUsar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 15, 17, 18, 19, 20, 21 };
                        columnasCsv = line.Split(',');

                        PILOT filaData = new PILOT();

                        if (counter > 1 && counter <= 41)
                        {
                            // this.gridDatos.Rows.Add(1);
                            Random rnd = new Random();

                            for (var i = 0; i < cantidadColumnas; i++)
                            {
                                var texto = SacarTexto(line, i + 1);

                                switch (i)
                                {
                                    case 1:
                                        filaData.Time = Convert.ToDateTime(texto);
                                        break;
                                    case 2:
                                        filaData.Va = Convert.ToDecimal(texto);
                                        break;
                                    case 3:
                                        filaData.Vb = Convert.ToDecimal(texto);
                                        break;
                                    case 4:
                                        filaData.Vc = Convert.ToDecimal(texto);
                                        break;
                                    case 5:
                                        filaData.Ia = Convert.ToDecimal(texto);
                                        break;
                                    case 6:
                                        filaData.Ib = Convert.ToDecimal(texto);
                                        break;
                                    case 7:
                                        filaData.Ic = Convert.ToDecimal(texto);
                                        break;
                                    case 8:
                                        filaData.Frequency = Convert.ToDecimal(texto);
                                        break;
                                    case 9:
                                        filaData.Pa = Convert.ToDecimal(texto);
                                        break;
                                    case 10:
                                        filaData.Pb = Convert.ToDecimal(texto);
                                        break;
                                    case 11:
                                        filaData.Pc = Convert.ToDecimal(texto);
                                        break;
                                    case 15:
                                        filaData.TotalkW = Convert.ToDecimal(texto);
                                        break;
                                    case 18:
                                        filaData.Pftot = Convert.ToDecimal(texto);
                                        break;
                                    case 19:
                                        filaData.KwhRec = Convert.ToDecimal(texto);
                                        break;
                                    case 20:
                                        filaData.KwhDel = Convert.ToDecimal(texto);
                                        break;
                                    case 21:
                                        filaData.kVARhDel = Convert.ToDecimal(texto);
                                        break;
                                    case 22:
                                        filaData.kVARhRec = Convert.ToDecimal(texto);
                                        break;
                                    case 23:
                                        filaData.TotalkWh_del_Rec = (filaData.KwhRec - filaData.KwhDel);
                                        filaData.TotalkVARh = (filaData.kVARhDel - filaData.kVARhRec);
                                        ////
                                        filaData.Rec_kW = (filaData.KwhRec * 4);
                                        filaData.Del_kW = (filaData.KwhDel * 4);
                                        double a = Convert.ToDouble(filaData.TotalkVARh);
                                        filaData.kVAh_rms = Convert.ToDecimal(a * 0.8);
                                        double b = Convert.ToDouble(filaData.KwhRec);
                                        filaData.Rec_kVAh = Convert.ToDecimal(b * 0.8);
                                        double c = Convert.ToDouble(filaData.KwhDel);
                                        filaData.Rec_kVAh = Convert.ToDecimal(c * 0.8);
                                        break;
                                }
                            }
                            listaData.Add(filaData);
                        }
                    }
                    var bindingList = new BindingList<PILOT>(listaData);
                    var source = new BindingSource(bindingList, null);
                    gridDatos.DataSource = source;
                }
            }
        }
        public string SacarTexto(string linea, int ubicacion)
        {
            linea = linea.TrimEnd(',');
            string[] arregloLinea = linea.Split(',');
            return (arregloLinea.Length >= ubicacion) ? arregloLinea[ubicacion - 1] : "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void PnlBarraTitulo_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
