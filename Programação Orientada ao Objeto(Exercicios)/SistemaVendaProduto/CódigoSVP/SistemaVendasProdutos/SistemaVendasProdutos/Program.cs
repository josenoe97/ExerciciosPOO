using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasProdutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var produto1 = new Produto("Produto 1", 10, 100);
            var produto2 = new Produto("Produto 2", 20, 50);
            var vendaService = new VendaService();

            Console.WriteLine("Realizando venda do Produto 1");
            var venda1 = new Venda(produto1, 200);
            var success1 = vendaService.RealizarVenda(venda1);
            if (success1)
            {
                Console.WriteLine("Venda realizada com sucesso");
            }
            else
            {
                Console.WriteLine("Estoque insuficiente");
            }

            Console.WriteLine("\nRealizando venda do Produto 2");
            var venda2 = new Venda(produto2, 20);
            var success2 = vendaService.RealizarVenda(venda2);
            if (success2)
            {
                Console.WriteLine("Venda realizada com sucesso");
            }
            else
            {
                Console.WriteLine("Estoque insuficiente");
            }

            Console.WriteLine("\nLista de Vendas:");
            var vendas = vendaService.MostrarVendas();
            Console.WriteLine(vendas);
            
        }
    }
}
