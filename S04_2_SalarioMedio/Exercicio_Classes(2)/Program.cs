using System;
using Exercicio_Classes_2_.Entities;

namespace Exercicio_Classes_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            string e1Name = Console.ReadLine();
            Console.Write("Salário: ");
            double e1Salary = double.Parse(Console.ReadLine());
            Employee emp1 = new Employee(e1Name, e1Salary);

            Console.WriteLine("\nDados do segundo funcionário:");
            Console.Write("Nome: ");
            string e2Name = Console.ReadLine();
            Console.Write("Salário: ");
            double e2Salary = double.Parse(Console.ReadLine());
            Employee emp2 = new Employee(e2Name, e2Salary);

            Console.WriteLine($"\nSalário médio = {emp1.AverageSalary(emp2):F2}");
        }
    }
}
