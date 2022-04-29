using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using S17_Exercicio_LINQ_5.Entities;

namespace S17_Exercicio_LINQ_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            
            Console.Write("Enter full file path: ");
            string sourcePatch = Console.ReadLine();

            using (StreamReader sr = File.OpenText(sourcePatch))
            {
                while (sr.EndOfStream == false)
                {
                    string[] s = sr.ReadLine().Split(',');
                    string eName = s[0];
                    string eEmail = s[1];
                    double eSalary = double.Parse(s[2], CultureInfo.InvariantCulture);

                    Employee emp = new Employee(eName, eEmail, eSalary);
                    list.Add(emp);
                }
            }

            Console.Write("\nEnter salary: ");
            double enterSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"\nEmail of people whose salary is more than {enterSalary.ToString("F2", CultureInfo.InvariantCulture)}:");

            var emails = list.Where(p => p.Salary > enterSalary).OrderBy(p => p.Email).Select(p => p.Email);
            foreach (string s in emails)
            {
                Console.WriteLine(s);
            }

            var sum = list.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum();
            Console.WriteLine($"\nSum of salary of people whose name starts with 'M': {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
