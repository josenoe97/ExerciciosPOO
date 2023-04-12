using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculo
{
    public class Carro : Veiculo
    {
        public int Portas { get; set; }
        public string Cambio { get; set; }

        public new int Acelerar()
        {
            if (Cambio == "AUT")
            {
                if (VelocidadeAtual < VelocidadeMaxima)
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
                else
                {
                    return VelocidadeMaxima;
                }
            }
            else if (Cambio == "MAN")
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
            else
            {
                return 0;
            }
        }

        public new void ExibirDados()
        {
            Console.WriteLine("Dados do veiculo: ");
            Console.WriteLine("Marca: " + this.Marca);
            Console.WriteLine("Modelo: " + this.Modelo);
            Console.WriteLine("Ano: " + this.Ano);
            Console.WriteLine("Car: " + this.Cor);
            Console.WriteLine("Câmbio: "+this.Cambio);
            Console.WriteLine("Quantidade de portas: "+this.Portas);
            Console.WriteLine();
        }
    }
}
