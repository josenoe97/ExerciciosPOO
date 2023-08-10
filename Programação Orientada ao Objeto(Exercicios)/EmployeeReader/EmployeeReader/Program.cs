using EmployeeReader.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;

namespace EmployeeReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream) // Atenção !!!
                    {
                        string[] fiels = sr.ReadLine().Split(',');
                        string name = fiels[0];
                        string email = fiels[1];
                        double emp_salary = double.Parse(fiels[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, emp_salary));
                    }
                }

                Console.WriteLine($"Email of peoples whose is more than {salary.ToString("F2", CultureInfo.InvariantCulture)}: ");

                var compEmails = list.Where(p => p.Salary > salary).OrderBy(p => p.Email).Select(p => p.Email);
                foreach (string obj in compEmails)
                {
                    Console.WriteLine(obj);
                }

                var sum = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);

                Console.Write($"Sum of salary of people whose name starts with 'M' : {sum}");
                Console.WriteLine();
            }
            catch (IOException ex) 
            {
                Console.WriteLine("An error occurred : " + ex.Message);
            }
        }
    }
}
