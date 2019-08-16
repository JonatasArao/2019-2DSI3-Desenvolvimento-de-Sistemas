using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Pessoa
    {
        private string nome;
        private string endereco;
        private int telefone;
        private int idade;
        private double altura;

        public Pessoa()
        {
            this.nome = null;
            this.endereco = null;
            this.telefone = 0;
            this.idade = 0;
            this.altura = 0;
        }
        public Pessoa(string nome, string endereco,int telefone,int idade, double altura)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
            this.idade = idade;
            this.altura = altura;
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public int Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public override string ToString()
        {
            return (String.Format("Dados da Pessoa\n\nNome: {0}\nEndereço: {1}\nTelefone: ({2}) {3}-{4}\nIdade: {5}\nAltura: {6}m",
                                    nome, endereco, telefone.ToString().Substring(0, 2), telefone.ToString().Substring(2, 4),
                                    telefone.ToString().Substring(4, 4), idade, altura));
        }
    }
}
