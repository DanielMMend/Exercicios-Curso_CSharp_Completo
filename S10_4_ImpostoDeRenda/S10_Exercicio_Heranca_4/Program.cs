using System;
using System.Collections.Generic;
using S10_Exercicio_Heranca_4.Entities;

namespace S10_Exercicio_Heranca_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nTax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                string ic = Console.ReadLine();
                Console.Write("Name: ");
                string tpName = Console.ReadLine();
                Console.Write("Anual income: ");
                double tpAI = double.Parse(Console.ReadLine());
                if (ic == "i")
                {
                    Console.Write("Health expenditures: ");
                    double iHE = double.Parse(Console.ReadLine());
                    Individual ind = new Individual(tpName, tpAI, iHE);
                    list.Add(ind);
                }
                else if (ic == "c")
                {
                    Console.Write("Number of employees: ");
                    int cNE = int.Parse(Console.ReadLine());
                    Company comp = new Company(tpName, tpAI, cNE);
                    list.Add(comp);
                }
                else
                {
                    Console.WriteLine("Unexpected error: Tax Payer must be classified as individual(i) or company(c);");
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("\nTAXES PAID:");
            foreach (TaxPayer tp in list)
            {
                Console.WriteLine(tp);
            }

            double totalTax = 0;
            foreach (TaxPayer tp in list)
            {
                totalTax = totalTax + tp.Tax();
            }
            Console.WriteLine($"\nTOTAL TAXES: ${totalTax:F2}");
        }
    }
}
