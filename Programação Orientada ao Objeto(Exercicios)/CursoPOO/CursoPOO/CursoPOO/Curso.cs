using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOO
{
    public class Curso
    {
        public string NomeCurso { get; set; }
        public List<Aluno> Alunos { get; set; }

        public Curso()
        {
            Alunos = new List<Aluno>();
        }

        public void AddListAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }

        public void RemListAluno(Aluno aluno)
        {
            Alunos.Remove(aluno);
        }
    }
}
