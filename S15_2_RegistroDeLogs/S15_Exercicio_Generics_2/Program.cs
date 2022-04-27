using System;
using System.IO;
using System.Collections.Generic;
using S15_Exercicio_Generics_2.Entities;

namespace S15_Exercicio_Generics_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HashSet<Log> set = new HashSet<Log>();

                Console.Write("Enter file full path: ");
                string sourcePath = Console.ReadLine();

                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    while (sr.EndOfStream == false)
                    {
                        string[] s = sr.ReadLine().Split(' ');
                        string name = s[0];
                        DateTime moment = DateTime.Parse(s[1]);

                        Log log = new Log(name, moment);
                        set.Add(log);
                    }
                }

                Console.WriteLine($"Total users: {set.Count}");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
