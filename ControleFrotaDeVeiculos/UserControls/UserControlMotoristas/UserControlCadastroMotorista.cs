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

namespace ControleFrotaDeVeiculos.UserControlMotoristas
{
    public partial class UserControlCadastroMotorista : UserControl
    {
        public Boolean list = false;
        public UserControlCadastroMotorista()
        {
            InitializeComponent();
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelCadMot_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelControl.Controls.Remove(frm1.userControlCadastroMotorista);
            if (frm1.panelControl.Controls.Contains(frm1.userControlListMotorista))
            {
                frm1.userControlListMotorista.BringToFront();
            }
            else if (frm1.panelControl.Controls.Contains(frm1.userControlMotorista))
            {
                frm1.userControlMotorista.BringToFront();
            }

        }

        private void btnCadastrarMot_Click(object sender, EventArgs e)
        {
            Motorista motorista = new Motorista();
            BLL bll = new BLL();
            motorista = bll.ListaMotoristaPorCPF(txtCPF.Text);
            if(txtCPF.Text == motorista.CPF)
            {
                MessageBox.Show("Motorista já cadastrado.");
            } else
            {
                if(txtNome.Text == "" || txtCPF.Text == "" || txtCNH.Text == "" || txtValCNH.Text == "" || txtCEP.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios");
                }
                else
                {
                    motorista.Nome = txtNome.Text;
                    motorista.DtNascimento = txtDtNasc.Text;
                    motorista.RG = txtRG.Text;
                    motorista.CPF = txtCPF.Text;
                    motorista.NCNH = txtCNH.Text;
                    motorista.ValCNH = txtValCNH.Text;
                    motorista.Rua = txtRua.Text;
                    motorista.Cidade = txtCidade.Text;
                    motorista.Bairro = txtBairro.Text;
                    motorista.Numero = txtNumero.Text;
                    motorista.CEP = txtCEP.Text;
                    motorista.Telefone = txtTelRes.Text;
                    motorista.Celular = txtTelCel.Text;
                    bll.novoMotorista(motorista);
                    MessageBox.Show("Motorista cadastrado com sucesso!");

                    Form1 frm1 = (Form1)Application.OpenForms["Form1"];
                    frm1.panelControl.Controls.Remove(frm1.userControlCadastroMotorista);
                    frm1.userControlMotorista.txtNome.Text = motorista.Nome;
                    txtNome.Text = "";
                    txtDtNasc.Text = "";
                    txtRG.Text = "";
                    txtCPF.Text = "";
                    txtCNH.Text = "";
                    txtValCNH.Text = "";
                    txtRua.Text = "";
                    txtCidade.Text = "";
                    txtBairro.Text = "";
                    txtNumero.Text = "";
                    txtCEP.Text = "";
                    txtTelRes.Text = "";
                    txtTelCel.Text = "";
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
                
                panel1.Controls.Clear();
                UserControlMotorista userControlMotorista = new UserControlMotorista();
                userControlMotorista.txtCPF.Text = motorista.CPF;
                panel1.Controls.Add(userControlMotorista);

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
