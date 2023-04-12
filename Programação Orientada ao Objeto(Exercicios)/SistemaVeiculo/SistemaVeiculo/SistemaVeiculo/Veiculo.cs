using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculo
{
    abstract public class Veiculo 
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public int VelocidadeAtual { get; set; }
        public int VelocidadeMaxima { get; set; }
        public bool Ligado { get; set; }

        public int Acelerar()
        {
            if (Ligado)
            {
                return VelocidadeAtual += 10;
            }
            else
            {
                return VelocidadeAtual = 0;
            }
        }

        public int Frenar()
        {
            if (Ligado)
            {
                return VelocidadeAtual -= 10;
            }
            else
            {
                return VelocidadeAtual = 0;
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine("Dados do veiculo: ");
            Console.WriteLine("Marca: "+this.Marca);
            Console.WriteLine("Modelo: "+this.Modelo);
            Console.WriteLine("Ano: "+this.Ano);
            Console.WriteLine("Car: " + this.Cor);
        }
    }
}
