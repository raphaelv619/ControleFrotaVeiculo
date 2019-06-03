namespace ControleFrotaDeVeiculos.UserControls.UserControlsEntradaSaida
{
    partial class UserControlEntradaSaida
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
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtHrEntrada = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtHrSaida = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeMotorista = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtPlacaVeiculo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtKmInicial = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtKmFinal = new MetroFramework.Controls.MetroTextBox();
            this.btnSalvarAlt = new MetroFramework.Controls.MetroButton();
            this.btnDeleteEntradaSaida = new System.Windows.Forms.Button();
            this.btnUltEntradaSaida = new MetroFramework.Controls.MetroLink();
            this.btnNewEntradaSaida = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInfoMotorista = new System.Windows.Forms.Button();
            this.btnInfoVeiculo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(48, 79);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(94, 20);
            this.txtData.TabIndex = 41;
            this.txtData.ValidatingType = typeof(System.DateTime);
            this.txtData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtData_MaskInputRejected);
            this.txtData.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtData_KeyUp);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(45, 57);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 19);
            this.metroLabel1.TabIndex = 42;
            this.metroLabel1.Text = "Data marcada";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(257, 57);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(72, 19);
            this.metroLabel5.TabIndex = 43;
            this.metroLabel5.Text = "Hr entrada";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // txtHrEntrada
            // 
            // 
            // 
            // 
            this.txtHrEntrada.CustomButton.Image = null;
            this.txtHrEntrada.CustomButton.Location = new System.Drawing.Point(50, 1);
            this.txtHrEntrada.CustomButton.Name = "";
            this.txtHrEntrada.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHrEntrada.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHrEntrada.CustomButton.TabIndex = 1;
            this.txtHrEntrada.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHrEntrada.CustomButton.UseSelectable = true;
            this.txtHrEntrada.CustomButton.Visible = false;
            this.txtHrEntrada.Lines = new string[0];
            this.txtHrEntrada.Location = new System.Drawing.Point(257, 79);
            this.txtHrEntrada.MaxLength = 32767;
            this.txtHrEntrada.Name = "txtHrEntrada";
            this.txtHrEntrada.PasswordChar = '\0';
            this.txtHrEntrada.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHrEntrada.SelectedText = "";
            this.txtHrEntrada.SelectionLength = 0;
            this.txtHrEntrada.SelectionStart = 0;
            this.txtHrEntrada.ShortcutsEnabled = true;
            this.txtHrEntrada.Size = new System.Drawing.Size(72, 23);
            this.txtHrEntrada.TabIndex = 44;
            this.txtHrEntrada.UseSelectable = true;
            this.txtHrEntrada.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHrEntrada.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHrEntrada.Click += new System.EventHandler(this.txtKmInicial_Click);
            this.txtHrEntrada.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHrEntrada_KeyUp);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(162, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 45;
            this.metroLabel2.Text = "Hr saida";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // txtHrSaida
            // 
            // 
            // 
            // 
            this.txtHrSaida.CustomButton.Image = null;
            this.txtHrSaida.CustomButton.Location = new System.Drawing.Point(50, 1);
            this.txtHrSaida.CustomButton.Name = "";
            this.txtHrSaida.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHrSaida.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHrSaida.CustomButton.TabIndex = 1;
            this.txtHrSaida.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHrSaida.CustomButton.UseSelectable = true;
            this.txtHrSaida.CustomButton.Visible = false;
            this.txtHrSaida.Lines = new string[0];
            this.txtHrSaida.Location = new System.Drawing.Point(162, 79);
            this.txtHrSaida.MaxLength = 32767;
            this.txtHrSaida.Name = "txtHrSaida";
            this.txtHrSaida.PasswordChar = '\0';
            this.txtHrSaida.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHrSaida.SelectedText = "";
            this.txtHrSaida.SelectionLength = 0;
            this.txtHrSaida.SelectionStart = 0;
            this.txtHrSaida.ShortcutsEnabled = true;
            this.txtHrSaida.Size = new System.Drawing.Size(72, 23);
            this.txtHrSaida.TabIndex = 46;
            this.txtHrSaida.UseSelectable = true;
            this.txtHrSaida.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHrSaida.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHrSaida.Click += new System.EventHandler(this.metroTextBox1_Click);
            this.txtHrSaida.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHrSaida_KeyUp);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(48, 124);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(106, 19);
            this.metroLabel3.TabIndex = 47;
            this.metroLabel3.Text = "Nome motorista";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
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
            this.txtNomeMotorista.Location = new System.Drawing.Point(48, 146);
            this.txtNomeMotorista.MaxLength = 32767;
            this.txtNomeMotorista.Name = "txtNomeMotorista";
            this.txtNomeMotorista.PasswordChar = '\0';
            this.txtNomeMotorista.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeMotorista.SelectedText = "";
            this.txtNomeMotorista.SelectionLength = 0;
            this.txtNomeMotorista.SelectionStart = 0;
            this.txtNomeMotorista.ShortcutsEnabled = true;
            this.txtNomeMotorista.Size = new System.Drawing.Size(186, 23);
            this.txtNomeMotorista.TabIndex = 48;
            this.txtNomeMotorista.UseSelectable = true;
            this.txtNomeMotorista.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeMotorista.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomeMotorista.Click += new System.EventHandler(this.txtNomeMotorista_Click);
            this.txtNomeMotorista.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNomeMotorista_KeyUp);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(48, 189);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(84, 19);
            this.metroLabel11.TabIndex = 51;
            this.metroLabel11.Text = "Placa veículo";
            this.metroLabel11.Click += new System.EventHandler(this.metroLabel11_Click);
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
            this.txtPlacaVeiculo.Location = new System.Drawing.Point(48, 211);
            this.txtPlacaVeiculo.MaxLength = 32767;
            this.txtPlacaVeiculo.Name = "txtPlacaVeiculo";
            this.txtPlacaVeiculo.PasswordChar = '\0';
            this.txtPlacaVeiculo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPlacaVeiculo.SelectedText = "";
            this.txtPlacaVeiculo.SelectionLength = 0;
            this.txtPlacaVeiculo.SelectionStart = 0;
            this.txtPlacaVeiculo.ShortcutsEnabled = true;
            this.txtPlacaVeiculo.Size = new System.Drawing.Size(94, 23);
            this.txtPlacaVeiculo.TabIndex = 52;
            this.txtPlacaVeiculo.UseSelectable = true;
            this.txtPlacaVeiculo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPlacaVeiculo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPlacaVeiculo.Click += new System.EventHandler(this.txtPlacaVeiculo_Click);
            this.txtPlacaVeiculo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPlacaVeiculo_KeyUp);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(48, 256);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(64, 19);
            this.metroLabel6.TabIndex = 57;
            this.metroLabel6.Text = "Km inicial";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
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
            this.txtKmInicial.Lines = new string[0];
            this.txtKmInicial.Location = new System.Drawing.Point(48, 278);
            this.txtKmInicial.MaxLength = 32767;
            this.txtKmInicial.Name = "txtKmInicial";
            this.txtKmInicial.PasswordChar = '\0';
            this.txtKmInicial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKmInicial.SelectedText = "";
            this.txtKmInicial.SelectionLength = 0;
            this.txtKmInicial.SelectionStart = 0;
            this.txtKmInicial.ShortcutsEnabled = true;
            this.txtKmInicial.Size = new System.Drawing.Size(94, 23);
            this.txtKmInicial.TabIndex = 58;
            this.txtKmInicial.UseSelectable = true;
            this.txtKmInicial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKmInicial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKmInicial.Click += new System.EventHandler(this.metroTextBox2_Click);
            this.txtKmInicial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKmInicial_KeyUp);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(162, 256);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(56, 19);
            this.metroLabel7.TabIndex = 59;
            this.metroLabel7.Text = "Km final";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
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
            this.txtKmFinal.Lines = new string[0];
            this.txtKmFinal.Location = new System.Drawing.Point(162, 278);
            this.txtKmFinal.MaxLength = 32767;
            this.txtKmFinal.Name = "txtKmFinal";
            this.txtKmFinal.PasswordChar = '\0';
            this.txtKmFinal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKmFinal.SelectedText = "";
            this.txtKmFinal.SelectionLength = 0;
            this.txtKmFinal.SelectionStart = 0;
            this.txtKmFinal.ShortcutsEnabled = true;
            this.txtKmFinal.Size = new System.Drawing.Size(94, 23);
            this.txtKmFinal.TabIndex = 60;
            this.txtKmFinal.UseSelectable = true;
            this.txtKmFinal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKmFinal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKmFinal.Click += new System.EventHandler(this.metroTextBox3_Click);
            this.txtKmFinal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKmFinal_KeyUp);
            // 
            // btnSalvarAlt
            // 
            this.btnSalvarAlt.Enabled = false;
            this.btnSalvarAlt.Location = new System.Drawing.Point(48, 335);
            this.btnSalvarAlt.Name = "btnSalvarAlt";
            this.btnSalvarAlt.Size = new System.Drawing.Size(121, 69);
            this.btnSalvarAlt.TabIndex = 62;
            this.btnSalvarAlt.Text = "Salvar";
            this.btnSalvarAlt.UseSelectable = true;
            this.btnSalvarAlt.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDeleteEntradaSaida
            // 
            this.btnDeleteEntradaSaida.BackgroundImage = global::ControleFrotaDeVeiculos.Properties.Resources.excluir;
            this.btnDeleteEntradaSaida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteEntradaSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteEntradaSaida.FlatAppearance.BorderSize = 0;
            this.btnDeleteEntradaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEntradaSaida.Location = new System.Drawing.Point(84, 0);
            this.btnDeleteEntradaSaida.Name = "btnDeleteEntradaSaida";
            this.btnDeleteEntradaSaida.Size = new System.Drawing.Size(36, 34);
            this.btnDeleteEntradaSaida.TabIndex = 65;
            this.btnDeleteEntradaSaida.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnDeleteEntradaSaida.UseVisualStyleBackColor = true;
            this.btnDeleteEntradaSaida.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // btnUltEntradaSaida
            // 
            this.btnUltEntradaSaida.Location = new System.Drawing.Point(267, 11);
            this.btnUltEntradaSaida.Name = "btnUltEntradaSaida";
            this.btnUltEntradaSaida.Size = new System.Drawing.Size(175, 23);
            this.btnUltEntradaSaida.TabIndex = 64;
            this.btnUltEntradaSaida.Text = "Ver Entrada/Saída";
            this.btnUltEntradaSaida.UseSelectable = true;
            this.btnUltEntradaSaida.Click += new System.EventHandler(this.btnUltEntradaSaida_Click);
            // 
            // btnNewEntradaSaida
            // 
            this.btnNewEntradaSaida.BackgroundImage = global::ControleFrotaDeVeiculos.Properties.Resources.novo3;
            this.btnNewEntradaSaida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewEntradaSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewEntradaSaida.FlatAppearance.BorderSize = 0;
            this.btnNewEntradaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEntradaSaida.Location = new System.Drawing.Point(42, 0);
            this.btnNewEntradaSaida.Name = "btnNewEntradaSaida";
            this.btnNewEntradaSaida.Size = new System.Drawing.Size(36, 34);
            this.btnNewEntradaSaida.TabIndex = 63;
            this.btnNewEntradaSaida.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnNewEntradaSaida.UseVisualStyleBackColor = true;
            this.btnNewEntradaSaida.Click += new System.EventHandler(this.btnNewEntradaSaida_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInfoVeiculo);
            this.panel1.Controls.Add(this.btnInfoMotorista);
            this.panel1.Controls.Add(this.btnNewEntradaSaida);
            this.panel1.Controls.Add(this.btnDeleteEntradaSaida);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.btnUltEntradaSaida);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.btnSalvarAlt);
            this.panel1.Controls.Add(this.txtHrEntrada);
            this.panel1.Controls.Add(this.txtKmFinal);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.txtHrSaida);
            this.panel1.Controls.Add(this.txtKmInicial);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Controls.Add(this.txtNomeMotorista);
            this.panel1.Controls.Add(this.metroLabel11);
            this.panel1.Controls.Add(this.txtPlacaVeiculo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 438);
            this.panel1.TabIndex = 66;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnInfoMotorista
            // 
            this.btnInfoMotorista.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInfoMotorista.BackgroundImage = global::ControleFrotaDeVeiculos.Properties.Resources.infomotorista;
            this.btnInfoMotorista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInfoMotorista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoMotorista.FlatAppearance.BorderSize = 0;
            this.btnInfoMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoMotorista.Location = new System.Drawing.Point(240, 135);
            this.btnInfoMotorista.Name = "btnInfoMotorista";
            this.btnInfoMotorista.Size = new System.Drawing.Size(36, 34);
            this.btnInfoMotorista.TabIndex = 66;
            this.btnInfoMotorista.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnInfoMotorista.UseVisualStyleBackColor = false;
            this.btnInfoMotorista.Click += new System.EventHandler(this.btnInfoMotorista_Click);
            // 
            // btnInfoVeiculo
            // 
            this.btnInfoVeiculo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInfoVeiculo.BackgroundImage = global::ControleFrotaDeVeiculos.Properties.Resources.infomotorista;
            this.btnInfoVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInfoVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoVeiculo.FlatAppearance.BorderSize = 0;
            this.btnInfoVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoVeiculo.Location = new System.Drawing.Point(148, 200);
            this.btnInfoVeiculo.Name = "btnInfoVeiculo";
            this.btnInfoVeiculo.Size = new System.Drawing.Size(36, 34);
            this.btnInfoVeiculo.TabIndex = 67;
            this.btnInfoVeiculo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnInfoVeiculo.UseVisualStyleBackColor = false;
            this.btnInfoVeiculo.Click += new System.EventHandler(this.btnInfoVeiculo_Click);
            // 
            // UserControlEntradaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlEntradaSaida";
            this.Size = new System.Drawing.Size(733, 438);
            this.Load += new System.EventHandler(this.UserControlEntradaSaida_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtData;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtHrEntrada;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtHrSaida;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroTextBox txtNomeMotorista;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        public MetroFramework.Controls.MetroTextBox txtPlacaVeiculo;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtKmInicial;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtKmFinal;
        private MetroFramework.Controls.MetroButton btnSalvarAlt;
        private System.Windows.Forms.Button btnDeleteEntradaSaida;
        private MetroFramework.Controls.MetroLink btnUltEntradaSaida;
        public System.Windows.Forms.Button btnNewEntradaSaida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInfoVeiculo;
        private System.Windows.Forms.Button btnInfoMotorista;
    }
}
