using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Escola escola = new Escola();

            //Joao
            Aluno aluno1 = new Aluno()
            {
                Nome = "João da Silva",
                Idade = 20,
                Altura = 1.75f
            };
            aluno1.Matricular("123456", "Computação");
            escola.AdicionarAluno(aluno1);

            //Patricia 
            Aluno aluno2 = new Aluno()
            {
                Nome = "Patricia Santos",
                Idade = 21,
                Altura = 1.65f
            };

            //Clebson
            Aluno aluno3 = new Aluno();
            aluno3.Nome = "Clebson Porto";
            aluno3.Idade = 19;
            aluno3.Altura = 1.9f;

            aluno3.Matricular("741852", "Designer");
            escola.AdicionarAluno(aluno3);

            aluno2.Matricular("987456","Direito");
            escola.AdicionarAluno(aluno2);

            //Professora Maria
            Professor professor1 = new Professor()
            {
                Nome = "Maria Rodrigues",
                Idade = 35,
                Altura = 1.65f
            };
            professor1.Contratar("654123",5000);
            escola.AdicionarProfessor(professor1);

            Console.WriteLine("Alunos da escola:");
            foreach (Aluno aluno in escola.Alunos)
            {
                Console.WriteLine("Nome: " + aluno.Nome);
                Console.WriteLine("Idade: " + aluno.Idade);
                Console.WriteLine("Altura: " + aluno.Altura);
                Console.WriteLine("Matrícula: " + aluno.Matricula);
                Console.WriteLine("Curso: " + aluno.Curso);
                Console.WriteLine();
            }

            Console.WriteLine("Professores da escola:");
            foreach(Professor professor in escola.Professores)
            {
                Console.WriteLine("Nome: " + professor.Nome);
                Console.WriteLine("Idade: " + professor.Idade);
                Console.WriteLine("Altura: " + professor.Altura);
                Console.WriteLine("Matrícula: " + professor.Matricula);
                Console.WriteLine("Salário: " + professor.Salario);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
