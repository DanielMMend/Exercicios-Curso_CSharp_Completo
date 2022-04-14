using System;
using S6_Exercicio_Listas_1.Entities;

namespace S6_Exercicio_Listas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rent[] rents = new Rent[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nAluguel #{i + 1}:");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());

                Rent rent = new Rent(name, email, room);

                rents[room - 1] = rent;
            }

            Console.WriteLine("Quartos ocupados:");
            foreach (Rent r in rents)
            {
                if (r != null)
                {
                    Console.WriteLine(r);
                }
            }
        }
    }
}
