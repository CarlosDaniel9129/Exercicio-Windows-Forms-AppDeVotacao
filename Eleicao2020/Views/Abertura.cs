using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eleicao2020.Views
{
    public partial class Abertura : Form
    {
        public Abertura()
        {
            InitializeComponent();
            btn_cadastro.Click += abrirCadastro;
            btn_iniciarVoto.Click += abrirVotacao;
            btn_resultado.Click += abrirResultado;
        }

        private void abrirResultado(object sender, EventArgs e)
        {
            new Resultado().Show();
            Visible = false;
        }

        private void abrirVotacao(object sender, EventArgs e)
        {
            new Votacao().Show();
            Visible = false;
        }

        private void abrirCadastro(object sender, EventArgs e)
        {
            new Cadastro().Show();
            Visible = false;
        }
    }
    
}
