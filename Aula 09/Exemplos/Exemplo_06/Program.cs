using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exemplo_06
{
    class Program
    {
        public struct Pessoa
        {
            public String nome;
            public int idade;
            public double altura;
        }
        static void Main(string[] args)
        {
            Pessoa p;
            int op = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Cadastrar dados");
                Console.WriteLine("2 - Listar dados");
                Console.WriteLine("0 - Sair");
                Console.Write("Digite a opção desejada: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        //Instanciando a variavel stream
                        FileStream streamCadastrar = new FileStream(@"..\..\..\..\Teste\Exemplo6.bin", FileMode.Append);

                        //Instanciando a variável do tipo BinaryWriter
                        BinaryWriter writer = new BinaryWriter(streamCadastrar);
                        Console.Write("\nDigite o nome: ");
                        p.nome = Console.ReadLine();
                        Console.Write("Digite a idade: ");
                        p.idade = int.Parse(Console.ReadLine());
                        Console.Write("Digite a altura: ");
                        p.altura = double.Parse(Console.ReadLine());
                        writer.Write(p.nome);
                        writer.Write(p.idade);
                        writer.Write(p.altura);
                        writer.Flush();
                        writer.Close();

                        break;

                    case 2:
                        FileStream streamListar = new FileStream(@"..\..\..\..\Teste\Exemplo6.bin", FileMode.Open);

                        //Instanciando a variável do tipo BinaryReader
                        BinaryReader reader = new BinaryReader(streamListar);

                        //O peekChar verifica o próximo byte do arquivo sem avançar o cursor,
                        //se não houver mais bytes para serem lidos, ele devolve valor negativo
                        while (reader.PeekChar() > -1)
                        {
                            //variaveis recebendo os valores lidos pelo arquivo binário
                            p.nome = reader.ReadString();
                            p.idade = reader.ReadInt32();
                            p.altura = reader.ReadDouble();
                            Console.WriteLine("\n{0} - {1} - {2}", p.nome, p.idade, p.altura);
                        }

                        //Fecha o acesso com o arquivo
                        reader.Close();
                        break;

                    case 0:
                        break;

                    default: Console.WriteLine("Opção Inválida");
                        break;
                }
                Console.WriteLine("\n\nPressione alguma tecla para continuar!!");
                Console.ReadKey();
            } while (op != 0);
        }
    }
}
