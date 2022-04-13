using System;
using System.Globalization;
using S9_Exercicio_Composicao_1.Entities;
using S9_Exercicio_Composicao_1.Entities.Enums;

namespace S9_Exercicio_Composicao_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string depName = Console.ReadLine();
            Department department = new Department(depName);

            Console.WriteLine("\nEnter worker data:");
            Console.Write("Name: ");
            string wName = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel wl = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double wBaseSalary = double.Parse(Console.ReadLine());

            Worker worker = new Worker(wName, wl, wBaseSalary, department);

            Console.Write("\nHow many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEnter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime cDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Value per hour: ");
                double cVph = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int cDuration = int.Parse(Console.ReadLine());

                HourContract hc = new HourContract(cDate, cVph, cDuration);
                worker.Contracts.Add(hc);
            }

            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            string[] s = Console.ReadLine().Split('/');
            int month = int.Parse(s[0]);
            int year = int.Parse(s[1]);

            Console.WriteLine($"\nName: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {s[0]}/{s[1]}: {worker.Income(year, month):F2}");
        }
    }
}
