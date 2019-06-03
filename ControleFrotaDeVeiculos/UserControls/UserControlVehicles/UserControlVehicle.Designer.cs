namespace ControleFrotaDeVeiculos
{
    partial class UserControlVehicle
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSearchPlaca = new MetroFramework.Controls.MetroTextBox();
            this.btnProcurarByPlaca = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnSalvarAlt = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPlaca = new MetroFramework.Controls.MetroTextBox();
            this.txtSituacao = new MetroFramework.Controls.MetroComboBox();
            this.txtAnoMod = new MetroFramework.Controls.MetroTextBox();
            this.txtTipo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtKmAtual = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtAnoFabr = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtMotorizacao = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtCombustivel = new MetroFramework.Controls.MetroComboBox();
            this.txtRenavam = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtModelo = new MetroFramework.Controls.MetroTextBox();
            this.txtCor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txtChassi = new MetroFramework.Controls.MetroTextBox();
            this.txtMarca = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnCadViagem = new System.Windows.Forms.Button();
            this.listViagens = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.listEntradaSaida = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCadEntradaSaida = new System.Windows.Forms.Button();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage6 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage7 = new MetroFramework.Controls.MetroTabPage();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.btnUltVeiculos = new MetroFramework.Controls.MetroLink();
            this.btnNewVehicle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(180, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Pesquisar por placa";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // txtSearchPlaca
            // 
            this.txtSearchPlaca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearchPlaca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtSearchPlaca.CustomButton.Image = null;
            this.txtSearchPlaca.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txtSearchPlaca.CustomButton.Name = "";
            this.txtSearchPlaca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchPlaca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchPlaca.CustomButton.TabIndex = 1;
            this.txtSearchPlaca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchPlaca.CustomButton.UseSelectable = true;
            this.txtSearchPlaca.CustomButton.Visible = false;
            this.txtSearchPlaca.Lines = new string[0];
            this.txtSearchPlaca.Location = new System.Drawing.Point(309, 15);
            this.txtSearchPlaca.MaxLength = 32767;
            this.txtSearchPlaca.Name = "txtSearchPlaca";
            this.txtSearchPlaca.PasswordChar = '\0';
            this.txtSearchPlaca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchPlaca.SelectedText = "";
            this.txtSearchPlaca.SelectionLength = 0;
            this.txtSearchPlaca.SelectionStart = 0;
            this.txtSearchPlaca.ShortcutsEnabled = true;
            this.txtSearchPlaca.Size = new System.Drawing.Size(96, 23);
            this.txtSearchPlaca.TabIndex = 4;
            this.txtSearchPlaca.UseSelectable = true;
            this.txtSearchPlaca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchPlaca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchPlaca.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // btnProcurarByPlaca
            // 
            this.btnProcurarByPlaca.Location = new System.Drawing.Point(411, 15);
            this.btnProcurarByPlaca.Name = "btnProcurarByPlaca";
            this.btnProcurarByPlaca.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarByPlaca.TabIndex = 5;
            this.btnProcurarByPlaca.Text = "Procurar";
            this.btnProcurarByPlaca.UseSelectable = true;
            this.btnProcurarByPlaca.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroTabControl1);
            this.panel1.Controls.Add(this.btnDeleteVehicle);
            this.panel1.Controls.Add(this.btnUltVeiculos);
            this.panel1.Controls.Add(this.btnNewVehicle);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.btnProcurarByPlaca);
            this.panel1.Controls.Add(this.txtSearchPlaca);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 466);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Controls.Add(this.metroTabPage5);
            this.metroTabControl1.Controls.Add(this.metroTabPage6);
            this.metroTabControl1.Controls.Add(this.metroTabPage7);
            this.metroTabControl1.Location = new System.Drawing.Point(35, 51);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(639, 412);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabControl1.TabIndex = 57;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnSalvarAlt);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.txtPlaca);
            this.metroTabPage1.Controls.Add(this.txtSituacao);
            this.metroTabPage1.Controls.Add(this.txtAnoMod);
            this.metroTabPage1.Controls.Add(this.txtTipo);
            this.metroTabPage1.Controls.Add(this.metroLabel12);
            this.metroTabPage1.Controls.Add(this.metroLabel11);
            this.metroTabPage1.Controls.Add(this.txtKmAtual);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.txtAnoFabr);
            this.metroTabPage1.Controls.Add(this.metroLabel13);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.txtMotorizacao);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.metroLabel10);
            this.metroTabPage1.Controls.Add(this.metroLabel8);
            this.metroTabPage1.Controls.Add(this.txtCombustivel);
            this.metroTabPage1.Controls.Add(this.txtRenavam);
            this.metroTabPage1.Controls.Add(this.metroLabel9);
            this.metroTabPage1.Controls.Add(this.txtModelo);
            this.metroTabPage1.Controls.Add(this.txtCor);
            this.metroTabPage1.Controls.Add(this.metroLabel14);
            this.metroTabPage1.Controls.Add(this.txtChassi);
            this.metroTabPage1.Controls.Add(this.txtMarca);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(631, 370);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Dados cadastrais";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // btnSalvarAlt
            // 
            this.btnSalvarAlt.Enabled = false;
            this.btnSalvarAlt.Location = new System.Drawing.Point(0, 208);
            this.btnSalvarAlt.Name = "btnSalvarAlt";
            this.btnSalvarAlt.Size = new System.Drawing.Size(121, 69);
            this.btnSalvarAlt.TabIndex = 56;
            this.btnSalvarAlt.Text = "Salvar";
            this.btnSalvarAlt.UseSelectable = true;
            this.btnSalvarAlt.Click += new System.EventHandler(this.btnSalvarAlt_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 19);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "Placa";
            // 
            // txtPlaca
            // 
            // 
            // 
            // 
            this.txtPlaca.CustomButton.Image = null;
            this.txtPlaca.CustomButton.Location = new System.Drawing.Point(59, 1);
            this.txtPlaca.CustomButton.Name = "";
            this.txtPlaca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPlaca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPlaca.CustomButton.TabIndex = 1;
            this.txtPlaca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPlaca.CustomButton.UseSelectable = true;
            this.txtPlaca.CustomButton.Visible = false;
            this.txtPlaca.Enabled = false;
            this.txtPlaca.Lines = new string[0];
            this.txtPlaca.Location = new System.Drawing.Point(0, 35);
            this.txtPlaca.MaxLength = 32767;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.PasswordChar = '\0';
            this.txtPlaca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPlaca.SelectedText = "";
            this.txtPlaca.SelectionLength = 0;
            this.txtPlaca.SelectionStart = 0;
            this.txtPlaca.ShortcutsEnabled = true;
            this.txtPlaca.Size = new System.Drawing.Size(81, 23);
            this.txtPlaca.TabIndex = 29;
            this.txtPlaca.UseSelectable = true;
            this.txtPlaca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPlaca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
            this.txtPlaca.Click += new System.EventHandler(this.txtPlaca_Click);
            this.txtPlaca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPlaca_KeyUp);
            // 
            // txtSituacao
            // 
            this.txtSituacao.FormattingEnabled = true;
            this.txtSituacao.ItemHeight = 23;
            this.txtSituacao.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.txtSituacao.Location = new System.Drawing.Point(442, 155);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(121, 29);
            this.txtSituacao.TabIndex = 51;
            this.txtSituacao.UseSelectable = true;
            this.txtSituacao.SelectionChangeCommitted += new System.EventHandler(this.txtSituacao_SelectionChangeCommitted);
            // 
            // txtAnoMod
            // 
            // 
            // 
            // 
            this.txtAnoMod.CustomButton.Image = null;
            this.txtAnoMod.CustomButton.Location = new System.Drawing.Point(40, 1);
            this.txtAnoMod.CustomButton.Name = "";
            this.txtAnoMod.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAnoMod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAnoMod.CustomButton.TabIndex = 1;
            this.txtAnoMod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAnoMod.CustomButton.UseSelectable = true;
            this.txtAnoMod.CustomButton.Visible = false;
            this.txtAnoMod.Lines = new string[0];
            this.txtAnoMod.Location = new System.Drawing.Point(112, 35);
            this.txtAnoMod.MaxLength = 32767;
            this.txtAnoMod.Name = "txtAnoMod";
            this.txtAnoMod.PasswordChar = '\0';
            this.txtAnoMod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAnoMod.SelectedText = "";
            this.txtAnoMod.SelectionLength = 0;
            this.txtAnoMod.SelectionStart = 0;
            this.txtAnoMod.ShortcutsEnabled = true;
            this.txtAnoMod.Size = new System.Drawing.Size(62, 23);
            this.txtAnoMod.TabIndex = 32;
            this.txtAnoMod.UseSelectable = true;
            this.txtAnoMod.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAnoMod.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAnoMod.Click += new System.EventHandler(this.txtAnoMod_Click);
            this.txtAnoMod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAnoMod_KeyUp);
            // 
            // txtTipo
            // 
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.ItemHeight = 23;
            this.txtTipo.Items.AddRange(new object[] {
            "Carro"});
            this.txtTipo.Location = new System.Drawing.Point(295, 154);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(121, 29);
            this.txtTipo.TabIndex = 49;
            this.txtTipo.UseSelectable = true;
            this.txtTipo.SelectionChangeCommitted += new System.EventHandler(this.txtTipo_SelectionChangeCommitted);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(442, 133);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(58, 19);
            this.metroLabel12.TabIndex = 50;
            this.metroLabel12.Text = "Situação";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(309, 133);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(35, 19);
            this.metroLabel11.TabIndex = 48;
            this.metroLabel11.Text = "Tipo";
            // 
            // txtKmAtual
            // 
            // 
            // 
            // 
            this.txtKmAtual.CustomButton.Image = null;
            this.txtKmAtual.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.txtKmAtual.CustomButton.Name = "";
            this.txtKmAtual.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKmAtual.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKmAtual.CustomButton.TabIndex = 1;
            this.txtKmAtual.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKmAtual.CustomButton.UseSelectable = true;
            this.txtKmAtual.CustomButton.Visible = false;
            this.txtKmAtual.Lines = new string[0];
            this.txtKmAtual.Location = new System.Drawing.Point(161, 154);
            this.txtKmAtual.MaxLength = 32767;
            this.txtKmAtual.Name = "txtKmAtual";
            this.txtKmAtual.PasswordChar = '\0';
            this.txtKmAtual.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKmAtual.SelectedText = "";
            this.txtKmAtual.SelectionLength = 0;
            this.txtKmAtual.SelectionStart = 0;
            this.txtKmAtual.ShortcutsEnabled = true;
            this.txtKmAtual.Size = new System.Drawing.Size(103, 23);
            this.txtKmAtual.TabIndex = 53;
            this.txtKmAtual.UseSelectable = true;
            this.txtKmAtual.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKmAtual.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKmAtual.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKmAtual_KeyUp);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(112, 13);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "Ano Mod.";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(200, 13);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "Ano Fabr.";
            // 
            // txtAnoFabr
            // 
            // 
            // 
            // 
            this.txtAnoFabr.CustomButton.Image = null;
            this.txtAnoFabr.CustomButton.Location = new System.Drawing.Point(40, 1);
            this.txtAnoFabr.CustomButton.Name = "";
            this.txtAnoFabr.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAnoFabr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAnoFabr.CustomButton.TabIndex = 1;
            this.txtAnoFabr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAnoFabr.CustomButton.UseSelectable = true;
            this.txtAnoFabr.CustomButton.Visible = false;
            this.txtAnoFabr.Lines = new string[0];
            this.txtAnoFabr.Location = new System.Drawing.Point(202, 35);
            this.txtAnoFabr.MaxLength = 32767;
            this.txtAnoFabr.Name = "txtAnoFabr";
            this.txtAnoFabr.PasswordChar = '\0';
            this.txtAnoFabr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAnoFabr.SelectedText = "";
            this.txtAnoFabr.SelectionLength = 0;
            this.txtAnoFabr.SelectionStart = 0;
            this.txtAnoFabr.ShortcutsEnabled = true;
            this.txtAnoFabr.Size = new System.Drawing.Size(62, 23);
            this.txtAnoFabr.TabIndex = 33;
            this.txtAnoFabr.UseSelectable = true;
            this.txtAnoFabr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAnoFabr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAnoFabr.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAnoFabr_KeyUp);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(161, 133);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(60, 19);
            this.metroLabel13.TabIndex = 52;
            this.metroLabel13.Text = "Km atual";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(295, 13);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(45, 19);
            this.metroLabel5.TabIndex = 34;
            this.metroLabel5.Text = "Chassi";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(442, 13);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(63, 19);
            this.metroLabel6.TabIndex = 36;
            this.metroLabel6.Text = "Renavam";
            // 
            // txtMotorizacao
            // 
            this.txtMotorizacao.FormattingEnabled = true;
            this.txtMotorizacao.ItemHeight = 23;
            this.txtMotorizacao.Items.AddRange(new object[] {
            "1.0",
            "1.4",
            "1.6",
            "1.8",
            "2.0",
            "2.2",
            "2.4"});
            this.txtMotorizacao.Location = new System.Drawing.Point(0, 155);
            this.txtMotorizacao.Name = "txtMotorizacao";
            this.txtMotorizacao.Size = new System.Drawing.Size(121, 29);
            this.txtMotorizacao.TabIndex = 47;
            this.txtMotorizacao.UseSelectable = true;
            this.txtMotorizacao.SelectionChangeCommitted += new System.EventHandler(this.txtMotorizacao_SelectionChangeCommitted);
            this.txtMotorizacao.TextChanged += new System.EventHandler(this.txtMotorizacao_TextChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 74);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(46, 19);
            this.metroLabel7.TabIndex = 38;
            this.metroLabel7.Text = "Marca";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(0, 133);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(83, 19);
            this.metroLabel10.TabIndex = 46;
            this.metroLabel10.Text = "Motorização";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(151, 74);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(55, 19);
            this.metroLabel8.TabIndex = 40;
            this.metroLabel8.Text = "Modelo";
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.FormattingEnabled = true;
            this.txtCombustivel.ItemHeight = 23;
            this.txtCombustivel.Items.AddRange(new object[] {
            "Flex",
            "Gasolina",
            "Álcool"});
            this.txtCombustivel.Location = new System.Drawing.Point(442, 96);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(121, 29);
            this.txtCombustivel.TabIndex = 45;
            this.txtCombustivel.UseSelectable = true;
            this.txtCombustivel.SelectionChangeCommitted += new System.EventHandler(this.txtCombustivel_SelectionChangeCommitted);
            this.txtCombustivel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCombustivel_KeyUp);
            this.txtCombustivel.MouseCaptureChanged += new System.EventHandler(this.txtCombustivel_MouseCaptureChanged);
            // 
            // txtRenavam
            // 
            // 
            // 
            // 
            this.txtRenavam.CustomButton.Image = null;
            this.txtRenavam.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txtRenavam.CustomButton.Name = "";
            this.txtRenavam.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRenavam.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRenavam.CustomButton.TabIndex = 1;
            this.txtRenavam.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRenavam.CustomButton.UseSelectable = true;
            this.txtRenavam.CustomButton.Visible = false;
            this.txtRenavam.Lines = new string[0];
            this.txtRenavam.Location = new System.Drawing.Point(442, 35);
            this.txtRenavam.MaxLength = 32767;
            this.txtRenavam.Name = "txtRenavam";
            this.txtRenavam.PasswordChar = '\0';
            this.txtRenavam.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRenavam.SelectedText = "";
            this.txtRenavam.SelectionLength = 0;
            this.txtRenavam.SelectionStart = 0;
            this.txtRenavam.ShortcutsEnabled = true;
            this.txtRenavam.Size = new System.Drawing.Size(117, 23);
            this.txtRenavam.TabIndex = 37;
            this.txtRenavam.UseSelectable = true;
            this.txtRenavam.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRenavam.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRenavam.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRenavam_KeyUp);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(442, 74);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(81, 19);
            this.metroLabel9.TabIndex = 44;
            this.metroLabel9.Text = "Combustível";
            // 
            // txtModelo
            // 
            // 
            // 
            // 
            this.txtModelo.CustomButton.Image = null;
            this.txtModelo.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.txtModelo.CustomButton.Name = "";
            this.txtModelo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtModelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtModelo.CustomButton.TabIndex = 1;
            this.txtModelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtModelo.CustomButton.UseSelectable = true;
            this.txtModelo.CustomButton.Visible = false;
            this.txtModelo.Lines = new string[0];
            this.txtModelo.Location = new System.Drawing.Point(151, 96);
            this.txtModelo.MaxLength = 32767;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.PasswordChar = '\0';
            this.txtModelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtModelo.SelectedText = "";
            this.txtModelo.SelectionLength = 0;
            this.txtModelo.SelectionStart = 0;
            this.txtModelo.ShortcutsEnabled = true;
            this.txtModelo.Size = new System.Drawing.Size(123, 23);
            this.txtModelo.TabIndex = 41;
            this.txtModelo.UseSelectable = true;
            this.txtModelo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtModelo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtModelo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtModelo_KeyUp);
            // 
            // txtCor
            // 
            // 
            // 
            // 
            this.txtCor.CustomButton.Image = null;
            this.txtCor.CustomButton.Location = new System.Drawing.Point(59, 1);
            this.txtCor.CustomButton.Name = "";
            this.txtCor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCor.CustomButton.TabIndex = 1;
            this.txtCor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCor.CustomButton.UseSelectable = true;
            this.txtCor.CustomButton.Visible = false;
            this.txtCor.Lines = new string[0];
            this.txtCor.Location = new System.Drawing.Point(309, 96);
            this.txtCor.MaxLength = 32767;
            this.txtCor.Name = "txtCor";
            this.txtCor.PasswordChar = '\0';
            this.txtCor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCor.SelectedText = "";
            this.txtCor.SelectionLength = 0;
            this.txtCor.SelectionStart = 0;
            this.txtCor.ShortcutsEnabled = true;
            this.txtCor.Size = new System.Drawing.Size(81, 23);
            this.txtCor.TabIndex = 43;
            this.txtCor.UseSelectable = true;
            this.txtCor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCor_KeyUp);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(309, 74);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(31, 19);
            this.metroLabel14.TabIndex = 42;
            this.metroLabel14.Text = "Cor";
            // 
            // txtChassi
            // 
            // 
            // 
            // 
            this.txtChassi.CustomButton.Image = null;
            this.txtChassi.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txtChassi.CustomButton.Name = "";
            this.txtChassi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtChassi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChassi.CustomButton.TabIndex = 1;
            this.txtChassi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChassi.CustomButton.UseSelectable = true;
            this.txtChassi.CustomButton.Visible = false;
            this.txtChassi.Lines = new string[0];
            this.txtChassi.Location = new System.Drawing.Point(295, 35);
            this.txtChassi.MaxLength = 32767;
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.PasswordChar = '\0';
            this.txtChassi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChassi.SelectedText = "";
            this.txtChassi.SelectionLength = 0;
            this.txtChassi.SelectionStart = 0;
            this.txtChassi.ShortcutsEnabled = true;
            this.txtChassi.Size = new System.Drawing.Size(117, 23);
            this.txtChassi.TabIndex = 35;
            this.txtChassi.UseSelectable = true;
            this.txtChassi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChassi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtChassi.Click += new System.EventHandler(this.txtChassi_Click);
            this.txtChassi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtChassi_KeyUp);
            // 
            // txtMarca
            // 
            // 
            // 
            // 
            this.txtMarca.CustomButton.Image = null;
            this.txtMarca.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.txtMarca.CustomButton.Name = "";
            this.txtMarca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMarca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMarca.CustomButton.TabIndex = 1;
            this.txtMarca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMarca.CustomButton.UseSelectable = true;
            this.txtMarca.CustomButton.Visible = false;
            this.txtMarca.Lines = new string[0];
            this.txtMarca.Location = new System.Drawing.Point(0, 96);
            this.txtMarca.MaxLength = 32767;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMarca.SelectedText = "";
            this.txtMarca.SelectionLength = 0;
            this.txtMarca.SelectionStart = 0;
            this.txtMarca.ShortcutsEnabled = true;
            this.txtMarca.Size = new System.Drawing.Size(123, 23);
            this.txtMarca.TabIndex = 39;
            this.txtMarca.UseSelectable = true;
            this.txtMarca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMarca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMarca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMarca_KeyUp);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnCadViagem);
            this.metroTabPage2.Controls.Add(this.listViagens);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(631, 370);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Viagens";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btnCadViagem
            // 
            this.btnCadViagem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadViagem.BackgroundImage = global::ControleFrotaDeVeiculos.Properties.Resources.novo3;
            this.btnCadViagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadViagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadViagem.FlatAppearance.BorderSize = 0;
            this.btnCadViagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadViagem.Location = new System.Drawing.Point(3, 0);
            this.btnCadViagem.Name = "btnCadViagem";
            this.btnCadViagem.Size = new System.Drawing.Size(36, 34);
            this.btnCadViagem.TabIndex = 58;
            this.btnCadViagem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCadViagem.UseVisualStyleBackColor = false;
            this.btnCadViagem.Click += new System.EventHandler(this.btnCadViagem_Click);
            // 
            // listViagens
            // 
            this.listViagens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViagens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.listViagens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViagens.Depth = 0;
            this.listViagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listViagens.FullRowSelect = true;
            this.listViagens.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViagens.Location = new System.Drawing.Point(0, 31);
            this.listViagens.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViagens.MouseState = MaterialSkin.MouseState.OUT;
            this.listViagens.MultiSelect = false;
            this.listViagens.Name = "listViagens";
            this.listViagens.OwnerDraw = true;
            this.listViagens.Scrollable = false;
            this.listViagens.Size = new System.Drawing.Size(631, 346);
            this.listViagens.TabIndex = 27;
            this.listViagens.UseCompatibleStateImageBehavior = false;
            this.listViagens.View = System.Windows.Forms.View.Details;
            this.listViagens.SelectedIndexChanged += new System.EventHandler(this.listViagens_SelectedIndexChanged);
            this.listViagens.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViagens_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Motorista";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Situação";
            this.columnHeader4.Width = 100;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.listEntradaSaida);
            this.metroTabPage3.Controls.Add(this.btnCadEntradaSaida);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(631, 370);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Entrada/Saída";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // listEntradaSaida
            // 
            this.listEntradaSaida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listEntradaSaida.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listEntradaSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listEntradaSaida.Depth = 0;
            this.listEntradaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listEntradaSaida.FullRowSelect = true;
            this.listEntradaSaida.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listEntradaSaida.Location = new System.Drawing.Point(0, 31);
            this.listEntradaSaida.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listEntradaSaida.MouseState = MaterialSkin.MouseState.OUT;
            this.listEntradaSaida.MultiSelect = false;
            this.listEntradaSaida.Name = "listEntradaSaida";
            this.listEntradaSaida.OwnerDraw = true;
            this.listEntradaSaida.Size = new System.Drawing.Size(631, 345);
            this.listEntradaSaida.TabIndex = 60;
            this.listEntradaSaida.UseCompatibleStateImageBehavior = false;
            this.listEntradaSaida.View = System.Windows.Forms.View.Details;
            this.listEntradaSaida.SelectedIndexChanged += new System.EventHandler(this.listEntradaSaida_SelectedIndexChanged);
            this.listEntradaSaida.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listEntradaSaida_MouseClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Motorista";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Data";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Saída";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Entrada";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            this.columnHeader9.Width = 1;
            // 
            // btnCadEntradaSaida
            // 
            this.btnCadEntradaSaida.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadEntradaSaida.BackgroundImage = global::ControleFrotaDeVeiculos.Properties.Resources.novo3;
            this.btnCadEntradaSaida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadEntradaSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadEntradaSaida.FlatAppearance.BorderSize = 0;
            this.btnCadEntradaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadEntradaSaida.Location = new System.Drawing.Point(3, 0);
            this.btnCadEntradaSaida.Name = "btnCadEntradaSaida";
            this.btnCadEntradaSaida.Size = new System.Drawing.Size(36, 34);
            this.btnCadEntradaSaida.TabIndex = 59;
            this.btnCadEntradaSaida.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCadEntradaSaida.UseVisualStyleBackColor = false;
            this.btnCadEntradaSaida.Click += new System.EventHandler(this.btnCadEntradaSaida_Click);
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(631, 370);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Manutenções";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(631, 370);
            this.metroTabPage5.TabIndex = 4;
            this.metroTabPage5.Text = "Abastecimentos";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // metroTabPage6
            // 
            this.metroTabPage6.HorizontalScrollbarBarColor = true;
            this.metroTabPage6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.HorizontalScrollbarSize = 10;
            this.metroTabPage6.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage6.Name = "metroTabPage6";
            this.metroTabPage6.Size = new System.Drawing.Size(631, 370);
            this.metroTabPage6.TabIndex = 5;
            this.metroTabPage6.Text = "Multas";
            this.metroTabPage6.VerticalScrollbarBarColor = true;
            this.metroTabPage6.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.VerticalScrollbarSize = 10;
            // 
            // metroTabPage7
            // 
            this.metroTabPage7.HorizontalScrollbarBarColor = true;
            this.metroTabPage7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.HorizontalScrollbarSize = 10;
            this.metroTabPage7.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage7.Name = "metroTabPage7";
            this.metroTabPage7.Size = new System.Drawing.Size(631, 370);
            this.metroTabPage7.TabIndex = 6;
            this.metroTabPage7.Text = "Pneus";
            this.metroTabPage7.VerticalScrollbarBarColor = true;
            this.metroTabPage7.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.VerticalScrollbarSize = 10;
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.BackgroundImage = global::ControleFrotaDeVeiculos.Properties.Resources.excluir;
            this.btnDeleteVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteVehicle.FlatAppearance.BorderSize = 0;
            this.btnDeleteVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteVehicle.Location = new System.Drawing.Point(84, 0);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(36, 34);
            this.btnDeleteVehicle.TabIndex = 12;
            this.btnDeleteVehicle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnDeleteVehicle.UseVisualStyleBackColor = true;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // btnUltVeiculos
            // 
            this.btnUltVeiculos.Location = new System.Drawing.Point(510, 15);
            this.btnUltVeiculos.Name = "btnUltVeiculos";
            this.btnUltVeiculos.Size = new System.Drawing.Size(175, 23);
            this.btnUltVeiculos.TabIndex = 9;
            this.btnUltVeiculos.Text = "Últimos veículos cadastrados";
            this.btnUltVeiculos.UseSelectable = true;
            this.btnUltVeiculos.Click += new System.EventHandler(this.btnUltVeiculos_Click);
            // 
            // btnNewVehicle
            // 
            this.btnNewVehicle.BackgroundImage = global::ControleFrotaDeVeiculos.Properties.Resources.novo3;
            this.btnNewVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewVehicle.FlatAppearance.BorderSize = 0;
            this.btnNewVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewVehicle.Location = new System.Drawing.Point(42, 0);
            this.btnNewVehicle.Name = "btnNewVehicle";
            this.btnNewVehicle.Size = new System.Drawing.Size(36, 34);
            this.btnNewVehicle.TabIndex = 8;
            this.btnNewVehicle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnNewVehicle.UseVisualStyleBackColor = true;
            this.btnNewVehicle.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControlVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlVehicle";
            this.Size = new System.Drawing.Size(733, 466);
            this.Load += new System.EventHandler(this.UserControlVehicle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSearchPlaca;
        private MetroFramework.Controls.MetroButton btnProcurarByPlaca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewVehicle;
        private MetroFramework.Controls.MetroLink btnUltVeiculos;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtAnoMod;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox txtSituacao;
        private MetroFramework.Controls.MetroTextBox txtKmAtual;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtAnoFabr;
        private MetroFramework.Controls.MetroComboBox txtTipo;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtChassi;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtRenavam;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox txtMotorizacao;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroComboBox txtCombustivel;
        private MetroFramework.Controls.MetroTextBox txtModelo;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txtCor;
        private MetroFramework.Controls.MetroButton btnSalvarAlt;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private MetroFramework.Controls.MetroTabPage metroTabPage6;
        private MetroFramework.Controls.MetroTabPage metroTabPage7;
        public MetroFramework.Controls.MetroTextBox txtMarca;
        public MetroFramework.Controls.MetroTextBox txtPlaca;
        public MaterialSkin.Controls.MaterialListView listViagens;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnCadViagem;
        private System.Windows.Forms.Button btnCadEntradaSaida;
        public MaterialSkin.Controls.MaterialListView listEntradaSaida;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}
