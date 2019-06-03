using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleFrotaDeVeiculos.models;

namespace ControleFrotaDeVeiculos.UserControlViagens
{
    public partial class UserControlCadastroViagens : UserControl
    {
        public Boolean byVehicle = false;
        public Boolean byMot = false;
        public UserControlCadastroViagens()
        {
            InitializeComponent();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelControl.Controls.Remove(frm1.userControlCadastroViagens);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();

            Motorista motorista = new Motorista();
            Veiculos veiculos = new Veiculos();
            Viagens viagens = new Viagens();
            viagens.Motorista = motorista;
            viagens.Veiculos = veiculos;

            motorista.CPF = txtCPFMotorista.Text;
            motorista.Nome = txtNomeMotorista.Text;
            veiculos.Placa = txtPlacaVeiculo.Text;

            if(metroCheckBox1.Checked == true)
            {
                viagens.dateViagemFeita = Convert.ToDateTime(txtDataFeita.Text);
                viagens.KmInicial = txtKmInicial.Text;
                viagens.KmFinal = txtKmFinal.Text;
            }
            viagens.dateViagem = Convert.ToDateTime(txtData.Text);                      
            viagens.Motorista.CPF = motorista.CPF;
            viagens.Motorista.Nome = motorista.Nome;
            viagens.Veiculos.Placa = veiculos.Placa;          
            viagens.Motivo = txtMotivo.Text;
            viagens.Situacao = txtSituacao.Text;
            bll.novaViagem(viagens);
            MessageBox.Show("Viagem cadastrada com sucesso.");

            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelControl.Controls.Remove(frm1.userControlCadastroViagens);
            if (frm1.panelControl.Controls.Contains(frm1.userControlViagem))
            {
                frm1.userControlViagem.BringToFront();
            }
            else
            {
                frm1.panelControl.Controls.Add(frm1.userControlViagem);
                frm1.userControlViagem.BringToFront();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (byVehicle == true)
            {
                txtPlacaVeiculo.Enabled = false;
                BLL bll = new BLL();
                Veiculos veiculos = new Veiculos();
                veiculos = bll.ListaVeiculosPorPlaca(txtPlacaVeiculo.Text);
                txtModeloVeiculo.Text = veiculos.Modelo;
                txtCor.Text = veiculos.Cor;
                byVehicle = false;
            }
            else if(byMot == true)
            {
                txtNomeMotorista.Enabled = false;
                BLL bll = new BLL();
                Motorista motorista = new Motorista();
                motorista = bll.ListaMotoristaPorNome(txtNomeMotorista.Text);
                txtCPFMotorista.Text = motorista.CPF;
                byMot = false;
            }
            else
            {
                txtPlacaVeiculo.Enabled = true;
                txtNomeMotorista.Enabled = true;
               // txtNomeMotorista.Text = "";
               // txtCPFMotorista.Text = "";
                //txtPlacaVeiculo.Text = "";
               // txtModeloVeiculo.Text = "";
               // txtCor.Text = "";
            }
        }

        private void UserControlCadastroViagens_Load(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            txtNomeMotorista.AutoCompleteCustomSource = bll.AutoCompletarNome();
            txtCPFMotorista.AutoCompleteCustomSource = bll.AutoCompletarCPF();
            txtPlacaVeiculo.AutoCompleteCustomSource = bll.AutoCompletarPlaca();
        }

        private void txtNomeMotorista_Leave(object sender, EventArgs e)
        {
            
                BLL bll = new BLL();
                Motorista motorista = new Motorista();
                motorista = bll.ListaMotoristaPorNome(txtNomeMotorista.Text);
                txtCPFMotorista.Text = motorista.CPF;
                txtCPFMotorista.Enabled = false;
            
        }

        private void txtCPFMotorista_Leave(object sender, EventArgs e)
        {
            
        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void txtPlacaVeiculo_Leave(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            Veiculos veiculos = new Veiculos();
            veiculos = bll.ListaVeiculosPorPlaca(txtPlacaVeiculo.Text);
            txtModeloVeiculo.Text = veiculos.Modelo;
            txtCor.Text = veiculos.Cor;
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBox1.Checked == true)
            {
                txtDataFeita.Enabled = true;
                txtKmInicial.Enabled = true;
                txtKmFinal.Enabled = true;
                txtSituacao.Text = "Concluída";
            }
            else
            {
                txtDataFeita.Text = "";
                txtKmFinal.Text = "";
                txtKmInicial.Text = "";
                txtSituacao.Text = "Pendente";
                txtDataFeita.Enabled = false;
                txtKmInicial.Enabled = false;
                txtKmFinal.Enabled = false;
            }
        }

        private void txtDataFeita_Click(object sender, EventArgs e)
        {

        }

        private void txtPlacaVeiculo_Click(object sender, EventArgs e)
        {

        }
    }
}
