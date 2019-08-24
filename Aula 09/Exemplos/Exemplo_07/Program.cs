using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exemplo_07
{
    class Program
    {
        public struct Pessoa
        {
            public String nome;
            public int idade;
            public double altura;
        }

        //Método principal
        static void Main(string[] args)
        {
            Pessoa[] p = new Pessoa[500];
            int op = 0;
            //x é o contador oficial da quantidade de registros cadastrados
            int x = carregarDados(p);

            do
            {
                op = menu();
                switch (op)
                {
                    case 1:
                        p[x] = entradaDados(); //Armazenando um registro no vetor
                        cadastrar(p[x]); //Chamando o método para gravar registro no arquivo
                        x++;
                        break;

                    case 2:
                        Console.WriteLine("\n **** Listagem **** ");
                        for (int i = 0; i < x; i++)
                            exibirDados(p[i]);
                        break;

                    case 0:
                        break;

                    default: Console.WriteLine("Opção inválida");
                        break;
                }
                pausar();
            } while (op != 0);
        }
        //método responsável por exibir o menu, ler e retornar a opção escolhida
        static int menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Cadastrar dados");
            Console.WriteLine("2 - Listar dados");
            Console.WriteLine("0 - Sair");
            Console.Write("\nDigite a opção desejada: ");
            return int.Parse(Console.ReadLine());
        }

        //método responsável por exibir os dados de um registro
        static void exibirDados(Pessoa aux)
        {
            Console.Write("\n" + aux.nome + "\t");
            Console.Write(aux.idade + "\t");
            Console.WriteLine(aux.altura);
        }

        //método responsável por ler um registro e retorna-lo para o main
        static Pessoa entradaDados()
        {
            Pessoa aux;

            Console.Write("\nDigite o nome: ");
            aux.nome = Console.ReadLine();
            Console.Write("Digite a idade: ");
            aux.idade = int.Parse(Console.ReadLine());
            Console.Write("Digite a altura: ");
            aux.altura = double.Parse(Console.ReadLine());

            return aux;
        }
        static void pausar()
        {
            Console.WriteLine("\n\nPressione alguma tecla para continuar!!");
            Console.ReadKey();
        }

        //método responsável por cadastrar o registro no arquivo
        static void cadastrar(Pessoa aux)
        {
            //instanciando a variável stream
            FileStream streamCadastrar = new FileStream(@"..\..\..\..\Teste\Exemplo7.bin", FileMode.Append);

            //instanciando a variável do tipo BinaryWriter
            BinaryWriter writer = new BinaryWriter(streamCadastrar);

            writer.Write(aux.nome);
            writer.Write(aux.idade);
            writer.Write(aux.altura);
            writer.Flush();
            writer.Close();
        }
        //Método responsável por carregar os registros que estão no arquivo, em um vetor
        static int carregarDados(Pessoa[] p)
        {
            FileStream streamListar;

            //Se o arquivo não existir, cria o arquivo, senão, apenas abre o arquivo
            if (!File.Exists(@"..\..\..\..\Teste\Exemplo7.bin"))
                streamListar = new FileStream(@"..\..\..\..\Teste\Exemplo7.bin", FileMode.Create);
            else
                streamListar = new FileStream(@"..\..\..\..\Teste\Exemplo7.bin", FileMode.Open);

            //serve de contador de registros
            int cont = 0;

            //instanciando a variável do tipo BinaryReader
            BinaryReader reader = new BinaryReader(streamListar);

            while (reader.PeekChar() > -1)
            {
                //variáveis recebendo os valores lidos pelo arquivo binário
                p[cont].nome = reader.ReadString();
                p[cont].idade = reader.ReadInt32();
                p[cont].altura = reader.ReadDouble();
                cont++;
            }
            //fecha o acesso com o arquivo
            reader.Close();
            return cont;
        }
    }
}
