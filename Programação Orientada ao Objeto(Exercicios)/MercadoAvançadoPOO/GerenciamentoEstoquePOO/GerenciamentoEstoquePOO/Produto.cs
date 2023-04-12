using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEstoquePOO
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque { get; set; }

        public void AumentarEstoque(int valor)
        {
            QuantidadeEstoque += valor;
        }

        public void DiminuirEstoque(int valor)
        {
            QuantidadeEstoque -= valor;
        }
    }
}
