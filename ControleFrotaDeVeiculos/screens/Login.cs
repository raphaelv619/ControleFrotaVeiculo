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

namespace ControleFrotaDeVeiculos
{
    public partial class Login : MetroForm
    {
        private string checkeds = "";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            UltimoAdm ultimoAdm = new UltimoAdm();
            ultimoAdm = bll.ListaUltAdmState();
            if(ultimoAdm.CheckedS == "Y")
            {           
                txtLogin.Text = ultimoAdm.Login;
                txtSenha.Text = ultimoAdm.Password;
                checkRemember.Checked = true;
            }
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Adm adm = new Adm();
            BLL bll = new BLL();
            adm = bll.ListaUserPorLogin(txtLogin.Text);          
            if (adm.Login ==  txtLogin.Text && adm.Password == txtSenha.Text)
            {
                if (checkRemember.Checked)
                {
                    UltimoAdm ultimoAdm = new UltimoAdm();
                    ultimoAdm.Login = adm.Login;
                    ultimoAdm.Password = adm.Password;
                    ultimoAdm.CheckedS = "Y";
                    bll.novoUltAdm(ultimoAdm);
                } else
                {
                    MessageBox.Show("test");
                }
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();

            }
            else
            {
                MessageBox.Show("Login ou senha incorretos");
            }
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
