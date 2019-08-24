using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exemplo_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando a variavel stream
            FileStream stream =
                new FileStream(@"..\..\..\..\Teste\Exemplo4.bin", FileMode.Open);

            //Instanciando a variável do tipo BinaryReader
            BinaryReader reader = new BinaryReader(stream);

            //Variáveis recebendo os valores lidos pelo arquivo binário
            int idade = reader.ReadInt32();
            string nome = reader.ReadString();
            bool temFilhos = reader.ReadBoolean();
            double altura = reader.ReadDouble();

            //Fecha o acesso com o arquivo
            reader.Close();

            //Exibe o resultado
            Console.WriteLine("Idade: {0}", Convert.ToString(idade));
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Tem filhos: {0}", Convert.ToString(temFilhos));
            Console.WriteLine("Altura: {0}", Convert.ToString(altura));
            Console.ReadKey();
        }
    }
}
