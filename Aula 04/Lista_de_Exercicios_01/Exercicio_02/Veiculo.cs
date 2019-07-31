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

        //Construtor sem parâmetros
        public Veiculo()
        {
            this.modelo = null;
            this.fabricante = null;
            this.ano = 0;
            this.cor = null;
            this.numero_portas = 0;
        }
        //Construtor com parâmetros
        public Veiculo(string modelo, string fabricante,int ano, string cor, int numero_portas)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.ano = ano;
            this.cor = cor;
            this.numero_portas = numero_portas;
        }
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
    }
}
