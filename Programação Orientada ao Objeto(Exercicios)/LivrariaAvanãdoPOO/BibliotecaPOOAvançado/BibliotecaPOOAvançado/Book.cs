using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPOOAvançado
{
    class Book
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, string isbn)
        {
            Titulo = title;
            Autor = author;
            ISBN = isbn;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine("Title: " + Titulo);
            Console.WriteLine("Author: " + Autor);
            Console.WriteLine("ISBN: " + ISBN);
        }
    }
}
