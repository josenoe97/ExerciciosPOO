using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasProdutos
{
    public class Venda 
    {
        public int QtdVenda { get; set; }
        public Produto Produto { get; set; }
        public DateTime Data { get; set; }

        public Venda(Produto produto,int qtdVenda)
        {
            Produto = produto;
            QtdVenda = qtdVenda;
            Data = DateTime.Now;
        }
    }
}
