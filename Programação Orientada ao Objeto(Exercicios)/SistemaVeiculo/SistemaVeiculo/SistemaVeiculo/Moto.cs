using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculo
{
    public class Moto : Veiculo
    {
        public int Rodas { get; set; }
        public bool PartidaEletrica { get; set; }

        public new int Frenar()
        {
            if (PartidaEletrica)
            {
                if (VelocidadeAtual >= 0)
                {
                    return VelocidadeAtual -= 10;
                }
                else
                {
                    return VelocidadeAtual = 0;
                }
            }
            else
            {
                return VelocidadeAtual -= 10;
            }
        }
        public new void ExibirDados()
        {
            Console.WriteLine("Dados do veiculo: ");
            Console.WriteLine("Marca: " + this.Marca);
            Console.WriteLine("Modelo: " + this.Modelo);
            Console.WriteLine("Ano: " + this.Ano);
            Console.WriteLine("Car: " + this.Cor);
            Console.WriteLine("Quantidade de rodas: " + this.Rodas);
            Console.WriteLine();
        }

    }
}
