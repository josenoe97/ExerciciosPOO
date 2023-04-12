using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Empregado : Pessoa
    {
        public string Matricula { get; set; }

        public void ExibirMat()
        {
            Console.WriteLine("Matricula do empregado " + this.Nome + " : " + this.Matricula);
        }
    }
}
