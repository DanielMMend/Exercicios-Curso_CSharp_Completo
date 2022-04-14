using System;

namespace S6_Exercicio_Listas_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            Console.Write("\nMain diagonal: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(mat[i, j] + " ");
                    }
                }
            }

            int negNumbers = 0;
            foreach (int x in mat)
            {
                if (x < 0)
                {
                    negNumbers = negNumbers + 1;
                }
            }
            Console.WriteLine($"\nNegative numbers = {negNumbers}");
        }
    }
}
