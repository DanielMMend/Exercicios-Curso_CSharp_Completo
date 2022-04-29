using System;
using System.Collections.Generic;
using S17_Exercicio_LINQ_3.Entities;
using System.Linq;

namespace S17_Exercicio_LINQ_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            List<string> list2 = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string s in list2)
            {
                Console.WriteLine(s);
            }
        }
    }
}
