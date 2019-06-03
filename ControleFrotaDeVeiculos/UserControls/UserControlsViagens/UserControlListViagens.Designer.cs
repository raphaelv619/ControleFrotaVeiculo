namespace ControleFrotaDeVeiculos.UserControlViagens
{
    partial class UserControlListViagens
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
            this.txtDia = new MetroFramework.Controls.MetroComboBox();
            this.txtAno = new MetroFramework.Controls.MetroComboBox();
            this.txtMes = new MetroFramework.Controls.MetroComboBox();
            this.checkConcluida = new MetroFramework.Controls.MetroCheckBox();
            this.checkPendente = new MetroFramework.Controls.MetroCheckBox();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnProcurar = new MetroFramework.Controls.MetroButton();
            this.btnNewViagem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.txtDia);
            this.panel1.Controls.Add(this.txtAno);
            this.panel1.Controls.Add(this.txtMes);
            this.panel1.Controls.Add(this.checkConcluida);
            this.panel1.Controls.Add(this.checkPendente);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.metroComboBox1);
            this.panel1.Controls.Add(this.materialListView1);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.btnProcurar);
            this.panel1.Controls.Add(this.btnNewViagem);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 466);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtDia
            // 
            this.txtDia.DropDownHeight = 300;
            this.txtDia.FormattingEnabled = true;
            this.txtDia.IntegralHeight = false;
            this.txtDia.ItemHeight = 23;
            this.txtDia.Items.AddRange(new object[] {
            "Dia",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.txtDia.Location = new System.Drawing.Point(42, 46);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(51, 29);
            this.txtDia.TabIndex = 43;
            this.txtDia.UseSelectable = true;
            // 
            // txtAno
            // 
            this.txtAno.FormattingEnabled = true;
            this.txtAno.ItemHeight = 23;
            this.txtAno.Items.AddRange(new object[] {
            "Ano",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015"});
            this.txtAno.Location = new System.Drawing.Point(171, 46);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(66, 29);
            this.txtAno.TabIndex = 34;
            this.txtAno.UseSelectable = true;
            // 
            // txtMes
            // 
            this.txtMes.FormattingEnabled = true;
            this.txtMes.ItemHeight = 23;
            this.txtMes.Items.AddRange(new object[] {
            "Mês",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.txtMes.Location = new System.Drawing.Point(99, 46);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(66, 29);
            this.txtMes.TabIndex = 33;
            this.txtMes.UseSelectable = true;
            // 
            // checkConcluida
            // 
            this.checkConcluida.AutoSize = true;
            this.checkConcluida.Location = new System.Drawing.Point(582, 25);
            this.checkConcluida.Name = "checkConcluida";
            this.checkConcluida.Size = new System.Drawing.Size(130, 15);
            this.checkConcluida.TabIndex = 30;
            this.checkConcluida.Text = "Somente concluídas";
            this.checkConcluida.UseSelectable = true;
            this.checkConcluida.CheckedChanged += new System.EventHandler(this.checkConcluida_CheckedChanged);
            // 
            // checkPendente
            // 
            this.checkPendente.AutoSize = true;
            this.checkPendente.Location = new System.Drawing.Point(582, 3);
            this.checkPendente.Name = "checkPendente";
            this.checkPendente.Size = new System.Drawing.Size(128, 15);
            this.checkPendente.TabIndex = 29;
            this.checkPendente.Text = "Somente pendentes";
            this.checkPendente.UseSelectable = true;
            this.checkPendente.CheckedChanged += new System.EventHandler(this.checkPendente_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(341, 11);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(134, 23);
            this.txtSearch.TabIndex = 28;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Todos",
            "Placa",
            "Motorista"});
            this.metroComboBox1.Location = new System.Drawing.Point(214, 11);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 27;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.TextChanged += new System.EventHandler(this.metroComboBox1_TextChanged);
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.materialListView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(42, 74);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.MultiSelect = false;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(680, 392);
            this.materialListView1.TabIndex = 26;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.materialListView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Placa";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Motorista";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Situação";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(120, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 25;
            this.metroLabel1.Text = "Pesquisar por";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(481, 11);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 23;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseSelectable = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
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
            this.btnNewViagem.TabIndex = 10;
            this.btnNewViagem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnNewViagem.UseVisualStyleBackColor = true;
            this.btnNewViagem.Click += new System.EventHandler(this.btnNewViagem_Click);
            // 
            // UserControlListViagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlListViagens";
            this.Size = new System.Drawing.Size(733, 466);
            this.Load += new System.EventHandler(this.UserControlListViagens_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnNewViagem;
        private MetroFramework.Controls.MetroButton btnProcurar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroCheckBox checkConcluida;
        private MetroFramework.Controls.MetroCheckBox checkPendente;
        private MetroFramework.Controls.MetroComboBox txtAno;
        private MetroFramework.Controls.MetroComboBox txtMes;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MetroFramework.Controls.MetroComboBox txtDia;
    }
}
