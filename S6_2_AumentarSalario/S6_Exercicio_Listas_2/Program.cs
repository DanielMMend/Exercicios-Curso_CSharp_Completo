using System;
using System.Collections.Generic;
using S6_Exercicio_Listas_2.Entities;

namespace S6_Exercicio_Listas_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEmployee #{i}:");
                Console.Write("Id: ");
                int eId = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string eName = Console.ReadLine();
                Console.Write("Salary: ");
                double eSalary = double.Parse(Console.ReadLine());

                Employee emp = new Employee(eId, eName, eSalary);
                list.Add(emp);
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int rId = int.Parse(Console.ReadLine());

            bool checkId = false;
            foreach (Employee emp in list)
            {
                if (emp.Id == rId)
                {
                    checkId = true;
                }
            }

            if (checkId == false)
            {
                Console.WriteLine("This id does not exist!");
            }
            else
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());

                foreach (Employee emp in list)
                {
                    if (emp.Id == rId)
                    {
                        emp.IncreaseSalary(percentage);
                    }
                }
            }

            Console.WriteLine("\nUpdated list of employees:");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
