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
    }
}
