using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[3, 4];

            numeros = botColocaNumero(numeros);

            mostraMediaMatriz(numeros);

            Console.ReadKey();
        }
        static int[,] botColocaNumero(int[,] retornaNumero)
        {
            int razao = 4, cont = 0;
            for (int i = 0; i < retornaNumero.GetLength(0); i++)
            {
                for (int j = 0; j < retornaNumero.GetLength(1); j++)
                {
                    cont++;
                    retornaNumero[i, j] = cont * razao;
                }
            }

            return retornaNumero;
        }
        static void mostraMediaMatriz(int[,] numero)
        {
            int media = somaValoresMatriz(numero) / numero.Length;

            Console.WriteLine("A média da soma de todos os números do vetor é: {0}", media);
        }
        static int somaValoresMatriz(int[,] numero)
        {
            int somaTotal = 0;
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int j = 0; j < numero.GetLength(1); j++)
                {
                    somaTotal += numero[i, j];
                }
            }
            return somaTotal;
        }
    }
}
