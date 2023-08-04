using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string sourcePath = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(sourcePath))
                {

                    Dictionary<string, int> dictionary = new Dictionary<string, int>();

                    while (!(sr.EndOfStream))
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int qtdVote = int.Parse(line[1]);

                        if (dictionary.ContainsKey(name))
                        {
                            dictionary[name] += qtdVote;
                        }
                        else
                        {
                            dictionary[name] = qtdVote;
                        }
                    }

                    foreach (var obj in dictionary)
                    {
                        Console.WriteLine(obj.Key + ": " + obj.Value);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
