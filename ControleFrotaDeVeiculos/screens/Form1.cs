using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ControleFrotaDeVeiculos.models;
using ControleFrotaDeVeiculos.UserControlVehicles;
using ControleFrotaDeVeiculos.UserControlMotoristas;
using ControleFrotaDeVeiculos.UserControlViagens;
using ControleFrotaDeVeiculos.UserControls;
using ControleFrotaDeVeiculos.UserControls.UserControlsEntradaSaida;

namespace ControleFrotaDeVeiculos
{
    public partial class Form1 : Form

    {

        //UserControls dos Veículos
        public UserControlListVehicle userControlListVehicle = new UserControlListVehicle();
        public UserControlVehicle userControlVehicle = new UserControlVehicle();
        public UserControlCadastroVehicle userControlCadastroVehicle = new UserControlCadastroVehicle();

        //UserControls dos Motoristas
        public UserControlListMotorista userControlListMotorista = new UserControlListMotorista();
        public UserControlMotorista userControlMotorista = new UserControlMotorista();
        public UserControlCadastroMotorista userControlCadastroMotorista = new UserControlCadastroMotorista();

        //UserControls das Viagens
        public UserControlListViagens userControlListViagens = new UserControlListViagens();
        public UserControlViagem userControlViagem = new UserControlViagem();
        public UserControlCadastroViagens userControlCadastroViagens = new UserControlCadastroViagens();

        //UserControls das Entradas/Saidas
        public UserControlListEntradaSaida userControlListEntradaSaida = new UserControlListEntradaSaida();
        public UserControlEntradaSaida userControlEntradaSaida = new UserControlEntradaSaida();
        public UserControlCadastroEntradaSaida userControlCadastroEntradaSaida = new UserControlCadastroEntradaSaida();
        


        public Form1()
        {
            InitializeComponent();
            panelLabel.Top = btnRelatorios.Top;
        
       }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

    private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            panelLabel.Visible = true;
            if (panelLabel.Top == btnVeiculos.Top)
            {

            } else
            {
                panelLabel.Height = btnVeiculos.Height;
                panelLabel.Top = btnVeiculos.Top;
                if (panelControl.Controls.Contains(userControlCadastroVehicle))
                {
                    userControlCadastroVehicle.BringToFront();
                }
                else if(panelControl.Controls.Contains(userControlVehicle))
                {
                    userControlVehicle.BringToFront();
                }
                else if (panelControl.Controls.Contains(userControlListVehicle))
                {
                    userControlListVehicle.BringToFront();
                }
                else
                {
                    panelControl.Controls.Add(userControlListVehicle);
                    userControlListVehicle.BringToFront();
                }
            }            
        }

        private void btnMotoristas_Click(object sender, EventArgs e)
        {
            panelLabel.Visible = true;
            if (panelLabel.Top == btnMotoristas.Top)
            {

            } else
            {
                panelLabel.Height = btnMotoristas.Height;
                panelLabel.Top = btnMotoristas.Top;
                if (panelControl.Controls.Contains(userControlCadastroMotorista))
                {
                    userControlCadastroMotorista.BringToFront();
                }
                else if(panelControl.Controls.Contains(userControlMotorista))
                {
                    userControlMotorista.BringToFront();
                }
                else if (panelControl.Controls.Contains(userControlListMotorista))
                {
                    userControlListMotorista.BringToFront();
                }
                else
                {
                    panelControl.Controls.Add(userControlListMotorista);
                    userControlListMotorista.BringToFront();
                }
            }                       
        }

        private void btnViagens_Click(object sender, EventArgs e)
        {
            panelLabel.Visible = true;
            if (panelLabel.Top == btnViagens.Top)
            {

            }
            else
            {
                panelLabel.Height = btnViagens.Height;
                panelLabel.Top = btnViagens.Top;
                if (panelControl.Controls.Contains(userControlCadastroViagens))
                {
                    userControlCadastroViagens.BringToFront();
                }
                else if (panelControl.Controls.Contains(userControlViagem))
                {
                    userControlViagem.BringToFront();
                }
                else if (panelControl.Controls.Contains(userControlListViagens))
                {
                    userControlListViagens.BringToFront();
                }
                else
                {
                    panelControl.Controls.Add(userControlListViagens);
                    userControlListViagens.BringToFront();
                }
            }
            
        }

        private void btnEntradaSaida_Click(object sender, EventArgs e)
        {
            panelLabel.Visible = true;
            if (panelLabel.Top == btnEntradaSaida.Top)
            {

            }
            else
            {
                panelLabel.Height = btnEntradaSaida.Height;
                panelLabel.Top = btnEntradaSaida.Top;
                if (panelControl.Controls.Contains(userControlCadastroEntradaSaida))
                {
                    userControlCadastroEntradaSaida.BringToFront();
                }
                else if (panelControl.Controls.Contains(userControlEntradaSaida))
                {
                    userControlEntradaSaida.BringToFront();
                }
                else if (panelControl.Controls.Contains(userControlListEntradaSaida))
                {
                    userControlListEntradaSaida.BringToFront();
                }
                else
                {
                    panelControl.Controls.Add(userControlListEntradaSaida);
                    userControlListEntradaSaida.BringToFront();
                }
            }
        }

        private void btnManutencao_Click(object sender, EventArgs e)
        {
            panelLabel.Visible = true;
            panelLabel.Height = btnManutencao.Height;
            panelLabel.Top = btnManutencao.Top;
        }

        private void btnAbastecimento_Click(object sender, EventArgs e)
        {
            panelLabel.Visible = true;
            panelLabel.Height = btnAbastecimento.Height;
            panelLabel.Top = btnAbastecimento.Top;
        }

        private void btnMultas_Click(object sender, EventArgs e)
        {
            panelLabel.Visible = true;
            panelLabel.Height = btnMultas.Height;
            panelLabel.Top = btnMultas.Top;
        }

        private void btnPneus_Click_1(object sender, EventArgs e)
        {
            panelLabel.Visible = true;
            panelLabel.Height = btnPneus.Height;
            panelLabel.Top = btnPneus.Top;
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            panelLabel.Visible = true;
            panelLabel.Height = btnEstoque.Height;
            panelLabel.Top = btnEstoque.Top;
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            panelLabel.Visible = true;
            panelLabel.Height = btnFinanceiro.Height;
            panelLabel.Top = btnFinanceiro.Top;
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            panelLabel.Visible = true;
            panelLabel.Height = btnRelatorios.Height;
            panelLabel.Top = btnRelatorios.Top;
        }

        private void userControlVehicle1_Load(object sender, EventArgs e)
        {

        }

        private void userControlVehicle1_Load_1(object sender, EventArgs e)
        {

        }

        private void userControlMotorista1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
