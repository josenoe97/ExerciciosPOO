using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPessoa
{
    public class Aluno : Pessoa
    {
        public string Matricula { get; private set; }
        public string Curso { get; set; }

        public void Matricular(string matricula,string curso) 
        {
            Matricula = matricula;
            Curso = curso;
        }
    }
}
