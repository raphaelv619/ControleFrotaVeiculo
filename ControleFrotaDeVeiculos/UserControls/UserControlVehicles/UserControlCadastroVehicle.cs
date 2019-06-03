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
using ControleFrotaDeVeiculos.UserControlVehicles;

namespace ControleFrotaDeVeiculos
{
    public partial class UserControlCadastroVehicle : UserControl
    {
        public bool listCad = false;
        public bool cad = false;
        public UserControlCadastroVehicle()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserControlCadastroVehicle_Load(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            DataTable dt = bll.selecionaNomeMotorista();
            //comboboxMotorista.DisplayMember=  dt.Columns[1].ToString();
            //comboboxMotorista.DataSource = dt;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            Veiculos veiculos = new Veiculos();
            veiculos = bll.ListaVeiculosPorPlaca(txtPlaca.Text);
            if(veiculos.Placa == txtPlaca.Text)
            {
                MessageBox.Show("Veículo já cadastrado.");
            }
            else
            {
                if(txtPlaca.Text == "" || txtChassi.Text == "" || txtRenavam.Text == "" || txtMarca.Text == "" || txtModelo.Text == "" || txtKmAtual.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios");
                }
                else
                {
                    veiculos.Placa = txtPlaca.Text;
                    veiculos.Marca = txtMarca.Text;
                    veiculos.Modelo = txtModelo.Text;
                    veiculos.Cor = txtCor.Text;
                    veiculos.AnoFabr = txtAnoFabr.Text;
                    veiculos.AnoMod = txtAnoMod.Text;
                    veiculos.Kilometragem = txtKmAtual.Text;
                    veiculos.Situacao = txtSituacao.Text;
                    veiculos.Motorista = "";
                    veiculos.Combustivel = txtCombustivel.Text;
                    veiculos.Renavam = txtRenavam.Text;
                    veiculos.Chassi = txtChassi.Text;
                    veiculos.Motorizacao = txtMotorizacao.Text;
                    veiculos.Tipo = txtTipo.Text;
                    bll.novoVeiculo(veiculos);

                    MessageBox.Show("Veículo cadastrado com sucesso.");

                    Form1 frm1 = (Form1)Application.OpenForms["Form1"];
                    frm1.panelControl.Controls.Remove(frm1.userControlCadastroVehicle);
                    frm1.userControlVehicle.txtPlaca.Text = veiculos.Placa;
                    txtPlaca.Text = "";
                    txtMarca.Text = "";
                    txtModelo.Text = "";
                    txtCor.Text = "";
                    txtAnoFabr.Text = "";
                    txtAnoMod.Text = "";
                    txtKmAtual.Text = "";
                    txtSituacao.Text = "";
                    //comboboxMotorista.Text = "";
                    txtCombustivel.Text = "" ;
                    txtRenavam.Text =  "";
                    txtChassi.Text = "" ;
                    txtMotorizacao.Text = "" ;
                    txtTipo.Text =  "" ;
                    if (frm1.panelControl.Controls.Contains(frm1.userControlVehicle))
                    {
                        frm1.userControlVehicle.BringToFront();
                    }
                    else
                    {
                        frm1.panelControl.Controls.Add(frm1.userControlVehicle);
                        frm1.userControlVehicle.BringToFront();
                    }
                }               
            }
            
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void txtPlaca_Click(object sender, EventArgs e)
        {

        }

        private void txtRenavam_Click(object sender, EventArgs e)
        {

        }

        private void txtMarca_Click(object sender, EventArgs e)
        {

        }

        private void txtModelo_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {

        }

        private void txtTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel14_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelControl.Controls.Remove(frm1.userControlCadastroVehicle);
            if (frm1.panelControl.Controls.Contains(frm1.userControlListVehicle))
            {
                frm1.userControlListVehicle.BringToFront();
            }
            else if (frm1.panelControl.Controls.Contains(frm1.userControlVehicle))
            {
                frm1.userControlVehicle.BringToFront();
            }
        }

        private void comboboxMotorista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }
    }
}
