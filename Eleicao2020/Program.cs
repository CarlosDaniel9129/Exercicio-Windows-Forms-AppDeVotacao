using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eleicao2020.Models;
using Eleicao2020.Views;

namespace Eleicao2020
{
    static class Program
    {
        /*fazemos da classe Candidato uma lista*/
        public static List<Candidato> candidatos = new List<Candidato>(); /*salva os candidatos*/ /*global pois queremos usar em outras telas*/
            
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
