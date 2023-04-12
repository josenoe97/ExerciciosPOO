using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPessoa
{
    public class Escola
    {
        public List<Aluno> Alunos  { get; set; } // Alunos é o nome da lista
        public List<Professor> Professores { get; set;} // Professores é o nome da lista

        public Escola()
        {
            Alunos= new List<Aluno>();
            Professores= new List<Professor>();
        }

        public void AdicionarAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }

        public void AdicionarProfessor(Professor professor)
        {
            Professores.Add(professor);
        }
    }
}
