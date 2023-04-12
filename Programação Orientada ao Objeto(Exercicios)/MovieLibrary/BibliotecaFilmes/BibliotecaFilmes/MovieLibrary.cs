using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFilmes
{
    public class MovieLibrary
    {
        public List<Movie> listMovie;

        public MovieLibrary() 
        { 
            listMovie= new List<Movie>();   
        }

        public void AddMovie(Movie movie)
        {
            listMovie.Add(movie);
        }
        public void RemoveMovie(string titulo)
        {
            listMovie.RemoveAll(m => m.Titulo == titulo); // m => m.Titulo , se trata de uma expressão lambda
        }


    }
}
