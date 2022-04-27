using System;
using System.Collections.Generic;

namespace S15_Exercicio_Generics_3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int nA = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nA; i++)
            {
                int x = int.Parse(Console.ReadLine());
                set.Add(x);
            }

            Console.Write("\nHow many students for course B? ");
            int nB = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nB; i++)
            {
                int x = int.Parse(Console.ReadLine());
                set.Add(x);
            }

            Console.Write("\nHow many students for course C? ");
            int nC = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nC; i++)
            {
                int x = int.Parse(Console.ReadLine());
                set.Add(x);
            }

            Console.WriteLine($"\nTotal students: {set.Count}");
        }
    }
}
