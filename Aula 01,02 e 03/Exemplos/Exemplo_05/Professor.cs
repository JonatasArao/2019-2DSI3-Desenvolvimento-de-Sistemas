using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_05
{
    class Professor : Pessoa
    {
        private string titulacao;
        private double ch;

        public Professor()
            : base()
        {
            titulacao = null;
            ch = 0;
        }
        public Professor(string nome, int idade, double altura, char sexo, string titulacao, double ch)
            : base(nome, idade, altura, sexo)
        {
            this.titulacao = titulacao;
            this.ch = ch;
        }
        public string Titulacao
        {
            get { return titulacao; }
            set { titulacao = value; }
        }
        public double Ch
        {
            get { return ch; }
            set { ch = value; }
        }
        public override string ToString()
        {
            return String.Format("{0} Titulação: {1} \n Carga Horária Semanal: {2}",
                                    base.ToString(), titulacao, ch);
        }
    }
}
