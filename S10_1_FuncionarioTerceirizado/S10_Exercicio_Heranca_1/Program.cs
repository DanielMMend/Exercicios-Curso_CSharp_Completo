using System;
using System.Globalization;
using System.Collections.Generic;
using S10_Exercicio_Heranca_1.Entities;

namespace S10_Exercicio_Heranca_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEmployee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                string yn = Console.ReadLine();
                Console.Write("Name: ");
                string eName = Console.ReadLine();
                Console.Write("Hours: ");
                int eHours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double eVPH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (yn == "y")
                {
                    Console.Write("Additional charge: ");
                    double eAC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    OutsourcedEmployee emp = new OutsourcedEmployee(eName, eHours, eVPH, eAC);
                    list.Add(emp);
                }
                else
                {
                    Employee emp = new Employee(eName, eHours, eVPH);
                    list.Add(emp);
                }
            }

            Console.WriteLine("\nPAYMENTS:");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
