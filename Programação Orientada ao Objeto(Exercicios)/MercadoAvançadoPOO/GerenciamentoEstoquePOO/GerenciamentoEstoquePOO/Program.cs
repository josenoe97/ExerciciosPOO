using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEstoquePOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loja lojaMeier = new Loja()
            {
                Nome = "Meier",
                Endereco = "Rua dias da cruz"
            };

            Departamento comida = new Departamento()
            {
                Nome = "Comida",
                Codigo = 001
            };
            Departamento limpeza = new Departamento()
            {
                Nome = "Limpeza",
                Codigo = 002
            };

            lojaMeier.AdicionarDepartamento(limpeza);
            lojaMeier.AdicionarDepartamento(comida);

           Produto produto1 = new Produto()
            {
                Nome = "Macarrão",
                Preco = 2.79,
                QuantidadeEstoque = 8
            };

            Produto produto2 = new Produto()
            {
                Nome = "Desinfetante",
                Preco = 3.30,
                QuantidadeEstoque = 4
            };

            Produto produto3 = new Produto()
            {
                Nome = "Extrato de tomate",
                Preco = 3.30,
                QuantidadeEstoque = 9
            };

            Produto produto4 = new Produto()
            {
                Nome = "Sabão em pó",
                Preco = 3.30,
                QuantidadeEstoque = 7
            };

            Produto produto5 = new Produto()
            {
                Nome = "Arroz",
                Preco = 3.30,
                QuantidadeEstoque = 3
            };

            lojaMeier.AdicionarProduto("Comida", produto1);
            lojaMeier.AdicionarProduto("Limpeza", produto2);
            lojaMeier.AdicionarProduto("Limpeza",produto3);
            lojaMeier.AdicionarProduto("Limpeza", produto4);
            lojaMeier.AdicionarProduto("Comida", produto5);

            lojaMeier.RemoverProduto("Limpeza", produto2);

            lojaMeier.ListaProdutosPorDepartamentos();


            Console.ReadKey();

        }
    }
}
