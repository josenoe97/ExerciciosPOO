using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    public class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }

        public string Comer()
        {
            return "O animal está comendo";
        }
    }
}
