using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeCarros
{
    public class Concessionaria
    {
        public List<Carro> Carros { get; set; } // Carros é o nome da Lista.

        public Concessionaria()
        {
            Carros = new List<Carro>();
        }

        public void AdicionarCarros(Carro carro)
        {
            Carros.Add(carro);
        }
    }
}
