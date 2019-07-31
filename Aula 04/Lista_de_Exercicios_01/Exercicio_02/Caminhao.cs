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
        private string tipo_carroceria;

        //Construtor sem parâmetros
        public Caminhao() 
            : base()
        {
            this.numero_eixos = 0;
            this.peso_maximo_carga = 0;
            this.tipo_carroceria = null;
        }

        //Construtor com parâmetros
        public Caminhao(string modelo, string fabricante, int ano, string cor, int numero_portas, string placa, int numero_eixos, double peso_maximo_carga, string tipo_carroceria)
            : base(modelo,fabricante,ano,cor,numero_portas,placa)
        {
            this.numero_eixos = numero_eixos;
            this.peso_maximo_carga = peso_maximo_carga;
            this.tipo_carroceria = tipo_carroceria;
        }
        //Encapsulamento
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
        public string Tipo_carroceria
        {
            get { return tipo_carroceria; }
            set { tipo_carroceria = value; }
        }
    }
}
