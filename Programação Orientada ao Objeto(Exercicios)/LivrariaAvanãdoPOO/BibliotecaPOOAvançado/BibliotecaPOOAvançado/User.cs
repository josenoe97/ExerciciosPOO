using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPOOAvançado
{
    class User
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string NumeroTell { get; set; }

        public User(string name, string address, string phoneNumber)
        {
            Nome = name;
            Endereco = address;
            NumeroTell = phoneNumber;
        }

        public void InfoUsuario()
        {
            Console.WriteLine("Name: " + Nome);
            Console.WriteLine("Address: " + Endereco);
            Console.WriteLine("Phone number: " + NumeroTell);
        }
    }
}
