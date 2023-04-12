using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPOOAvançado
{
    class Library
    {
        public List<Book> Books { get; set; }
        public List<Loan> Loans { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Loans = new List<Loan>(); //  Parte que cuida dos emprestimos
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }

        public void Emprestimo(Loan loan)
        {
            Loans.Add(loan);
        }

        public void Devolucao(Loan loan)
        {
            Loans.Remove(loan);
        }
    }

}

