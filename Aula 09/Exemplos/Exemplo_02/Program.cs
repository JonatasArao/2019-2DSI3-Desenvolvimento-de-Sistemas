using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exemplo_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primeiro devemos escolher o nome do arquivo e onde iremos cria-lo
            String nome_arquivo = @"..\..\..\..\Teste\Exemplo2.txt";

            //Depois devemos verificar se o arquivo existe, se não existir então criamos o arquivo
            if (!System.IO.File.Exists(nome_arquivo))
                System.IO.File.Create(nome_arquivo).Close();

            //Agora usamos a classe TextWriter para escrever no arquivo
            System.IO.TextWriter arquivo = System.IO.File.AppendText(nome_arquivo);
            arquivo.WriteLine("Escrevendo no arquivo");

            //Fechamos o arquivo
            arquivo.Close();
        }
    }
}
