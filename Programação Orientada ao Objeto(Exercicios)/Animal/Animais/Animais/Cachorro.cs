using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    public class Cachorro : Animal
    {
        public int latidosPorDia{ get; set; }

        public string Latir()
        {
            latidosPorDia++;
            return "Latindo ...";
        }
    }
}
