using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exemplo_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando as variáveis
            int idade = 25;
            string nome = "Tomari Shinnosuke";
            bool temFilhos = false;
            double altura = 1.79;

            //Criando o arquivo
            FileStream stream = new FileStream(@"..\..\..\..\Teste\Exemplo4.bin", FileMode.Create);

            //Instanciando a variável do tipo BinaryWriter
            BinaryWriter writer = new BinaryWriter(stream);

            //Usando o método Write para escrever no arquivo.
            writer.Write(idade);
            writer.Write(nome);
            writer.Write(temFilhos);
            writer.Write(altura);

            writer.Flush();
            writer.Close();
        }
    }
}
