using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Pessoa
    {
        private double matricula = 0;
        private string nome = "";

        public double Matricula { get => matricula; set => matricula = value; }
        public string Nome { get => nome; set => nome = value; }
    }

    internal class Aluno : Pessoa
    {
        private double media = 0;
        public double Media { get => media; set => media = value; }
    }

    internal class Professor : Pessoa
    {
        private double salario = 0;
        public double Salario { get => salario; set => salario = value; }
    }
}
