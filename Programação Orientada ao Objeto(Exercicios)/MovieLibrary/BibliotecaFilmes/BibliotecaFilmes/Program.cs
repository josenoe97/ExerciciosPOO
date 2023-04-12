using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFilmes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieLibrary listafilmes = new MovieLibrary();

            Movie movie1 = new Movie()
            {
                Titulo = "Capitão America",
                AnoLancamento = 2015,
                Diretor = "JunimPlay",
                Genero = "Ação",
                Classificacao = "Livre",
                PretoeBranco = true
            };
            listafilmes.AddMovie(movie1);

            Movie movie2 = new Movie()
            {
                Titulo = "Avatar",
                AnoLancamento = 2022,
                Diretor = "Seila kkkj",
                Genero = "Aventura",
                Classificacao = "12+",
                PretoeBranco = false
            };
            listafilmes.AddMovie(movie2);


            Console.WriteLine("Biblioteca de Filmes: \n");
            foreach (Movie movie in listafilmes.listMovie)
            {
                Console.WriteLine("Titulo: "+ movie.Titulo);
                Console.WriteLine("Lançamento: "+ movie.AnoLancamento);
                Console.WriteLine("Direto: "+ movie.Diretor);
                Console.WriteLine("Genero: "+movie.Genero);
                Console.WriteLine("Classificação: "+ movie.Classificacao);

                if(movie.PretoeBranco == true)
                {
                    Console.WriteLine("Cor: Preto e branco.");
                }
                else
                {
                    Console.WriteLine("Cor: Colorido.");
                }
                Console.WriteLine();
            }

            Console.Write("Filmes por titulo: ");
            string titulo = Convert.ToString(Console.ReadLine());
            foreach (Movie movie in listafilmes.listMovie)
            {
                if (movie.Titulo == titulo)
                {
                    Console.WriteLine("Titulo: " + movie.Titulo);
                    Console.WriteLine("Lançamento: " + movie.AnoLancamento);
                    Console.WriteLine("Direto: " + movie.Diretor);
                    Console.WriteLine("Genero: " + movie.Genero);
                    Console.WriteLine("Classificação: " + movie.Classificacao);
                    Console.WriteLine();
                }
            }

            Console.Write("Filmes por genero: ");
            string genero = Convert.ToString(Console.ReadLine());
            foreach (Movie movie in listafilmes.listMovie)
            {
                if (movie.Genero == genero)
                {
                    Console.WriteLine("Titulo: " + movie.Titulo);
                    Console.WriteLine("Lançamento: " + movie.AnoLancamento);
                    Console.WriteLine("Direto: " + movie.Diretor);
                    Console.WriteLine("Genero: " + movie.Genero);
                    Console.WriteLine("Classificação: " + movie.Classificacao);
                    Console.WriteLine();
                }
            }

            Console.ReadKey();

        }
    }
}
