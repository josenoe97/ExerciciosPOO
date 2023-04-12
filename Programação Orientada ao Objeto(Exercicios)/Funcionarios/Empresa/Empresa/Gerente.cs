using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Gerente : Pessoa
    {
        public string Senha { get; set; }

        public void ExibirSenha()
        {
            Console.WriteLine("Senha do gerente "+this.Nome+" : "+this.Senha);
        }
    }
}
