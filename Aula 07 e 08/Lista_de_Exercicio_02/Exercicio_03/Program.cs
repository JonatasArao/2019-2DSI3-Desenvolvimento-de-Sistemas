using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Tsukasa Kadoya", "Hikari Studio, 2009", 1334992009, 99, 1.75);

            Console.WriteLine(pessoa.ToString());

            Console.ReadKey();
        }
    }
}
