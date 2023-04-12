using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estoque estoque= new Estoque();
            Produto produto1 = new Produto()
            {
                Nome = "Chá",
                Preco = 12.99,
                Quantidade= 12
            };

            Produto produto2 = new Produto()
            {
                Nome = "Café",
                Preco = 17.99,
                Quantidade= 5
            };

            Produto produto3 = new Produto()
            {
                Nome = "Sabonete",
                Preco = 5.99,
                Quantidade = 9
            };

            estoque.AddListProduto(produto1);
            estoque.AddListProduto(produto2);
            estoque.AddListProduto(produto3);
            produto3.adicionarouremoverEstoque(-5);

            estoque.RemListProduto(produto3);

            Console.WriteLine("Produtos cadastrados: ");
            foreach (Produto produto in estoque.Produtos)
            {
                Console.WriteLine("Nome: "+ produto.Nome);
                Console.WriteLine("Preço: "+produto.Preco);
                Console.WriteLine("Quantidade: "+produto.Quantidade);
                Console.WriteLine();
            }
        }
    }
}
