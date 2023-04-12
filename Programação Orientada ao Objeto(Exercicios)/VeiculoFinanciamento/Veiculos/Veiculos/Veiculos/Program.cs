using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veiculos.Pagamentos;

namespace Veiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Moto moto = new Moto()
            {
                Modelo = "CG",
                Marca = "Honda",
                Ano = 2012,
                Preco = 12.000,
                Cilindrada = 160,
                TipoPagamento = new Credito()
                
            };
            moto.Valor = moto.TipoPagamento.CalcularJuros(moto.Preco);
            moto.ExibirCilindradas();
            moto.ExibirInfo();

            Console.WriteLine("Valor a ser pago: "+ moto.Valor);

            Console.ReadKey();
        }
    }
}
