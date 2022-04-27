using System;
using System.Globalization;
using System.Collections.Generic;
using S15_Exercicio_Generics_1.Entities;
using S15_Exercicio_Generics_1.Services;

namespace S15_Exercicio_Generics_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                string[] s = Console.ReadLine().Split(',');
                string pName = s[0];
                double pPrice = double.Parse(s[1], CultureInfo.InvariantCulture);

                Product p = new Product(pName, pPrice);
                list.Add(p);
            }

            CalculationService cs = new CalculationService();
            Product prod = cs.Max(list);
            Console.WriteLine($"\nMax: {prod}");
        }
    }
}
