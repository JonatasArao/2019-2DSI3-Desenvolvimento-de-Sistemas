using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    class Caminhao : Veiculo
    {
        //Atributos
        private int numero_eixos;
        private double peso_maximo_carga;

        //Construtor sem parâmetros
        public Caminhao() 
            : base()
        {
            this.numero_eixos = 0;
            this.peso_maximo_carga = 0;
        }

        //Construtor com parâmetros
        public Caminhao(string modelo, string fabricante, int ano, string cor, int numero_portas, int numero_eixos, double peso_maximo_carga) 
            : base(modelo,fabricante,ano,cor,numero_portas)
        {
            this.numero_eixos = numero_eixos;
            this.peso_maximo_carga = peso_maximo_carga;
        }
        public int Numero_eixos
        {
            get { return numero_eixos; }
            set { numero_eixos = value; }
        }
        public double Peso_maximo_carga
        {
            get { return peso_maximo_carga; }
            set { peso_maximo_carga = value; }
        }
    }
}
