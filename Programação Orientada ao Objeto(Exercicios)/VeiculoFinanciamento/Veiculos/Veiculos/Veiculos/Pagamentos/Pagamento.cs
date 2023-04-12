using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    abstract class Pagamento
    {
        public abstract double CalcularJuros(double valor);
    }
}
