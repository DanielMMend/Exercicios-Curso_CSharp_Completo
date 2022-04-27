using System;
using System.IO;
using System.Collections.Generic;

namespace S15_Exercicio_Generics_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<string, int> dic = new Dictionary<string, int>();
                Console.Write("Enter file full path: ");
                string sourcePath = Console.ReadLine();

                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    while (sr.EndOfStream == false)
                    {
                        string[] s = sr.ReadLine().Split(',');
                        string name = s[0];
                        int votes = int.Parse(s[1]);

                        if (dic.ContainsKey(name) == false)
                        {
                            dic.Add(name, votes);
                        }
                        else
                        {
                            dic[name] = dic[name] + votes;
                        }
                    }
                }

                foreach (KeyValuePair<string, int> item in dic)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
