using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasProdutos
{
    public class VendaService 
    {
        private List<Venda> vendaList = new List<Venda>();

        public object Most { get; internal set; }

        public bool RealizarVenda(Venda venda)
        {
            var produto = venda.Produto;
            if (produto.QtdEstoque < venda.QtdVenda)
            {
                return false;
            }
             produto.QtdEstoque -= venda.QtdVenda;
             vendaList.Add(venda);
             return true;
        }

        public List<Venda> MostrarVendas()
        {
            return vendaList;
        }
        

    }
}
