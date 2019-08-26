using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            string mensagem;

            do
            {
                op = menu();
                switch (op)
                {
                    case 1:
                        mensagem = escreverMensagem();
                        gravarMensagem(mensagem);
                        break;
                    case 2:
                        lerArquivo();
                        break;
                    case 0:
                        break;
                }
            } while (op != 0);

        }
        static int menu()
        {
            Console.Clear();
            Console.WriteLine(" **** Turma B ****");
            Console.WriteLine("1 - Escreva Mensagem - bin");
            Console.WriteLine("2 - Leia um arquivo - txt");
            Console.WriteLine("0 - Sair");
            Console.Write("\nDigite a opção desejada: ");
            return int.Parse(Console.ReadLine());
        }
        static string escreverMensagem()
        {
            string mensagem;
            Console.Clear();
            Console.Write("Escreva sua Mensagem: ");
            mensagem = Console.ReadLine();
            return mensagem;

        }
        static void gravarMensagem(string mensagem)
        {
            Console.Write("\nEscreva o nome que deseja para o arquivo: ");
            string nomedoarquivo = Console.ReadLine();
            FileStream streamMensagem = new FileStream(nomedoarquivo + ".bin", FileMode.Create);
            BinaryWriter escritor = new BinaryWriter(streamMensagem);
            escritor.Write(mensagem);
            escritor.Flush();
            escritor.Close();
            Console.WriteLine("\nClique para voltar ao menu. ");
            Console.ReadKey();
        }
        static void lerArquivo()
        {
            Console.Clear();
            Console.WriteLine("Coloque o arquivo na pasta desse executável.");
            Console.Write("Escreva o nome do arquivo: ");
            string caminho = Console.ReadLine() + ".txt";
            Console.WriteLine();

            System.IO.StreamReader leitor;
            string linhaAtual;

            if (!System.IO.File.Exists(caminho))
            {
                throw (new System.IO.FileNotFoundException("Não foi Possível Localizar o Arquivo Especificado"));
            }

            using (leitor = new System.IO.StreamReader(caminho))
            {
                while (!leitor.EndOfStream)
                {
                    linhaAtual = leitor.ReadLine();
                    Console.WriteLine(linhaAtual);
                }
            }
            Console.WriteLine("\nClique para voltar ao menu. ");
            Console.ReadKey();
        }
    }
}
