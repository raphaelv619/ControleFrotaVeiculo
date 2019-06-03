namespace ControleFrotaDeVeiculos.UserControlViagens
{
    partial class UserControlCadastroViagens
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDataFeita = new System.Windows.Forms.MaskedTextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtSituacao = new MetroFramework.Controls.MetroTextBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.txtCor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtModeloVeiculo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtCPFMotorista = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtMotivo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtKmFinal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtKmInicial = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtPlacaVeiculo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeMotorista = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.txtDataFeita);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.txtSituacao);
            this.panel1.Controls.Add(this.metroCheckBox1);
            this.panel1.Controls.Add(this.txtCor);
            this.panel1.Controls.Add(this.metroLabel12);
            this.panel1.Controls.Add(this.txtModeloVeiculo);
            this.panel1.Controls.Add(this.metroLabel11);
            this.panel1.Controls.Add(this.txtCPFMotorista);
            this.panel1.Controls.Add(this.metroLabel10);
            this.panel1.Controls.Add(this.metroLabel9);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.metroLabel8);
            this.panel1.Controls.Add(this.txtMotivo);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.txtKmFinal);
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Controls.Add(this.txtKmInicial);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.txtPlacaVeiculo);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.txtNomeMotorista);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 438);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtDataFeita
            // 
            this.txtDataFeita.Location = new System.Drawing.Point(452, 63);
            this.txtDataFeita.Mask = "00/00/0000";
            this.txtDataFeita.Name = "txtDataFeita";
            this.txtDataFeita.Size = new System.Drawing.Size(94, 20);
            this.txtDataFeita.TabIndex = 42;
            this.txtDataFeita.ValidatingType = typeof(System.DateTime);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(12, 37);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(94, 20);
            this.txtData.TabIndex = 40;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtSituacao
            // 
            // 
            // 
            // 
            this.txtSituacao.CustomButton.Image = null;
            this.txtSituacao.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.txtSituacao.CustomButton.Name = "";
            this.txtSituacao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSituacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSituacao.CustomButton.TabIndex = 1;
            this.txtSituacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSituacao.CustomButton.UseSelectable = true;
            this.txtSituacao.CustomButton.Visible = false;
            this.txtSituacao.Enabled = false;
            this.txtSituacao.Lines = new string[] {
        "Pendente"};
            this.txtSituacao.Location = new System.Drawing.Point(240, 212);
            this.txtSituacao.MaxLength = 32767;
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.PasswordChar = '\0';
            this.txtSituacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSituacao.SelectedText = "";
            this.txtSituacao.SelectionLength = 0;
            this.txtSituacao.SelectionStart = 0;
            this.txtSituacao.ShortcutsEnabled = true;
            this.txtSituacao.Size = new System.Drawing.Size(94, 23);
            this.txtSituacao.TabIndex = 39;
            this.txtSituacao.Text = "Pendente";
            this.txtSituacao.UseSelectable = true;
            this.txtSituacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSituacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(449, 15);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(124, 15);
            this.metroCheckBox1.TabIndex = 38;
            this.metroCheckBox1.Text = "Viagem já realizada";
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // txtCor
            // 
            // 
            // 
            // 
            this.txtCor.CustomButton.Image = null;
            this.txtCor.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.txtCor.CustomButton.Name = "";
            this.txtCor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCor.CustomButton.TabIndex = 1;
            this.txtCor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCor.CustomButton.UseSelectable = true;
            this.txtCor.CustomButton.Visible = false;
            this.txtCor.Enabled = false;
            this.txtCor.Lines = new string[0];
            this.txtCor.Location = new System.Drawing.Point(240, 153);
            this.txtCor.MaxLength = 32767;
            this.txtCor.Name = "txtCor";
            this.txtCor.PasswordChar = '\0';
            this.txtCor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCor.SelectedText = "";
            this.txtCor.SelectionLength = 0;
            this.txtCor.SelectionStart = 0;
            this.txtCor.ShortcutsEnabled = true;
            this.txtCor.Size = new System.Drawing.Size(94, 23);
            this.txtCor.TabIndex = 37;
            this.txtCor.UseSelectable = true;
            this.txtCor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(240, 131);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(31, 19);
            this.metroLabel12.TabIndex = 36;
            this.metroLabel12.Text = "Cor";
            // 
            // txtModeloVeiculo
            // 
            this.txtModeloVeiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtModeloVeiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtModeloVeiculo.CustomButton.Image = null;
            this.txtModeloVeiculo.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.txtModeloVeiculo.CustomButton.Name = "";
            this.txtModeloVeiculo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtModeloVeiculo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtModeloVeiculo.CustomButton.TabIndex = 1;
            this.txtModeloVeiculo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtModeloVeiculo.CustomButton.UseSelectable = true;
            this.txtModeloVeiculo.CustomButton.Visible = false;
            this.txtModeloVeiculo.Enabled = false;
            this.txtModeloVeiculo.Lines = new string[0];
            this.txtModeloVeiculo.Location = new System.Drawing.Point(127, 153);
            this.txtModeloVeiculo.MaxLength = 32767;
            this.txtModeloVeiculo.Name = "txtModeloVeiculo";
            this.txtModeloVeiculo.PasswordChar = '\0';
            this.txtModeloVeiculo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtModeloVeiculo.SelectedText = "";
            this.txtModeloVeiculo.SelectionLength = 0;
            this.txtModeloVeiculo.SelectionStart = 0;
            this.txtModeloVeiculo.ShortcutsEnabled = true;
            this.txtModeloVeiculo.Size = new System.Drawing.Size(94, 23);
            this.txtModeloVeiculo.TabIndex = 35;
            this.txtModeloVeiculo.UseSelectable = true;
            this.txtModeloVeiculo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtModeloVeiculo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(12, 131);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(90, 19);
            this.metroLabel11.TabIndex = 34;
            this.metroLabel11.Text = "Placa veículo*";
            this.metroLabel11.Click += new System.EventHandler(this.metroLabel11_Click);
            // 
            // txtCPFMotorista
            // 
            this.txtCPFMotorista.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCPFMotorista.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtCPFMotorista.CustomButton.Image = null;
            this.txtCPFMotorista.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtCPFMotorista.CustomButton.Name = "";
            this.txtCPFMotorista.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCPFMotorista.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCPFMotorista.CustomButton.TabIndex = 1;
            this.txtCPFMotorista.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCPFMotorista.CustomButton.UseSelectable = true;
            this.txtCPFMotorista.CustomButton.Visible = false;
            this.txtCPFMotorista.Enabled = false;
            this.txtCPFMotorista.Lines = new string[0];
            this.txtCPFMotorista.Location = new System.Drawing.Point(222, 94);
            this.txtCPFMotorista.MaxLength = 32767;
            this.txtCPFMotorista.Name = "txtCPFMotorista";
            this.txtCPFMotorista.PasswordChar = '\0';
            this.txtCPFMotorista.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCPFMotorista.SelectedText = "";
            this.txtCPFMotorista.SelectionLength = 0;
            this.txtCPFMotorista.SelectionStart = 0;
            this.txtCPFMotorista.ShortcutsEnabled = true;
            this.txtCPFMotorista.Size = new System.Drawing.Size(100, 23);
            this.txtCPFMotorista.TabIndex = 33;
            this.txtCPFMotorista.UseSelectable = true;
            this.txtCPFMotorista.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCPFMotorista.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCPFMotorista.Leave += new System.EventHandler(this.txtCPFMotorista_Leave);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(222, 72);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(93, 19);
            this.metroLabel10.TabIndex = 32;
            this.metroLabel10.Text = "CPF motorista";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(12, 402);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(144, 19);
            this.metroLabel9.TabIndex = 31;
            this.metroLabel9.Text = "* Campos obrigatórios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(525, 318);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 69);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 318);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(121, 69);
            this.btnCadastrar.TabIndex = 29;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(240, 190);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(58, 19);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Situação";
            // 
            // txtMotivo
            // 
            // 
            // 
            // 
            this.txtMotivo.CustomButton.Image = null;
            this.txtMotivo.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.txtMotivo.CustomButton.Name = "";
            this.txtMotivo.CustomButton.Size = new System.Drawing.Size(81, 81);
            this.txtMotivo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMotivo.CustomButton.TabIndex = 1;
            this.txtMotivo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMotivo.CustomButton.UseSelectable = true;
            this.txtMotivo.CustomButton.Visible = false;
            this.txtMotivo.Lines = new string[0];
            this.txtMotivo.Location = new System.Drawing.Point(12, 212);
            this.txtMotivo.MaxLength = 32767;
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.PasswordChar = '\0';
            this.txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMotivo.SelectedText = "";
            this.txtMotivo.SelectionLength = 0;
            this.txtMotivo.SelectionStart = 0;
            this.txtMotivo.ShortcutsEnabled = true;
            this.txtMotivo.Size = new System.Drawing.Size(211, 83);
            this.txtMotivo.TabIndex = 13;
            this.txtMotivo.UseSelectable = true;
            this.txtMotivo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMotivo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(12, 190);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(50, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Motivo";
            // 
            // txtKmFinal
            // 
            // 
            // 
            // 
            this.txtKmFinal.CustomButton.Image = null;
            this.txtKmFinal.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.txtKmFinal.CustomButton.Name = "";
            this.txtKmFinal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKmFinal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKmFinal.CustomButton.TabIndex = 1;
            this.txtKmFinal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKmFinal.CustomButton.UseSelectable = true;
            this.txtKmFinal.CustomButton.Visible = false;
            this.txtKmFinal.Enabled = false;
            this.txtKmFinal.Lines = new string[0];
            this.txtKmFinal.Location = new System.Drawing.Point(552, 116);
            this.txtKmFinal.MaxLength = 32767;
            this.txtKmFinal.Name = "txtKmFinal";
            this.txtKmFinal.PasswordChar = '\0';
            this.txtKmFinal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKmFinal.SelectedText = "";
            this.txtKmFinal.SelectionLength = 0;
            this.txtKmFinal.SelectionStart = 0;
            this.txtKmFinal.ShortcutsEnabled = true;
            this.txtKmFinal.Size = new System.Drawing.Size(94, 23);
            this.txtKmFinal.TabIndex = 11;
            this.txtKmFinal.UseSelectable = true;
            this.txtKmFinal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKmFinal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(552, 94);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(56, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Km final";
            // 
            // txtKmInicial
            // 
            // 
            // 
            // 
            this.txtKmInicial.CustomButton.Image = null;
            this.txtKmInicial.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.txtKmInicial.CustomButton.Name = "";
            this.txtKmInicial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKmInicial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKmInicial.CustomButton.TabIndex = 1;
            this.txtKmInicial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKmInicial.CustomButton.UseSelectable = true;
            this.txtKmInicial.CustomButton.Visible = false;
            this.txtKmInicial.Enabled = false;
            this.txtKmInicial.Lines = new string[0];
            this.txtKmInicial.Location = new System.Drawing.Point(449, 116);
            this.txtKmInicial.MaxLength = 32767;
            this.txtKmInicial.Name = "txtKmInicial";
            this.txtKmInicial.PasswordChar = '\0';
            this.txtKmInicial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKmInicial.SelectedText = "";
            this.txtKmInicial.SelectionLength = 0;
            this.txtKmInicial.SelectionStart = 0;
            this.txtKmInicial.ShortcutsEnabled = true;
            this.txtKmInicial.Size = new System.Drawing.Size(94, 23);
            this.txtKmInicial.TabIndex = 9;
            this.txtKmInicial.UseSelectable = true;
            this.txtKmInicial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKmInicial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(449, 94);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Km inicial";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // txtPlacaVeiculo
            // 
            this.txtPlacaVeiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPlacaVeiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtPlacaVeiculo.CustomButton.Image = null;
            this.txtPlacaVeiculo.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.txtPlacaVeiculo.CustomButton.Name = "";
            this.txtPlacaVeiculo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPlacaVeiculo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPlacaVeiculo.CustomButton.TabIndex = 1;
            this.txtPlacaVeiculo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPlacaVeiculo.CustomButton.UseSelectable = true;
            this.txtPlacaVeiculo.CustomButton.Visible = false;
            this.txtPlacaVeiculo.Lines = new string[0];
            this.txtPlacaVeiculo.Location = new System.Drawing.Point(12, 153);
            this.txtPlacaVeiculo.MaxLength = 32767;
            this.txtPlacaVeiculo.Name = "txtPlacaVeiculo";
            this.txtPlacaVeiculo.PasswordChar = '\0';
            this.txtPlacaVeiculo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPlacaVeiculo.SelectedText = "";
            this.txtPlacaVeiculo.SelectionLength = 0;
            this.txtPlacaVeiculo.SelectionStart = 0;
            this.txtPlacaVeiculo.ShortcutsEnabled = true;
            this.txtPlacaVeiculo.Size = new System.Drawing.Size(94, 23);
            this.txtPlacaVeiculo.TabIndex = 7;
            this.txtPlacaVeiculo.UseSelectable = true;
            this.txtPlacaVeiculo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPlacaVeiculo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPlacaVeiculo.Click += new System.EventHandler(this.txtPlacaVeiculo_Click);
            this.txtPlacaVeiculo.Leave += new System.EventHandler(this.txtPlacaVeiculo_Leave);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(127, 131);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(99, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Modelo veículo";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(449, 41);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Data conclusão";
            // 
            // txtNomeMotorista
            // 
            this.txtNomeMotorista.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNomeMotorista.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtNomeMotorista.CustomButton.Image = null;
            this.txtNomeMotorista.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtNomeMotorista.CustomButton.Name = "";
            this.txtNomeMotorista.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeMotorista.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeMotorista.CustomButton.TabIndex = 1;
            this.txtNomeMotorista.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeMotorista.CustomButton.UseSelectable = true;
            this.txtNomeMotorista.CustomButton.Visible = false;
            this.txtNomeMotorista.Lines = new string[0];
            this.txtNomeMotorista.Location = new System.Drawing.Point(12, 94);
            this.txtNomeMotorista.MaxLength = 32767;
            this.txtNomeMotorista.Name = "txtNomeMotorista";
            this.txtNomeMotorista.PasswordChar = '\0';
            this.txtNomeMotorista.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeMotorista.SelectedText = "";
            this.txtNomeMotorista.SelectionLength = 0;
            this.txtNomeMotorista.SelectionStart = 0;
            this.txtNomeMotorista.ShortcutsEnabled = true;
            this.txtNomeMotorista.Size = new System.Drawing.Size(186, 23);
            this.txtNomeMotorista.TabIndex = 3;
            this.txtNomeMotorista.UseSelectable = true;
            this.txtNomeMotorista.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeMotorista.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomeMotorista.Click += new System.EventHandler(this.metroTextBox2_Click);
            this.txtNomeMotorista.Leave += new System.EventHandler(this.txtNomeMotorista_Leave);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 72);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(112, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Nome motorista*";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Data marcada*";
            // 
            // UserControlCadastroViagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlCadastroViagens";
            this.Size = new System.Drawing.Size(733, 438);
            this.Load += new System.EventHandler(this.UserControlCadastroViagens_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtMotivo;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtKmFinal;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtKmInicial;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private MetroFramework.Controls.MetroTextBox txtCPFMotorista;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtModeloVeiculo;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroTextBox txtCor;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtSituacao;
        private System.Windows.Forms.MaskedTextBox txtDataFeita;
        private System.Windows.Forms.MaskedTextBox txtData;
        public MetroFramework.Controls.MetroTextBox txtPlacaVeiculo;
        public MetroFramework.Controls.MetroTextBox txtNomeMotorista;
    }
}
