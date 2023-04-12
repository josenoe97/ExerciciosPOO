using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Curso engenharia = new Curso();
            Curso computacao= new Curso();

            Aluno aluno1 = new Aluno();
            aluno1.Nome = "Carlos";
            aluno1.SobreNome = "Pereira";
            aluno1.Matricula = "21015451";
            aluno1.DataNascimento = new DateTime(2000, 01, 01);
            computacao.AddListAluno(aluno1);

            Aluno aluno2 = new Aluno();
            aluno2.Nome = "Carlos";
            aluno2.Matricula = "21014554";
            aluno2.SobreNome = "Noe";
            aluno2.DataNascimento = new DateTime(2001, 03, 06);
            engenharia.AddListAluno(aluno2);

            Console.WriteLine("Alunos Computação: ");
            foreach(Aluno aluno in computacao.Alunos){
                Console.WriteLine("Nome: " + aluno.Nome + " " + aluno.SobreNome);
                Console.WriteLine("Matricula: " + aluno.Matricula);
                Console.WriteLine();
            }

            Console.WriteLine("Alunos Engenharia: ");
            foreach (Aluno aluno in engenharia.Alunos)
            {
                Console.WriteLine("Nome: " + aluno.Nome + " " + aluno.SobreNome);
                Console.WriteLine("Matricula: " + aluno.Matricula);
                Console.WriteLine();
            }
        }
    }
}
