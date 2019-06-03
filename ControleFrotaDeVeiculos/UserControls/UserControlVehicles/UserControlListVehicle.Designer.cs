namespace ControleFrotaDeVeiculos.UserControlVehicles
{
    partial class UserControlListVehicle
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
            this.btnNewVehicle = new System.Windows.Forms.Button();
            this.btnUltVeiculos = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnProcurarByPlaca = new MetroFramework.Controls.MetroButton();
            this.txtSearchPlaca = new MetroFramework.Controls.MetroTextBox();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelList = new MetroFramework.Controls.MetroLabel();
            this.panelUserControlListVehicle = new System.Windows.Forms.Panel();
            this.panelUserControlListVehicle.SuspendLayout();
            this.SuspendLayout();
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
            this.btnNewVehicle.TabIndex = 9;
            this.btnNewVehicle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnNewVehicle.UseVisualStyleBackColor = true;
            this.btnNewVehicle.Click += new System.EventHandler(this.btnNewVehicle_Click);
            // 
            // btnUltVeiculos
            // 
            this.btnUltVeiculos.Location = new System.Drawing.Point(510, 15);
            this.btnUltVeiculos.Name = "btnUltVeiculos";
            this.btnUltVeiculos.Size = new System.Drawing.Size(175, 23);
            this.btnUltVeiculos.TabIndex = 16;
            this.btnUltVeiculos.Text = "Todos os veículos";
            this.btnUltVeiculos.UseSelectable = true;
            this.btnUltVeiculos.Click += new System.EventHandler(this.btnUltVeiculos_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(180, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Pesquisar por placa";
            // 
            // btnProcurarByPlaca
            // 
            this.btnProcurarByPlaca.Location = new System.Drawing.Point(411, 15);
            this.btnProcurarByPlaca.Name = "btnProcurarByPlaca";
            this.btnProcurarByPlaca.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarByPlaca.TabIndex = 15;
            this.btnProcurarByPlaca.Text = "Procurar";
            this.btnProcurarByPlaca.UseSelectable = true;
            this.btnProcurarByPlaca.Click += new System.EventHandler(this.btnProcurarByPlaca_Click);
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
            this.txtSearchPlaca.TabIndex = 14;
            this.txtSearchPlaca.UseSelectable = true;
            this.txtSearchPlaca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchPlaca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchPlaca.Click += new System.EventHandler(this.txtSearchPlaca_Click);
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.materialListView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(42, 64);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.MultiSelect = false;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Scrollable = false;
            this.materialListView1.Size = new System.Drawing.Size(643, 374);
            this.materialListView1.TabIndex = 19;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            this.materialListView1.VisibleChanged += new System.EventHandler(this.materialListView1_VisibleChanged);
            this.materialListView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.materialListView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Placa";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Marca";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Modelo";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cor";
            this.columnHeader4.Width = 100;
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(42, 42);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(176, 19);
            this.labelList.TabIndex = 20;
            this.labelList.Text = "Últimos veículos cadastrados";
            this.labelList.Click += new System.EventHandler(this.labelList_Click);
            // 
            // panelUserControlListVehicle
            // 
            this.panelUserControlListVehicle.Controls.Add(this.materialListView1);
            this.panelUserControlListVehicle.Controls.Add(this.labelList);
            this.panelUserControlListVehicle.Controls.Add(this.btnNewVehicle);
            this.panelUserControlListVehicle.Controls.Add(this.txtSearchPlaca);
            this.panelUserControlListVehicle.Controls.Add(this.btnUltVeiculos);
            this.panelUserControlListVehicle.Controls.Add(this.btnProcurarByPlaca);
            this.panelUserControlListVehicle.Controls.Add(this.metroLabel1);
            this.panelUserControlListVehicle.Location = new System.Drawing.Point(0, 0);
            this.panelUserControlListVehicle.Name = "panelUserControlListVehicle";
            this.panelUserControlListVehicle.Size = new System.Drawing.Size(733, 438);
            this.panelUserControlListVehicle.TabIndex = 21;
            this.panelUserControlListVehicle.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UserControlListVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panelUserControlListVehicle);
            this.Name = "UserControlListVehicle";
            this.Size = new System.Drawing.Size(733, 438);
            this.Load += new System.EventHandler(this.UserControlListVehicle_Load);
            this.panelUserControlListVehicle.ResumeLayout(false);
            this.panelUserControlListVehicle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLink btnUltVeiculos;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnProcurarByPlaca;
        private MetroFramework.Controls.MetroTextBox txtSearchPlaca;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroLabel labelList;
        public System.Windows.Forms.Button btnNewVehicle;
        public System.Windows.Forms.Panel panelUserControlListVehicle;
        public MaterialSkin.Controls.MaterialListView materialListView1;
    }
}
