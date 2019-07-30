using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação de um objeto p, do tipo da classe Pessoa
            Pessoa p = new Pessoa();

            //Exibindo na tela informações do objeto p,
            //realizando uma chamada do método ToString
            Console.WriteLine(p.ToString());

            //Atribuindo um nome ao objeto p, por meio da
            //propriedade Nome
            p.Nome = "Aruto Hiden";

            //Exibindo na tela informações do objeto p,
            //após a atribuição do nome
            Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}
