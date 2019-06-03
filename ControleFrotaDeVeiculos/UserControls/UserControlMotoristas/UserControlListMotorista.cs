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
    public partial class UserControlListMotorista : UserControl
    {
        public UserControlListMotorista()
        {
            InitializeComponent();
        }

        private void btnProcurarByPlaca_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            Motorista motorista = new Motorista();
            motorista = bll.ListaMotoristaPorNome(txtSearchNome.Text);
            if(motorista.Nome == txtSearchNome.Text)
            {
                Form1 frm1 = (Form1)Application.OpenForms["Form1"];
                frm1.panelControl.Controls.Remove(frm1.userControlListMotorista);
                frm1.panelControl.Controls.Add(frm1.userControlMotorista);
                frm1.userControlMotorista.txtNome.Text = motorista.Nome;
                frm1.userControlMotorista.BringToFront();
                txtSearchNome.Text = "";
            }
            else
            {
                MessageBox.Show("Motorista não encontrado");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnUltVeiculos_Click(object sender, EventArgs e)
        {
            
            BLL bll = new BLL();
            List<Motorista> list = new List<Motorista>();

            materialListView1.Items.Clear();

            if(btnUltVeiculos.Text == "Últimos motoristas cadastrados")
            {
                list = bll.listaUltMotoristas();
                foreach (var item in list)
                {
                    materialListView1.Items.Add(new ListViewItem(new string[] { item.Nome, item.CPF, item.NCNH, item.ValCNH }));
                }
                materialListView1.Refresh();
                materialListView1.Scrollable = false;
                labelList.Text = "Últimos motoristas cadastrados";
                btnUltVeiculos.Text = "Todos os motoristas";

            } else
            {
                list = bll.listaTodosMotoristas();
                foreach (var item in list)
                {
                    materialListView1.Items.Add(new ListViewItem(new string[] { item.Nome, item.CPF, item.NCNH, item.ValCNH }));
                }
                materialListView1.Refresh();
                materialListView1.Scrollable = true;
                labelList.Text = "Todos os motoristas";
                btnUltVeiculos.Text = "Últimos motoristas cadastrados";
            }
        }

        private void UserControlListMotorista_Load(object sender, EventArgs e)
        {
                materialListView1.Refresh();
                BLL bll = new BLL();
                List<Motorista> list = new List<Motorista>();
                list = bll.listaUltMotoristas();

                foreach (var item in list)
                {
                    materialListView1.Items.Add(new ListViewItem(new string[] { item.Nome, item.CPF, item.NCNH, item.ValCNH }));
                }

            
            txtSearchNome.AutoCompleteCustomSource = bll.AutoCompletarNome();
        }
               
        

        private void materialListView1_MouseClick(object sender, MouseEventArgs e)
        {
            String nome = materialListView1.SelectedItems[0].SubItems[0].Text;
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelControl.Controls.Remove(frm1.userControlListMotorista);
            frm1.panelControl.Controls.Add(frm1.userControlMotorista);
            frm1.userControlMotorista.txtNome.Text = nome;
            frm1.userControlMotorista.BringToFront();
        }

        private void btnNewVehicle_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelControl.Controls.Add(frm1.userControlCadastroMotorista);
            frm1.userControlCadastroMotorista.BringToFront();
        }
    }
}
