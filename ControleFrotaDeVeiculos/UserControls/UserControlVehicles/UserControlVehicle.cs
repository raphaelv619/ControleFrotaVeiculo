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
using ControleFrotaDeVeiculos.UserControlMotoristas;

namespace ControleFrotaDeVeiculos
{
    public partial class UserControlVehicle : UserControl
    {
        Veiculos veiculos = new Veiculos();
        public UserControlVehicle()
        {
            InitializeComponent();
        }

        private void UserControlVehicle_Load(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            
        }
        

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            BLL bll = new BLL();
            txtSearchPlaca.AutoCompleteCustomSource = bll.AutoCompletarPlaca();


            listEntradaSaida.Items.Clear();
            List<EntradaSaida> listEntradasSaida = new List<EntradaSaida>();
            listEntradasSaida = bll.listaEntradaSaida("Placa", "", "", "", "", txtPlaca.Text);
            foreach (var item in listEntradasSaida)
            {
                listEntradaSaida.Items.Add(new ListViewItem(new string[] { item.Motorista.Nome, item.Data.ToShortDateString(), item.HrSaida.ToString(), item.HrEntrada.ToString(), item.ID.ToString() }));
            }
            listEntradaSaida.Refresh();


            listViagens.Items.Clear();
            List<Viagens> listViagem = new List<Viagens>();
            listViagem = bll.listaViagens("Placa","","","","",txtPlaca.Text);
            foreach (var item in listViagem)
            {
                listViagens.Items.Add(new ListViewItem(new string[] { item.Motorista.Nome, item.dateViagem.ToShortDateString(), item.Situacao, item.ID.ToString() }));
            }
            listViagens.Refresh();



            if (txtPlaca.Text != "")
            {
                //BLL bll = new BLL();
                veiculos = bll.ListaVeiculosPorPlaca(txtPlaca.Text);
                txtPlaca.Text = veiculos.Placa;
                txtMarca.Text = veiculos.Marca;
                txtModelo.Text = veiculos.Modelo;
                txtCor.Text = veiculos.Cor;
                txtAnoMod.Text = veiculos.AnoMod;
                txtAnoFabr.Text = veiculos.AnoFabr;
                txtKmAtual.Text = veiculos.Kilometragem;
                txtSituacao.Text = veiculos.Situacao;
                DataTable dt = bll.selecionaNomeMotorista();
                //comboboxMotorista.DisplayMember = dt.Columns[1].ToString();
                //comboboxMotorista.DataSource = dt;
                //comboboxMotorista.Text = veiculos.Motorista;
                txtCombustivel.Text = veiculos.Combustivel;
                txtRenavam.Text = veiculos.Renavam;
                txtChassi.Text = veiculos.Chassi;
                txtMotorizacao.Text = veiculos.Motorizacao;
                txtTipo.Text = veiculos.Tipo;
                
                btnDeleteVehicle.Enabled = true;
                //btnInfoMotorista.Enabled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnSalvarAlt.Enabled == true)
            {
                if (MessageBox.Show("Deseja salvar?", "É possível que alterações feitas sejam perdidas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Salvar();
                }
            }
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelControl.Controls.Add(frm1.userControlCadastroVehicle);
            frm1.userControlCadastroVehicle.BringToFront();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (btnSalvarAlt.Enabled == true)
            {
                if (MessageBox.Show("Deseja salvar?", "É possível que alterações feitas sejam perdidas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Salvar();
                }
            }
            BLL bll = new BLL();
            try
            {
                 veiculos = bll.ListaVeiculosPorPlaca(txtSearchPlaca.Text);
                if (veiculos.Placa == txtSearchPlaca.Text)
                {
                    txtPlaca.Text = veiculos.Placa;
                    txtMarca.Text = veiculos.Marca;
                    txtModelo.Text = veiculos.Modelo;
                    txtCor.Text = veiculos.Cor;
                    txtAnoMod.Text = veiculos.AnoMod;
                    txtAnoFabr.Text = veiculos.AnoFabr;
                    txtKmAtual.Text = veiculos.Kilometragem;
                    txtSituacao.Text = veiculos.Situacao;
                    DataTable dt = bll.selecionaNomeMotorista();
                    //comboboxMotorista.DisplayMember = dt.Columns[1].ToString();
                   // comboboxMotorista.DataSource = dt;
                    //comboboxMotorista.Text = veiculos.Motorista;
                    txtCombustivel.Text = veiculos.Combustivel;
                    txtRenavam.Text = veiculos.Renavam;
                    txtChassi.Text = veiculos.Chassi;
                    txtMotorizacao.Text = veiculos.Motorizacao;
                    txtTipo.Text = veiculos.Tipo;                   
                    txtSearchPlaca.Text = "";
                }
                else
                {
                    MessageBox.Show("Veículo não encontrado.");
                }
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        private void comboboxMotorista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            
        }

        private void txtChassi_Click(object sender, EventArgs e)
        {

        }

        private void txtAnoMod_Click(object sender, EventArgs e)
        {

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
            //frm1.userControlMotorista.txtNome.Text = comboboxMotorista.Text;
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

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnUltVeiculos_Click(object sender, EventArgs e)
        {
            if (btnSalvarAlt.Enabled == true)
            {
                if (MessageBox.Show("Deseja salvar?", "É possível que alterações feitas sejam perdidas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Salvar();
                }
            }
            BLL bll = new BLL();
            List<Veiculos> list = new List<Veiculos>();
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.userControlListVehicle.materialListView1.Items.Clear();
            list = bll.listaUltVeiculos();
            foreach (var item in list)
            {
                frm1.userControlListVehicle.materialListView1.Items.Add(new ListViewItem(new string[] { item.Placa, item.Marca, item.Modelo, item.Cor }));
            }
            frm1.userControlListVehicle.materialListView1.Refresh();
            frm1.panelControl.Controls.Remove(frm1.userControlVehicle);
            frm1.panelControl.Controls.Add(frm1.userControlListVehicle);
            frm1.userControlListVehicle.BringToFront();
        }

        private void txtPlaca_Click(object sender, EventArgs e)
        {

        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPlaca_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtAnoMod_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtAnoFabr_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtChassi_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtRenavam_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtMarca_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtModelo_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtCor_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtCombustivel_KeyUp(object sender, KeyEventArgs e)
        {
            //
        }

        private void txtKmAtual_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtCombustivel_MouseCaptureChanged(object sender, EventArgs e)
        {
            //btnSalvarAlt.Enabled = true;
        }

        private void txtMotorizacao_TextChanged(object sender, EventArgs e)
        {
           // btnSalvarAlt.Enabled = true;
        }

        private void txtCombustivel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtMotorizacao_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtSituacao_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void comboboxMotorista_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void btnSalvarAlt_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            Veiculos veiculos = new Veiculos();
            veiculos.Placa = txtPlaca.Text;
            if (MessageBox.Show("Todos os dados sobre esse veículo serão perdidos", "Excluir veículo?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bll.DeleteVeiculo(veiculos);
                Form1 frm1 = (Form1)Application.OpenForms["Form1"];
                List<Veiculos> list = new List<Veiculos>();

                frm1.userControlListVehicle.materialListView1.Items.Clear();
                list = bll.listaUltVeiculos();

                foreach (var item in list)
                {
                    frm1.userControlListVehicle.materialListView1.Items.Add(new ListViewItem(new string[] { item.Placa, item.Marca, item.Modelo, item.Cor }));
                }
                frm1.userControlListVehicle.materialListView1.Refresh();
                frm1.userControlListVehicle.materialListView1.Scrollable = false;
                frm1.panelControl.Controls.Remove(frm1.userControlVehicle);
                frm1.panelControl.Controls.Add(frm1.userControlListVehicle);
                frm1.userControlListVehicle.BringToFront();
            }
            else
            {

            }          
        }

        private void Salvar()
        {
            BLL bll = new BLL();
            Veiculos upveiculos = new Veiculos();
            upveiculos.Placa = txtPlaca.Text;
            upveiculos.Marca = txtMarca.Text;
            upveiculos.Modelo = txtModelo.Text;
            upveiculos.Cor = txtCor.Text;
            upveiculos.AnoFabr = txtAnoFabr.Text;
            upveiculos.AnoMod = txtAnoMod.Text;
            upveiculos.Kilometragem = txtKmAtual.Text;
            upveiculos.Combustivel = txtCombustivel.Text;
            upveiculos.Chassi = txtChassi.Text;
            upveiculos.Renavam = txtRenavam.Text;
            upveiculos.Motorizacao = txtMotorizacao.Text;
            upveiculos.Tipo = txtTipo.Text;
            upveiculos.Motorista = "";
            upveiculos.Situacao = txtSituacao.Text;
            bll.UpdateVeiculo(upveiculos);
            MessageBox.Show("Alterações feitas com sucesso.");
            btnSalvarAlt.Enabled = false;

            List<Veiculos> list = new List<Veiculos>();
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.userControlListVehicle.materialListView1.Items.Clear();
            list = bll.listaUltVeiculos();
            foreach (var item in list)
            {
                frm1.userControlListVehicle.materialListView1.Items.Add(new ListViewItem(new string[] { item.Placa, item.Marca, item.Modelo, item.Cor }));
            }
            frm1.userControlListVehicle.materialListView1.Refresh();

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViagens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadViagem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelControl.Controls.Add(frm1.userControlCadastroViagens);
            frm1.userControlCadastroViagens.BringToFront();
            frm1.userControlCadastroViagens.byVehicle = true;
            frm1.userControlCadastroViagens.txtPlacaVeiculo.Text = txtPlaca.Text;
        }

        private void listViagens_MouseClick(object sender, MouseEventArgs e)
        {
            int id = Convert.ToInt32(listViagens.SelectedItems[0].SubItems[3].Text);
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.userControlViagem.id = id;
            frm1.panelLabel.Height = frm1.btnViagens.Height; //Muda o botão do menu
            frm1.panelLabel.Top = frm1.btnViagens.Top; //Muda o botão do menu
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

        private void listEntradaSaida_MouseClick(object sender, MouseEventArgs e)
        {
            int id = Convert.ToInt32(listEntradaSaida.SelectedItems[0].SubItems[4].Text);
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.userControlEntradaSaida.id = id;
            frm1.panelLabel.Height = frm1.btnEntradaSaida.Height; //Muda o botão do menu
            frm1.panelLabel.Top = frm1.btnEntradaSaida.Top; //Muda o botão do menu
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

        private void btnCadEntradaSaida_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelControl.Controls.Add(frm1.userControlCadastroEntradaSaida);
            frm1.userControlCadastroEntradaSaida.BringToFront();
            frm1.userControlCadastroEntradaSaida.byVehicle = true;
            frm1.userControlCadastroEntradaSaida.txtPlacaVeiculo.Text = txtPlaca.Text;
        }

        private void listEntradaSaida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
