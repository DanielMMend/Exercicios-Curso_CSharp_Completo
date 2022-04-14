using System;
using Exercicio_Classe_1_.Entities;

namespace Exercicio_Classe_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            string p1Name = Console.ReadLine();
            Console.Write("Idade: ");
            int p1Age = int.Parse(Console.ReadLine());
            Person p1 = new Person(p1Name, p1Age);

            Console.WriteLine("\nDados da segunda pessoa:");
            Console.Write("Nome: ");
            string p2Name = Console.ReadLine();
            Console.Write("Idade: ");
            int p2Age = int.Parse(Console.ReadLine());
            Person p2 = new Person(p2Name, p2Age);

            Console.WriteLine($"Pessoa mais velha: {p1.OldestPerson(p2)}");
        }
    }
}
