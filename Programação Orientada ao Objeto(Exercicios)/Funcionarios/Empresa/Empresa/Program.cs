using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empregado empregado1 = new Empregado()
            {
                Nome = "Carlos",
                Idade = 22,
                Salario = 1212.13,
                Matricula = "2022155"
            };

            Gerente gerente1 = new Gerente()
            {
                Nome = "Joao",
                Idade = 32,
                Salario = 3211.66,
                Senha = "79582"
            };

            empregado1.ExebirInfo();
            empregado1.ExibirMat();
            Console.WriteLine();
            gerente1.ExebirInfo();
            gerente1.ExibirSenha();


        }
    }
}
