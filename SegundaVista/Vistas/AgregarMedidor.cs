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

namespace SegundaVista.Vistas
{
    public partial class AgregarMedidor : Form
    {
        public AgregarMedidor()
        {
            InitializeComponent();
        }

        private void AgregarMedidor_Load(object sender, EventArgs e)
        {
            string NIS,NOMBRE;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreMedidor_TextChanged(object sender, EventArgs e)
        {

        }

        private void PnlFormMedidor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radio_Eternet_si_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radio_Eternet_no_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarMedidor_Click(object sender, EventArgs e)
        {
            float relacionTC , relacionTP;
            relacionTC = Convert.ToSingle(txtTc_primaria.Text) / Convert.ToSingle(txtTc_secundaria.Text);
            relacionTP = Convert.ToSingle(txtTP_primaria.Text) / Convert.ToSingle(txtTP_secundario.Text);
            txtRelacion_TC.Text = ""+ relacionTC;
            txtRelacion_TP.Text = "" + relacionTP;

            Conector_DataBase conector = new Conector_DataBase();
            DatosMedidor Datos = new DatosMedidor();
            Datos.Nis = txtNIS.Text;
            Datos.Numero_Medidor =  txtNumero_Medidor.Text;
            Datos.Nombre_Medidor = txtNombreMedidor.Text;
            Datos.Modo_Uso = txtModo_Uso.Text;
            Datos.Grupo = txtNumero_Grupo.Text;
            Datos.Nombre_Propietario = txtNom_Propietario.Text;
            Datos.UbicaCion = txtUbicacionMedidor.Text;
            Datos.KWH_Punto_dia =  Convert.ToSingle(txtKWH_punto_dia.Text);
            Datos.Potencia_Punto_dia = Convert.ToSingle(txtPotencia_Punto_dia.Text);
            Datos.Marca = txtMarca.Text;
            Datos.Modelo = txtModelo.Text;
            Datos.Tipo = txtTipo.Text;
            Datos.clase = Convert.ToInt16(txtClase.Text);
            Datos.Presicion = Convert.ToSingle(txtPresicion.Text);
            Datos.Codigo_fabricante = txtCodigo_Fabricante.Text;
            Datos.TC_Primario = Convert.ToSingle(txtTc_primaria.Text);
            Datos.TC_secundario = Convert.ToSingle(txtTc_secundaria.Text);
            Datos.Relacion_TC = relacionTC;
            Datos.TP_Primario = Convert.ToSingle(txtTP_primaria.Text);
            Datos.TP_secundario = Convert.ToSingle(txtTP_secundario.Text);
            Datos.Relacion_TP = relacionTP;
            Datos.Numero_Cerie = txtNumero_Serie.Text;
            Datos.Ia_punto = Convert.ToSingle(txt_Ia_punto.Text);
            Datos.Ib_punto = Convert.ToSingle(txt_Ib_punto.Text);
            Datos.Ic_punto = Convert.ToSingle(txt_Ic_punto.Text);
            Datos.Va_punto = Convert.ToSingle(txt_Va_punto.Text);
            Datos.Vb_punto = Convert.ToSingle(txt_Vb_punto.Text);
            Datos.Vc_punto = Convert.ToSingle(txt_Vc_punto.Text);

        }


        //https://www.youtube.com/watch?v=rv4IJfjD8K0
        //https://social.msdn.microsoft.com/Forums/es-ES/cf1fdace-f4f0-4f9a-915d-02191ad56b2b/recoger-datos-de-una-fila-de-un-datagrid?forum=vcses


    }
}
