using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos.Pagamentos 
{
     class Credito : Pagamento
    {


        public override double CalcularJuros(double valor)
        {
            return valor * 1.29;
        }
    }
}
