using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exemplo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instrução para a criação do diretório Teste
            Directory.CreateDirectory(@"..\..\..\..\Teste\");

            //Cria um objeto para manipular a escrita no arquivo
            StreamWriter wr = new StreamWriter(@"..\..\..\..\Teste\Exemplo1.txt", true);
            wr.WriteLine("Primeira Linha");
            wr.WriteLine("Segunda Linha");
            wr.Close();

            //Cria um objeto para manipular a leitura do arquivo
            StreamReader rd = new StreamReader(@"..\..\..\..\Teste\Exemplo1.txt");
            while (!rd.EndOfStream)
            {
                string linha = rd.ReadLine();
                Console.WriteLine(linha);
            }
            rd.Close();

            Console.ReadKey();
        }
    }
}
