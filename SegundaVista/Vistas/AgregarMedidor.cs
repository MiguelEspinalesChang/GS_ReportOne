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
            pnlAlertaVerde.Visible = false;
            pnlAlertaRojo.Visible = false;
            DatosMedidor datosTxt = new DatosMedidor();
            Conector_DataBase conector = new Conector_DataBase();

            try { 

            //Campos Obligatorios


            //Ternarios Para Validar Y rellenar los datos del Medidor
            datosTxt.Area = (string.IsNullOrEmpty(txtArea.Text)) ? "" : txtArea.Text;
            datosTxt.Modo_Uso = (string.IsNullOrEmpty(txtModo_Uso.Text)) ? "" : txtModo_Uso.Text;
            datosTxt.Ubicacion = (string.IsNullOrEmpty(txtUbicacionMedidor.Text)) ? "" : txtUbicacionMedidor.Text;
            datosTxt.KWH_Punto_dia = (string.IsNullOrEmpty(txtKWH_punto_dia.Text)) ? 0 : Convert.ToSingle(txtKWH_punto_dia.Text);
            datosTxt.Grupo = (string.IsNullOrEmpty(txtNumero_Grupo.Text)) ? "" : txtNumero_Grupo.Text;
            datosTxt.Potencia_Punto_dia = (string.IsNullOrEmpty(txtPotencia_Punto_dia.Text)) ? 0 : Convert.ToSingle(txtArea.Text);
            datosTxt.Marca = (string.IsNullOrEmpty(txtMarca.Text)) ? "" : txtPotencia_Punto_dia.Text;
            datosTxt.Modelo = (string.IsNullOrEmpty(txtModelo.Text)) ? "" : txtModelo.Text;
            datosTxt.Tipo = (string.IsNullOrEmpty(txtTipo.Text)) ? "" : txtTipo.Text;
            datosTxt.Presicion = (string.IsNullOrEmpty(txtPresicion.Text)) ? 0 : Convert.ToSingle(txtPresicion.Text);
            datosTxt.Codigo_fabricante = (string.IsNullOrEmpty(txtCodigo_Fabricante.Text)) ? "" : txtCodigo_Fabricante.Text;
            datosTxt.TC_Primario = (string.IsNullOrEmpty(txtTc_primaria.Text)) ? 0 : Convert.ToSingle(txtTipo.Text);
            datosTxt.TC_secundario = (string.IsNullOrEmpty(txtTc_secundaria.Text)) ? 0 : Convert.ToSingle(txtTc_secundaria.Text);
            datosTxt.TP_Primario = (string.IsNullOrEmpty(txtTP_primaria.Text)) ? 0 : Convert.ToSingle(txtTP_primaria.Text);
            datosTxt.TP_secundario = (string.IsNullOrEmpty(txtTP_secundario.Text)) ? 0 : Convert.ToSingle(txtTP_secundario.Text);
            datosTxt.Numero_Cerie = (string.IsNullOrEmpty(txtNumero_Serie.Text)) ? "" : txtNumero_Serie.Text;
            datosTxt.Ia_punto = (string.IsNullOrEmpty(txt_Ia_punto.Text)) ? 0 : Convert.ToSingle(txt_Ia_punto.Text);
            datosTxt.Ib_punto = (string.IsNullOrEmpty(txt_Ib_punto.Text)) ? 0 : Convert.ToSingle(txt_Ib_punto.Text);
            datosTxt.Ic_punto = (string.IsNullOrEmpty(txt_Ic_punto.Text)) ? 0 : Convert.ToSingle(txt_Ic_punto.Text);
            datosTxt.Va_punto = (string.IsNullOrEmpty(txt_Va_punto.Text)) ? 0 : Convert.ToSingle(txt_Va_punto.Text);
            datosTxt.Vb_punto = (string.IsNullOrEmpty(txt_Vb_punto.Text)) ? 0 : Convert.ToSingle(txt_Vb_punto.Text);
            datosTxt.Vc_punto = (string.IsNullOrEmpty(txt_Vc_punto.Text)) ? 0 : Convert.ToSingle(txt_Vc_punto.Text);
            if (datosTxt.TC_secundario == 0)
            {
                datosTxt.Relacion_TC = 0;
            }
            else
            {
                datosTxt.Relacion_TC = datosTxt.TC_Primario / datosTxt.TC_secundario;
            }

            if (datosTxt.TP_secundario == 0)
            {
                datosTxt.Relacion_TP = 0;
            }
            else
            {
                datosTxt.Relacion_TP = datosTxt.TP_Primario / datosTxt.TP_secundario;
            }
            //Comunicacion
            //Eternet
            datosTxt.Eternet = check_Eternet.Checked;
            datosTxt.Eternet_NumeroIp = (string.IsNullOrEmpty(txtNumeroIp_Eternet.Text)) ? "" : txtNumero_Serie.Text;
            if (radio_Eternet_si.Checked == true)
            {
                datosTxt.Eternet_Operativo = true;
            }
            else
            {
                datosTxt.Eternet_Operativo = false;
            }

              //  conector.insertar_Medidor(datosTxt);
                pnlAlertaVerde.Visible = true;
                lbl_verde.Text = "Medidor Guardado";
            }
            catch (Exception ex)
            {
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "Error Al Guardar Los Datos Del Medidor";

            }


            // pnlAlertaRojo.Visible = true;
            // lblRojo.Text = "Por Favor Rellene Todos Los Campos ";
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

        private bool ValidadorChart(char texto, List<string> tipos)
        {

            foreach (var item in tipos)
            {

                switch (item)
                {
                    case "numero":
                        if (!Char.IsDigit(texto))
                        {
                            return false;
                        }
                        else if (Char.IsSeparator(texto))
                        {
                            return  false;
                        }
                        else if (Char.IsControl(texto))
                        {
                            return false;
                        }
                        else if (Char.IsControl(texto))
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                       }
                        break;

                    case "texto":
                        break;

                }

            }

            return true;
        }

        ///////////////
        

        private void txtClase_KeyPress(object sender, KeyPressEventArgs e)
        {
            //List<string> listaTipos = new List<string>();
            //listaTipos.Add("numero");
            //bool esValido = ValidadorChart(e.KeyChar, listaTipos);

            //if (esValido)
            //{
            //    pnlAlertaRojo.Visible = false;
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //    pnlAlertaRojo.Visible = true;
            //    lblRojo.Text = "El Campo Solo Acepta números ";
            //}

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
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "El Campo Solo Acepta números ";
            }

        }



        ////////////////////////////////

        private void txtPresicion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPotencia_Punto_dia_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNumTelefono_modem_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                pnlAlertaRojo.Visible = true;
                lblRojo.Text = "El Campo Solo Acepta números ";
            }
        }

        private void txtNumero_Medidor_Validated(object sender, EventArgs e)
        {
            if (txtNumero_Medidor.Text.Trim() == "")
            {
                epError.SetError(txtNumero_Medidor, "Introduzca Numero Del Medidor ");
                txtNumero_Medidor.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
    }
}
