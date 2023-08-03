using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using UdemyCourse.Entities;

namespace UdemyCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string sourcePath = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instante = DateTime.Parse(line[1]);
                        set.Add(new LogRecord {UserName = name, Instant = instante});
                        Console.WriteLine(line[0] + " " + line[1]);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Total users: " + set.Count);

                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
