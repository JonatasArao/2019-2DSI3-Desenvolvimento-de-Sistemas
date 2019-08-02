using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_05
{
    class Aluno : Pessoa
    {
        private int matricula;
        private string curso;

        public Aluno()
            : base()
        {
            matricula = 0;
            curso = null;
        }
        public Aluno(string nome, int idade, double altura, char sexo, int matricula, string curso)
            : base(nome, idade, altura, sexo)
        {
            this.matricula = matricula;
            this.curso = curso;
        }
        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public override string ToString()
        {
            return String.Format("{0} Matricula: {1} \n Curso: {2}",
                                    base.ToString(), matricula, curso);
        }
    }
}
