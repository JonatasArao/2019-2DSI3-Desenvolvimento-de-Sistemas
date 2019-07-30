using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.Nome = "Barry Allen";
            a.Idade = 23;
            a.Altura = 1.7;
            a.Sexo = "m";
            a.Matricula = 2014;
            a.Curso = "Ciência Forense";

            Console.WriteLine(" Dados do Aluno");
            Console.WriteLine("\n{0}", a.ToString());

            Professor p = new Professor();
            p.Nome = "Eobard Thawne";
            p.Idade = 50;
            p.Altura = 1.8;
            p.Sexo = "m";
            p.Titulacao = "Mestre Doutor";
            p.Ch = 70;

            Console.WriteLine("\n\n Dados do Professor");
            Console.WriteLine("\n{0}", p.ToString());

            Console.ReadKey();
        }
    }
}
