using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoPOO
{
    public class Estoque
    {
        public List<Produto>Produtos { get; set; }
        
        public Estoque()
        {
            Produtos = new List<Produto>();
        }

        public void AddListProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public void RemListProduto(Produto produto)
        {
            Produtos.Remove(produto);
        }
    }
}
