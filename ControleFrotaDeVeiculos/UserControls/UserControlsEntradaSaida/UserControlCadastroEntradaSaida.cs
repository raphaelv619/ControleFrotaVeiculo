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

namespace ControleFrotaDeVeiculos.UserControls.UserControlsEntradaSaida
{
    public partial class UserControlCadastroEntradaSaida : UserControl
    {
        public Boolean byVehicle = false;
        public Boolean byMot = false;
        public UserControlCadastroEntradaSaida()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelControl.Controls.Remove(frm1.userControlCadastroEntradaSaida);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();

            Motorista motorista = new Motorista();
            Veiculos veiculos = new Veiculos();
            EntradaSaida entradaSaida = new EntradaSaida();
            entradaSaida.Motorista = motorista;
            entradaSaida.Veiculos = veiculos;

            motorista.Nome = txtNomeMotorista.Text;
            motorista.CPF = txtCPFMotorista.Text;
            veiculos.Placa = txtPlacaVeiculo.Text;

            entradaSaida.Data = Convert.ToDateTime(txtData.Text);
            entradaSaida.HrEntrada = txtHrEntrada.Text;
            entradaSaida.HrSaida = txtHrSaida.Text;
            entradaSaida.Motorista.Nome = motorista.Nome;
            entradaSaida.Veiculos.Placa = veiculos.Placa;
            entradaSaida.KmInicial = txtKmInicial.Text;
            entradaSaida.KmFinal = txtKmFinal.Text;
            bll.novaEntradaSaida(entradaSaida);
            MessageBox.Show("Registro castradado com sucesso.");

            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelControl.Controls.Remove(frm1.userControlCadastroEntradaSaida);
            if (frm1.panelControl.Controls.Contains(frm1.userControlEntradaSaida))
            {
                frm1.userControlEntradaSaida.BringToFront();
            }
            else
            {
                frm1.panelControl.Controls.Add(frm1.userControlEntradaSaida);
                frm1.userControlEntradaSaida.BringToFront();
            }
        }

        private void txtNomeMotorista_Leave(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            Motorista motorista = new Motorista();
            motorista = bll.ListaMotoristaPorNome(txtNomeMotorista.Text);
            txtCPFMotorista.Text = motorista.CPF;
            txtCPFMotorista.Enabled = false;
        }

        private void txtPlacaVeiculo_Leave(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            Veiculos veiculos = new Veiculos();
            veiculos = bll.ListaVeiculosPorPlaca(txtPlacaVeiculo.Text);
            txtModeloVeiculo.Text = veiculos.Modelo;
            txtCor.Text = veiculos.Cor;
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
            else if (byMot == true)
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
                txtNomeMotorista.Text = "";
                txtCPFMotorista.Text = "";
                txtPlacaVeiculo.Text = "";
                txtModeloVeiculo.Text = "";
                txtCor.Text = "";
            }
        }
    }
}
