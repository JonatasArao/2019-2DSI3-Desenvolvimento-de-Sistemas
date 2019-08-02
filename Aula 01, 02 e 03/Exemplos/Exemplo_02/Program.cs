using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação de um objeto p, do tipo da classe Pessoa
            Pessoa p = new Pessoa("Sougo Tokiwa");

            //Exibindo na tela informações do objeto p,
            //realizando uma chamada do método ToString
            Console.WriteLine(p.ToString());

            Console.ReadKey();
        }
    }
}
