using System;
using System.Globalization;
using S4_Exercicio_Classes_5.Entities;

namespace S4_Exercicio_Classes_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do aluno: ");
            Console.WriteLine("Digite as três notas do aluno:");
            double sGrade1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double sGrade2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double sGrade3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Student std = new Student(sGrade1, sGrade2, sGrade3);

            Console.WriteLine($"\nNOTA FINAL: {std.FinalGrade().ToString("F2", CultureInfo.InvariantCulture)}");
            std.Approval();
            std.RemainingGrade();
        }
    }
}
