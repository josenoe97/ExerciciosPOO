using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEstoquePOO
{
    public class Loja
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public List<Departamento> Departamentos;

        public Loja()
        {
            Departamentos = new List<Departamento>();
        }

        public void AdicionarDepartamento(Departamento departamento)
        {
            Departamentos.Add(departamento);
        }

        public void AdicionarProduto(string departamento,Produto produto)
        {
            Departamento depar = Departamentos.FirstOrDefault(d => d.Nome == departamento);
            if (depar != null)
            {
                depar.Produtos.Add(produto);
            }
        }

        public void RemoverProduto(string departamento,Produto produto)
        {
            Departamento depar = Departamentos.FirstOrDefault(d => d.Nome == departamento);
            if (depar != null)
            {
                depar.Produtos.Remove(produto);
            }
        }

        public void ListaProdutosPorDepartamentos()
        {
            foreach(Departamento depar in Departamentos)
            {
                Console.WriteLine("Departamento: "+depar.Nome);
                Console.WriteLine();
                foreach(Produto produto in depar.Produtos)
                {
                    Console.WriteLine(" Produto: " + produto.Nome + ", Preço: "+ produto.Preco + ", Estoque: "+ produto.QuantidadeEstoque);
                    Console.WriteLine();
                }
            }
        }
    }
}
