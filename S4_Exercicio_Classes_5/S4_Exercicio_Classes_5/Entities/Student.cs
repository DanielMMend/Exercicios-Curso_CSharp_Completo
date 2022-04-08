using System;

namespace S4_Exercicio_Classes_5.Entities
{
    class Student
    {
        public double Grade1 { get; set; }
        public double Grade2 { get; set; }
        public double Grade3 { get; set; }

        public Student(double grade1, double grade2, double grade3)
        {
            Grade1 = grade1;
            Grade2 = grade2;
            Grade3 = grade3;
        }

        public double FinalGrade()
        {
            return Grade1 + Grade2 + Grade3;
        }
        public void Approval()
        {
            if (FinalGrade() < 60.0)
            {
                Console.WriteLine("REPROVADO");
            }
            else
            {
                Console.WriteLine("APROVADO");
            }
        }
        public void RemainingGrade()
        {
            if (FinalGrade() < 60.0)
            {
                Console.WriteLine($"FALTARAM {60.0 - FinalGrade():F2} PONTOS");
            }
        }
    }
}
