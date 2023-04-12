using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPessoa
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }

        public double Crescer()
        {
            return this.Altura += 0.02;
        }

        public int Envelhecer()
        {
            return this.Idade += 1;
        }
    }
}
