namespace ControleFrotaDeVeiculos
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLabel = new System.Windows.Forms.Panel();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnPneus = new System.Windows.Forms.Button();
            this.btnMultas = new System.Windows.Forms.Button();
            this.btnAbastecimento = new System.Windows.Forms.Button();
            this.btnManutencao = new System.Windows.Forms.Button();
            this.btnEntradaSaida = new System.Windows.Forms.Button();
            this.btnViagens = new System.Windows.Forms.Button();
            this.btnMotoristas = new System.Windows.Forms.Button();
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(599, 381);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(272, 105);
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Motoristas";
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panelLabel);
            this.panel1.Controls.Add(this.btnRelatorios);
            this.panel1.Controls.Add(this.btnFinanceiro);
            this.panel1.Controls.Add(this.btnEstoque);
            this.panel1.Controls.Add(this.btnPneus);
            this.panel1.Controls.Add(this.btnMultas);
            this.panel1.Controls.Add(this.btnAbastecimento);
            this.panel1.Controls.Add(this.btnManutencao);
            this.panel1.Controls.Add(this.btnEntradaSaida);
            this.panel1.Controls.Add(this.btnViagens);
            this.panel1.Controls.Add(this.btnMotoristas);
            this.panel1.Controls.Add(this.btnVeiculos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 530);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelLabel
            // 
            this.panelLabel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panelLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.panelLabel.Location = new System.Drawing.Point(3, 48);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(10, 38);
            this.panelLabel.TabIndex = 6;
            this.panelLabel.Visible = false;
            this.panelLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.White;
            this.btnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Image")));
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.Location = new System.Drawing.Point(12, 482);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(165, 38);
            this.btnRelatorios.TabIndex = 16;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.FlatAppearance.BorderSize = 0;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanceiro.ForeColor = System.Drawing.Color.White;
            this.btnFinanceiro.Image = ((System.Drawing.Image)(resources.GetObject("btnFinanceiro.Image")));
            this.btnFinanceiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanceiro.Location = new System.Drawing.Point(12, 440);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(165, 38);
            this.btnFinanceiro.TabIndex = 15;
            this.btnFinanceiro.Text = "Financeiro";
            this.btnFinanceiro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Image = global::ControleFrotaDeVeiculos.Properties.Resources.estoque1;
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.Location = new System.Drawing.Point(12, 400);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(165, 38);
            this.btnEstoque.TabIndex = 14;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnPneus
            // 
            this.btnPneus.FlatAppearance.BorderSize = 0;
            this.btnPneus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPneus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPneus.ForeColor = System.Drawing.Color.White;
            this.btnPneus.Image = ((System.Drawing.Image)(resources.GetObject("btnPneus.Image")));
            this.btnPneus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPneus.Location = new System.Drawing.Point(12, 356);
            this.btnPneus.Name = "btnPneus";
            this.btnPneus.Size = new System.Drawing.Size(165, 38);
            this.btnPneus.TabIndex = 13;
            this.btnPneus.Text = "Pneus";
            this.btnPneus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPneus.UseVisualStyleBackColor = true;
            this.btnPneus.Click += new System.EventHandler(this.btnPneus_Click_1);
            // 
            // btnMultas
            // 
            this.btnMultas.FlatAppearance.BorderSize = 0;
            this.btnMultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultas.ForeColor = System.Drawing.Color.White;
            this.btnMultas.Image = ((System.Drawing.Image)(resources.GetObject("btnMultas.Image")));
            this.btnMultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMultas.Location = new System.Drawing.Point(12, 312);
            this.btnMultas.Name = "btnMultas";
            this.btnMultas.Size = new System.Drawing.Size(165, 38);
            this.btnMultas.TabIndex = 12;
            this.btnMultas.Text = "Multas";
            this.btnMultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMultas.UseVisualStyleBackColor = true;
            this.btnMultas.Click += new System.EventHandler(this.btnMultas_Click);
            // 
            // btnAbastecimento
            // 
            this.btnAbastecimento.FlatAppearance.BorderSize = 0;
            this.btnAbastecimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbastecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbastecimento.ForeColor = System.Drawing.Color.White;
            this.btnAbastecimento.Image = ((System.Drawing.Image)(resources.GetObject("btnAbastecimento.Image")));
            this.btnAbastecimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbastecimento.Location = new System.Drawing.Point(12, 268);
            this.btnAbastecimento.Name = "btnAbastecimento";
            this.btnAbastecimento.Size = new System.Drawing.Size(165, 38);
            this.btnAbastecimento.TabIndex = 11;
            this.btnAbastecimento.Text = "Abastecimento";
            this.btnAbastecimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbastecimento.UseVisualStyleBackColor = true;
            this.btnAbastecimento.Click += new System.EventHandler(this.btnAbastecimento_Click);
            // 
            // btnManutencao
            // 
            this.btnManutencao.FlatAppearance.BorderSize = 0;
            this.btnManutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManutencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManutencao.ForeColor = System.Drawing.Color.White;
            this.btnManutencao.Image = ((System.Drawing.Image)(resources.GetObject("btnManutencao.Image")));
            this.btnManutencao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManutencao.Location = new System.Drawing.Point(12, 224);
            this.btnManutencao.Name = "btnManutencao";
            this.btnManutencao.Size = new System.Drawing.Size(165, 38);
            this.btnManutencao.TabIndex = 10;
            this.btnManutencao.Text = "Manutenção";
            this.btnManutencao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManutencao.UseVisualStyleBackColor = true;
            this.btnManutencao.Click += new System.EventHandler(this.btnManutencao_Click);
            // 
            // btnEntradaSaida
            // 
            this.btnEntradaSaida.FlatAppearance.BorderSize = 0;
            this.btnEntradaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradaSaida.ForeColor = System.Drawing.Color.White;
            this.btnEntradaSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnEntradaSaida.Image")));
            this.btnEntradaSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntradaSaida.Location = new System.Drawing.Point(12, 180);
            this.btnEntradaSaida.Name = "btnEntradaSaida";
            this.btnEntradaSaida.Size = new System.Drawing.Size(165, 38);
            this.btnEntradaSaida.TabIndex = 9;
            this.btnEntradaSaida.Text = "Entrada/Saída";
            this.btnEntradaSaida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntradaSaida.UseVisualStyleBackColor = true;
            this.btnEntradaSaida.Click += new System.EventHandler(this.btnEntradaSaida_Click);
            // 
            // btnViagens
            // 
            this.btnViagens.FlatAppearance.BorderSize = 0;
            this.btnViagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViagens.ForeColor = System.Drawing.Color.White;
            this.btnViagens.Image = ((System.Drawing.Image)(resources.GetObject("btnViagens.Image")));
            this.btnViagens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViagens.Location = new System.Drawing.Point(12, 136);
            this.btnViagens.Name = "btnViagens";
            this.btnViagens.Size = new System.Drawing.Size(165, 38);
            this.btnViagens.TabIndex = 8;
            this.btnViagens.Text = "Viagens";
            this.btnViagens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViagens.UseVisualStyleBackColor = true;
            this.btnViagens.Click += new System.EventHandler(this.btnViagens_Click);
            // 
            // btnMotoristas
            // 
            this.btnMotoristas.FlatAppearance.BorderSize = 0;
            this.btnMotoristas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMotoristas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotoristas.ForeColor = System.Drawing.Color.White;
            this.btnMotoristas.Image = ((System.Drawing.Image)(resources.GetObject("btnMotoristas.Image")));
            this.btnMotoristas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMotoristas.Location = new System.Drawing.Point(12, 92);
            this.btnMotoristas.Name = "btnMotoristas";
            this.btnMotoristas.Size = new System.Drawing.Size(165, 38);
            this.btnMotoristas.TabIndex = 7;
            this.btnMotoristas.Text = "Motoristas";
            this.btnMotoristas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMotoristas.UseVisualStyleBackColor = true;
            this.btnMotoristas.Click += new System.EventHandler(this.btnMotoristas_Click);
            // 
            // btnVeiculos
            // 
            this.btnVeiculos.FlatAppearance.BorderSize = 0;
            this.btnVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeiculos.ForeColor = System.Drawing.Color.White;
            this.btnVeiculos.Image = ((System.Drawing.Image)(resources.GetObject("btnVeiculos.Image")));
            this.btnVeiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVeiculos.Location = new System.Drawing.Point(12, 48);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.Size = new System.Drawing.Size(165, 38);
            this.btnVeiculos.TabIndex = 6;
            this.btnVeiculos.Text = "Veículos";
            this.btnVeiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVeiculos.UseVisualStyleBackColor = true;
            this.btnVeiculos.Click += new System.EventHandler(this.btnVeiculos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(177, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 14);
            this.panel2.TabIndex = 5;
            // 
            // panelControl
            // 
            this.panelControl.Location = new System.Drawing.Point(177, 64);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(733, 466);
            this.panelControl.TabIndex = 7;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl_Paint);
            // 
            // button15
            // 
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Image = global::ControleFrotaDeVeiculos.Properties.Resources.home;
            this.button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.Location = new System.Drawing.Point(686, 20);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(41, 38);
            this.button15.TabIndex = 11;
            this.button15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::ControleFrotaDeVeiculos.Properties.Resources.sair1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(869, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 38);
            this.btnClose.TabIndex = 10;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = global::ControleFrotaDeVeiculos.Properties.Resources.config1;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(780, 20);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(42, 38);
            this.button13.TabIndex = 9;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Image = global::ControleFrotaDeVeiculos.Properties.Resources.notif;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(733, 20);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(41, 38);
            this.button12.TabIndex = 8;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.AutoSize = true;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroTile1.ForeColor = System.Drawing.Color.DarkKhaki;
            this.metroTile1.Location = new System.Drawing.Point(259, 367);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(259, 111);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Veiculos";
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(910, 530);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroTile2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnPneus;
        private System.Windows.Forms.Button btnMultas;
        private System.Windows.Forms.Button btnAbastecimento;
        private System.Windows.Forms.Button btnManutencao;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button15;
        public System.Windows.Forms.Panel panelControl;
        public System.Windows.Forms.Button btnMotoristas;
        public System.Windows.Forms.Panel panelLabel;
        public System.Windows.Forms.Button btnVeiculos;
        public System.Windows.Forms.Button btnViagens;
        public System.Windows.Forms.Button btnEntradaSaida;
    }
}

