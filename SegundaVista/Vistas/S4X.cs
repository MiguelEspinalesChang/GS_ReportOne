using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundaVista.Vistas
{
    public partial class S4X : Form
    {
        public S4X()
        {
            InitializeComponent();
        }

        private void S4X_Load(object sender, EventArgs e)
        {
            gridParametros.Columns.Add("DeviceID", "Device ID"); //linea 2  del archivo
            gridParametros.Columns.Add("SerialNumber", "Serial Number");  //linea 3 del archivo
            gridParametros.Columns.Add("Kh", "Kh");  //linea 4  del archivo
            gridParametros.Columns.Add("IntervalLength", "Interval Length");  //linea 5  del archivo
            gridParametros.Columns.Add("TransformerFactor", "Transformer Factor");  //linea 6  del archivo
            gridParametros.Columns.Add("TransformerFactor Applied", "Transformer Factor Applied");  //linea 7  del archivo
            gridParametros.Columns.Add("MeterMultiplier", "Meter Multiplier");  //linea 8  del archivo
            gridParametros.Columns.Add("MeterMultiplierApplied", "Meter Multiplier Applied");  //linea 9  del archivo

            //////////////////////////////////////////////

            //GRID DATOS COLUMNAS. LINEA 18 DEL ARCHIVO
            gridDatos.Columns.Add("Time", "Time");
            gridDatos.Columns.Add("Status", "Status");
            gridDatos.Columns.Add("TotalkWh", "Total kWh");
            gridDatos.Columns.Add("TotalkVARh", "TotalkVARh");
            gridDatos.Columns.Add("TotalkW", "Total kW");
            gridDatos.Columns.Add("DelkWh", "Del. kWh");
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Title = "Buscar medición en formato XML";
            openFileDialog1.DefaultExt = ".xml";
            openFileDialog1.Filter = "archivos csv (*.csv)|*.csv";
            //openFileDialog1.ShowDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.ToString() != "")
            {

                if (File.Exists("" + openFileDialog1.FileName))
                {
                    string line;
                    int counter = 0;
                    int filasGridDatos = 1;
                    // Read the file and display it line by line.  
                    System.IO.StreamReader file =
                        new System.IO.StreamReader(@"" + openFileDialog1.FileName);

                    while ((line = file.ReadLine()) != null)
                    {
                        counter++;
                        if (counter < 18)
                        {

                            switch (counter)
                            {
                                case 1:
                                    break;

                                case 2:
                                    this.gridParametros[0, 0].Value = SacarTexto(line, 2);
                                    break;

                                case 3:
                                    this.gridParametros[counter - 2, 0].Value = SacarTexto(line, 2);
                                    break;

                                case 4:
                                    this.gridParametros[counter - 2, 0].Value = SacarTexto(line, 2);
                                    break;

                                case 5:
                                    //counter-2 = 3
                                    this.gridParametros[counter - 2, 0].Value = SacarTexto(line, 2);
                                    break;

                                case 6:
                                    //counter-2 = 4
                                    this.gridParametros[counter - 2, 0].Value = SacarTexto(line, 2);
                                    break;

                                case 7:
                                    //counter-2 = 5
                                    this.gridParametros[counter - 2, 0].Value = SacarTexto(line, 2);
                                    break;

                                case 8:
                                    //counter-2 = 6
                                    this.gridParametros[counter - 2, 0].Value = SacarTexto(line, 2);
                                    break;

                                case 9:
                                    //counter-2 = 7
                                    this.gridParametros[counter - 2, 0].Value = SacarTexto(line, 2);
                                    break;


                            }
                        }
                        else
                        {
                            if (counter > 18 && counter <= 58)
                            {

                                this.gridDatos.Rows.Add(1);
                                //Convert.ToDateTime(date);
                                //"" + SacarTexto(line, 1);

                                //string fecha = "" + SacarTexto(line, 1);

                                List<fecha> listaFecha = new List<fecha>();

                                for (var i = 0; i < 6; i++)
                                {
                                    var texto = SacarTexto(line, i + 1);
                                    listaFecha.Add(new fecha(texto, i + 1));

                                    if (i == 0)
                                    {


                                        decimal fechaa = Convert.ToDecimal(texto);
                                       // DateTime interval = Convert.ToDateTime( fechaa);
                                        this.gridDatos[i, filasGridDatos - 1].Value = "" + texto;
                                    }
                                    else
                                    {
                                        if (i > 1)
                                        {
                                            decimal fechaa = Convert.ToDecimal(texto);
                                            this.gridDatos[i, filasGridDatos - 1].Value = "" + (fechaa * 700);
                                        }
                                        //this.gridDatos[i, filasGridDatos - 1].Value = "" + texto;
                                    }


                                }

                                //this.gridDatos[0, filasGridDatos - 1].Value = "" + SacarTexto(line, 1);
                                //this.gridDatos[1, filasGridDatos - 1].Value = "" + SacarTexto(line, 2);
                                //this.gridDatos[2, filasGridDatos - 1].Value = "" + SacarTexto(line, 3);
                                //this.gridDatos[3, filasGridDatos - 1].Value = "" + SacarTexto(line, 4);
                                //this.gridDatos[4, filasGridDatos - 1].Value = "" + SacarTexto(line, 5);
                                //this.gridDatos[5, filasGridDatos - 1].Value = "" + SacarTexto(line, 6);

                                this.gridDatos.Refresh();
                                filasGridDatos++;
                            }

                        }


                    }
                    //counter = counter;
                }
            }
        }


        public string SacarTexto(string linea, int ubicacion)
        {
            linea = linea.TrimEnd(',');
            string[] arregloLinea = linea.Split(',');

            return (arregloLinea.Length >= ubicacion) ? arregloLinea[ubicacion - 1] : "";
        }
        public class fecha
        {
            public int index { get; set; }
            public string valor { get; set; }
            public fecha(string linea, int ubicacion)
            {
                index = ubicacion;
                valor = linea;
            }
            public fecha(string linea, int ubicacion, int otro)
            {
                index = ubicacion;
                valor = linea;

            }

        }
    }

}
