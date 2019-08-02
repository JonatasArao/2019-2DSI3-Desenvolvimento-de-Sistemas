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
            const int qtd_carro = 2, qtd_caminhao = 2;
            int cont_car = 0, cont_cam = 0, opcao;
            Carro[] carro = new Carro[qtd_carro];
            Caminhao[] caminhao = new Caminhao[qtd_caminhao];

            do
            {
                opcao = menu();
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        carro[cont_car] = new Carro();
                        carro[cont_car].Cadastrar();
                        cont_car++;
                        break;

                    case 2:
                        Console.Clear();
                        caminhao[cont_cam] = new Caminhao();
                        caminhao[cont_cam].Cadastrar();
                        cont_cam++;
                        break;

                    case 3:
                        Console.Clear();
                        consultaPlaca(carro, caminhao);
                        break;

                    case 4:
                        Console.Clear();
                        consultaCaminhaoModeloMarca(caminhao);
                        break;

                    case 5:
                        Console.Clear();
                        consultaCarroCor(carro);
                        break;

                    case 6:
                        Console.Clear();
                        listaCarros(carro);
                        break;

                    case 7:
                        Console.Clear();
                        listaCaminhao(caminhao);
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Opção Inválida - Tente Novamente");
                        break;
                }
                Console.WriteLine("\nTecle algo para continuar");
                Console.ReadKey();
            } while (opcao != 0);
        }
        static int menu()
        {
            Console.Clear();
            Console.WriteLine("Menu Principal - Veículos");
            Console.WriteLine("1 - Cadastrar Carro");
            Console.WriteLine("2 - Cadastrar Caminhão");
            Console.WriteLine("3 - Consulta por Placa");
            Console.WriteLine("4 - Consulta Caminhão por modelo/marca");
            Console.WriteLine("5 - Consultar Carro por cor");
            Console.WriteLine("6 - Exibir todos os Carros cadastrados");
            Console.WriteLine("7 - Exibir todos os Caminhões cadastrados");
            Console.WriteLine("0 - Sair");
            Console.Write("\nDigite uma opção: ");
            return int.Parse(Console.ReadLine());
        }
        static void consultaPlaca(Carro[] consulCarro, Caminhao[] consulCaminhao)
        {
            string placa;

            Console.WriteLine("Consulta por Placa\n");
            Console.Write("Digite a Placa: ");
            placa = Console.ReadLine();

            for (int iCar = 0; iCar < consulCarro.Length; iCar++)
            {
                if (consulCarro[iCar] != null && consulCarro[iCar].Placa == placa)
                {
                    Console.WriteLine();
                    Console.WriteLine(consulCarro[iCar].ToString());
                    Console.WriteLine("-----------------------------------------");
                }
            }
            
            for (int iCam = 0; iCam < consulCaminhao.Length; iCam++)
            {
                if (consulCaminhao[iCam] != null && consulCaminhao[iCam].Placa == placa)
                {
                    Console.WriteLine();
                    Console.WriteLine(consulCaminhao[iCam].ToString());
                    Console.WriteLine("-----------------------------------------");
                }
            }
        }
        static void consultaCaminhaoModeloMarca(Caminhao[] consulCaminhao)
        {
            string modeloMarca;

            Console.WriteLine("Consulta por Modelo/Marca\n");
            Console.Write("Digite o Modelo/Marca: ");
            modeloMarca = Console.ReadLine();

            for (int iCam = 0; iCam < consulCaminhao.Length; iCam++)
            {
                if (consulCaminhao[iCam] != null && consulCaminhao[iCam].Modelo == modeloMarca) 
                {
                    Console.WriteLine();
                    Console.WriteLine(consulCaminhao[iCam].ToString());
                    Console.WriteLine("-----------------------------------------");
                }
            }
        }
        static void consultaCarroCor(Carro[] consulCarro)
        {
            string cor;

            Console.WriteLine("Consulta por Cor\n");
            Console.Write("Digite a Cor: ");
            cor = Console.ReadLine();

            for (int iCar = 0; iCar < consulCarro.Length; iCar++)
            {
                if (consulCarro[iCar] != null && consulCarro[iCar].Cor == cor)
                {
                    Console.WriteLine();
                    Console.WriteLine(consulCarro[iCar].ToString());
                    Console.WriteLine("-----------------------------------------");
                }
            }
        }
        static void listaCarros(Carro[] listaCarro)
        {
            Console.WriteLine("Todos os Carros");
            for (int iCar = 0; iCar < listaCarro.Length; iCar++)
            {
                if (listaCarro[iCar] != null)
                {
                    Console.WriteLine();
                    Console.WriteLine(listaCarro[iCar].ToString());
                    Console.WriteLine("-----------------------------------------");
                }
            }
        }
        static void listaCaminhao(Caminhao[] listaCaminhao)
        {
            Console.WriteLine("Todos os Caminhões");
            for (int iCam = 0; iCam < listaCaminhao.Length; iCam++)
            {
                if (listaCaminhao[iCam] != null)
                {
                    Console.WriteLine();
                    Console.WriteLine(listaCaminhao[iCam].ToString());
                    Console.WriteLine("-----------------------------------------");
                }
            }
        }
    }
}
