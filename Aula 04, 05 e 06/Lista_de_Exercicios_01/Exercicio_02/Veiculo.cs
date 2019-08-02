using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    abstract class Veiculo
    {
        //Atributos
        private string modelo;
        private string fabricante;
        private int ano;
        private string cor;
        private int numero_portas;
        private string placa;

        //Construtor sem parâmetros
        public Veiculo()
        {
            this.modelo = null;
            this.fabricante = null;
            this.ano = 0;
            this.cor = null;
            this.numero_portas = 0;
            this.placa = null;
        }
        //Construtor com parâmetros
        public Veiculo(string modelo, string fabricante,int ano, string cor, int numero_portas, string placa)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.ano = ano;
            this.cor = cor;
            this.numero_portas = numero_portas;
            this.placa = placa;
        }
        //Encapsulamento
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public int Numero_portas
        {
            get { return numero_portas; }
            set { numero_portas = value; }
        }
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        //Funções
        public override string ToString()
        {
            return (String.Format(" Modelo: {0} \n Fabricante: {1} \n Ano: {2} \n Cor: {3} \n Número de Portas: {4} \n Placa: {5}\n",
                                    modelo,fabricante,ano,cor,numero_portas,placa));
        }
        public void Cadastrar()
        {
            Console.Write("Digite o Modelo: ");
            modelo = Console.ReadLine();

            Console.Write("Digite o Fabricante: ");
            fabricante = Console.ReadLine();

            Console.Write("Digite o Ano: ");
            ano = int.Parse(Console.ReadLine());

            Console.Write("Digite o Cor: ");
            cor = Console.ReadLine();

            Console.Write("Digite o Número de Portas: ");
            numero_portas = int.Parse(Console.ReadLine());

            Console.Write("Digite o Placa: ");
            placa = Console.ReadLine();
        }
    }
}
