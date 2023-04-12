using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPOOAvançado
{
    class Loan
    {
        public Book Book { get; set; }
        public User User { get; set; }
        public DateTime DueDate { get; set; }

        public Loan(Book book, User user, DateTime dueDate)
        {
            Book = book;
            User = user;
            DueDate = dueDate;
        }

        public int DiasEntrega()
        {
            TimeSpan timeUntilDue = DueDate - DateTime.Now;
            TimeSpan hourUntilDue = DueDate - DateTime.Now;
            int daysUntil = (int)timeUntilDue.TotalDays; //Conversao de Data para inteiro
            int hoursUntil = (int)timeUntilDue.TotalHours;
            return hoursUntil;
        }
    }
}
