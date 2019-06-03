namespace ControleFrotaDeVeiculos.UserControlMotoristas
{
    partial class UserControlListMotorista
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSearchNome = new MetroFramework.Controls.MetroTextBox();
            this.btnProcurarByPlaca = new MetroFramework.Controls.MetroButton();
            this.btnUltVeiculos = new MetroFramework.Controls.MetroLink();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelList = new MetroFramework.Controls.MetroLabel();
            this.panelMotorista = new System.Windows.Forms.Panel();
            this.panelMotorista.SuspendLayout();
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
            this.btnNewVehicle.TabIndex = 17;
            this.btnNewVehicle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnNewVehicle.UseVisualStyleBackColor = true;
            this.btnNewVehicle.Click += new System.EventHandler(this.btnNewVehicle_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(128, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(126, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Pesquisar por nome";
            // 
            // txtSearchNome
            // 
            this.txtSearchNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearchNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtSearchNome.CustomButton.Image = null;
            this.txtSearchNome.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txtSearchNome.CustomButton.Name = "";
            this.txtSearchNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchNome.CustomButton.TabIndex = 1;
            this.txtSearchNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchNome.CustomButton.UseSelectable = true;
            this.txtSearchNome.CustomButton.Visible = false;
            this.txtSearchNome.Lines = new string[0];
            this.txtSearchNome.Location = new System.Drawing.Point(260, 15);
            this.txtSearchNome.MaxLength = 32767;
            this.txtSearchNome.Name = "txtSearchNome";
            this.txtSearchNome.PasswordChar = '\0';
            this.txtSearchNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchNome.SelectedText = "";
            this.txtSearchNome.SelectionLength = 0;
            this.txtSearchNome.SelectionStart = 0;
            this.txtSearchNome.ShortcutsEnabled = true;
            this.txtSearchNome.Size = new System.Drawing.Size(201, 23);
            this.txtSearchNome.TabIndex = 19;
            this.txtSearchNome.UseSelectable = true;
            this.txtSearchNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnProcurarByPlaca
            // 
            this.btnProcurarByPlaca.Location = new System.Drawing.Point(467, 15);
            this.btnProcurarByPlaca.Name = "btnProcurarByPlaca";
            this.btnProcurarByPlaca.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarByPlaca.TabIndex = 20;
            this.btnProcurarByPlaca.Text = "Procurar";
            this.btnProcurarByPlaca.UseSelectable = true;
            this.btnProcurarByPlaca.Click += new System.EventHandler(this.btnProcurarByPlaca_Click);
            // 
            // btnUltVeiculos
            // 
            this.btnUltVeiculos.Location = new System.Drawing.Point(548, 15);
            this.btnUltVeiculos.Name = "btnUltVeiculos";
            this.btnUltVeiculos.Size = new System.Drawing.Size(182, 23);
            this.btnUltVeiculos.TabIndex = 21;
            this.btnUltVeiculos.Text = "Todos os motoristas";
            this.btnUltVeiculos.UseSelectable = true;
            this.btnUltVeiculos.Click += new System.EventHandler(this.btnUltVeiculos_Click);
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
            this.materialListView1.TabIndex = 22;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.materialListView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CPF";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CNH";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Val CNH";
            this.columnHeader4.Width = 140;
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(42, 42);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(192, 19);
            this.labelList.TabIndex = 23;
            this.labelList.Text = "Últimos motoristas cadastrados";
            // 
            // panelMotorista
            // 
            this.panelMotorista.Controls.Add(this.materialListView1);
            this.panelMotorista.Controls.Add(this.labelList);
            this.panelMotorista.Controls.Add(this.btnNewVehicle);
            this.panelMotorista.Controls.Add(this.metroLabel1);
            this.panelMotorista.Controls.Add(this.btnUltVeiculos);
            this.panelMotorista.Controls.Add(this.txtSearchNome);
            this.panelMotorista.Controls.Add(this.btnProcurarByPlaca);
            this.panelMotorista.Location = new System.Drawing.Point(0, 0);
            this.panelMotorista.Name = "panelMotorista";
            this.panelMotorista.Size = new System.Drawing.Size(733, 438);
            this.panelMotorista.TabIndex = 24;
            this.panelMotorista.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UserControlListMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panelMotorista);
            this.Name = "UserControlListMotorista";
            this.Size = new System.Drawing.Size(733, 438);
            this.Load += new System.EventHandler(this.UserControlListMotorista_Load);
            this.panelMotorista.ResumeLayout(false);
            this.panelMotorista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewVehicle;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSearchNome;
        private MetroFramework.Controls.MetroButton btnProcurarByPlaca;
        private MetroFramework.Controls.MetroLink btnUltVeiculos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroLabel labelList;
        private System.Windows.Forms.Panel panelMotorista;
        public MaterialSkin.Controls.MaterialListView materialListView1;
    }
}
