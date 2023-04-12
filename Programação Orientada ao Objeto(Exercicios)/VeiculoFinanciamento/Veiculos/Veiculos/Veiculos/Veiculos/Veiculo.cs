using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Preco { get; set; }
        internal Pagamento TipoPagamento { get; set; }
        public double Valor { get; set; }

        public void ExibirInfo()
        {
            Console.WriteLine("Marca: "+this.Marca);
            Console.WriteLine("Modelo: " + this.Modelo);
            Console.WriteLine("Ano: " + this.Ano);
            Console.WriteLine("Preço: " + this.Preco);
        }
    }
}
