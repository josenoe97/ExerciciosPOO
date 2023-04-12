using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasProdutos
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QtdEstoque { get; set; }

        public Produto(string nome,double preco,int qtdEstoque)
        {
            Nome = nome;
            Preco = preco;
            QtdEstoque = qtdEstoque;
        }
    }
}
