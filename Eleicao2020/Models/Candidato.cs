using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eleicao2020.Views;

namespace Eleicao2020.Models
{
    class Candidato
    {
        private string nome;

        public string Nome
        {
            get 
            { 
                return nome; 
            }
            set 
            {
                if(value.Length >= 3)
                {
                    nome = value; 
                }
                else
                {
                    throw new Exception("O nome precisa ter ao menos 3 letras!");
                }
            }
        }

        private int numero;

        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    numero = value;
                }
                else
                {
                    throw new Exception("O numero precisa ser entre 1 e 99!");
                }
            }
        }
        public string partido { get; set; }
        public int qtvotos { get; set; }

        public override string ToString()
        {
            return $"{Numero} - {Nome}";
        }

    }
}
