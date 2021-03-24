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
    public partial class Resultado : Form
    {
        public Resultado()
        {
            InitializeComponent();
            carregaResultados();
            btn_voltar.Click += voltar;
        }

        private void voltar(object sender, EventArgs e)
        {
            new Abertura().Show();
            Visible = false;
        }

        private void carregaResultados()
        {
            int linha = 0;

            /*para cada candidato eu jogo na var candidato*/
            Program.candidatos.ForEach(novoCandidato =>
                {
                    /*para ir para proxima linha*/
                

                    Label nomeCandidato = new Label();
                    nomeCandidato.Text = novoCandidato.Nome;/*coluna e linha*/ 
                    tbl_Candidato.Controls.Add(nomeCandidato, 0, linha);
               

                    Label qtdeVotos = new Label();
                    qtdeVotos.Text = novoCandidato.qtvotos.ToString();
                    tbl_Candidato.Controls.Add(qtdeVotos, 1, linha);

                    linha++;
                    
                });
        }

    }
}
