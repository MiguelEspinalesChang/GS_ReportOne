namespace SegundaVista.Vistas
{
    partial class EditarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarCliente));
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
            this.btnGuardarClienteEditado = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlFormCliente = new System.Windows.Forms.Panel();
            this.txt_E_NisCliente = new MetroFramework.Controls.MetroTextBox();
            this.txt_E_Ruc = new MetroFramework.Controls.MetroTextBox();
            this.txt_E_RazonSocial = new MetroFramework.Controls.MetroTextBox();
            this.txt_E_DirigirReporte = new MetroFramework.Controls.MetroTextBox();
            this.txt_E_ResponsableMedidcion = new MetroFramework.Controls.MetroTextBox();
            this.txt_E_NombreEmpresa = new MetroFramework.Controls.MetroTextBox();
            this.txt_E_Apellido = new MetroFramework.Controls.MetroTextBox();
            this.txt_E_Nombre = new MetroFramework.Controls.MetroTextBox();
            this.txt_IdCliente = new MetroFramework.Controls.MetroTextBox();
            this.lblNisCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.PnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.PnlBarraTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBarraTitulo.Controls.Add(this.label1);
            this.PnlBarraTitulo.Controls.Add(this.btnCerrar);
            this.PnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlBarraTitulo.Name = "PnlBarraTitulo";
            this.PnlBarraTitulo.Size = new System.Drawing.Size(480, 38);
            this.PnlBarraTitulo.TabIndex = 8;
            this.PnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlBarraTitulo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "GS Report One - Editar Cliente";
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
            this.pnlBtnClientes.Controls.Add(this.btnGuardarClienteEditado);
            this.pnlBtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBtnClientes.Location = new System.Drawing.Point(0, 38);
            this.pnlBtnClientes.Name = "pnlBtnClientes";
            this.pnlBtnClientes.Size = new System.Drawing.Size(480, 57);
            this.pnlBtnClientes.TabIndex = 9;
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
            // btnGuardarClienteEditado
            // 
            this.btnGuardarClienteEditado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(178)))));
            this.btnGuardarClienteEditado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarClienteEditado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarClienteEditado.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarClienteEditado.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarClienteEditado.Image")));
            this.btnGuardarClienteEditado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarClienteEditado.Location = new System.Drawing.Point(12, 6);
            this.btnGuardarClienteEditado.Name = "btnGuardarClienteEditado";
            this.btnGuardarClienteEditado.Size = new System.Drawing.Size(169, 41);
            this.btnGuardarClienteEditado.TabIndex = 22;
            this.btnGuardarClienteEditado.Text = "Guardar";
            this.btnGuardarClienteEditado.UseVisualStyleBackColor = true;
            this.btnGuardarClienteEditado.Click += new System.EventHandler(this.btnGuardarMedidor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(244, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 22);
            this.label8.TabIndex = 98;
            this.label8.Text = "NisCliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 22);
            this.label6.TabIndex = 94;
            this.label6.Text = "Responsable De La Medicion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 92;
            this.label5.Text = "Ruc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 90;
            this.label4.Text = "Razón Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 22);
            this.label3.TabIndex = 88;
            this.label3.Text = "Nombre De La Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 83;
            this.label2.Text = "Apellido";
            // 
            // PnlFormCliente
            // 
            this.PnlFormCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlFormCliente.Controls.Add(this.txt_E_NisCliente);
            this.PnlFormCliente.Controls.Add(this.txt_E_Ruc);
            this.PnlFormCliente.Controls.Add(this.txt_E_RazonSocial);
            this.PnlFormCliente.Controls.Add(this.txt_E_DirigirReporte);
            this.PnlFormCliente.Controls.Add(this.txt_E_ResponsableMedidcion);
            this.PnlFormCliente.Controls.Add(this.txt_E_NombreEmpresa);
            this.PnlFormCliente.Controls.Add(this.txt_E_Apellido);
            this.PnlFormCliente.Controls.Add(this.txt_E_Nombre);
            this.PnlFormCliente.Controls.Add(this.txt_IdCliente);
            this.PnlFormCliente.Controls.Add(this.lblNisCliente);
            this.PnlFormCliente.Controls.Add(this.lblNombreCliente);
            this.PnlFormCliente.Controls.Add(this.label9);
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
            this.PnlFormCliente.Size = new System.Drawing.Size(480, 347);
            this.PnlFormCliente.TabIndex = 10;
            this.PnlFormCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlFormCliente_Paint);
            // 
            // txt_E_NisCliente
            // 
            // 
            // 
            // 
            this.txt_E_NisCliente.CustomButton.Image = null;
            this.txt_E_NisCliente.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txt_E_NisCliente.CustomButton.Name = "";
            this.txt_E_NisCliente.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_E_NisCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_E_NisCliente.CustomButton.TabIndex = 1;
            this.txt_E_NisCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_E_NisCliente.CustomButton.UseSelectable = true;
            this.txt_E_NisCliente.CustomButton.Visible = false;
            this.txt_E_NisCliente.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_E_NisCliente.Lines = new string[0];
            this.txt_E_NisCliente.Location = new System.Drawing.Point(248, 125);
            this.txt_E_NisCliente.MaxLength = 32767;
            this.txt_E_NisCliente.Name = "txt_E_NisCliente";
            this.txt_E_NisCliente.PasswordChar = '\0';
            this.txt_E_NisCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_E_NisCliente.SelectedText = "";
            this.txt_E_NisCliente.SelectionLength = 0;
            this.txt_E_NisCliente.SelectionStart = 0;
            this.txt_E_NisCliente.ShortcutsEnabled = true;
            this.txt_E_NisCliente.Size = new System.Drawing.Size(166, 25);
            this.txt_E_NisCliente.TabIndex = 120;
            this.txt_E_NisCliente.UseSelectable = true;
            this.txt_E_NisCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_E_NisCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_E_Ruc
            // 
            // 
            // 
            // 
            this.txt_E_Ruc.CustomButton.Image = null;
            this.txt_E_Ruc.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txt_E_Ruc.CustomButton.Name = "";
            this.txt_E_Ruc.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_E_Ruc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_E_Ruc.CustomButton.TabIndex = 1;
            this.txt_E_Ruc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_E_Ruc.CustomButton.UseSelectable = true;
            this.txt_E_Ruc.CustomButton.Visible = false;
            this.txt_E_Ruc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_E_Ruc.Lines = new string[0];
            this.txt_E_Ruc.Location = new System.Drawing.Point(248, 72);
            this.txt_E_Ruc.MaxLength = 32767;
            this.txt_E_Ruc.Name = "txt_E_Ruc";
            this.txt_E_Ruc.PasswordChar = '\0';
            this.txt_E_Ruc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_E_Ruc.SelectedText = "";
            this.txt_E_Ruc.SelectionLength = 0;
            this.txt_E_Ruc.SelectionStart = 0;
            this.txt_E_Ruc.ShortcutsEnabled = true;
            this.txt_E_Ruc.Size = new System.Drawing.Size(166, 25);
            this.txt_E_Ruc.TabIndex = 119;
            this.txt_E_Ruc.UseSelectable = true;
            this.txt_E_Ruc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_E_Ruc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_E_RazonSocial
            // 
            // 
            // 
            // 
            this.txt_E_RazonSocial.CustomButton.Image = null;
            this.txt_E_RazonSocial.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txt_E_RazonSocial.CustomButton.Name = "";
            this.txt_E_RazonSocial.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_E_RazonSocial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_E_RazonSocial.CustomButton.TabIndex = 1;
            this.txt_E_RazonSocial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_E_RazonSocial.CustomButton.UseSelectable = true;
            this.txt_E_RazonSocial.CustomButton.Visible = false;
            this.txt_E_RazonSocial.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_E_RazonSocial.Lines = new string[0];
            this.txt_E_RazonSocial.Location = new System.Drawing.Point(248, 22);
            this.txt_E_RazonSocial.MaxLength = 32767;
            this.txt_E_RazonSocial.Name = "txt_E_RazonSocial";
            this.txt_E_RazonSocial.PasswordChar = '\0';
            this.txt_E_RazonSocial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_E_RazonSocial.SelectedText = "";
            this.txt_E_RazonSocial.SelectionLength = 0;
            this.txt_E_RazonSocial.SelectionStart = 0;
            this.txt_E_RazonSocial.ShortcutsEnabled = true;
            this.txt_E_RazonSocial.Size = new System.Drawing.Size(166, 25);
            this.txt_E_RazonSocial.TabIndex = 118;
            this.txt_E_RazonSocial.UseSelectable = true;
            this.txt_E_RazonSocial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_E_RazonSocial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_E_DirigirReporte
            // 
            // 
            // 
            // 
            this.txt_E_DirigirReporte.CustomButton.Image = null;
            this.txt_E_DirigirReporte.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txt_E_DirigirReporte.CustomButton.Name = "";
            this.txt_E_DirigirReporte.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_E_DirigirReporte.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_E_DirigirReporte.CustomButton.TabIndex = 1;
            this.txt_E_DirigirReporte.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_E_DirigirReporte.CustomButton.UseSelectable = true;
            this.txt_E_DirigirReporte.CustomButton.Visible = false;
            this.txt_E_DirigirReporte.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_E_DirigirReporte.Lines = new string[0];
            this.txt_E_DirigirReporte.Location = new System.Drawing.Point(18, 277);
            this.txt_E_DirigirReporte.MaxLength = 32767;
            this.txt_E_DirigirReporte.Name = "txt_E_DirigirReporte";
            this.txt_E_DirigirReporte.PasswordChar = '\0';
            this.txt_E_DirigirReporte.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_E_DirigirReporte.SelectedText = "";
            this.txt_E_DirigirReporte.SelectionLength = 0;
            this.txt_E_DirigirReporte.SelectionStart = 0;
            this.txt_E_DirigirReporte.ShortcutsEnabled = true;
            this.txt_E_DirigirReporte.Size = new System.Drawing.Size(166, 25);
            this.txt_E_DirigirReporte.TabIndex = 117;
            this.txt_E_DirigirReporte.UseSelectable = true;
            this.txt_E_DirigirReporte.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_E_DirigirReporte.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_E_ResponsableMedidcion
            // 
            // 
            // 
            // 
            this.txt_E_ResponsableMedidcion.CustomButton.Image = null;
            this.txt_E_ResponsableMedidcion.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txt_E_ResponsableMedidcion.CustomButton.Name = "";
            this.txt_E_ResponsableMedidcion.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_E_ResponsableMedidcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_E_ResponsableMedidcion.CustomButton.TabIndex = 1;
            this.txt_E_ResponsableMedidcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_E_ResponsableMedidcion.CustomButton.UseSelectable = true;
            this.txt_E_ResponsableMedidcion.CustomButton.Visible = false;
            this.txt_E_ResponsableMedidcion.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_E_ResponsableMedidcion.Lines = new string[0];
            this.txt_E_ResponsableMedidcion.Location = new System.Drawing.Point(21, 224);
            this.txt_E_ResponsableMedidcion.MaxLength = 32767;
            this.txt_E_ResponsableMedidcion.Name = "txt_E_ResponsableMedidcion";
            this.txt_E_ResponsableMedidcion.PasswordChar = '\0';
            this.txt_E_ResponsableMedidcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_E_ResponsableMedidcion.SelectedText = "";
            this.txt_E_ResponsableMedidcion.SelectionLength = 0;
            this.txt_E_ResponsableMedidcion.SelectionStart = 0;
            this.txt_E_ResponsableMedidcion.ShortcutsEnabled = true;
            this.txt_E_ResponsableMedidcion.Size = new System.Drawing.Size(166, 25);
            this.txt_E_ResponsableMedidcion.TabIndex = 116;
            this.txt_E_ResponsableMedidcion.UseSelectable = true;
            this.txt_E_ResponsableMedidcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_E_ResponsableMedidcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_E_NombreEmpresa
            // 
            // 
            // 
            // 
            this.txt_E_NombreEmpresa.CustomButton.Image = null;
            this.txt_E_NombreEmpresa.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txt_E_NombreEmpresa.CustomButton.Name = "";
            this.txt_E_NombreEmpresa.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_E_NombreEmpresa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_E_NombreEmpresa.CustomButton.TabIndex = 1;
            this.txt_E_NombreEmpresa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_E_NombreEmpresa.CustomButton.UseSelectable = true;
            this.txt_E_NombreEmpresa.CustomButton.Visible = false;
            this.txt_E_NombreEmpresa.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_E_NombreEmpresa.Lines = new string[0];
            this.txt_E_NombreEmpresa.Location = new System.Drawing.Point(21, 176);
            this.txt_E_NombreEmpresa.MaxLength = 32767;
            this.txt_E_NombreEmpresa.Name = "txt_E_NombreEmpresa";
            this.txt_E_NombreEmpresa.PasswordChar = '\0';
            this.txt_E_NombreEmpresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_E_NombreEmpresa.SelectedText = "";
            this.txt_E_NombreEmpresa.SelectionLength = 0;
            this.txt_E_NombreEmpresa.SelectionStart = 0;
            this.txt_E_NombreEmpresa.ShortcutsEnabled = true;
            this.txt_E_NombreEmpresa.Size = new System.Drawing.Size(166, 25);
            this.txt_E_NombreEmpresa.TabIndex = 115;
            this.txt_E_NombreEmpresa.UseSelectable = true;
            this.txt_E_NombreEmpresa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_E_NombreEmpresa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_E_Apellido
            // 
            // 
            // 
            // 
            this.txt_E_Apellido.CustomButton.Image = null;
            this.txt_E_Apellido.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txt_E_Apellido.CustomButton.Name = "";
            this.txt_E_Apellido.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_E_Apellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_E_Apellido.CustomButton.TabIndex = 1;
            this.txt_E_Apellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_E_Apellido.CustomButton.UseSelectable = true;
            this.txt_E_Apellido.CustomButton.Visible = false;
            this.txt_E_Apellido.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_E_Apellido.Lines = new string[0];
            this.txt_E_Apellido.Location = new System.Drawing.Point(21, 128);
            this.txt_E_Apellido.MaxLength = 32767;
            this.txt_E_Apellido.Name = "txt_E_Apellido";
            this.txt_E_Apellido.PasswordChar = '\0';
            this.txt_E_Apellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_E_Apellido.SelectedText = "";
            this.txt_E_Apellido.SelectionLength = 0;
            this.txt_E_Apellido.SelectionStart = 0;
            this.txt_E_Apellido.ShortcutsEnabled = true;
            this.txt_E_Apellido.Size = new System.Drawing.Size(166, 25);
            this.txt_E_Apellido.TabIndex = 114;
            this.txt_E_Apellido.UseSelectable = true;
            this.txt_E_Apellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_E_Apellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_E_Nombre
            // 
            // 
            // 
            // 
            this.txt_E_Nombre.CustomButton.Image = null;
            this.txt_E_Nombre.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txt_E_Nombre.CustomButton.Name = "";
            this.txt_E_Nombre.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_E_Nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_E_Nombre.CustomButton.TabIndex = 1;
            this.txt_E_Nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_E_Nombre.CustomButton.UseSelectable = true;
            this.txt_E_Nombre.CustomButton.Visible = false;
            this.txt_E_Nombre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_E_Nombre.Lines = new string[0];
            this.txt_E_Nombre.Location = new System.Drawing.Point(21, 75);
            this.txt_E_Nombre.MaxLength = 32767;
            this.txt_E_Nombre.Name = "txt_E_Nombre";
            this.txt_E_Nombre.PasswordChar = '\0';
            this.txt_E_Nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_E_Nombre.SelectedText = "";
            this.txt_E_Nombre.SelectionLength = 0;
            this.txt_E_Nombre.SelectionStart = 0;
            this.txt_E_Nombre.ShortcutsEnabled = true;
            this.txt_E_Nombre.Size = new System.Drawing.Size(166, 25);
            this.txt_E_Nombre.TabIndex = 113;
            this.txt_E_Nombre.UseSelectable = true;
            this.txt_E_Nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_E_Nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_IdCliente
            // 
            // 
            // 
            // 
            this.txt_IdCliente.CustomButton.Image = null;
            this.txt_IdCliente.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txt_IdCliente.CustomButton.Name = "";
            this.txt_IdCliente.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_IdCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_IdCliente.CustomButton.TabIndex = 1;
            this.txt_IdCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_IdCliente.CustomButton.UseSelectable = true;
            this.txt_IdCliente.CustomButton.Visible = false;
            this.txt_IdCliente.Enabled = false;
            this.txt_IdCliente.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_IdCliente.Lines = new string[0];
            this.txt_IdCliente.Location = new System.Drawing.Point(21, 22);
            this.txt_IdCliente.MaxLength = 32767;
            this.txt_IdCliente.Name = "txt_IdCliente";
            this.txt_IdCliente.PasswordChar = '\0';
            this.txt_IdCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_IdCliente.SelectedText = "";
            this.txt_IdCliente.SelectionLength = 0;
            this.txt_IdCliente.SelectionStart = 0;
            this.txt_IdCliente.ShortcutsEnabled = true;
            this.txt_IdCliente.Size = new System.Drawing.Size(190, 25);
            this.txt_IdCliente.TabIndex = 112;
            this.txt_IdCliente.UseSelectable = true;
            this.txt_IdCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_IdCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNisCliente
            // 
            this.lblNisCliente.AutoSize = true;
            this.lblNisCliente.Location = new System.Drawing.Point(208, 27);
            this.lblNisCliente.Name = "lblNisCliente";
            this.lblNisCliente.Size = new System.Drawing.Size(0, 13);
            this.lblNisCliente.TabIndex = 111;
            this.lblNisCliente.Visible = false;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(205, 10);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(0, 13);
            this.lblNombreCliente.TabIndex = 110;
            this.lblNombreCliente.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 22);
            this.label9.TabIndex = 99;
            this.label9.Text = "Id Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 22);
            this.label7.TabIndex = 96;
            this.label7.Text = "Dirigir Reporte A";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(17, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 22);
            this.label19.TabIndex = 80;
            this.label19.Text = "Nombre";
            // 
            // EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 442);
            this.Controls.Add(this.PnlFormCliente);
            this.Controls.Add(this.pnlBtnClientes);
            this.Controls.Add(this.PnlBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(480, 442);
            this.MinimumSize = new System.Drawing.Size(480, 442);
            this.Name = "EditarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarCliente";
            this.Load += new System.EventHandler(this.EditarCliente_Load);
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
        public System.Windows.Forms.Panel pnlAlerta;
        private System.Windows.Forms.Panel pnlAlertaVerde;
        public System.Windows.Forms.Panel pnlAlertaRojo;
        private System.Windows.Forms.PictureBox btnCerrarAlertaR;
        public System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.Label lbl_verde;
        private System.Windows.Forms.PictureBox btnCerrarAlertaV;
        private System.Windows.Forms.Label lblverde;
        private System.Windows.Forms.Button btnGuardarClienteEditado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnlFormCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNisCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        public MetroFramework.Controls.MetroTextBox txt_IdCliente;
        public MetroFramework.Controls.MetroTextBox txt_E_Nombre;
        public MetroFramework.Controls.MetroTextBox txt_E_Apellido;
        public MetroFramework.Controls.MetroTextBox txt_E_NombreEmpresa;
        public MetroFramework.Controls.MetroTextBox txt_E_DirigirReporte;
        public MetroFramework.Controls.MetroTextBox txt_E_ResponsableMedidcion;
        public MetroFramework.Controls.MetroTextBox txt_E_NisCliente;
        public MetroFramework.Controls.MetroTextBox txt_E_Ruc;
        public MetroFramework.Controls.MetroTextBox txt_E_RazonSocial;
    }
}