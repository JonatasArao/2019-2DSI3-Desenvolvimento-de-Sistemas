using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_01
{
    class Pessoa
    {
        //Atrubuto da classe
        private string nome;

        //Construtor sem parâmetros
        public Pessoa()
        {
            this.nome = null;
        }
        //Contrutor com parâmetros
        public Pessoa(string nome)
        {
            this.nome = nome;
        }
        //propriedade do campo nome para acesso ao seu conteúdo
        public string Nome
        {
            get { return nome; } //retornar o valor armazenado em um campo
            set { nome = value; } //Armazena o valor no campo
        }
        //Método que retorna uma string contendo as informações da pessoa
        public override string ToString()
        {
            return (String.Format("Nome: {0}", nome));
        }
    }
}
