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

        //Construtor sem parâmetros
        public Carro()
            : base()
        {
            capacidadePortaMala = 0;
            bagageiro = false;
        }
        //Construtor com parâmetros
        public Carro(string modelo, string fabricante, int ano, string cor, int numero_portas, int capacidadePortaMala, bool bagageiro)
            :base(modelo,fabricante,ano,cor,numero_portas)
        {
            this.capacidadePortaMala = capacidadePortaMala;
            this.bagageiro = bagageiro;
        }
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
    }
}
