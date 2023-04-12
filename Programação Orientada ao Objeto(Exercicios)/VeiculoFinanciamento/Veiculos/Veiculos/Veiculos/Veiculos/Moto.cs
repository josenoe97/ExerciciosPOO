using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    public class Moto:Veiculo
    {
        public int Cilindrada { get; set; }

        public void ExibirCilindradas()
        {
            Console.WriteLine("Aquantidade de cilindrada da " + this.Modelo + " é " + this.Cilindrada);
        }
    }
}
