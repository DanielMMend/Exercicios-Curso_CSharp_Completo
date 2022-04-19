using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using S14_Exercicio_Interface_3.Entities;

namespace S14_Exercicio_Interface_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Employee> list = new List<Employee>();
                string path = @"C:\Users\danie\source\repos\Curso CSharp Completo - Exercicios\S14_Exercicio_Interface_3\S14_Exercicio_Interface_3\File\file.csv";

                using (StreamReader sr = File.OpenText(path))
                {
                    while (sr.EndOfStream == false)
                    {
                        string[] s = sr.ReadLine().Split(',');
                        string eName = s[0];
                        double eSalary = double.Parse(s[1], CultureInfo.InvariantCulture);

                        Employee emp = new Employee(eName, eSalary);
                        list.Add(emp);
                    }
                }

                list.Sort();
                foreach (Employee emp in list)
                {
                    Console.WriteLine(emp);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
