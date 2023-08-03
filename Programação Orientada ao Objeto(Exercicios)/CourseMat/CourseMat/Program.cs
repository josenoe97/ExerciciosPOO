using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseMat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many student for course A? ");
            int n1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n1; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseA.Add(cod);
            }


            Console.Write("How many student for course B? ");
            int n2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n2; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseB.Add(cod);
            }

            Console.Write("How many student for course C? ");
            int n3 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n3; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseC.Add(cod);
            }

            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);
            Console.WriteLine("Total students: " + all.Count);

        }
    }
}
