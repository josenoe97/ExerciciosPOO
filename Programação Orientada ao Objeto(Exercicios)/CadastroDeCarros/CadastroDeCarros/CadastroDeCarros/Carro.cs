using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeCarros
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Preco { get; set; }

        public Carro(string marca, string modelo, int ano, double preco)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Preco = preco;
        }

        public void ExibirDados()
        { 
            
            Console.WriteLine("Dados do Veiculo: ");
            Console.WriteLine("Marca: "+this.Marca);
            Console.WriteLine("Modelo: "+ this.Modelo);
            Console.WriteLine("Ano: " + this.Ano);
            Console.WriteLine("Preço: "+ this.Preco);
            Console.WriteLine();
        } 
    }
}
