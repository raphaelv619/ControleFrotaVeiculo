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
    public partial class UserControlEntradaSaida : UserControl
    {
        public int id = 0;
        public UserControlEntradaSaida()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            EntradaSaida entradaSaida = new EntradaSaida();
            Motorista motorista = new Motorista();
            Veiculos veiculos = new Veiculos();
            entradaSaida.Motorista = motorista;
            entradaSaida.Veiculos = veiculos;
            entradaSaida.ID = id;
            if (MessageBox.Show("Todos os dados serão perdidos", "Excluir?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bll.DeleteEntradaSaida(entradaSaida);
                Form1 frm1 = (Form1)Application.OpenForms["Form1"];
                List<EntradaSaida> list = new List<EntradaSaida>();

                frm1.userControlListEntradaSaida.materialListView1.Items.Clear();
                list = bll.listaEntradaSaida("Todos", "", "", "", "", "");

                foreach (var item in list)
                {
                    frm1.userControlListEntradaSaida.materialListView1.Items.Add(new ListViewItem(new string[] { item.Veiculos.Placa, item.Motorista.Nome, item.Data.ToShortDateString(), item.HrSaida.ToString(), item.HrEntrada.ToString(), item.ID.ToString() }));
                }
                frm1.userControlListEntradaSaida.materialListView1.Refresh();
                frm1.panelControl.Controls.Remove(frm1.userControlEntradaSaida);
                if (frm1.panelControl.Controls.Contains(frm1.userControlListEntradaSaida))
                {
                    frm1.userControlListEntradaSaida.BringToFront();
                }
                else
                {
                    frm1.panelControl.Controls.Add(frm1.userControlListEntradaSaida);
                    frm1.userControlListEntradaSaida.BringToFront();
                }

            }
            else
            {

            }
        }

        private void btnUltEntradaSaida_Click(object sender, EventArgs e)
        {
            if (btnSalvarAlt.Enabled == true)
            {
                if (MessageBox.Show("Deseja salvar?", "É possível que alterações feitas sejam perdidas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Salvar();
                }
            }
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelControl.Controls.Remove(frm1.userControlEntradaSaida);
            if (frm1.panelControl.Controls.Contains(frm1.userControlListEntradaSaida))
            {
                frm1.userControlListEntradaSaida.BringToFront();
            }
            else
            {
                frm1.panelControl.Controls.Add(frm1.userControlListEntradaSaida);
                frm1.userControlListEntradaSaida.BringToFront();
            }
        }

        private void UserControlEntradaSaida_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeMotorista_Click(object sender, EventArgs e)
        {

        }

        private void txtData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnNewEntradaSaida_Click(object sender, EventArgs e)
        {
            if (btnSalvarAlt.Enabled == true)
            {
                if (MessageBox.Show("Deseja salvar?", "É possível que alterações feitas sejam perdidas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Salvar();
                }
            }
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelControl.Controls.Add(frm1.userControlCadastroEntradaSaida);
            frm1.userControlCadastroEntradaSaida.BringToFront();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtKmInicial_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void txtCPFMotorista_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void txtPlacaVeiculo_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void txtModeloVeiculo_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {

        }

        private void txtCor_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            BLL bll = new BLL();
            EntradaSaida entradaSaida = new EntradaSaida();
            Motorista motorista = new Motorista();
            Veiculos veiculos = new Veiculos();
            entradaSaida.Motorista = motorista;
            entradaSaida.Veiculos = veiculos;
            if (id != 0)
            {
                entradaSaida = bll.ListaEntradaSaidaPorID(id);
                txtData.Text = entradaSaida.Data.ToShortDateString();
                txtHrEntrada.Text = entradaSaida.HrEntrada;
                txtHrSaida.Text = entradaSaida.HrSaida;
                txtNomeMotorista.Text = entradaSaida.Motorista.Nome;
                txtPlacaVeiculo.Text = entradaSaida.Veiculos.Placa;
                txtKmInicial.Text = entradaSaida.KmInicial;
                txtKmFinal.Text = entradaSaida.KmFinal;

            }
        }

        private void btnInfoMotorista_Click(object sender, EventArgs e)
        {
            if (btnSalvarAlt.Enabled == true)
            {
                if (MessageBox.Show("Deseja salvar?", "É possível que alterações feitas sejam perdidas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Salvar();
                }
            }
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.userControlMotorista.txtNome.Text = txtNomeMotorista.Text;
            frm1.panelLabel.Height = frm1.btnMotoristas.Height; //Muda o botão do menu
            frm1.panelLabel.Top = frm1.btnMotoristas.Top; //Muda o botão do menu
            if (frm1.panelControl.Controls.Contains(frm1.userControlMotorista))
            {
                frm1.userControlMotorista.BringToFront();
            }
            else
            {
                frm1.panelControl.Controls.Add(frm1.userControlMotorista);
                frm1.userControlMotorista.BringToFront();
            }
        }

        private void btnInfoVeiculo_Click(object sender, EventArgs e)
        {
            if (btnSalvarAlt.Enabled == true)
            {
                if (MessageBox.Show("Deseja salvar?", "É possível que alterações feitas sejam perdidas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Salvar();
                }
            }
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.userControlVehicle.txtPlaca.Text = txtPlacaVeiculo.Text;
            frm1.panelLabel.Height = frm1.btnVeiculos.Height; //Muda o botão do menu
            frm1.panelLabel.Top = frm1.btnVeiculos.Top; //Muda o botão do menu
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

        private void txtData_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtHrSaida_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtHrEntrada_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtNomeMotorista_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtPlacaVeiculo_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtKmInicial_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtKmFinal_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void Salvar()
        {
            BLL bll = new BLL();
            EntradaSaida entradaSaida = new EntradaSaida();
            Motorista motorista = new Motorista();
            Veiculos veiculos = new Veiculos();
            entradaSaida.Motorista = motorista;
            entradaSaida.Veiculos = veiculos;
            entradaSaida.Data = Convert.ToDateTime(txtData.Text);
            entradaSaida.KmInicial = txtKmInicial.Text;
            entradaSaida.KmFinal = txtKmFinal.Text;
            entradaSaida.Motorista.Nome = txtNomeMotorista.Text;
            entradaSaida.Veiculos.Placa = txtPlacaVeiculo.Text;
            entradaSaida.HrEntrada = txtHrEntrada.Text;
            entradaSaida.HrSaida = txtHrSaida.Text;
            entradaSaida.ID = id;
            bll.UpdateEntradaSaida(entradaSaida);
            MessageBox.Show("Alterações feitas com sucesso.");
            btnSalvarAlt.Enabled = false;
        }
    }
}
