namespace ControleFrotaDeVeiculos.UserControlViagens
{
    partial class UserControlViagem
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
            this.txtDataViagemFeita = new System.Windows.Forms.MaskedTextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.btnInfoVeiculo = new System.Windows.Forms.Button();
            this.btnInfoMotorista = new System.Windows.Forms.Button();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.btnSalvarAlt = new MetroFramework.Controls.MetroButton();
            this.txtSituacao = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtMotivo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtKmFinal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtKmInicial = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtPlacaVeiculo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeMotorista = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnUltViagens = new MetroFramework.Controls.MetroLink();
            this.btnNewViagem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.txtDataViagemFeita);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.btnInfoVeiculo);
            this.panel1.Controls.Add(this.btnInfoMotorista);
            this.panel1.Controls.Add(this.btnDeleteVehicle);
            this.panel1.Controls.Add(this.btnSalvarAlt);
            this.panel1.Controls.Add(this.txtSituacao);
            this.panel1.Controls.Add(this.metroLabel8);
            this.panel1.Controls.Add(this.txtMotivo);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.txtKmFinal);
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Controls.Add(this.txtKmInicial);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.txtPlacaVeiculo);
            this.panel1.Controls.Add(this.metroLabel11);
            this.panel1.Controls.Add(this.txtNomeMotorista);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.btnUltViagens);
            this.panel1.Controls.Add(this.btnNewViagem);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 438);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtDataViagemFeita
            // 
            this.txtDataViagemFeita.Location = new System.Drawing.Point(173, 76);
            this.txtDataViagemFeita.Mask = "00/00/0000";
            this.txtDataViagemFeita.Name = "txtDataViagemFeita";
            this.txtDataViagemFeita.Size = new System.Drawing.Size(94, 20);
            this.txtDataViagemFeita.TabIndex = 62;
            this.txtDataViagemFeita.ValidatingType = typeof(System.DateTime);
            this.txtDataViagemFeita.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDataViagemFeita_KeyUp);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(44, 76);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(94, 20);
            this.txtData.TabIndex = 61;
            this.txtData.ValidatingType = typeof(System.DateTime);
            this.txtData.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtData_KeyUp);
            // 
            // btnInfoVeiculo
            // 
            this.btnInfoVeiculo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInfoVeiculo.BackgroundImage = global::ControleFrotaDeVeiculos.Properties.Resources.infomotorista;
            this.btnInfoVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInfoVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoVeiculo.FlatAppearance.BorderSize = 0;
            this.btnInfoVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoVeiculo.Location = new System.Drawing.Point(406, 137);
            this.btnInfoVeiculo.Name = "btnInfoVeiculo";
            this.btnInfoVeiculo.Size = new System.Drawing.Size(36, 34);
            this.btnInfoVeiculo.TabIndex = 60;
            this.btnInfoVeiculo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnInfoVeiculo.UseVisualStyleBackColor = false;
            this.btnInfoVeiculo.Click += new System.EventHandler(this.btnInfoVeiculo_Click);
            // 
            // btnInfoMotorista
            // 
            this.btnInfoMotorista.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInfoMotorista.BackgroundImage = global::ControleFrotaDeVeiculos.Properties.Resources.infomotorista;
            this.btnInfoMotorista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInfoMotorista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoMotorista.FlatAppearance.BorderSize = 0;
            this.btnInfoMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoMotorista.Location = new System.Drawing.Point(231, 137);
            this.btnInfoMotorista.Name = "btnInfoMotorista";
            this.btnInfoMotorista.Size = new System.Drawing.Size(36, 34);
            this.btnInfoMotorista.TabIndex = 59;
            this.btnInfoMotorista.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnInfoMotorista.UseVisualStyleBackColor = false;
            this.btnInfoMotorista.Click += new System.EventHandler(this.btnInfoMotorista_Click);
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
            this.btnDeleteVehicle.TabIndex = 58;
            this.btnDeleteVehicle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnDeleteVehicle.UseVisualStyleBackColor = true;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // btnSalvarAlt
            // 
            this.btnSalvarAlt.Enabled = false;
            this.btnSalvarAlt.Location = new System.Drawing.Point(39, 329);
            this.btnSalvarAlt.Name = "btnSalvarAlt";
            this.btnSalvarAlt.Size = new System.Drawing.Size(121, 69);
            this.btnSalvarAlt.TabIndex = 57;
            this.btnSalvarAlt.Text = "Salvar";
            this.btnSalvarAlt.UseSelectable = true;
            this.btnSalvarAlt.Click += new System.EventHandler(this.btnSalvarAlt_Click);
            // 
            // txtSituacao
            // 
            this.txtSituacao.FormattingEnabled = true;
            this.txtSituacao.ItemHeight = 23;
            this.txtSituacao.Items.AddRange(new object[] {
            "Pendente",
            "Realizada"});
            this.txtSituacao.Location = new System.Drawing.Point(306, 220);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(121, 29);
            this.txtSituacao.TabIndex = 51;
            this.txtSituacao.UseSelectable = true;
            this.txtSituacao.TextUpdate += new System.EventHandler(this.txtSituacao_TextUpdate);
            this.txtSituacao.TextChanged += new System.EventHandler(this.txtSituacao_TextChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(306, 198);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(58, 19);
            this.metroLabel8.TabIndex = 50;
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
            this.txtMotivo.Location = new System.Drawing.Point(39, 220);
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
            this.txtMotivo.TabIndex = 49;
            this.txtMotivo.UseSelectable = true;
            this.txtMotivo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMotivo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMotivo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMotivo_KeyUp);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(39, 198);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(50, 19);
            this.metroLabel7.TabIndex = 48;
            this.metroLabel7.Text = "Motivo";
            // 
            // txtKmFinal
            // 
            this.txtKmFinal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKmFinal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
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
            this.txtKmFinal.Location = new System.Drawing.Point(413, 76);
            this.txtKmFinal.MaxLength = 32767;
            this.txtKmFinal.Name = "txtKmFinal";
            this.txtKmFinal.PasswordChar = '\0';
            this.txtKmFinal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKmFinal.SelectedText = "";
            this.txtKmFinal.SelectionLength = 0;
            this.txtKmFinal.SelectionStart = 0;
            this.txtKmFinal.ShortcutsEnabled = true;
            this.txtKmFinal.Size = new System.Drawing.Size(94, 23);
            this.txtKmFinal.TabIndex = 47;
            this.txtKmFinal.UseSelectable = true;
            this.txtKmFinal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKmFinal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKmFinal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKmFinal_KeyUp);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(413, 54);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(56, 19);
            this.metroLabel6.TabIndex = 46;
            this.metroLabel6.Text = "Km final";
            // 
            // txtKmInicial
            // 
            this.txtKmInicial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKmInicial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
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
            this.txtKmInicial.Location = new System.Drawing.Point(306, 76);
            this.txtKmInicial.MaxLength = 32767;
            this.txtKmInicial.Name = "txtKmInicial";
            this.txtKmInicial.PasswordChar = '\0';
            this.txtKmInicial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKmInicial.SelectedText = "";
            this.txtKmInicial.SelectionLength = 0;
            this.txtKmInicial.SelectionStart = 0;
            this.txtKmInicial.ShortcutsEnabled = true;
            this.txtKmInicial.Size = new System.Drawing.Size(94, 23);
            this.txtKmInicial.TabIndex = 45;
            this.txtKmInicial.UseSelectable = true;
            this.txtKmInicial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKmInicial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKmInicial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKmInicial_KeyUp);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(306, 54);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 19);
            this.metroLabel5.TabIndex = 44;
            this.metroLabel5.Text = "Km Inicial";
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
            this.txtPlacaVeiculo.Location = new System.Drawing.Point(306, 148);
            this.txtPlacaVeiculo.MaxLength = 32767;
            this.txtPlacaVeiculo.Name = "txtPlacaVeiculo";
            this.txtPlacaVeiculo.PasswordChar = '\0';
            this.txtPlacaVeiculo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPlacaVeiculo.SelectedText = "";
            this.txtPlacaVeiculo.SelectionLength = 0;
            this.txtPlacaVeiculo.SelectionStart = 0;
            this.txtPlacaVeiculo.ShortcutsEnabled = true;
            this.txtPlacaVeiculo.Size = new System.Drawing.Size(94, 23);
            this.txtPlacaVeiculo.TabIndex = 43;
            this.txtPlacaVeiculo.UseSelectable = true;
            this.txtPlacaVeiculo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPlacaVeiculo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPlacaVeiculo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPlacaVeiculo_KeyUp);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(306, 126);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(84, 19);
            this.metroLabel11.TabIndex = 42;
            this.metroLabel11.Text = "Placa veículo";
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
            this.txtNomeMotorista.Location = new System.Drawing.Point(39, 148);
            this.txtNomeMotorista.MaxLength = 32767;
            this.txtNomeMotorista.Name = "txtNomeMotorista";
            this.txtNomeMotorista.PasswordChar = '\0';
            this.txtNomeMotorista.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeMotorista.SelectedText = "";
            this.txtNomeMotorista.SelectionLength = 0;
            this.txtNomeMotorista.SelectionStart = 0;
            this.txtNomeMotorista.ShortcutsEnabled = true;
            this.txtNomeMotorista.Size = new System.Drawing.Size(186, 23);
            this.txtNomeMotorista.TabIndex = 41;
            this.txtNomeMotorista.UseSelectable = true;
            this.txtNomeMotorista.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeMotorista.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomeMotorista.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNomeMotorista_KeyUp);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(39, 126);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(106, 19);
            this.metroLabel3.TabIndex = 40;
            this.metroLabel3.Text = "Nome motorista";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(174, 54);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(112, 19);
            this.metroLabel2.TabIndex = 38;
            this.metroLabel2.Text = "Data viagem feita";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(39, 54);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(92, 19);
            this.metroLabel4.TabIndex = 37;
            this.metroLabel4.Text = "Data marcada";
            // 
            // btnUltViagens
            // 
            this.btnUltViagens.Location = new System.Drawing.Point(267, 11);
            this.btnUltViagens.Name = "btnUltViagens";
            this.btnUltViagens.Size = new System.Drawing.Size(175, 23);
            this.btnUltViagens.TabIndex = 31;
            this.btnUltViagens.Text = "Ver viagens";
            this.btnUltViagens.UseSelectable = true;
            this.btnUltViagens.Click += new System.EventHandler(this.btnUltViagens_Click);
            // 
            // btnNewViagem
            // 
            this.btnNewViagem.BackgroundImage = global::ControleFrotaDeVeiculos.Properties.Resources.novo3;
            this.btnNewViagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewViagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewViagem.FlatAppearance.BorderSize = 0;
            this.btnNewViagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewViagem.Location = new System.Drawing.Point(42, 0);
            this.btnNewViagem.Name = "btnNewViagem";
            this.btnNewViagem.Size = new System.Drawing.Size(36, 34);
            this.btnNewViagem.TabIndex = 11;
            this.btnNewViagem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnNewViagem.UseVisualStyleBackColor = true;
            this.btnNewViagem.Click += new System.EventHandler(this.btnNewViagem_Click);
            // 
            // UserControlViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlViagem";
            this.Size = new System.Drawing.Size(733, 438);
            this.Load += new System.EventHandler(this.UserControlViagens_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnNewViagem;
        private MetroFramework.Controls.MetroLink btnUltViagens;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNomeMotorista;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtPlacaVeiculo;
        private MetroFramework.Controls.MetroTextBox txtKmFinal;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtKmInicial;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtMotivo;
        private MetroFramework.Controls.MetroComboBox txtSituacao;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btnSalvarAlt;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.Button btnInfoVeiculo;
        private System.Windows.Forms.Button btnInfoMotorista;
        private System.Windows.Forms.MaskedTextBox txtDataViagemFeita;
        private System.Windows.Forms.MaskedTextBox txtData;
    }
}
