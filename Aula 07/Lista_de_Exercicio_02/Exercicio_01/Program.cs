using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];

            numeros = colocaNumero(numeros);

            mostraVetor(numeros);

            numeros = multiplicaNumero(numeros);

            mostraVetor(numeros);
        }
        static int[] colocaNumero(int[] retornaNumero)
        {
            int razao;

            Console.Clear();
            Console.Write("Escolha a razão dos números do vetor: ");
            razao = int.Parse(Console.ReadLine());

            for(int i = 0; i<retornaNumero.Length; i++)
            {
                retornaNumero[i] = i * razao;
            }

            return retornaNumero;
        }
        static void mostraVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }
            Console.Write("Clique para continuar");
            Console.ReadKey();
        }
        static int[] multiplicaNumero(int[] retornaNumero)
        {
            int multiplicador;

            Console.Clear();
            Console.Write("Escolha o multiplicador dos números do vetor: ");
            multiplicador = int.Parse(Console.ReadLine());

            for (int i = 0; i < retornaNumero.Length; i++)
            {
                retornaNumero[i] *= multiplicador;
            }

            return retornaNumero;
        }
    }
}
