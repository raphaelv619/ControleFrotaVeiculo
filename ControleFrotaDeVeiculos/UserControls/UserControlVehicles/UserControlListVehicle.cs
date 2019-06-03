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

namespace ControleFrotaDeVeiculos.UserControlVehicles
{
    public partial class UserControlListVehicle : UserControl
    {
        
       
        public bool cadastroPelaList = false;


        public UserControlListVehicle()
        {
            InitializeComponent();
            
        }

        private void txtSearchPlaca_Click(object sender, EventArgs e)
        {

        }

        private void btnProcurarByPlaca_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            Veiculos veiculos = new Veiculos();
            veiculos = bll.ListaVeiculosPorPlaca(txtSearchPlaca.Text);
            if (veiculos.Placa == txtSearchPlaca.Text)
            {
                Form1 frm1 = (Form1)Application.OpenForms["Form1"];
                frm1.panelControl.Controls.Remove(frm1.userControlListVehicle);
                frm1.panelControl.Controls.Add(frm1.userControlVehicle);
                frm1.userControlVehicle.txtPlaca.Text = veiculos.Placa;
               
                frm1.userControlVehicle.BringToFront();
                txtSearchPlaca.Text = "";
            }
            else
            {
                MessageBox.Show("Veículo não encontrado.");
            }
            
        }

        private void materialListView1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void UserControlListVehicle_Load(object sender, EventArgs e)
        {
            materialListView1.Refresh();
            BLL bll = new BLL();
            List<Veiculos> list = new List<Veiculos>();
            list = bll.listaUltVeiculos();
            
            foreach (var item in list)
            {
                materialListView1.Items.Add(new ListViewItem(new string[] { item.Placa, item.Marca, item.Modelo, item.Cor }));
            }

            txtSearchPlaca.AutoCompleteCustomSource = bll.AutoCompletarPlaca();
        }

        private void btnUltVeiculos_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            List<Veiculos> list = new List<Veiculos>();
            
            materialListView1.Items.Clear();

            if(btnUltVeiculos.Text == "Últimos veículos cadastrados")
            {
                list = bll.listaUltVeiculos();
                foreach (var item in list)
                {
                    materialListView1.Items.Add(new ListViewItem(new string[] { item.Placa, item.Marca, item.Modelo, item.Cor }));
                }
                materialListView1.Refresh();
                materialListView1.Scrollable = false;
                labelList.Text = "Últimos veículos cadastrados";
                btnUltVeiculos.Text = "Todos os veículos";
            } else
            {
                list = bll.listaAllVeiculos();
                foreach (var item in list)
                {
                    materialListView1.Items.Add(new ListViewItem(new string[] { item.Placa, item.Marca, item.Modelo, item.Cor }));
                }
                materialListView1.Refresh();
                materialListView1.Scrollable = true;
                labelList.Text = "Todos os veículos";
                btnUltVeiculos.Text = "Últimos veículos cadastrados";
            }
            
        }

        private void btnNewVehicle_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelControl.Controls.Add(frm1.userControlCadastroVehicle);
            frm1.userControlCadastroVehicle.BringToFront();           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelList_Click(object sender, EventArgs e)
        {

        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialListView1_MouseClick(object sender, MouseEventArgs e)
        {
            String placa = materialListView1.SelectedItems[0].SubItems[0].Text;
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.panelControl.Controls.Remove(frm1.userControlListVehicle);
            frm1.panelControl.Controls.Add(frm1.userControlVehicle);
            frm1.userControlVehicle.txtPlaca.Text = placa;
            frm1.userControlVehicle.BringToFront();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
