using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_07
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite um número: ");

                int numero = Convert.ToInt32(Console.ReadLine());

                int resultado = 100 / numero;

                Console.WriteLine("Resultado de 100 / {0} = {1}", numero, resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato de número inválido!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("O número não pode ser zero!");
            }
            catch (Exception e)
            { //exceção para caso ocorrer qualquer outro tipo de erro
                Console.WriteLine("Erro: {0}", e.Message);
            }

            Console.ReadKey();
        }
    }
}
