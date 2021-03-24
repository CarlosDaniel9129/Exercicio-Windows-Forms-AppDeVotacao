using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eleicao2020.Models;
using Eleicao2020.Views;


namespace Eleicao2020.Views
{
    public partial class Votacao : Form
    {
        public Votacao()
        {
            InitializeComponent();
            carregaCandidatos();
            btn_votar.Click += votar;
            btn_voltar.Click += voltar;
        }

        private void voltar(object sender, EventArgs e)
        {
            new Abertura().Show();
            Visible = false;
        }

        private void votar(object sender, EventArgs e)
        {
            /*pega da comboBox1, ele retorna um objeto, tem de converter*/
            Candidato selecionado = (Candidato)cmb_Candidato.SelectedItem;
            selecionado.qtvotos ++;

            MessageBox.Show("Voto Salvo com Sucesso");
        }

        private void carregaCandidatos()
        {
            /*carrega com os itens salvo na lista da classe Program*/
            cmb_Candidato.DataSource = Program.candidatos;
        }
    }
}
