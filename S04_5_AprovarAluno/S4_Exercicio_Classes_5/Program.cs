using System;
using S4_Exercicio_Classes_5.Entities;

namespace S4_Exercicio_Classes_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do aluno: ");
            Console.WriteLine("Digite as três notas do aluno:");
            double sGrade1 = double.Parse(Console.ReadLine());
            double sGrade2 = double.Parse(Console.ReadLine());
            double sGrade3 = double.Parse(Console.ReadLine());
            Student std = new Student(sGrade1, sGrade2, sGrade3);

            Console.WriteLine($"\nNOTA FINAL: {std.FinalGrade():F2}");
            std.Approval();
            std.RemainingGrade();
        }
    }
}
