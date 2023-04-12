using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPessoa
{
    public class Professor : Pessoa
    {
        public string Matricula { get; private set; }
        public double Salario { get; set; }

        public void Contratar(string matricula,double salario)
        {
            Matricula = matricula;
            Salario = salario;
        }
    }
}
