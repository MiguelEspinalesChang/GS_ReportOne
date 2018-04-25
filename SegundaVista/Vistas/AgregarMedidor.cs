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



        public void datosGtid(string clienteNombre, string NisCliente)
        {
           
        }


        private void AgregarMedidor_Load(object sender, EventArgs e)
        {

            pnlAlerta.Visible = true;
            pnlAlertaVerde.Visible = false;
            pnlAlertaRojo.Visible = false;
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
            try
            {
                float relacionTC, relacionTP;
                relacionTC = Convert.ToSingle(txtTc_primaria.Text) / Convert.ToSingle(txtTc_secundaria.Text);
                relacionTP = Convert.ToSingle(txtTP_primaria.Text) / Convert.ToSingle(txtTP_secundario.Text);
                txtRelacion_TC.Text = "" + relacionTC;
                txtRelacion_TP.Text = "" + relacionTP;

                Conector_DataBase conector = new Conector_DataBase();
                DatosMedidor Datos = new DatosMedidor();
                Datos.Nis = txtNIS.Text;
                Datos.Numero_Medidor = txtNumero_Medidor.Text;
                Datos.Nombre_Medidor = txtNombreMedidor.Text;
                Datos.Modo_Uso = txtModo_Uso.Text;
                Datos.Grupo = txtNumero_Grupo.Text;
                Datos.Nombre_Propietario = txtNom_Propietario.Text;
                Datos.UbicaCion = txtUbicacionMedidor.Text;
                Datos.KWH_Punto_dia = Convert.ToSingle(txtKWH_punto_dia.Text);
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
                //conector.insertar_Medidor(
                //    Datos.Nis, Datos.Numero_Medidor, Datos.Nombre_Medidor, Datos.Modo_Uso, Datos.Grupo,
                //    Datos.Nombre_Propietario,Datos.UbicaCion, Datos.KWH_Punto_dia, Datos.Potencia_Punto_dia,
                //    Datos.Marca, Datos.Modelo, Datos.Tipo, Datos.clase, Datos.Presicion,Datos.Codigo_fabricante,
                //    Datos.TC_Primario, Datos.TC_secundario,Datos.Relacion_TC, Datos.TP_Primario,Datos.TP_secundario,
                //    Datos.Relacion_TP, Datos.Numero_Cerie, Datos.Ia_punto, Datos.Ib_punto,Datos.Ic_punto, Datos.Va_punto,
                //    Datos.Vb_punto, Datos.Vc_punto
                //    );
                MessageBox.Show("Medidor Agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }


        }

        private void txtNIS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_Medidor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_Medidor_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_Medidor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtKWH_punto_dia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // validar.NumerosDecimales(e);
            // pnlAlertaRojo.Visible = true;
            // lblRojo.Text = "El Campo Solo Acepta números o números con punto decimal";
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "El Campo Solo Acepta números o números con punto decimal";
            }
        }

        private void btnCerrarAlertaR_Click(object sender, EventArgs e)
        {
            pnlAlertaRojo.Visible = false;
        }

        private void btnCerrarAlertaV_Click(object sender, EventArgs e)
        {
            pnlAlertaVerde.Visible = false;
        }

        private void txtTc_primaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "El Campo Solo Acepta números o números con punto decimal";
            }
        }

        private void txtTc_secundaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "El Campo Solo Acepta números o números con punto decimal";
            }
        }

        private void txtTP_primaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "El Campo Solo Acepta números o números con punto decimal";
            }
        }

        private void txtTP_secundario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "El Campo Solo Acepta números o números con punto decimal";
            }
        }

        private void txt_Ia_punto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "El Campo Solo Acepta números o números con punto decimal";
            }
        }

        private void txt_Ib_punto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Ib_punto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "El Campo Solo Acepta números o números con punto decimal";
            }
        }

        private void txt_Ic_punto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "El Campo Solo Acepta números o números con punto decimal";
            }
        }

        private void txt_Va_punto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "El Campo Solo Acepta números o números con punto decimal";
            }
        }

        private void txt_Vb_punto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Vb_punto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "El Campo Solo Acepta números o números con punto decimal";
            }
        }

        private void txt_Vc_punto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "El Campo Solo Acepta números o números con punto decimal";
            }
        }

        private void txt_Va_punto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "El Campo Solo Acepta números o números con punto decimal";
            }
        }
    }
}
