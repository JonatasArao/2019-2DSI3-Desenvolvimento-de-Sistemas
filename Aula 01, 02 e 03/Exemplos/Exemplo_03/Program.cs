using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados usando variáveis auxiliares
            Console.Write("Digite o nome da pessoa: "); string n = Console.ReadLine();
            Console.Write("Digite a idade de {0}: ", n); int i = int.Parse(Console.ReadLine());
            Console.Write("Digite a altura de {0}: ", n); double a = double.Parse(Console.ReadLine());
            Console.Write("Digita a letra correspondente ao sexo (F/M): ");
            char s = char.Parse(Console.ReadLine());

            //Criando um objeto, usando o construtor com parâmetros
            Pessoa pessoa = new Pessoa(n, i, a, s);

            //Exibindo os dados da pessoa cadastrada
            Console.WriteLine("\n\n*** Dados da Pessoa ***\n");
            Console.WriteLine(pessoa.ToString());

            //Exibindo o resultado do calculo do peso ideal
            Console.WriteLine(" Peso Ideal: {0}", pessoa.calcularPesoIdeal());

            Console.ReadKey();
        }
    }
}
