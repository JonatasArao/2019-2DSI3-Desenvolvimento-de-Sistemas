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

            mostraMenorNumeroMatriz(numeros);

            mostraMaiorNumeroMatriz(numeros);

            mostraMediaMatriz(numeros);

            Console.ReadKey();
        }
        static int[,] botColocaNumero(int[,] retornaNumero)
        {
            Random numAleatorio = new Random();
            for (int i = 0; i < retornaNumero.GetLength(0); i++)
            {
                for (int j = 0; j < retornaNumero.GetLength(1); j++)
                {
                    retornaNumero[i, j] = numAleatorio.Next(0, 50);
                }
            }

            return retornaNumero;
        }
        static void mostraMenorNumeroMatriz(int[,] numero)
        {
            int menorValor = numero[0, 0];
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int j = 0; j < numero.GetLength(1); j++)
                {
                    if (numero[i, j] < menorValor)
                    {
                        menorValor = numero[i, j];
                    }
                }
            }

            Console.WriteLine("O menor valor da matriz é: {0}", menorValor);
        }
        static void mostraMaiorNumeroMatriz(int[,] numero)
        {
            int maiorValor = numero[0,0];
            for(int i = 0; i < numero.GetLength(0); i++)
            {
                for(int j = 0; j < numero.GetLength(1); j++)
                {
                    if(numero[i, j] > maiorValor)
                    {
                        maiorValor = numero[i, j];
                    }
                }
            }

            Console.WriteLine("O maior valor da matriz é: {0}", maiorValor);
        }
        static void mostraMediaMatriz(int[,] numero)
        {
            int media = somaValoresMatriz(numero) / numero.Length;

            Console.WriteLine("A média de todos os números da matriz é: {0}", media);
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
