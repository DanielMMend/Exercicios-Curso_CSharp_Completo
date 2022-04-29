using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using S17_Exercicio_LINQ_4.Entities;

namespace S17_Exercicio_LINQ_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Product> list = new List<Product>();

                Console.Write("Enter full file path: ");
                string sourcePatch = Console.ReadLine();

                using (StreamReader sr = File.OpenText(sourcePatch))
                {
                    while (sr.EndOfStream == false)
                    {
                        string[] s = sr.ReadLine().Split(',');
                        string pName = s[0];
                        double pPrice = double.Parse(s[1], CultureInfo.InvariantCulture);

                        Product p = new Product(pName, pPrice);
                        list.Add(p);
                    }
                }

                var avg = list.Select(p => p.Price).Average();
                Console.WriteLine($"Average price: {avg.ToString("F2", CultureInfo.InvariantCulture)}");

                var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
                foreach (String s in names)
                {
                    Console.WriteLine(s);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
