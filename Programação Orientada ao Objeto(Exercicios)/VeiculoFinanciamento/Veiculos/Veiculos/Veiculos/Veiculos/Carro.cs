using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    public class Carro:Veiculo
    {
        public int Portas { get; set; }

        public void ExibirPortas()
        {
            Console.WriteLine("Aquantidade de portas do "+this.Modelo+ "é "+ this.Portas);
        }
    }
}
