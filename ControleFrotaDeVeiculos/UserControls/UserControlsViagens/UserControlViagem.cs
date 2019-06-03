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
    public partial class UserControlViagem : UserControl
    {
        public int id = 0;
        public UserControlViagem()
        {
            InitializeComponent();
        }

        private void UserControlViagens_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            BLL bll = new BLL();
            Viagens viagens = new Viagens();
            Motorista motorista = new Motorista();
            Veiculos veiculos = new Veiculos();
            viagens.Motorista = motorista;
            viagens.Veiculos = veiculos;
            if(id != 0)
            {
                viagens = bll.ListaViagemPorID(id);
                txtData.Text = viagens.dateViagem.ToShortDateString();
                if(viagens.KmFinal == "")
                {
                    txtDataViagemFeita.Text = "";
                }
                else
                {
                    txtDataViagemFeita.Text = viagens.dateViagemFeita.ToShortDateString();
                }
                
                txtKmInicial.Text = viagens.KmInicial;
                txtKmFinal.Text = viagens.KmFinal;
                txtNomeMotorista.Text = viagens.Motorista.Nome;
                txtPlacaVeiculo.Text = viagens.Veiculos.Placa;
                txtMotivo.Text = viagens.Motivo;
                txtSituacao.Text = viagens.Situacao;

            }
            
        }

        private void btnUltViagens_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelControl.Controls.Remove(frm1.userControlViagem);
            if (frm1.panelControl.Controls.Contains(frm1.userControlListViagens))
            {
                frm1.userControlListViagens.BringToFront();
            }
            else
            {
                frm1.panelControl.Controls.Add(frm1.userControlListViagens);
                frm1.userControlListViagens.BringToFront();
            }
        }

        private void txtData_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtDataViagemFeita_KeyUp(object sender, KeyEventArgs e)
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

        private void txtNomeMotorista_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtPlacaVeiculo_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtMotivo_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtSituacao_TextChanged(object sender, EventArgs e)
        {
            //btnSalvarAlt.Enabled = true;
        }

        private void btnSalvarAlt_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            BLL bll = new BLL();
            Viagens viagens = new Viagens();
            Motorista motorista = new Motorista();
            Veiculos veiculos = new Veiculos();
            viagens.Motorista = motorista;
            viagens.Veiculos = veiculos;
            viagens.dateViagem = Convert.ToDateTime(txtData.Text);
            if(txtDataViagemFeita.Text == txtDataViagemFeita.Text)
            {

            }
            else
            {
                viagens.dateViagemFeita = Convert.ToDateTime(txtDataViagemFeita.Text);
            }
            
            viagens.KmInicial = txtKmInicial.Text;
            viagens.KmFinal = txtKmFinal.Text;
            viagens.Motorista.Nome = txtNomeMotorista.Text;
            viagens.Veiculos.Placa = txtPlacaVeiculo.Text;
            viagens.Motivo = txtMotivo.Text;
            viagens.Situacao = txtSituacao.Text;
            viagens.ID = id;
            bll.UpdateViagem(viagens);
            MessageBox.Show("Alterações feitas com sucesso.");
            btnSalvarAlt.Enabled = false;
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            Viagens viagens = new Viagens();
            Motorista motorista = new Motorista();
            Veiculos veiculos = new Veiculos();
            viagens.Motorista = motorista;
            viagens.Veiculos = veiculos;
            viagens.ID = id;
            if (MessageBox.Show("Todos os dados sobre essa viagem serão perdidos", "Excluir viagem?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bll.DeleteViagem(viagens);
                Form1 frm1 = (Form1)Application.OpenForms["Form1"];
                List<Viagens> list = new List<Viagens>();

                frm1.userControlListViagens.materialListView1.Items.Clear();
                list = bll.listaViagens("Todos","","","","","");

                foreach (var item in list)
                {
                    frm1.userControlListViagens.materialListView1.Items.Add(new ListViewItem(new string[] { item.Veiculos.Placa, item.Motorista.Nome, item.dateViagem.ToShortDateString(), item.Situacao, item.ID.ToString() }));
                }
                frm1.userControlListViagens.materialListView1.Refresh();
                frm1.panelControl.Controls.Remove(frm1.userControlViagem);
                if (frm1.panelControl.Controls.Contains(frm1.userControlListViagens))
                {
                    frm1.userControlListViagens.BringToFront();
                }
                else
                {
                    frm1.panelControl.Controls.Add(frm1.userControlListViagens);
                    frm1.userControlListViagens.BringToFront();
                }
                
            }
            else
            {

            }
        }

        private void btnProcurarByPlaca_Click(object sender, EventArgs e)
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

        private void txtSituacao_TextUpdate(object sender, EventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void btnNewViagem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelControl.Controls.Add(frm1.userControlCadastroViagens);
            frm1.userControlCadastroViagens.BringToFront();
        }
    }
}
