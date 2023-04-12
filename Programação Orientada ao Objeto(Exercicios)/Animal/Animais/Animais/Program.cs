using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato gato1 = new Gato();
            gato1.Nome = "Sofia";
            gato1.Idade = 3;
            gato1.Peso = 6.4;

            Console.WriteLine("\n\n"+gato1.Nome);
            Console.WriteLine(gato1.Idade);
            Console.WriteLine(gato1.Peso);

            Console.WriteLine(gato1.Comer());

            Console.WriteLine(gato1.Miar());

            Cachorro dog1 = new Cachorro();
            dog1.Nome = "Jubileu";
            dog1.Idade = 6;
            dog1.Peso = 12.7;

            Console.WriteLine("\n\n" + dog1.Nome);
            Console.WriteLine(dog1.Idade);
            Console.WriteLine(dog1.Peso);

            Console.WriteLine(dog1.Latir());
            Console.WriteLine(dog1.Latir());

            Console.WriteLine("\nQuantidade de miados: "+ gato1.miadosPorDia);
            Console.WriteLine("\nQuantidade de latidos: " + dog1.latidosPorDia);

            Console.ReadKey();
        }
    }
}
