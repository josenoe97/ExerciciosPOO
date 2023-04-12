using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeCarros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Concessionaria concessionaria = new Concessionaria();
            Carro carro1 = new Carro("Toyota","Corolla",2018,56.785);
            concessionaria.AdicionarCarros(carro1);

            Carro carro2 = new Carro("Ford","Ka",2015,48.867);
            concessionaria.AdicionarCarros(carro2);

            carro1.ExibirDados();
            carro2.ExibirDados();

            Console.WriteLine();

            Console.WriteLine("Carros da Concessionária: ");
            foreach (Carro carro in concessionaria.Carros )
            {
                Console.WriteLine("Marca: " + carro.Marca);
                Console.WriteLine("Modelo: " + carro.Modelo);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
