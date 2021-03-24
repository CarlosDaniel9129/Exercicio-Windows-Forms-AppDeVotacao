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

namespace Eleicao2020.Views
{
    public partial class Cadastro : Form
    {
        string[] partidos = { "---", "Patriota", "Novo", "PT" }; /*vetor para preencher a comboBox1*/

        public Cadastro()
        {
            InitializeComponent();
            btn_salvar.Click += salvar;
            cmb_partido.DataSource = partidos;  /*preencho a comboBox1*/ /*pego de uma fonte de dados, no caso o vetor*/
            btn_voltar.Click += voltarAbertura;
        }

            /*Ou ! partidoLista*/
            /*para adicionar itens na Lista*/

            /*      partidoLista.Add("PT"); 
                    partidoLista.Add("Saitama");
            */
                           /*!!!!*/
       
        private void salvar(object sender, EventArgs e)
        {
            try
            {


                /*cria um objeto, e definimos suas caracteristicas*/
                /*usa a classe candidato e o construtor padrão e adiciona os elementos direto aqui*/
                Candidato candidato = new Candidato()
                {
                    Nome = txt_nome.Text,               /*salva nome*/
                    Numero = int.Parse(txt_numero.Text),  /*salva numero*/ /*passa o texto da texBox2 para inteiro*/
                    partido = cmb_partido.SelectedItem.ToString(),   /*salva o partido selc*/ /*SelectedItem, retora um objeto, por isso tostring*/
                    qtvotos = 0
                    /*se fosse para salvar  objeto, seria partido = (Time) comboBox1.SelectedItem; Onde so identifico qual objeto eu quero*/
                };    
                    Program.candidatos.Add(candidato); /*ax'diciono o cada novo candidato na lista da classe Program*/
                    MessageBox.Show("Salvo com sucesso");

                    carregaCandidatos();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar salvar. {ex.Message}");
            }
  
        }

        private void carregaCandidatos()
        {
            CadastroCandidato.DataSource = null; /*limpa os dados*/
            CadastroCandidato.DataSource = Program.candidatos; /*adiciono com o data Source na dataGridView1*/
        }

        private void voltarAbertura(object sender, EventArgs e)
        {
            new Abertura().Show();
            Visible = false;
        }
    }
}
