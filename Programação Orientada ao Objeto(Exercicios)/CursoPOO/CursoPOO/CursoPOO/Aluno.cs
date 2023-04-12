using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOO
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Matricula { get; set; }

        public int CalcularIdade()
        {
            int idade = DateTime.Today.Year - DataNascimento.Year;
            if(DataNascimento > DateTime.Today.AddYears(-idade))
            {
                idade--;
            }
            return idade;
        }
    }
}
