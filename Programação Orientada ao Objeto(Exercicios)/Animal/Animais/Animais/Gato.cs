using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    public class Gato : Animal
    {
        public int miadosPorDia  { get ; set; }

        public string Miar()
        {
            miadosPorDia++;
          return "Miando ...";
        }
    }
}
