using System;
using System.Globalization;
using System.Collections.Generic;
using S10_Exercicio_Heranca_2.Entities;

namespace S10_Exercicio_Heranca_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nProduct #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                string cui = Console.ReadLine();
                Console.Write("Name: ");
                string pName = Console.ReadLine();
                Console.Write("Price: ");
                double pPrice = double.Parse(Console.ReadLine());
                if (cui == "c")
                {
                    Product prod = new Product(pName, pPrice);
                    list.Add(prod);
                }
                else if (cui == "i")
                {
                    Console.Write("Customs fee: ");
                    double pCF = double.Parse(Console.ReadLine());
                    ImportedProduct prod = new ImportedProduct(pName, pPrice, pCF);
                    list.Add(prod);
                }
                else if (cui == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime pMD = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    UsedProduct prod = new UsedProduct(pName, pPrice, pMD);
                    list.Add(prod);
                }
                else
                {
                    Console.WriteLine("Unexpected error: Product should be classified as common(c), used(u) or imported(i);");
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product p in list)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
