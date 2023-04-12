using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos.Pagamentos
{
     class Debito : Pagamento
    {
        public override double CalcularJuros(double valor)
        { 
            return valor; 
        }
    }
}
