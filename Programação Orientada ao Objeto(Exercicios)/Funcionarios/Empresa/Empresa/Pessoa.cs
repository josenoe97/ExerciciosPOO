using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }

        public void ExebirInfo()
        {
            Console.WriteLine(this.Nome);
            Console.WriteLine(this.Idade);
            Console.WriteLine(this.Salario);
        }
    }
}
