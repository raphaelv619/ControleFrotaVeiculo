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
using ControleFrotaDeVeiculos.UserControlMotoristas;

namespace ControleFrotaDeVeiculos
{
    public partial class UserControlMotorista : UserControl
    {
        Motorista motorista = new Motorista();
        public UserControlMotorista()
        {
            InitializeComponent();
        }

        private void btnNewVehicle_Click(object sender, EventArgs e)
        {
            if (btnSalvarAlt.Enabled == true)
            {
                if (MessageBox.Show("Deseja salvar?", "É possível que alterações feitas sejam perdidas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Salvar();
                }
            }
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelControl.Controls.Add(frm1.userControlCadastroMotorista);
            frm1.userControlCadastroMotorista.BringToFront();
        }

        private void btnProcurarByPlaca_Click(object sender, EventArgs e)
        {
            if (btnSalvarAlt.Enabled == true)
            {
                if (MessageBox.Show("Deseja salvar?", "É possível que alterações feitas sejam perdidas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Salvar();
                }
            }
            BLL bll = new BLL();
            Motorista motorista = new Motorista();
            motorista = bll.ListaMotoristaPorNome(txtSearchNome.Text);
            if (motorista.Nome == txtSearchNome.Text)
            {
                txtNome.Text = motorista.Nome;
                txtDtNasc.Text = motorista.DtNascimento;
                txtRG.Text = motorista.RG;
                txtCPF.Text = motorista.CPF;
                txtCNH.Text = motorista.NCNH;
                txtValCNH.Text = motorista.ValCNH;
                txtRua.Text = motorista.Rua;
                txtCidade.Text = motorista.Cidade;
                txtBairro.Text = motorista.Bairro;
                txtNumero.Text = motorista.Numero;
                txtCEP.Text = motorista.CEP;
                txtTelRes.Text = motorista.Telefone;
                txtTelCel.Text = motorista.Celular;
                txtSearchNome.Text = "";
            } else
            {
                MessageBox.Show("Morotista não encontrado.");
            }
        }

        private void panelUserControlMotorista_Paint(object sender, PaintEventArgs e)
        {
            BLL bll = new BLL();


            listViagens.Items.Clear();
            List<Viagens> list = new List<Viagens>();
            list = bll.listaViagens("Mot","", "", "", txtNome.Text, "");
            foreach (var item in list)
            {
                listViagens.Items.Add(new ListViewItem(new string[] { item.Veiculos.Placa, item.dateViagem.ToShortDateString(), item.Situacao, item.ID.ToString() }));
            }
            listViagens.Refresh();


            listEntradaSaida.Items.Clear();
            List<EntradaSaida> listEntradasSaida = new List<EntradaSaida>();
            listEntradasSaida = bll.listaEntradaSaida("Mot", "", "", "", txtNome.Text, "");
            foreach (var item in listEntradasSaida)
            {
                listEntradaSaida.Items.Add(new ListViewItem(new string[] { item.Veiculos.Placa, item.Data.ToShortDateString(), item.HrSaida.ToString(), item.HrEntrada.ToString(), item.ID.ToString() }));
            }
            listEntradaSaida.Refresh();





            if (txtNome.Text != "")
            {

                //BLL bll = new BLL();
                motorista = bll.ListaMotoristaPorNome(txtNome.Text);
                txtNome.Text = motorista.Nome;
                txtRG.Text = motorista.RG;
                txtCPF.Text = motorista.CPF;
                txtDtNasc.Text = motorista.DtNascimento;
                txtCNH.Text = motorista.NCNH;
                txtValCNH.Text = motorista.ValCNH;
                txtRua.Text = motorista.Rua;
                txtCidade.Text = motorista.Cidade;
                txtBairro.Text = motorista.Bairro;
                txtNumero.Text = motorista.Numero;
                txtCEP.Text = motorista.CEP;
                txtTelRes.Text = motorista.Telefone;
                txtTelCel.Text = motorista.Celular;
            }
        }

        private void UserControlMotorista_Load(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            txtSearchNome.AutoCompleteCustomSource = bll.AutoCompletarNome();
        }

        private void btnUltVeiculos_Click(object sender, EventArgs e)
        {
            if(btnSalvarAlt.Enabled == true)
            {
                if(MessageBox.Show("Deseja salvar?", "É possível que alterações feitas sejam perdidas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Salvar();
                }
            }
            BLL bll = new BLL();
            List<Motorista> list = new List<Motorista>();
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.userControlListMotorista.materialListView1.Items.Clear();
            list = bll.listaUltMotoristas();
            foreach (var item in list)
            {
                frm1.userControlListMotorista.materialListView1.Items.Add(new ListViewItem(new string[] { item.Nome, item.CPF, item.NCNH, item.ValCNH }));
            }
            frm1.userControlListMotorista.materialListView1.Refresh();
            frm1.panelControl.Controls.Remove(frm1.userControlMotorista);
            frm1.panelControl.Controls.Add(frm1.userControlListMotorista);
            frm1.userControlListMotorista.BringToFront();
        }

        private void txtSearchNome_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarAlt_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtDtNasc_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtValCNH_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtRua_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtCidade_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtBairro_Click(object sender, EventArgs e)
        {

        }

        private void txtBairro_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtNumero_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtCEP_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtTelRes_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void txtTelCel_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvarAlt.Enabled = true;
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            Motorista motorista = new Motorista();
            motorista.CPF = txtCPF.Text;
            if (MessageBox.Show("Todos os dados sobre esse motorista serão perdidos", "Excluir motorista?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bll.DeleteMotorista(motorista);
                Form1 frm1 = (Form1)Application.OpenForms["Form1"];
                List<Motorista> list = new List<Motorista>();

                frm1.userControlListMotorista.materialListView1.Items.Clear();
                list = bll.listaUltMotoristas();

                foreach (var item in list)
                {
                    frm1.userControlListMotorista.materialListView1.Items.Add(new ListViewItem(new string[] { item.Nome, item.CPF, item.NCNH, item.ValCNH }));
                }
                frm1.userControlListMotorista.materialListView1.Refresh();
                frm1.userControlListMotorista.materialListView1.Scrollable = false;
                frm1.panelControl.Controls.Remove(frm1.userControlMotorista);
                frm1.panelControl.Controls.Add(frm1.userControlListMotorista);
                frm1.userControlListMotorista.BringToFront();
            }
            else
            {

            }
        }
        private void Salvar()
        {
            BLL bll = new BLL();
            Motorista motorista = new Motorista();
            motorista.Nome = txtNome.Text;
            motorista.DtNascimento = txtDtNasc.Text;
            motorista.CPF = txtCPF.Text;
            motorista.RG = txtRG.Text;
            motorista.NCNH = txtCNH.Text;
            motorista.ValCNH = txtValCNH.Text;
            motorista.Rua = txtRua.Text;
            motorista.Cidade = txtCidade.Text;
            motorista.Bairro = txtBairro.Text;
            motorista.Numero = txtNumero.Text;
            motorista.CEP = txtCEP.Text;
            motorista.Telefone = txtTelRes.Text;
            motorista.Celular = txtTelCel.Text;
            bll.UpdateMotorista(motorista);
            MessageBox.Show("Alterações feitas com sucesso");
            btnSalvarAlt.Enabled = false;

            List<Motorista> list = new List<Motorista>();
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.userControlListMotorista.materialListView1.Items.Clear();
            list = bll.listaUltMotoristas();
            foreach (var item in list)
            {
                frm1.userControlListMotorista.materialListView1.Items.Add(new ListViewItem(new string[] { item.Nome, item.CPF, item.NCNH, item.ValCNH }));
            }
            frm1.userControlListMotorista.materialListView1.Refresh();
        }

        private void btnCadViagem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelControl.Controls.Add(frm1.userControlCadastroViagens);
            frm1.userControlCadastroViagens.BringToFront();
            frm1.userControlCadastroViagens.byMot = true;
            frm1.userControlCadastroViagens.txtNomeMotorista.Text = txtNome.Text;
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

        private void btnCadEntradaSaida_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelControl.Controls.Add(frm1.userControlCadastroEntradaSaida);
            frm1.userControlCadastroEntradaSaida.BringToFront();
            frm1.userControlCadastroEntradaSaida.byMot = true;
            frm1.userControlCadastroEntradaSaida.txtNomeMotorista.Text = txtNome.Text;
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
    }
}
