using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPOOAvançado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library livraria = new Library();

            User usuario1 = new User("João Pereira","Rua Maria Lopes","(21)96445-6464");

            Book book1 = new Book("Historia do Brasil", "L. Silva Ramos", "978-0-679-64249-1");
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", "978-0-449-31170-1");

            livraria.AddBook(book1);
            livraria.AddBook(book2);

            Console.WriteLine("Lista de Livros na Livraria");
            foreach (Book book in livraria.Books)
            {
                book.DisplayBookInfo();
                Console.WriteLine();
            }

            Loan loan1 = new Loan(book2, usuario1, DateTime.Now.AddDays(7));
            livraria.Emprestimo(loan1);

            Console.WriteLine("Livros Emprestados:");
            foreach (Loan loan in livraria.Loans)
            {
                Console.WriteLine("Livro : " + loan.Book.Titulo);
                Console.WriteLine("Pessoa nome : " + loan.User.Nome);
                Console.WriteLine("Data do emprestimo : " + loan.DueDate.ToString("dd/MM/yyyy"));//OBS: COMO FAZER O FORMATO DE DATA
                Console.WriteLine("Dias para entregar : " + loan.DiasEntrega());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
