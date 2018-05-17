namespace SegundaVista.Vistas
{
    partial class AgregarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCliente));
            this.PnlBarraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlBtnClientes = new System.Windows.Forms.Panel();
            this.pnlAlerta = new System.Windows.Forms.Panel();
            this.pnlAlertaVerde = new System.Windows.Forms.Panel();
            this.pnlAlertaRojo = new System.Windows.Forms.Panel();
            this.btnCerrarAlertaR = new System.Windows.Forms.PictureBox();
            this.lblRojo = new System.Windows.Forms.Label();
            this.lbl_verde = new System.Windows.Forms.Label();
            this.btnCerrarAlertaV = new System.Windows.Forms.PictureBox();
            this.lblverde = new System.Windows.Forms.Label();
            this.btnGuardarMedidor = new System.Windows.Forms.Button();
            this.PnlFormCliente = new System.Windows.Forms.Panel();
            this.txt_m_NisCliente = new MetroFramework.Controls.MetroTextBox();
            this.txt_m_Ruc = new MetroFramework.Controls.MetroTextBox();
            this.txt_m_RazonSocial = new MetroFramework.Controls.MetroTextBox();
            this.txt_m_DirigirReporte = new MetroFramework.Controls.MetroTextBox();
            this.txt_m_ResMedicion = new MetroFramework.Controls.MetroTextBox();
            this.txt_m_NomEmpresa = new MetroFramework.Controls.MetroTextBox();
            this.txt_m_Apellido = new MetroFramework.Controls.MetroTextBox();
            this.txt_m_Nombre = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.PnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlBtnClientes.SuspendLayout();
            this.pnlAlerta.SuspendLayout();
            this.pnlAlertaVerde.SuspendLayout();
            this.pnlAlertaRojo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarAlertaR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarAlertaV)).BeginInit();
            this.PnlFormCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBarraTitulo
            // 
            this.PnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(178)))));
            this.PnlBarraTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBarraTitulo.Controls.Add(this.label1);
            this.PnlBarraTitulo.Controls.Add(this.btnCerrar);
            this.PnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlBarraTitulo.Name = "PnlBarraTitulo";
            this.PnlBarraTitulo.Size = new System.Drawing.Size(480, 38);
            this.PnlBarraTitulo.TabIndex = 7;
            this.PnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlBarraTitulo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "GS Report One - Agregar Cliente";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(439, -1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(36, 38);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlBtnClientes
            // 
            this.pnlBtnClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBtnClientes.Controls.Add(this.pnlAlerta);
            this.pnlBtnClientes.Controls.Add(this.btnGuardarMedidor);
            this.pnlBtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBtnClientes.Location = new System.Drawing.Point(0, 38);
            this.pnlBtnClientes.Name = "pnlBtnClientes";
            this.pnlBtnClientes.Size = new System.Drawing.Size(480, 57);
            this.pnlBtnClientes.TabIndex = 8;
            // 
            // pnlAlerta
            // 
            this.pnlAlerta.Controls.Add(this.pnlAlertaVerde);
            this.pnlAlerta.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAlerta.Location = new System.Drawing.Point(233, 0);
            this.pnlAlerta.Name = "pnlAlerta";
            this.pnlAlerta.Size = new System.Drawing.Size(245, 55);
            this.pnlAlerta.TabIndex = 24;
            // 
            // pnlAlertaVerde
            // 
            this.pnlAlertaVerde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAlertaVerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(216)))));
            this.pnlAlertaVerde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlAlertaVerde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAlertaVerde.Controls.Add(this.pnlAlertaRojo);
            this.pnlAlertaVerde.Controls.Add(this.lbl_verde);
            this.pnlAlertaVerde.Controls.Add(this.btnCerrarAlertaV);
            this.pnlAlertaVerde.Controls.Add(this.lblverde);
            this.pnlAlertaVerde.Location = new System.Drawing.Point(45, 6);
            this.pnlAlertaVerde.Name = "pnlAlertaVerde";
            this.pnlAlertaVerde.Size = new System.Drawing.Size(197, 30);
            this.pnlAlertaVerde.TabIndex = 0;
            // 
            // pnlAlertaRojo
            // 
            this.pnlAlertaRojo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAlertaRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.pnlAlertaRojo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlAlertaRojo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAlertaRojo.Controls.Add(this.btnCerrarAlertaR);
            this.pnlAlertaRojo.Controls.Add(this.lblRojo);
            this.pnlAlertaRojo.Location = new System.Drawing.Point(-1, -1);
            this.pnlAlertaRojo.Name = "pnlAlertaRojo";
            this.pnlAlertaRojo.Size = new System.Drawing.Size(197, 30);
            this.pnlAlertaRojo.TabIndex = 1;
            // 
            // btnCerrarAlertaR
            // 
            this.btnCerrarAlertaR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarAlertaR.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarAlertaR.Image")));
            this.btnCerrarAlertaR.Location = new System.Drawing.Point(5, 3);
            this.btnCerrarAlertaR.Name = "btnCerrarAlertaR";
            this.btnCerrarAlertaR.Size = new System.Drawing.Size(22, 22);
            this.btnCerrarAlertaR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrarAlertaR.TabIndex = 2;
            this.btnCerrarAlertaR.TabStop = false;
            this.btnCerrarAlertaR.Click += new System.EventHandler(this.btnCerrarAlertaR_Click);
            // 
            // lblRojo
            // 
            this.lblRojo.AutoSize = true;
            this.lblRojo.Location = new System.Drawing.Point(47, 8);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(0, 13);
            this.lblRojo.TabIndex = 0;
            this.lblRojo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_verde
            // 
            this.lbl_verde.AutoSize = true;
            this.lbl_verde.Location = new System.Drawing.Point(33, 7);
            this.lbl_verde.Name = "lbl_verde";
            this.lbl_verde.Size = new System.Drawing.Size(0, 13);
            this.lbl_verde.TabIndex = 2;
            // 
            // btnCerrarAlertaV
            // 
            this.btnCerrarAlertaV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarAlertaV.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarAlertaV.Image")));
            this.btnCerrarAlertaV.Location = new System.Drawing.Point(5, 3);
            this.btnCerrarAlertaV.Name = "btnCerrarAlertaV";
            this.btnCerrarAlertaV.Size = new System.Drawing.Size(22, 22);
            this.btnCerrarAlertaV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrarAlertaV.TabIndex = 1;
            this.btnCerrarAlertaV.TabStop = false;
            this.btnCerrarAlertaV.Click += new System.EventHandler(this.btnCerrarAlertaV_Click);
            // 
            // lblverde
            // 
            this.lblverde.AutoSize = true;
            this.lblverde.Location = new System.Drawing.Point(312, 7);
            this.lblverde.Name = "lblverde";
            this.lblverde.Size = new System.Drawing.Size(0, 13);
            this.lblverde.TabIndex = 0;
            // 
            // btnGuardarMedidor
            // 
            this.btnGuardarMedidor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(178)))));
            this.btnGuardarMedidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMedidor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMedidor.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarMedidor.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarMedidor.Image")));
            this.btnGuardarMedidor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarMedidor.Location = new System.Drawing.Point(12, 6);
            this.btnGuardarMedidor.Name = "btnGuardarMedidor";
            this.btnGuardarMedidor.Size = new System.Drawing.Size(169, 41);
            this.btnGuardarMedidor.TabIndex = 22;
            this.btnGuardarMedidor.Text = "Guardar";
            this.btnGuardarMedidor.UseVisualStyleBackColor = true;
            this.btnGuardarMedidor.Click += new System.EventHandler(this.btnGuardarMedidor_Click);
            // 
            // PnlFormCliente
            // 
            this.PnlFormCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlFormCliente.Controls.Add(this.txt_m_NisCliente);
            this.PnlFormCliente.Controls.Add(this.txt_m_Ruc);
            this.PnlFormCliente.Controls.Add(this.txt_m_RazonSocial);
            this.PnlFormCliente.Controls.Add(this.txt_m_DirigirReporte);
            this.PnlFormCliente.Controls.Add(this.txt_m_ResMedicion);
            this.PnlFormCliente.Controls.Add(this.txt_m_NomEmpresa);
            this.PnlFormCliente.Controls.Add(this.txt_m_Apellido);
            this.PnlFormCliente.Controls.Add(this.txt_m_Nombre);
            this.PnlFormCliente.Controls.Add(this.label8);
            this.PnlFormCliente.Controls.Add(this.label7);
            this.PnlFormCliente.Controls.Add(this.label6);
            this.PnlFormCliente.Controls.Add(this.label5);
            this.PnlFormCliente.Controls.Add(this.label4);
            this.PnlFormCliente.Controls.Add(this.label3);
            this.PnlFormCliente.Controls.Add(this.label2);
            this.PnlFormCliente.Controls.Add(this.label19);
            this.PnlFormCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFormCliente.Location = new System.Drawing.Point(0, 95);
            this.PnlFormCliente.Name = "PnlFormCliente";
            this.PnlFormCliente.Size = new System.Drawing.Size(480, 335);
            this.PnlFormCliente.TabIndex = 9;
            // 
            // txt_m_NisCliente
            // 
            // 
            // 
            // 
            this.txt_m_NisCliente.CustomButton.Image = null;
            this.txt_m_NisCliente.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txt_m_NisCliente.CustomButton.Name = "";
            this.txt_m_NisCliente.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_m_NisCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_m_NisCliente.CustomButton.TabIndex = 1;
            this.txt_m_NisCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_m_NisCliente.CustomButton.UseSelectable = true;
            this.txt_m_NisCliente.CustomButton.Visible = false;
            this.txt_m_NisCliente.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_m_NisCliente.Lines = new string[0];
            this.txt_m_NisCliente.Location = new System.Drawing.Point(281, 135);
            this.txt_m_NisCliente.MaxLength = 32767;
            this.txt_m_NisCliente.Name = "txt_m_NisCliente";
            this.txt_m_NisCliente.PasswordChar = '\0';
            this.txt_m_NisCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_m_NisCliente.SelectedText = "";
            this.txt_m_NisCliente.SelectionLength = 0;
            this.txt_m_NisCliente.SelectionStart = 0;
            this.txt_m_NisCliente.ShortcutsEnabled = true;
            this.txt_m_NisCliente.Size = new System.Drawing.Size(166, 25);
            this.txt_m_NisCliente.TabIndex = 107;
            this.txt_m_NisCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_m_NisCliente.UseSelectable = true;
            this.txt_m_NisCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_m_NisCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_m_Ruc
            // 
            // 
            // 
            // 
            this.txt_m_Ruc.CustomButton.Image = null;
            this.txt_m_Ruc.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txt_m_Ruc.CustomButton.Name = "";
            this.txt_m_Ruc.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_m_Ruc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_m_Ruc.CustomButton.TabIndex = 1;
            this.txt_m_Ruc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_m_Ruc.CustomButton.UseSelectable = true;
            this.txt_m_Ruc.CustomButton.Visible = false;
            this.txt_m_Ruc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_m_Ruc.Lines = new string[0];
            this.txt_m_Ruc.Location = new System.Drawing.Point(281, 77);
            this.txt_m_Ruc.MaxLength = 32767;
            this.txt_m_Ruc.Name = "txt_m_Ruc";
            this.txt_m_Ruc.PasswordChar = '\0';
            this.txt_m_Ruc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_m_Ruc.SelectedText = "";
            this.txt_m_Ruc.SelectionLength = 0;
            this.txt_m_Ruc.SelectionStart = 0;
            this.txt_m_Ruc.ShortcutsEnabled = true;
            this.txt_m_Ruc.Size = new System.Drawing.Size(166, 25);
            this.txt_m_Ruc.TabIndex = 106;
            this.txt_m_Ruc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_m_Ruc.UseSelectable = true;
            this.txt_m_Ruc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_m_Ruc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_m_RazonSocial
            // 
            // 
            // 
            // 
            this.txt_m_RazonSocial.CustomButton.Image = null;
            this.txt_m_RazonSocial.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txt_m_RazonSocial.CustomButton.Name = "";
            this.txt_m_RazonSocial.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_m_RazonSocial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_m_RazonSocial.CustomButton.TabIndex = 1;
            this.txt_m_RazonSocial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_m_RazonSocial.CustomButton.UseSelectable = true;
            this.txt_m_RazonSocial.CustomButton.Visible = false;
            this.txt_m_RazonSocial.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_m_RazonSocial.Lines = new string[0];
            this.txt_m_RazonSocial.Location = new System.Drawing.Point(281, 27);
            this.txt_m_RazonSocial.MaxLength = 32767;
            this.txt_m_RazonSocial.Name = "txt_m_RazonSocial";
            this.txt_m_RazonSocial.PasswordChar = '\0';
            this.txt_m_RazonSocial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_m_RazonSocial.SelectedText = "";
            this.txt_m_RazonSocial.SelectionLength = 0;
            this.txt_m_RazonSocial.SelectionStart = 0;
            this.txt_m_RazonSocial.ShortcutsEnabled = true;
            this.txt_m_RazonSocial.Size = new System.Drawing.Size(166, 25);
            this.txt_m_RazonSocial.TabIndex = 105;
            this.txt_m_RazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_m_RazonSocial.UseSelectable = true;
            this.txt_m_RazonSocial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_m_RazonSocial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_m_DirigirReporte
            // 
            // 
            // 
            // 
            this.txt_m_DirigirReporte.CustomButton.Image = null;
            this.txt_m_DirigirReporte.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txt_m_DirigirReporte.CustomButton.Name = "";
            this.txt_m_DirigirReporte.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_m_DirigirReporte.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_m_DirigirReporte.CustomButton.TabIndex = 1;
            this.txt_m_DirigirReporte.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_m_DirigirReporte.CustomButton.UseSelectable = true;
            this.txt_m_DirigirReporte.CustomButton.Visible = false;
            this.txt_m_DirigirReporte.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_m_DirigirReporte.Lines = new string[0];
            this.txt_m_DirigirReporte.Location = new System.Drawing.Point(12, 246);
            this.txt_m_DirigirReporte.MaxLength = 32767;
            this.txt_m_DirigirReporte.Name = "txt_m_DirigirReporte";
            this.txt_m_DirigirReporte.PasswordChar = '\0';
            this.txt_m_DirigirReporte.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_m_DirigirReporte.SelectedText = "";
            this.txt_m_DirigirReporte.SelectionLength = 0;
            this.txt_m_DirigirReporte.SelectionStart = 0;
            this.txt_m_DirigirReporte.ShortcutsEnabled = true;
            this.txt_m_DirigirReporte.Size = new System.Drawing.Size(166, 25);
            this.txt_m_DirigirReporte.TabIndex = 104;
            this.txt_m_DirigirReporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_m_DirigirReporte.UseSelectable = true;
            this.txt_m_DirigirReporte.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_m_DirigirReporte.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_m_ResMedicion
            // 
            // 
            // 
            // 
            this.txt_m_ResMedicion.CustomButton.Image = null;
            this.txt_m_ResMedicion.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txt_m_ResMedicion.CustomButton.Name = "";
            this.txt_m_ResMedicion.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_m_ResMedicion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_m_ResMedicion.CustomButton.TabIndex = 1;
            this.txt_m_ResMedicion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_m_ResMedicion.CustomButton.UseSelectable = true;
            this.txt_m_ResMedicion.CustomButton.Visible = false;
            this.txt_m_ResMedicion.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_m_ResMedicion.Lines = new string[0];
            this.txt_m_ResMedicion.Location = new System.Drawing.Point(12, 193);
            this.txt_m_ResMedicion.MaxLength = 32767;
            this.txt_m_ResMedicion.Name = "txt_m_ResMedicion";
            this.txt_m_ResMedicion.PasswordChar = '\0';
            this.txt_m_ResMedicion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_m_ResMedicion.SelectedText = "";
            this.txt_m_ResMedicion.SelectionLength = 0;
            this.txt_m_ResMedicion.SelectionStart = 0;
            this.txt_m_ResMedicion.ShortcutsEnabled = true;
            this.txt_m_ResMedicion.Size = new System.Drawing.Size(166, 25);
            this.txt_m_ResMedicion.TabIndex = 103;
            this.txt_m_ResMedicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_m_ResMedicion.UseSelectable = true;
            this.txt_m_ResMedicion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_m_ResMedicion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_m_NomEmpresa
            // 
            // 
            // 
            // 
            this.txt_m_NomEmpresa.CustomButton.Image = null;
            this.txt_m_NomEmpresa.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txt_m_NomEmpresa.CustomButton.Name = "";
            this.txt_m_NomEmpresa.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_m_NomEmpresa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_m_NomEmpresa.CustomButton.TabIndex = 1;
            this.txt_m_NomEmpresa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_m_NomEmpresa.CustomButton.UseSelectable = true;
            this.txt_m_NomEmpresa.CustomButton.Visible = false;
            this.txt_m_NomEmpresa.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_m_NomEmpresa.Lines = new string[0];
            this.txt_m_NomEmpresa.Location = new System.Drawing.Point(12, 135);
            this.txt_m_NomEmpresa.MaxLength = 32767;
            this.txt_m_NomEmpresa.Name = "txt_m_NomEmpresa";
            this.txt_m_NomEmpresa.PasswordChar = '\0';
            this.txt_m_NomEmpresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_m_NomEmpresa.SelectedText = "";
            this.txt_m_NomEmpresa.SelectionLength = 0;
            this.txt_m_NomEmpresa.SelectionStart = 0;
            this.txt_m_NomEmpresa.ShortcutsEnabled = true;
            this.txt_m_NomEmpresa.Size = new System.Drawing.Size(166, 25);
            this.txt_m_NomEmpresa.TabIndex = 102;
            this.txt_m_NomEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_m_NomEmpresa.UseSelectable = true;
            this.txt_m_NomEmpresa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_m_NomEmpresa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_m_Apellido
            // 
            // 
            // 
            // 
            this.txt_m_Apellido.CustomButton.Image = null;
            this.txt_m_Apellido.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txt_m_Apellido.CustomButton.Name = "";
            this.txt_m_Apellido.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_m_Apellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_m_Apellido.CustomButton.TabIndex = 1;
            this.txt_m_Apellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_m_Apellido.CustomButton.UseSelectable = true;
            this.txt_m_Apellido.CustomButton.Visible = false;
            this.txt_m_Apellido.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_m_Apellido.Lines = new string[0];
            this.txt_m_Apellido.Location = new System.Drawing.Point(12, 77);
            this.txt_m_Apellido.MaxLength = 32767;
            this.txt_m_Apellido.Name = "txt_m_Apellido";
            this.txt_m_Apellido.PasswordChar = '\0';
            this.txt_m_Apellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_m_Apellido.SelectedText = "";
            this.txt_m_Apellido.SelectionLength = 0;
            this.txt_m_Apellido.SelectionStart = 0;
            this.txt_m_Apellido.ShortcutsEnabled = true;
            this.txt_m_Apellido.Size = new System.Drawing.Size(166, 25);
            this.txt_m_Apellido.TabIndex = 101;
            this.txt_m_Apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_m_Apellido.UseSelectable = true;
            this.txt_m_Apellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_m_Apellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_m_Nombre
            // 
            // 
            // 
            // 
            this.txt_m_Nombre.CustomButton.Image = null;
            this.txt_m_Nombre.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txt_m_Nombre.CustomButton.Name = "";
            this.txt_m_Nombre.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_m_Nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_m_Nombre.CustomButton.TabIndex = 1;
            this.txt_m_Nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_m_Nombre.CustomButton.UseSelectable = true;
            this.txt_m_Nombre.CustomButton.Visible = false;
            this.txt_m_Nombre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_m_Nombre.Lines = new string[0];
            this.txt_m_Nombre.Location = new System.Drawing.Point(12, 27);
            this.txt_m_Nombre.MaxLength = 32767;
            this.txt_m_Nombre.Name = "txt_m_Nombre";
            this.txt_m_Nombre.PasswordChar = '\0';
            this.txt_m_Nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_m_Nombre.SelectedText = "";
            this.txt_m_Nombre.SelectionLength = 0;
            this.txt_m_Nombre.SelectionStart = 0;
            this.txt_m_Nombre.ShortcutsEnabled = true;
            this.txt_m_Nombre.Size = new System.Drawing.Size(166, 25);
            this.txt_m_Nombre.TabIndex = 100;
            this.txt_m_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_m_Nombre.UseSelectable = true;
            this.txt_m_Nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_m_Nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(277, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 22);
            this.label8.TabIndex = 98;
            this.label8.Text = "NisCliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 22);
            this.label7.TabIndex = 96;
            this.label7.Text = "Dirigir Reporte A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 22);
            this.label6.TabIndex = 94;
            this.label6.Text = "Responsable De La Medicion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 92;
            this.label5.Text = "Ruc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 90;
            this.label4.Text = "Razón Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 22);
            this.label3.TabIndex = 88;
            this.label3.Text = "Nombre De La Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 83;
            this.label2.Text = "Apellido";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(8, 2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 22);
            this.label19.TabIndex = 80;
            this.label19.Text = "Nombre";
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 430);
            this.Controls.Add(this.PnlFormCliente);
            this.Controls.Add(this.pnlBtnClientes);
            this.Controls.Add(this.PnlBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(480, 430);
            this.MinimumSize = new System.Drawing.Size(480, 430);
            this.Name = "AgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCliente";
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            this.PnlBarraTitulo.ResumeLayout(false);
            this.PnlBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlBtnClientes.ResumeLayout(false);
            this.pnlAlerta.ResumeLayout(false);
            this.pnlAlertaVerde.ResumeLayout(false);
            this.pnlAlertaVerde.PerformLayout();
            this.pnlAlertaRojo.ResumeLayout(false);
            this.pnlAlertaRojo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarAlertaR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarAlertaV)).EndInit();
            this.PnlFormCliente.ResumeLayout(false);
            this.PnlFormCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBarraTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel pnlBtnClientes;
        private System.Windows.Forms.Panel PnlFormCliente;
        private System.Windows.Forms.Button btnGuardarMedidor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Panel pnlAlerta;
        public System.Windows.Forms.Panel pnlAlertaRojo;
        private System.Windows.Forms.PictureBox btnCerrarAlertaR;
        public System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.Panel pnlAlertaVerde;
        private System.Windows.Forms.PictureBox btnCerrarAlertaV;
        private System.Windows.Forms.Label lblverde;
        private System.Windows.Forms.Label lbl_verde;
        private MetroFramework.Controls.MetroTextBox txt_m_Nombre;
        private MetroFramework.Controls.MetroTextBox txt_m_DirigirReporte;
        private MetroFramework.Controls.MetroTextBox txt_m_ResMedicion;
        private MetroFramework.Controls.MetroTextBox txt_m_NomEmpresa;
        private MetroFramework.Controls.MetroTextBox txt_m_Apellido;
        private MetroFramework.Controls.MetroTextBox txt_m_NisCliente;
        private MetroFramework.Controls.MetroTextBox txt_m_Ruc;
        private MetroFramework.Controls.MetroTextBox txt_m_RazonSocial;
    }
}