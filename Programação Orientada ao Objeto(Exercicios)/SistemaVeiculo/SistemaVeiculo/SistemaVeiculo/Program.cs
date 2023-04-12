using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Carro carro = new Carro()
            {
                Marca = "Ford",
                Modelo = "Prisma",
                Ano = 2015,
                Cor = "Branco",
                VelocidadeAtual = 102,
                VelocidadeMaxima = 150,
                Ligado = true,
                Cambio = "MAN",
                Portas = 4
            };

            Moto moto = new Moto()
            {
                Marca = "Honda",
                Modelo = "CG - 160",
                Ano = 2017,
                Cor = "Branco",
                VelocidadeAtual = 50,
                VelocidadeMaxima = 120,
                Ligado = true,
                Rodas = 2
            };

            carro.Acelerar();
            carro.Acelerar();

            carro.ExibirDados();
            moto.ExibirDados();

            Console.ReadKey();
        }
    }
}
