using System;
using System.Globalization;
using S11_Exercicio_Excecoes_2.Entities;
using S11_Exercicio_Excecoes_2.Entities.Exceptions;

namespace S11_Exercicio_Excecoes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int aNumber = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string aHolder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double aBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double aWL = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account acc = new Account(aNumber, aHolder, aBalance, aWL);

                Console.Write("\nEnter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.Withdraw(withdraw);
                Console.WriteLine($"New balance: {acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch(DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
