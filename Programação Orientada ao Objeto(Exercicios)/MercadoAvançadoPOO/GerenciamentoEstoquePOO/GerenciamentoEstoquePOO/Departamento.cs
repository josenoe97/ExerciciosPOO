using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEstoquePOO
{
    public class Departamento
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public List<Produto> Produtos { get; set; }

        public Departamento()
        {
            Produtos = new List<Produto>();
        }
    }
}
