using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    class Carro : Veiculo 
    {
        //Atributos
        private int capacidadePortaMala;
        private bool bagageiro;
        private bool central_multimidia;

        //Construtor sem parâmetros
        public Carro()
            : base()
        {
            this.capacidadePortaMala = 0;
            this.bagageiro = false;
            this.central_multimidia = false;
        }
        //Construtor com parâmetros
        public Carro(string modelo, string fabricante, int ano, string cor, int numero_portas, string placa, int capacidadePortaMala, bool bagageiro, bool central_multimidia)
            :base(modelo,fabricante,ano,cor,numero_portas,placa)
        {
            this.capacidadePortaMala = capacidadePortaMala;
            this.bagageiro = bagageiro;
            this.central_multimidia = central_multimidia;
        }
        //Encapsulamento
        public int CapacidadePortaMala
        {
            get { return capacidadePortaMala; }
            set { capacidadePortaMala = value; }
        }
        public bool Bagageiro
        {
            get { return bagageiro; }
            set { bagageiro = value; }
        }
        public bool Central_multimidia
        {
            get { return central_multimidia; }
            set { central_multimidia = value; }
        }
        //Funções
        public override string ToString()
        {
            return String.Format("{0} Capacidade do Porta Mala: {1} \n Bagageiro: {2} \n Central Multimidia: {3}",
                                    base.ToString(), capacidadePortaMala, bagageiro == true ? "Sim" : "Não", central_multimidia == true ? "Sim" : "Não");
        }
        public new void Cadastrar()
        {
            Console.WriteLine("Cadastrar Carro\n");

            base.Cadastrar();

            Console.Write("Digite o Capacidade do Porta Malas: ");
            capacidadePortaMala = int.Parse(Console.ReadLine());

            Console.Write("Tem Bagageiro ( Sim = S / Não = N ): ");
            bagageiro = Console.ReadLine().ToUpper() == "S" ? true : false;

            Console.Write("Tem Central Multimidia ( Sim = S / Não = N ): ");
            central_multimidia = Console.ReadLine().ToUpper() == "S" ? true : false;
        }
    }
}
