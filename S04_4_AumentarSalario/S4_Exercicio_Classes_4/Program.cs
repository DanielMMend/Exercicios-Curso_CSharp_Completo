using System;
using System.Globalization;
using S4_Exercicio_Classes_4.Entities;

namespace S4_Exercicio_Classes_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string eName = Console.ReadLine();
            Console.Write("Salário bruto: ");
            double eGrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            double eTax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Employee emp = new Employee(eName, eGrossSalary, eTax);

            Console.WriteLine($"\nFuncionário: {emp}");

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            emp.IncreaseSalary(percentage);

            Console.WriteLine($"Dados atualizados: {emp}");

        }
    }
}
